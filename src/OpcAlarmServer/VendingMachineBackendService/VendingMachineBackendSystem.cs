using System;
using System.Collections.Generic;
using System.Text;
using static OpcAlarmServer.VendingMachineBackendService.VendingMachineBackend;

namespace OpcAlarmServer.VendingMachineBackendService
{
    class VendingMachineBackendSystem
    {
        private object _lock = new object();
        private Dictionary<string, VendingMachineBackend> _vendingMachineBackends = new Dictionary<string, VendingMachineBackend>();

        public VendingMachineBackend CreateVendingMachineBackend(string name, AlarmChangedEventHandler alarmChangeCallback)
        {
            VendingMachineBackend vendingMachineBackend = null;

            lock(_lock)
            {
                vendingMachineBackend = new VendingMachineBackend
                {
                    Name = name,
                    OnAlarmChanged = alarmChangeCallback
                };

                _vendingMachineBackends.Add(name, vendingMachineBackend);

                // create alarms
                vendingMachineBackend.CreateAlarm(name + "A1");
            }

            return vendingMachineBackend;
        }
    }
}
