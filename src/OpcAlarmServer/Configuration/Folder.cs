using System;
using System.Collections.Generic;
using System.Text;

namespace OpcAlarmServer.Configuration
{
    public class Folder
    {
        public string Name { get; set; }
        public List<Source> Sources { get; set; }
    }
}
