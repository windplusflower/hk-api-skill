# Damage Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Damage Control |
| GameObject Name | Jar Collector |
| GameObject Path | Battle Scene/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level126 |
| Start State | Idle |
| FSM PathId | 84 |
| GameObject PathId | 10 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hops | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Phase 2 | false | Boolean: false |

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

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Phase 2 | Variable |   |
| isTrue |   | Event(DECREMENT) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. SendRandomEvent

Full Name: HutongGames.PlayMaker.Actions.SendRandomEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| delay |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |
| DECREMENT | Dec | 0 | |

### Dec

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Control" | FsmName |   |
| variableName |   | "Hops" | FsmInt |   |
| storeValue |   | int Hops | Variable |   |
| everyFrame |   | false |   |   |

##### 2. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Hops |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Hops | Variable |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Control" | FsmName |   |
| variableName |   | "Hops" | FsmInt |   |
| setValue |   | int Hops |   |   |
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
| DECREMENT | false |
| FINISHED | false |
| TOOK DAMAGE | false |

