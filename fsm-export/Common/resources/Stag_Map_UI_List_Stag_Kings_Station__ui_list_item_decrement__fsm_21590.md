# ui_list_item_decrement

## Summary

| Field | Value |
| --- | --- |
| FSM Name | ui_list_item_decrement |
| GameObject Name | Kings Station |
| GameObject Path | Stag Map/UI List Stag |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Idle |
| FSM PathId | 21590 |
| GameObject PathId | 5389 |

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

_None_

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Item Number | int Item Number | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Item Number | int Item Number |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Item Number | int Item Number | Variable |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| setValue | int Item Number | int Item Number |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | DECREMENT LIST NUMBER | Decrement | 0 | 0 | 0 |
| Decrement | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| DECREMENT LIST NUMBER | false |

