using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static OpcAlarmServer.VendingMachineBackendService.VendingMachineBackend;


namespace OpcAlarmServer.VendingMachineBackendService
{
    class VendingMachineBackendSystem
    {
        private object _lock = new object();
        private Dictionary<string, VendingMachineBackend> _vendingMachineBackends = new Dictionary<string, VendingMachineBackend>();
        private Timer _simulationTimer;
        private long _simulationRunCounter;

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

        public void StartSimulation()
        {
            lock(_lock)
            {
                if (_simulationTimer != null)
                {
                    _simulationTimer.Dispose();
                    _simulationTimer = null;
                }

                _simulationTimer = new Timer(DoSimulation, null, 1000, 1000);
            }
        }

        public void StopSimulation()
        {
            lock (_lock)
            {
                if (_simulationTimer != null)
                {
                    _simulationTimer.Dispose();
                    _simulationTimer = null;
                }
            }
        }

        private void DoSimulation(object state)
        {
            try
            {
                // get the list of sources.
                List<VendingMachineBackend> sources = null;

                lock (_lock)
                {
                    _simulationRunCounter++;
                    sources = new List<VendingMachineBackend>(_vendingMachineBackends.Values);
                }

                foreach (var vendingMachineBackend in sources)
                {
                    vendingMachineBackend.DoSimulation(_simulationRunCounter);
                }
            }
            catch (Exception ex)
            {
                Utils.Trace(ex, "Unexpected error running simulation for system");
            }
        }
    }
}
