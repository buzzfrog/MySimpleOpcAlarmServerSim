using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MyNs = buzzfrog.OpcAlarmServer;

namespace OpcAlarmServer
{
    class OpcAlarmServerNodeManager : CustomNodeManager2
    {
        private OpcAlarmServerConfiguration _configuration;

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

    }
}
