using Opc.Ua;
using OpcAlarmServer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpcAlarmServer.VendingMachineBackendService
{
    class VendingMachineBackendAlarm
    {
        public VendingMachineBackend Source { get; internal set; }
        public string Name { get; internal set; }
        public string Reason { get; internal set; }
        public DateTime Time { get; internal set; }
        public EventSeverity Severity { get; internal set; }
        public VendingMachineConditionStates State { get; internal set; }
        public DateTime EnableTime { get; internal set; }
        public DateTime ActiveTime { get; internal set; }
        public LocalizedText Comment { get; internal set; }
        public string UserName { get; internal set; }

        public VendingMachineBackendAlarm CreateSnapshot()
        {
            return (VendingMachineBackendAlarm)MemberwiseClone();
        }
    }
}
