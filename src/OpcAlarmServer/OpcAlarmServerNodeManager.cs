using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using MyNs = buzzfrog.OpcAlarmServer;

namespace OpcAlarmServer
{
    class OpcAlarmServerNodeManager : CustomNodeManager2
    {
        private OpcAlarmServerConfiguration _configuration;
        private Timer _eventsSimulationTimer;

        public OpcAlarmServerNodeManager(IServerInternal server, ApplicationConfiguration configuration) : base(server, configuration) 
        {
            SystemContext.NodeIdFactory = this;

            // set one namespace for the type model and one names for dynamically created nodes.
            string[] namespaceUrls = new string[1];
            namespaceUrls[0] = MyNs.Namespaces.OpcAlarmServer;
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
                LoadPredefinedNodes(SystemContext, externalReferences);
            }

            _eventsSimulationTimer = new Timer(OnRaiseSystemEvents, null, 1000, 1000);
        }

        /// <summary>
        /// Loads a node set from a file or resource and addes them to the set of predefined nodes.
        /// </summary>
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            
            predefinedNodes.LoadFromBinaryResource(context,
                "OpcAlarmServer.buzzfrog.OpcAlarmServer.PredefinedNodes.uanodes",
                typeof(OpcAlarmServerNodeManager).GetTypeInfo().Assembly,
                true);

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
