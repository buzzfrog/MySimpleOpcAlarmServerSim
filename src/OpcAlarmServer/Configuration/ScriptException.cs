using System;
using System.Collections.Generic;
using System.Text;

namespace OpcAlarmServer.Configuration
{
    class ScriptException : Exception
    {
        public ScriptException(string? message) : base(message) { }
    }
}
