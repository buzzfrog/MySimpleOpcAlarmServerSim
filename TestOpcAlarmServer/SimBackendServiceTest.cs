using System;
using Xunit;
using OpcAlarmServer.SimBackend;
using OpcAlarmServer.Configuration;
using System.Collections.Generic;

namespace TestOpcAlarmServer
{
    public class SimBackendServiceTest
    {
        [Fact]
        public void Create1()
        {
            var sources = new List<Source>
                {
                    new Source
                    {
                        ObjectType = SourceObjectState.BaseObjectState,
                        Name = "VendingMachine1",
                        Alarms = new List<Alarm>
                        {
                            new Alarm
                            {
                                ObjectType = AlarmObjectStates.TripAlarmState,
                                Name = "VendingMachine1_DoorOpen",
                                Id = "A1"
                            },
                            new Alarm
                            {
                                ObjectType = AlarmObjectStates.ConditionState,
                                Name = "VendingMachine1_Operational",
                                Id = "C1"
                            }
                        }
                    },
                    new Source
                    {
                        ObjectType = SourceObjectState.BaseObjectState,
                        Name = "VendingMachine2",
                        Alarms = new List<Alarm>
                        {
                            new Alarm
                            {
                                ObjectType = AlarmObjectStates.TripAlarmState,
                                Name = "VendingMachine1_DoorOpen",
                                Id = "A2"
                            },
                            new Alarm
                            {
                                ObjectType = AlarmObjectStates.ConditionState,
                                Name = "VendingMachine1_Operational",
                                Id = "C2"
                            }
                        }
                    }
                };

            var simBackend = SimBackendService.CreateSimBackEnd(sources);
            
            Assert.NotEmpty(simBackend.SourceNodes);
            Assert.Equal("VendingMachine1_DoorOpen", simBackend.SourceNodes["VendingMachine1"].Alarms["A1"].Name);
        }
    }
}
