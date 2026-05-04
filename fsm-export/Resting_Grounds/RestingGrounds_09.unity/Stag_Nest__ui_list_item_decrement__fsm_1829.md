# ui_list_item_decrement

## Summary

| Field | Value |
| --- | --- |
| FSM Name | ui_list_item_decrement |
| GameObject Name | Stag Nest |
| GameObject Path | Stag Map/UI List Stag/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level244 |
| Start State | Idle |
| FSM PathId | 1829 |
| GameObject PathId | 485 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Item Number | 0 | Int32: 0 |

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
| DECREMENT LIST NUMBER | Decrement | 0 | |

### Decrement

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
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Item Number | Variable |   |
| everyFrame |   | false |   |   |

##### 2. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Item Number |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Item Number | Variable |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| setValue |   | int Item Number |   |   |
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
| DECREMENT LIST NUMBER | false |
| FINISHED | false |

