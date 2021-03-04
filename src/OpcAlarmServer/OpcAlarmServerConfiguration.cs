using buzzfrog.OpcAlarmServer;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OpcAlarmServer
{
    [DataContract(Namespace = Namespaces.OpcAlarmServer)]
    class OpcAlarmServerConfiguration
    {
        public OpcAlarmServerConfiguration()
        {
            Initialize();
        }

        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
        }
    }
}
