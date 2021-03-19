using System.Collections.Generic;

namespace OpcAlarmServer.Configuration
{
    public class Script
    {
        public int WaitUntilStartInSeconds { get; set; }
        public bool StepsInLoop { get; set; }
        public int RunningForSecounds { get; set; }
        public List<Step> Steps { get; set; }

    }
}