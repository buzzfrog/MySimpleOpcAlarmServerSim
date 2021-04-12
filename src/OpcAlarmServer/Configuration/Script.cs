using System.Collections.Generic;

namespace OpcAlarmServer.Configuration
{
    public class Script
    {
        public int WaitUntilStartInSeconds { get; set; }
        public bool IsScriptInRepeatingLoop { get; set; }
        public int RunningForSeconds { get; set; }
        public List<Step> Steps { get; set; }
    }
}