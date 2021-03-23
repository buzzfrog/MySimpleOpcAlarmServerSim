using System;
using Xunit;
using OpcAlarmServer.SimBackend;
using OpcAlarmServer.Configuration;
using System.Collections.Generic;
using OpcAlarmServer.Model;
using Moq;
using Opc.Ua.Server;
using Opc.Ua;

namespace TestOpcAlarmServer
{
    public class SimSourceNodeStateTest
    {
        [Fact]
        public void ctor()
        {

            var simSourceNodeState = new SimSourceNodeState(new CustomNodeManager2(), new NodeId(1), "name");

        }
    }
}
