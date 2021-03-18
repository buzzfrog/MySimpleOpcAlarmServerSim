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
    }
}
