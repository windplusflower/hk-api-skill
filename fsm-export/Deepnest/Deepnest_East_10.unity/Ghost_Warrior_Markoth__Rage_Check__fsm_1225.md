# Rage Check

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Rage Check |
| GameObject Name | Ghost Warrior Markoth |
| GameObject Path | Warrior/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level314 |
| Start State | Wait |
| FSM PathId | 1225 |
| GameObject PathId | 246 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| HP | 0 | Int32: 0 |
| Rage HP | 0 | Int32: 0 |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TOOK DAMAGE | Check | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| storeValue |   | int HP | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int HP |   |   |
| integer2 |   | int Rage HP |   |   |
| equal |   | Event(RAGE) |   |   |
| lessThan |   | Event(RAGE) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RAGE | Set Rage | 0 | |
| FINISHED | Idle | 0 | |

### Set Rage

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Attacking" | FsmName |   |
| variableName |   | "Rage" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Shield Attack" | FsmName |   |
| variableName |   | "Rage" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set HP | 0 | |

### Set HP

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| storeValue |   | int Rage HP | Variable |   |

##### 2. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Rage HP |   |   |
| integer2 |   | 2 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Divide | 3 |   |   |
| storeResult |   | int Rage HP | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| RAGE | false |
| TOOK DAMAGE | false |

