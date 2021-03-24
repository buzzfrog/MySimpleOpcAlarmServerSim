using Opc.Ua;
using OpcAlarmServer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpcAlarmServer.VendingMachineBackendService
{
    class VendingMachineBackend
    {
        private List<VendingMachineBackendAlarm> _vendingMachineBackendAlarms = new List<VendingMachineBackendAlarm>();

        public AlarmChangedEventHandler OnAlarmChanged;
        public delegate void AlarmChangedEventHandler(VendingMachineBackendAlarm alarm);

        public string Name { get; set; }

        public VendingMachineBackend()
        {

        }

        internal void CreateAlarm(string name)
        {
            VendingMachineBackendAlarm alarm = new VendingMachineBackendAlarm();

            alarm.Source = this;
            alarm.Name = name;
            alarm.Reason = "Alarm created.";
            alarm.Time = DateTime.UtcNow;
            alarm.Severity = EventSeverity.Medium;
            alarm.State = VendingMachineConditionStates.Active | VendingMachineConditionStates.Enabled;
            alarm.EnableTime = DateTime.UtcNow;
            alarm.ActiveTime = DateTime.UtcNow;

            lock (_vendingMachineBackendAlarms)
            {
                _vendingMachineBackendAlarms.Add(alarm);
            }
        }

        internal void Refresh()
        {
            List<VendingMachineBackendAlarm> snapshots = new List<VendingMachineBackendAlarm>();

            lock (_vendingMachineBackendAlarms)
            {
                foreach (var alarm in _vendingMachineBackendAlarms)
                {
                    snapshots.Add(alarm.CreateSnapshot());
                }

            }

            foreach (var snapshotAlarm in snapshots)
            {
                OnAlarmChanged!.Invoke(snapshotAlarm);
            }

        }

        internal void DoSimulation(long simulationRunCounter)
        {
            List<VendingMachineBackendAlarm> snapshots = new List<VendingMachineBackendAlarm>();

            lock(_vendingMachineBackendAlarms)
            {
                foreach (var vendingMachineAlarm in _vendingMachineBackendAlarms)
                {
                    UpdateAlarm(vendingMachineAlarm, simulationRunCounter, snapshots);
                }
            }

            foreach (var snapshot in snapshots)
            {
                ReportAlarmChange(snapshot);
            }

        }

        private void ReportAlarmChange(VendingMachineBackendAlarm vendingMachineBackendAlarm)
        {
            OnAlarmChanged!.Invoke(vendingMachineBackendAlarm);
        }

        private void UpdateAlarm(VendingMachineBackendAlarm vendingMachineAlarm, long simulationRunCounter, List<VendingMachineBackendAlarm> snapshots)
        {
            // ignore disabled alarms
            if((vendingMachineAlarm.State & VendingMachineConditionStates.Enabled) == 0)
            {
                return;
            }

            // TEST
            if(simulationRunCounter % 12 == 0)
            {
                // is alarm active?
                if((vendingMachineAlarm.State & VendingMachineConditionStates.Active) == 0)
                {
                    // no - alarm is not active
                    vendingMachineAlarm.SetStateBits(VendingMachineConditionStates.Active, true);
                    vendingMachineAlarm.SetStateBits(VendingMachineConditionStates.Acknowledged | VendingMachineConditionStates.Confirmed, false);
                    vendingMachineAlarm.Severity = EventSeverity.Low;
                    vendingMachineAlarm.ActiveTime = DateTime.UtcNow;

                    vendingMachineAlarm.Time = DateTime.UtcNow;
                    vendingMachineAlarm.Reason = $"Activated {DateTime.UtcNow.Ticks}";

                }
                else
                {
                    // yes - alarm is active
                    vendingMachineAlarm.SetStateBits(VendingMachineConditionStates.Active, false);
                    vendingMachineAlarm.SetStateBits(VendingMachineConditionStates.Acknowledged | VendingMachineConditionStates.Confirmed, false);
                    vendingMachineAlarm.Severity = EventSeverity.Low;

                    vendingMachineAlarm.Time = DateTime.UtcNow;
                    vendingMachineAlarm.Reason = $"Deactivated {DateTime.UtcNow.Ticks}";
                }

                snapshots.Add(vendingMachineAlarm.CreateSnapshot());
            }
        }
    }
}
