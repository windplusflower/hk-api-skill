# Set Jinn

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Jinn |
| GameObject Name | door_jiji |
| GameObject Path | Jiji Door/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level7 |
| Start State | Pause |
| FSM PathId | 3819 |
| GameObject PathId | 162 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| PermaDeath Mode | 0 | Int32: 0 |

## States

### Pause

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
| FINISHED | Check | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "permadeathMode" |   |   |
| storeValue |   | int PermaDeath Mode | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int PermaDeath Mode |   |   |
| integer2 |   | 0 |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | JINN |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| JINN | Change | 0 | |

### Change

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Door Control" | FsmName |   |
| variableName |   | "New Scene" | FsmString |   |
| setValue |   | "Room_Jinn" |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| JINN | false |

