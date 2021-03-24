using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OpcAlarmServer
{
    [DataContract(Namespace = Namespaces.VendingMachines)]
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
