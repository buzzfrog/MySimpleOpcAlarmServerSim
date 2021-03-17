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

        private Dictionary<string, VendingMachineState> _vendingMachines = new Dictionary<string, VendingMachineState>();

        public OpcAlarmServerNodeManager(IServerInternal server, ApplicationConfiguration configuration) : base(server, configuration) 
        {
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
