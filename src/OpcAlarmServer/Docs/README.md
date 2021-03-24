# Documentation

## Replay Script Format

```
folder:
  name: Folder_A
  sources:
    source:
      type: BaseObjectState
      name: Source_A
      alarms:
        alarm:
          type: TripAlarmState
          name: Source_A_Alarm_A
          id: A1
        alarm:
          type: ConditionState
          name: Source_A_Condition_A
          id: C1

steps:
  waitUntilStartInSeconds: 30
  stepsInLoop: true
  runningForSeconds: 600
  step:
    event:
      alarmId: "A1"
      reason: "Alarm Enabled"
      severity: "MediumHigh"
      eventid: "A1-0001"
      stateChanges:
        stateChange:
            stateType: Enabled
            state: true
        stateChange:
            stateType: Activated
            state: true
  step:
    sleepInSeconds: 10
  step:
    event:
      alarmId: "C1"
      severity: "Low"
      reason: "Condition Enabled"
      eventid: "C1-0001"
      stateChanges:
        stateChange:
            stateType: Enabled
            state: true

  step:
    event:
      alarmId: "A1"
      severity: "Medium"
      reason: "Alarm Acknowledged"
      eventid: "A1-0002"
      stateChanges:
        stateChange:
            stateType: Acknowledged
            state: true
  step:
    sleepInSeconds: 100
  step:
    event:
      alarmId: "A1"
      severity: "Low"
      reason: "Alarm Disabled"
      eventid: "A1-0003"
      stateChanges:
        stateChange:
            stateType: Enabled
            state: false

```

