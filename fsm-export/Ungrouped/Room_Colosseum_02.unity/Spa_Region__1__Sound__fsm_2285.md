# Sound

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Sound |
| GameObject Name | Spa Region (1) |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level31 |
| Start State | State 1 |
| FSM PathId | 2285 |
| GameObject PathId | 634 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Health | false | Boolean: false |
| Soul | false | Boolean: false |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Health | Variable |   |
| isTrue |   | SOUND |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | true |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Soul | Variable |   |
| isTrue |   | SOUND |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SOUND | Sound | 0 | |

### Sound

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| boolStates |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trueEvent |   | STOP |   |   |
| falseEvent |   |   |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

##### 2. AudioPlayInState

Full Name: HutongGames.PlayMaker.Actions.AudioPlayInState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| STOP | State 1 | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| SOUND | false |
| STOP | false |

