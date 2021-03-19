using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpcAlarmServer.Configuration
{
    public class Configuration
    {
        public List<Folder> Folders { get; set; }
        public Script Script { get; set; }

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
                                Type = typeof(BaseObjectState),
                                Name = "VendingMachine1",
                                Alarms = new List<Alarm>
                                {
                                    new Alarm
                                    {
                                        Type = typeof(TripAlarmState),
                                        Name = "VendingMachine1_DoorOpen",
                                        Id = "A1"
                                    },
                                    new Alarm
                                    {
                                        Type = typeof(ConditionState),
                                        Name = "VendingMachine1_Operational",
                                        Id = "C1"
                                    }
                                }
                            }
                        }
                    }
                },
                Script = new Script
                {
                    WaitUntilStartInSeconds = 30,
                    StepsInLoop = true,
                    RunningForSecounds = 6000,
                    Steps = new List<Step>
                    {
                        new Step
                        {
                            Event =
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
                            Event =
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
                            Event =
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
                            Event =
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
