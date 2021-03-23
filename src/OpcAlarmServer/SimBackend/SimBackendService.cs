using Opc.Ua;
using OpcAlarmServer.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using static OpcAlarmServer.SimBackend.SimSourceNodeBackend;

namespace OpcAlarmServer.SimBackend
{
    public class SimBackendService
    {
        private object _lock = new object();
        public Dictionary<string, SimSourceNodeBackend> SourceNodes = new Dictionary<string, SimSourceNodeBackend>();

        public SimSourceNodeBackend CreateSourceNodeBackend(string name, List<Alarm> alarms, AlarmChangedEventHandler alarmChangeCallback)
        {
            SimSourceNodeBackend simSourceNodeBackend;

            lock(_lock)
            {
                simSourceNodeBackend = new SimSourceNodeBackend
                {
                    Name = name,
                    OnAlarmChanged = alarmChangeCallback
                };

                simSourceNodeBackend.CreateAlarms(alarms);

                SourceNodes[name] = simSourceNodeBackend;
            }

            return simSourceNodeBackend;
        }
    }
}
