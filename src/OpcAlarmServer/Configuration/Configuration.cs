using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpcAlarmServer.Configuration
{
    public class Configuration
    {
        public List<Folder> Folders { get; set; }
        public Script Script { get; set; }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions 
                { 
                    WriteIndented = true,
                    IgnoreNullValues = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    Converters = {
                        new JsonStringEnumConverter()
                    }
            });
        }

        public static Configuration FromJson(string json)
        {
            return JsonSerializer.Deserialize<Configuration>(json, new JsonSerializerOptions
                {
                    IgnoreNullValues = false,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    Converters = {
                    new JsonStringEnumConverter()
                    }
            });
        }

        public static Configuration Create()
        {
            return new Configuration
            {
                Folders = new List<Folder> {
                    new Folder
                    {
                        Name = "VendingMachines",
                        Sources = new List<Source>
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
                        }
                    }
                },
                Script = new Script
                {
                    WaitUntilStartInSeconds = 5,
                    StepsInLoop = true,
                    RunningForSecounds = 6000,
                    Steps = new List<Step>
                    {
                        new Step
                        {
                            Event = new Event
                            {
                                AlarmId = "A1",
                                Reason = "Alarm Enabled",
                                Severity = EventSeverity.MediumHigh,
                                EventId = "A1-0001",
                                StateChanges = new List<StateChange>
                                {
                                    new StateChange
                                    {
                                        StateType = ConditionStates.Enabled,
                                        State = true
                                    },
                                    new StateChange
                                    {
                                        StateType = ConditionStates.Activated,
                                        State = true
                                    }
                                }
                            }
                        },
                        new Step
                        {
                            SleepInSeconds = 10
                        },
                        new Step
                        {
                            Event = new Event
                            {
                                AlarmId = "C1",
                                Reason = "Condition Enabled",
                                Severity = EventSeverity.Medium,
                                EventId = "C1-0001",
                                StateChanges = new List<StateChange>
                                {
                                    new StateChange
                                    {
                                        StateType = ConditionStates.Enabled,
                                        State = true
                                    }
                                }
                            }
                        },
                        new Step
                        {
                            Event = new Event
                            {
                                AlarmId = "A1",
                                Reason = "Alarm Acknowledged",
                                Severity = EventSeverity.Medium,
                                EventId = "A1-0002",
                                StateChanges = new List<StateChange>
                                {
                                    new StateChange
                                    {
                                        StateType = ConditionStates.Acknowledged,
                                        State = true
                                    }
                                }
                            }
                        },
                        new Step
                        {
                            SleepInSeconds = 100
                        },
                        new Step
                        {
                            Event = new Event
                            {
                                AlarmId = "A1",
                                Reason = "Alarm Disabled",
                                Severity = EventSeverity.Low,
                                EventId = "A1-0003",
                                StateChanges = new List<StateChange>
                                {
                                    new StateChange
                                    {
                                        StateType = ConditionStates.Enabled,
                                        State = false
                                    }
                                }
                            }
                        },
                    }
                }
            };
        }
    }
}
