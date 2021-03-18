using Opc.Ua;
using Opc.Ua.Server;
using OpcAlarmServer.Model;
using OpcAlarmServer.VendingMachineBackendService;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;

namespace OpcAlarmServer
{
    class OpcAlarmServerNodeManager : CustomNodeManager2
    {
        private OpcAlarmServerConfiguration _configuration;
        private Timer _eventsSimulationTimer;
        private VendingMachineBackendSystem _system;
        private VendingMachinesFolder _vendingMachinesFolder;
        private uint _nodeIdCounter = 0;
        private List<NodeState> _rootNotifiers;
        private IServerInternal _server;
        private ServerSystemContext _defaultSystemContext;

        private Dictionary<string, VendingMachineState> _vendingMachines = new Dictionary<string, VendingMachineState>();

        public OpcAlarmServerNodeManager(IServerInternal server, ApplicationConfiguration configuration) : base(server, configuration) 
        {
            _server = server;
            _defaultSystemContext = _server.DefaultSystemContext.Copy();
            SystemContext.NodeIdFactory = this;
            SystemContext.SystemHandle = _system = new VendingMachineBackendSystem();

            // set one namespace for the type model and one names for dynamically created nodes.
            string[] namespaceUrls = new string[1];
            namespaceUrls[0] = Namespaces.VendingMachines;
            SetNamespaces(namespaceUrls);

            // get the configuration for the node manager.
            _configuration = configuration.ParseExtension<OpcAlarmServerConfiguration>();

            // use suitable defaults if no configuration exists.
            if (_configuration == null)
            {
                _configuration = new OpcAlarmServerConfiguration();
            }
        }

        public override void CreateMonitoredItems(
            OperationContext context,
            uint subscriptionId,
            double publishingInterval,
            TimestampsToReturn timestampsToReturn,
            IList<MonitoredItemCreateRequest> itemsToCreate,
            IList<ServiceResult> errors,
            IList<MonitoringFilterResult> filterResults,
            IList<IMonitoredItem> monitoredItems,
            ref long globalIdCounter)
        {
            ServerSystemContext systemContext = _defaultSystemContext.Copy(context);
            IDictionary<NodeId, NodeState> operationCache = new NodeIdDictionary<NodeState>();
            List<NodeHandle> nodesToValidate = new List<NodeHandle>();
            List<IMonitoredItem> createdItems = new List<IMonitoredItem>();

            lock (Lock)
            {
                for (int ii = 0; ii < itemsToCreate.Count; ii++)
                {
                    MonitoredItemCreateRequest monitoredItemCreateRequest = itemsToCreate[ii];

                    // skip items that have already been processed.
                    if (monitoredItemCreateRequest.Processed)
                    {
                        continue;
                    }

                    ReadValueId itemToMonitor = monitoredItemCreateRequest.ItemToMonitor;

                    // check for valid handle.
                    NodeHandle handle = GetManagerHandle(systemContext, itemToMonitor.NodeId, operationCache);

                    if (handle == null)
                    {
                        continue;
                    }

                    // owned by this node manager.
                    monitoredItemCreateRequest.Processed = true;

                    // must validate node in a seperate operation.
                    errors[ii] = StatusCodes.BadNodeIdUnknown;

                    handle.Index = ii;
                    nodesToValidate.Add(handle);
                }

                // check for nothing to do.
                if (nodesToValidate.Count == 0)
                {
                    return;
                }
            }

            // validates the nodes (reads values from the underlying data source if required).
            for (int ii = 0; ii < nodesToValidate.Count; ii++)
            {
                NodeHandle handle = nodesToValidate[ii];

                MonitoringFilterResult filterResult = null;
                IMonitoredItem monitoredItem = null;

                lock (Lock)
                {
                    // validate node.
                    NodeState source = ValidateNode(systemContext, handle, operationCache);

                    if (source == null)
                    {
                        continue;
                    }

                    MonitoredItemCreateRequest itemToCreate = itemsToCreate[handle.Index];

                    // create monitored item.
                    errors[handle.Index] = CreateMonitoredItem(
                        systemContext,
                        handle,
                        subscriptionId,
                        publishingInterval,
                        context.DiagnosticsMask,
                        timestampsToReturn,
                        itemToCreate,
                        ref globalIdCounter,
                        out filterResult,
                        out monitoredItem);
                }

                // save any filter error details.
                filterResults[handle.Index] = filterResult;

                if (ServiceResult.IsBad(errors[handle.Index]))
                {
                    continue;
                }

                // save the monitored item.
                monitoredItems[handle.Index] = monitoredItem;
                createdItems.Add(monitoredItem);
            }

            // do any post processing.
            OnCreateMonitoredItemsComplete(systemContext, createdItems);
        }

        protected override NodeState ValidateNode(
             ServerSystemContext context,
             NodeHandle handle,
             IDictionary<NodeId, NodeState> cache)
        {
            // lookup in cache.
            NodeState target = FindNodeInCache(context, handle, cache);

            if (target != null)
            {
                handle.Node = target;
                handle.Validated = true;
                return handle.Node;
            }

            // return default.
            return handle.Node;
        }

        public override ServiceResult SubscribeToAllEvents(
             Opc.Ua.Server.OperationContext context,
             uint subscriptionId,
             IEventMonitoredItem monitoredItem,
             bool unsubscribe)
        {
            ServerSystemContext serverSystemContext = SystemContext.Copy(context);

            lock (Lock)
            {
                // A client has subscribed to the Server object which means all events produced
                // by this manager must be reported. This is done by incrementing the monitoring
                // reference count for all root notifiers.
                if (_rootNotifiers != null)
                {
                    for (int ii = 0; ii < _rootNotifiers.Count; ii++)
                    {
                        SubscribeToEvents(serverSystemContext, _rootNotifiers[ii], monitoredItem, unsubscribe);
                    }
                }

                return ServiceResult.Good;
            }
        }

        protected override ServiceResult SubscribeToEvents(
           ServerSystemContext context,
           NodeState source,
           IEventMonitoredItem monitoredItem,
           bool unsubscribe)
        {

            // handle unsubscribe.
            if (unsubscribe)
            {
                // check for existing monitored node.
                if (!MonitoredNodes.TryGetValue(source.NodeId, out MonitoredNode2 monitoredNode2))
                {
                    return StatusCodes.BadNodeIdUnknown;
                }

                monitoredNode2.Remove(monitoredItem);

                // check if node is no longer being monitored.
                if (!monitoredNode2.HasMonitoredItems)
                {
                    MonitoredNodes.Remove(source.NodeId);
                }

                // update flag.
                source.SetAreEventsMonitored(context, !unsubscribe, true);

                // call subclass.
                OnSubscribeToEvents(context, monitoredNode2, unsubscribe);

                // all done.
                return ServiceResult.Good;
            }

            // only objects or views can be subscribed to.
            BaseObjectState instance = source as BaseObjectState;

            if (instance == null || (instance.EventNotifier & EventNotifiers.SubscribeToEvents) == 0)
            {
                ViewState view = source as ViewState;

                if (view == null || (view.EventNotifier & EventNotifiers.SubscribeToEvents) == 0)
                {
                    return StatusCodes.BadNotSupported;
                }
            }

            // check for existing monitored node.
            if (!MonitoredNodes.TryGetValue(source.NodeId, out MonitoredNode2 monitoredNode))
            {
                MonitoredNodes[source.NodeId] = monitoredNode = new MonitoredNode2(this, source);
            }

            // this links the node to specified monitored item and ensures all events
            // reported by the node are added to the monitored item's queue.
            monitoredNode.Add(monitoredItem);

            // This call recursively updates a reference count all nodes in the notifier
            // hierarchy below the area. Sources with a reference count of 0 do not have 
            // any active subscriptions so they do not need to report events.
            source.SetAreEventsMonitored(context, !unsubscribe, true);

            // signal update.
            OnSubscribeToEvents(context, monitoredNode, unsubscribe);

            // all done.
            return ServiceResult.Good;
        }

        /// <summary>
        /// Does any initialization required before the address space can be used.
        /// </summary>
        /// <remarks>
        /// The externalReferences is an out parameter that allows the node manager to link to nodes
        /// in other node managers. For example, the 'Objects' node is managed by the CoreNodeManager and
        /// should have a reference to the root folder node(s) exposed by this node manager.  
        /// </remarks>
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                IList<IReference> references = null;

                if (!externalReferences.TryGetValue(ObjectIds.Server, out references))
                {
                    externalReferences[ObjectIds.Server] = references = new List<IReference>();
                }

                
                // create root for vending machines
                _vendingMachinesFolder = new VendingMachinesFolder(SystemContext, null, new NodeId("vendingmachinefolder", NamespaceIndex), "VendingMachines");

                _vendingMachinesFolder.AddReference(ReferenceTypeIds.HasNotifier, true, ObjectIds.Server);
                AddRootNotifier(_vendingMachinesFolder);

                // create a number of vendingmachines
                for (int postNameNumber = 0; postNameNumber < 10; postNameNumber++)
                {
                    VendingMachineState vendingMachine;

                    var name = $"vending_machine_{postNameNumber}";
                    _vendingMachines[name] = vendingMachine = 
                        new VendingMachineState(this, new NodeId(name, NamespaceIndex), name);

                   _vendingMachinesFolder.AddChild(vendingMachine);

                    vendingMachine.AddNotifier(SystemContext, ReferenceTypeIds.HasEventSource, true, _vendingMachinesFolder);
                    _vendingMachinesFolder.AddNotifier(SystemContext, ReferenceTypeIds.HasEventSource, false, vendingMachine);
                }

                references.Add(new NodeStateReference(ReferenceTypeIds.HasNotifier, false, _vendingMachinesFolder.NodeId));
            }

            AddPredefinedNode(SystemContext, _vendingMachinesFolder);

            //_eventsSimulationTimer = new Timer(OnRaiseSystemEvents, null, 1000, 1000);
        }


        public override ServiceResult ConditionRefresh(
            OperationContext context,
            IList<IEventMonitoredItem> monitoredItems)
        {
            ServerSystemContext serverSystemContext = SystemContext.Copy(context);

            foreach (MonitoredItem monitoredItem in monitoredItems)
            {
                if(monitoredItem == null)
                {
                    continue;
                }

                List<IFilterTarget> events = new List<IFilterTarget>();
                List<NodeState> nodesToRefresh = new List<NodeState>();

                lock(Lock)
                {
                    // check for server subscription.
                    if (monitoredItem.NodeId == ObjectIds.Server)
                    {
                        if (_rootNotifiers != null)
                        {
                            nodesToRefresh.AddRange(_rootNotifiers);
                        }
                    }
                    else
                    {

                        if (!MonitoredNodes.TryGetValue(monitoredItem.NodeId, out MonitoredNode2 monitoredNode))
                        {
                            continue;
                        }

                        // get the refresh events.
                        nodesToRefresh.Add(monitoredNode.Node);
                    }
                }

                foreach (var node in nodesToRefresh)
                {
                    node.ConditionRefresh(SystemContext, events, true);
                }

                foreach (var @event in events)
                {
                    monitoredItem.QueueEvent(@event);
                }
            }

            return ServiceResult.Good;
        }

        protected override void AddRootNotifier(NodeState notifier)
        {
            if (_rootNotifiers == null)
            {
                _rootNotifiers = new List<NodeState>();
            }

            for (int ii = 0; ii < _rootNotifiers.Count; ii++)
            {
                if (Object.ReferenceEquals(notifier, _rootNotifiers[ii]))
                {
                    return;
                }
            }

            _rootNotifiers.Add(notifier);

            // need to prevent recursion with the server object.
            if (notifier.NodeId != ObjectIds.Server)
            {
                notifier.OnReportEvent = OnReportEvent;

                if (!notifier.ReferenceExists(ReferenceTypeIds.HasNotifier, true, ObjectIds.Server))
                {
                    notifier.AddReference(ReferenceTypeIds.HasNotifier, true, ObjectIds.Server);
                }
            }

            // subscribe to existing events.
            if (_server.EventManager != null)
            {
                IList<IEventMonitoredItem> monitoredItems = _server.EventManager.GetMonitoredItems();

                for (int ii = 0; ii < monitoredItems.Count; ii++)
                {
                    if (monitoredItems[ii].MonitoringAllEvents)
                    {
                        SubscribeToEvents(
                            SystemContext,
                            notifier,
                            monitoredItems[ii],
                            true);
                    }
                }
            }
        }

        public override NodeId New(ISystemContext context, NodeState node)
        {
            return new NodeId(++_nodeIdCounter, NamespaceIndex);
        }


        /// <summary>
        /// Loads a node set from a file or resource and addes them to the set of predefined nodes.
        /// </summary>
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();

            return predefinedNodes;
        }

        /// <summary>
        /// Creates simulated events
        /// </summary>
        /// <param name="state"></param>
        private void OnRaiseSystemEvents(object state)
        {
            try
            {
                SystemEventState e = new SystemEventState(null);

                e.Initialize(
                    SystemContext,
                    null,
                    EventSeverity.Medium,
                    new LocalizedText("Raising Events"));

                e.SetChildValue(SystemContext, BrowseNames.SourceNode, ObjectIds.Server, false);
                e.SetChildValue(SystemContext, BrowseNames.SourceName, "Internal", false);

                Server.ReportEvent(e);

                AuditEventState ae = new AuditEventState(null);

                ae.Initialize(
                    SystemContext,
                    null,
                    EventSeverity.Medium,
                    new LocalizedText("Events Raised"),
                    true,
                    DateTime.UtcNow);

                ae.SetChildValue(SystemContext, BrowseNames.SourceNode, ObjectIds.Server, false);
                ae.SetChildValue(SystemContext, BrowseNames.SourceName, "Internal", false);

                Server.ReportEvent(ae);
            }
            catch (Exception e)
            {
                Utils.Trace(e, "Unexpected error in OnRaiseSystemEvents");
            }
        }
    }
}
