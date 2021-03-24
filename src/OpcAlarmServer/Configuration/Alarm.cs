using System;
using System.Collections.Generic;
using System.Text;

namespace OpcAlarmServer.Configuration
{
    public class Alarm
    {
        public AlarmObjectStates ObjectType { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public enum AlarmObjectStates
    {
        TripAlarmType,
        OffNormalAlarmType,
        AlarmConditionType,
        LimitAlarmType
    }
}
