# Play Sound

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Play Sound |
| GameObject Name | mine_1_quake_floor |
| GameObject Path | _Scenery/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level248 |
| Start State | No Sound |
| FSM PathId | 2853 |
| GameObject PathId | 193 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Floor 1 | false | Boolean: false |
| Floor 2 | false | Boolean: false |
| Floor 3 | false | Boolean: false |

## States

### No Sound

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |

##### 2. BoolAnyTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAnyTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(ON) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ON | State 1 | 0 | |

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [] |   |   |
| finishedEvent |   | Event() |   |   |

##### 2. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(OFF) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| OFF | No Sound | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| OFF | false |
| ON | false |

