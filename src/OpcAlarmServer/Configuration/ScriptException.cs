using System;
using System.Collections.Generic;
using System.Text;

namespace OpcAlarmServer.Configuration
{
    class ScriptException : Exception
    {
#nullable enable
        public ScriptException(string? message) : base(message) { }
    }
}
