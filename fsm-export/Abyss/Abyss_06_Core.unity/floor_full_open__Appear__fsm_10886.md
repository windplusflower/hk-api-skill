# Appear

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Appear |
| GameObject Name | floor_full_open |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level334 |
| Start State | State 3 |
| FSM PathId | 10886 |
| GameObject PathId | 662 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Equipped CHarm | false | Boolean: false |
| Gate Opened | false | Boolean: false |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### State 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### State 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "equippedCharm_36" |   |   |
| storeValue |   | bool Equipped CHarm | Variable |   |

##### 2. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "openedBlackEggPath" |   |   |
| storeValue |   | bool Gate Opened | Variable |   |

##### 3. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | BLACK FLOOR OPEN |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Equipped CHarm | Variable |   |
| isTrue |   |   |   |   |
| isFalse |   | BLACK FLOOR OPEN |   |   |
| everyFrame |   | false |   |   |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Gate Opened | Variable |   |
| isTrue |   |   |   |   |
| isFalse |   | BLACK FLOOR OPEN |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BLACK FLOOR OPEN | State 5 | 0 | |

### State 5

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### State 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | State 4 | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BLACK FLOOR OPEN | false |
| FINISHED | false |

