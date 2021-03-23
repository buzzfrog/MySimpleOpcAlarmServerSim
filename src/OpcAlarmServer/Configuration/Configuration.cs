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
                                        ObjectType = AlarmObjectStates.TripAlarmType,
                                        Name = "VendingMachine1_DoorOpen",
                                        Id = "V1_DoorOpen"
                                    },
                                    new Alarm
                                    {
                                        ObjectType = AlarmObjectStates.LimitAlarmType,
                                        Name = "VendingMachine1_TemperatureHigh",
                                        Id = "V1_TemperatureHigh"
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
                                        ObjectType = AlarmObjectStates.TripAlarmType,
                                        Name = "VendingMachine2_DoorOpen",
                                        Id = "V2_DoorOpen"
                                    },
                                    new Alarm
                                    {
                                        ObjectType = AlarmObjectStates.OffNormalAlarmType,
                                        Name = "VendingMachine2_LightOff",
                                        Id = "V2_LightOff"
                                    }
                                }
                            }
                        }
                    }
                },
                Script = new Script
                {
                    WaitUntilStartInSeconds = 15,
                    StepsInLoop = true,
                    RunningForSecounds = 6000,
                    Steps = new List<Step>
                    {
                        new Step
                        {
                            Event = new Event
                            {
                                AlarmId = "V1_DoorOpen",
                                Reason = "Door Open",
                                Severity = EventSeverity.High,
                                EventId = "V1_DoorOpen-1",
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
                            SleepInSeconds = 20
                        },
                        new Step
                        {
                            Event = new Event
                            {
                                AlarmId = "V2_LightOff",
                                Reason = "Light Off in machine",
                                Severity = EventSeverity.Medium,
                                EventId = "V2_LightOff-1",
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
                            SleepInSeconds = 30
                        },
                        new Step
                        {
                            Event = new Event
                            {
                                AlarmId = "V1_DoorOpen",
                                Reason = "Door Closed",
                                Severity = EventSeverity.Medium,
                                EventId = "V1_DoorOpen-2",
                                StateChanges = new List<StateChange>
                                {
                                    new StateChange
                                    {
                                        StateType = ConditionStates.Activated,
                                        State = false
                                    }
                                }
                            }
                        },
                        new Step
                        {
                            SleepInSeconds = 20
                        },
                        new Step
                        {
                            Event = new Event
                            {
                                AlarmId = "V2_LightOff",
                                Reason = "Light is on",
                                Severity = EventSeverity.Low,
                                EventId = "V2_LightOff-2",
                                StateChanges = new List<StateChange>
                                {
                                    new StateChange
                                    {
                                        StateType = ConditionStates.Activated,
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
