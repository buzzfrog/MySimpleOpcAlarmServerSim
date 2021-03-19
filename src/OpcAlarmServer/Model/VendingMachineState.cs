using Opc.Ua;
using Opc.Ua.Server;
using OpcAlarmServer.VendingMachineBackendService;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;


namespace OpcAlarmServer.Model
{
    class VendingMachineState : BaseObjectState
    {
        private OpcAlarmServerNodeManager _nodeManager;
        private VendingMachineBackend _vendingMachineBackend;
        private Dictionary<string, AlarmConditionState> _alarms = new Dictionary<string, AlarmConditionState>();
        private Dictionary<string, AlarmConditionState> _events = new Dictionary<string, AlarmConditionState>();

        public VendingMachineState(OpcAlarmServerNodeManager nodeManager, NodeId nodeId, string name)
            : base(null)
        {
            _nodeManager = nodeManager;

            Initialize(_nodeManager.SystemContext);

            _vendingMachineBackend =
                ((VendingMachineBackendSystem)_nodeManager.SystemContext.SystemHandle)
                    .CreateVendingMachineBackend(name, OnAlarmChanged);

            // initialize the area with the fixed metadata.
            this.SymbolicName = name;
            this.NodeId = nodeId;
            this.BrowseName = new QualifiedName(name, nodeId.NamespaceIndex);
            this.DisplayName = BrowseName.Name;
            this.Description = null;
            this.ReferenceTypeId = null;
            this.TypeDefinitionId = ObjectTypeIds.BaseObjectType;
            this.EventNotifier = EventNotifiers.None;

            _vendingMachineBackend.Refresh();
        }
 
        public override void ConditionRefresh(ISystemContext context, List<IFilterTarget> events, bool includeChildren)
        {
            foreach (var @event in events)
            {
                InstanceStateSnapshot instanceSnapShotForExistingEvent = @event as InstanceStateSnapshot;
                if (instanceSnapShotForExistingEvent != null && Object.ReferenceEquals(instanceSnapShotForExistingEvent.Handle, this))
                {
                    return;
                }

            }
            foreach (var alarm in _alarms.Values)
            {
                if (!alarm.Retain.Value)
                {
                    continue;
                }

                InstanceStateSnapshot instanceStateSnapshotNewAlarm = new InstanceStateSnapshot();
                instanceStateSnapshotNewAlarm.Initialize(context, alarm);
                instanceStateSnapshotNewAlarm.Handle = this;
                events.Add(instanceStateSnapshotNewAlarm);
            }

        }

        // COMMENT: Here is the "real" OPC Alarms created and updated.
        // COMMENT: It uses the BackendAlarm to describe how this alarm should be created
        // COMMENT: Can we use the BackendAlarm has the source for changes in our script?
        private void OnAlarmChanged(VendingMachineBackendAlarm alarm)
        {
            lock (_nodeManager.Lock)
            {
                if (!_alarms.TryGetValue(alarm.Name, out AlarmConditionState node))
                {
                    _alarms[alarm.Name] = node = CreateAlarm(alarm, null);
                }

                UpdateAlarm(node, alarm);
                ReportChanges(node);
            }
        }

        private void ReportChanges(AlarmConditionState alarm)
        {
            // report changes to node attributes.
            alarm.ClearChangeMasks(_nodeManager.SystemContext, true);

            // check if events are being monitored for the source.
            if (this.AreEventsMonitored)
            {
                // create a snapshot.
                InstanceStateSnapshot e = new InstanceStateSnapshot();
                e.Initialize(_nodeManager.SystemContext, alarm);

                // report the event.
                alarm.ReportEvent(_nodeManager.SystemContext, e);
            }
        }

        private void UpdateAlarm(AlarmConditionState node, VendingMachineBackendAlarm alarm)
        {
            ISystemContext context = _nodeManager.SystemContext;

            // remove old event.
            if (node.EventId.Value != null)
            {
                _events.Remove(Utils.ToHexString(node.EventId.Value));
            }

            // update the basic event information (include generating a unique id for the event).
            node.EventId.Value = Guid.NewGuid().ToByteArray();
            node.Time.Value = DateTime.UtcNow;
            node.ReceiveTime.Value = node.Time.Value;

            // save the event for later lookup.
            _events[Utils.ToHexString(node.EventId.Value)] = node;

            // determine the retain state.
            node.Retain.Value = true;

            if (alarm != null)
            {
                node.Time.Value = alarm.Time;
                node.Message.Value = new LocalizedText(alarm.Reason);

                // update the states.
                node.SetEnableState(context, (alarm.State & VendingMachineConditionStates.Enabled) != 0);
                node.SetAcknowledgedState(context, (alarm.State & VendingMachineConditionStates.Acknowledged) != 0);
                node.SetConfirmedState(context, (alarm.State & VendingMachineConditionStates.Confirmed) != 0);
                node.SetActiveState(context, (alarm.State & VendingMachineConditionStates.Active) != 0);
                node.SetSuppressedState(context, (alarm.State & VendingMachineConditionStates.Suppressed) != 0);

                // update other information.
                node.SetComment(context, alarm.Comment, alarm.UserName);
                node.SetSeverity(context, alarm.Severity);

                node.EnabledState.TransitionTime.Value = alarm.EnableTime;
                node.ActiveState.TransitionTime.Value = alarm.ActiveTime;

                // check for deleted items.
                if ((alarm.State & VendingMachineConditionStates.Deleted) != 0)
                {
                    node.Retain.Value = false;
                }
            }

            // not interested in disabled or inactive alarms.
            if (!node.EnabledState.Id.Value || !node.ActiveState.Id.Value)
            {
                node.Retain.Value = false;
            }
        }

        private AlarmConditionState CreateAlarm(VendingMachineBackendAlarm alarm, NodeId branchId)
        {
            ISystemContext context = _nodeManager.SystemContext;

            // COMMENT: Here we can create different alarms
            AlarmConditionState node = new TripAlarmState(this);

            node.SymbolicName = alarm.Name;

            // add optional components.
            node.Comment = new ConditionVariableState<LocalizedText>(node);
            node.ClientUserId = new PropertyState<string>(node);
            node.AddComment = new AddCommentMethodState(node);
            node.ConfirmedState = new TwoStateVariableState(node);
            node.Confirm = new AddCommentMethodState(node);

            if (NodeId.IsNull(branchId))
            {
                node.SuppressedState = new TwoStateVariableState(node);
                node.ShelvingState = new ShelvedStateMachineState(node);
            }

            // adding optional components to children is a little more complicated since the 
            // necessary initilization strings defined by the class that represents the child.
            // in this case we pre-create the child, add the optional components
            // and call create without assigning NodeIds. The NodeIds will be assigned when the
            // parent object is created.
            node.EnabledState = new TwoStateVariableState(node);
            node.EnabledState.TransitionTime = new PropertyState<DateTime>(node.EnabledState);
            node.EnabledState.EffectiveDisplayName = new PropertyState<LocalizedText>(node.EnabledState);
            node.EnabledState.Create(context, null, BrowseNames.EnabledState, null, false);

            // same procedure add optional components to the ActiveState component.
            node.ActiveState = new TwoStateVariableState(node);
            node.ActiveState.TransitionTime = new PropertyState<DateTime>(node.ActiveState);
            node.ActiveState.EffectiveDisplayName = new PropertyState<LocalizedText>(node.ActiveState);
            node.ActiveState.Create(context, null, BrowseNames.ActiveState, null, false);

            // specify reference type between the source and the alarm.
            node.ReferenceTypeId = ReferenceTypeIds.HasComponent;

            // This call initializes the condition from the type model (i.e. creates all of the objects
            // and variables requried to store its state). The information about the type model was 
            // incorporated into the class when the class was created.
            //
            // This method also assigns new NodeIds to all of the components by calling the INodeIdFactory.New
            // method on the INodeIdFactory object which is part of the system context. The NodeManager provides
            // the INodeIdFactory implementation used here.
            node.Create(
                context,
                null,
                new QualifiedName(alarm.Name, this.BrowseName.NamespaceIndex),
                null,
                true);

            // don't add branches to the address space.
            if (NodeId.IsNull(branchId))
            {
                this.AddChild(node);
            }

            // initialize event information.node
            node.EventType.Value = node.TypeDefinitionId;
            node.SourceNode.Value = this.NodeId;
            node.SourceName.Value = this.SymbolicName;
            node.ConditionName.Value = node.SymbolicName;
            node.Time.Value = DateTime.UtcNow;
            node.ReceiveTime.Value = node.Time.Value;
            node.BranchId.Value = branchId;

            // set up method handlers.
            node.OnEnableDisable = OnEnableDisableAlarm;
            node.OnAcknowledge = OnAcknowledge;
            node.OnAddComment = OnAddComment;
            node.OnConfirm = OnConfirm;
            node.OnShelve = OnShelve;
            node.OnTimedUnshelve = OnTimedUnshelve;

            // return the new node.
            return node;
        }

        private ServiceResult OnTimedUnshelve(ISystemContext context, AlarmConditionState alarm)
        {
            throw new NotImplementedException();
        }

        private ServiceResult OnShelve(ISystemContext context, AlarmConditionState alarm, bool shelving, bool oneShot, double shelvingTime)
        {
            throw new NotImplementedException();
        }

        private ServiceResult OnConfirm(ISystemContext context, ConditionState condition, byte[] eventId, LocalizedText comment)
        {
            throw new NotImplementedException();
        }

        private ServiceResult OnAddComment(ISystemContext context, ConditionState condition, byte[] eventId, LocalizedText comment)
        {
            throw new NotImplementedException();
        }

        private ServiceResult OnAcknowledge(ISystemContext context, ConditionState condition, byte[] eventId, LocalizedText comment)
        {
            throw new NotImplementedException();
        }

        private ServiceResult OnEnableDisableAlarm(ISystemContext context, ConditionState condition, bool enabling)
        {
            throw new NotImplementedException();
        }
    }
}