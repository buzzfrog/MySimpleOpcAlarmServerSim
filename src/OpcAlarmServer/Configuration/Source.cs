using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpcAlarmServer.Configuration
{
    public class Source
    {
        public Type Type { get; set; }
        public string Name { get; set; }
        public List<Alarm> Alarms { get; set; }
    }
}
