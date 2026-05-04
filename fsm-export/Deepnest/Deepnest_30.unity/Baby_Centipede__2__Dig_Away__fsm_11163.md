# Dig Away

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Dig Away |
| GameObject Name | Baby Centipede (2) |
| GameObject Path | _Enemies/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level288 |
| Start State | Away |
| FSM PathId | 11163 |
| GameObject PathId | 2991 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| In Range | false | Boolean: false |

## States

### Away

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool In Range | Variable |   |
| isTrue |   | Event(IN) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 2. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 8f |   |   |
| timeMax |   | 12f |   |   |
| finishEvent |   | Event(DIG) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| IN | In | 0 | |
| DIG | Dig | 0 | |

### In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool In Range | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(AWAY) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| AWAY | Away | 0 | |

### Dig

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Centipede" | FsmName |   |
| variableName |   | "Will Dig" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Away | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| AWAY | false |
| DIG | false |
| FINISHED | false |
| IN | false |

