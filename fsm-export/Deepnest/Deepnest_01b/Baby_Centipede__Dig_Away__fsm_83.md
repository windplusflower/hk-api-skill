# Dig Away

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Dig Away |
| GameObject Name | Baby Centipede |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets278.assets |
| Start State | Away |
| FSM PathId | 83 |
| GameObject PathId | 32 |

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
| boolVariable | bool In Range | bool In Range | Variable |  |
| isTrue | Event(IN) | Event(IN) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 2. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 8f | 8f |  |  |
| timeMax | 12f | 12f |  |  |
| finishEvent | Event(DIG) | Event(DIG) |  |  |
| realTime | false | false |  |  |

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
| boolVariable | bool In Range | bool In Range | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(AWAY) | Event(AWAY) |  |  |
| everyFrame | true | true |  |  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Centipede" | "Centipede" | FsmName |  |
| variableName | "Will Dig" | "Will Dig" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Away | IN | In | 0 | 0 | 0 |
| Away | DIG | Dig | 0 | 0 | 0 |
| In | AWAY | Away | 0 | 0 | 0 |
| Dig | FINISHED | Away | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| AWAY | false |
| DIG | false |
| IN | false |

