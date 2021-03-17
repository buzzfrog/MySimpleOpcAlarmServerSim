using Opc.Ua;
using OpcAlarmServer.VendingMachineBackendService;
using System;
using System.Collections.Generic;
using System.Text;


namespace OpcAlarmServer.Model
{
    class VendingMachineState : BaseObjectState
    {
        private OpcAlarmServerNodeManager _nodeManager;
        private VendingMachineBackend _vendingMachineBackend;

        public VendingMachineState(OpcAlarmServerNodeManager nodeManager, NodeId nodeId, string name)
            : base(null)
        {
            _nodeManager = nodeManager;

            Initialize(_nodeManager.SystemContext);

            _vendingMachineBackend = ((VendingMachineBackendSystem)_nodeManager.SystemContext.SystemHandle).CreateVendingMachineBackend(nodeId.ToString(), OnAlarmChanged);

            // initialize the area with the fixed metadata.
            this.SymbolicName = name;
            this.NodeId = nodeId;
            this.BrowseName = new QualifiedName(name, nodeId.NamespaceIndex);
            this.DisplayName = BrowseName.Name;
            this.Description = null;
            this.ReferenceTypeId = null;
            this.TypeDefinitionId = ObjectTypeIds.BaseObjectType;
            this.EventNotifier = EventNotifiers.None;
        }

        private void OnAlarmChanged(VendingMachineBackendAlarm alarm)
        {
        }
    }
}
