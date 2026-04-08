# equip_position

## Summary

| Field | Value |
| --- | --- |
| FSM Name | equip_position |
| GameObject Name | Map and Quill |
| GameObject Path | _GameCameras/HudCamera/Inventory/Inv/Equipment |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 20049 |
| GameObject PathId | 4587 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Init X Pos | 1.1 | Single: 1.1 |
| Init Y Pos | -3.8 | Single: -3.8 |
| X Increment | 2.08 | Single: 2.08 |
| X Pos | 0 | Single: 0 |
| Y Increment | -2.18 | Single: -2.18 |
| Y Pos | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Columns | 4 | Int32: 4 |
| Current Column | 1 | Int32: 1 |
| Item Counter | 0 | Int32: 0 |
| Item Number | 0 | Int32: 0 |
| Loops | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Break | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Item Counter | int Item Counter | Variable |  |
| intValue | int Item Number | int Item Number |  |  |
| everyFrame | false | false |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Init X Pos | float Init X Pos |  |  |
| y | float Init Y Pos | float Init Y Pos |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Pos | float X Pos | Variable |  |
| y | float Y Pos | float Y Pos | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 5. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Loops | int Loops | Variable |  |
| intValue | int Item Number | int Item Number |  |  |
| everyFrame | false | false |  |  |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Column | int Current Column | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Break | bool Break | Variable |  |
| isTrue | Event(BREAK) | Event(BREAK) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Loop Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Loops | int Loops |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(LOOP) | Event(LOOP) |  |  |
| everyFrame | false | false |  |  |

### Increment X

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Pos | float X Pos | Variable |  |
| add | float X Increment | float X Increment |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 2. IntAddV2

Full Name: HutongGames.PlayMaker.Actions.IntAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Loops | int Loops | Variable |  |
| add | -1 | -1 |  |  |
| everyFrame | false | false |  |  |

##### 3. IntAddV2

Full Name: HutongGames.PlayMaker.Actions.IntAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Column | int Current Column | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Column | int Current Column |  |  |
| integer2 | int Columns | int Columns |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(SHIFT DOWN) | Event(SHIFT DOWN) |  |  |
| everyFrame | false | false |  |  |

### Shift Y Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Pos | float X Pos | Variable |  |
| floatValue | float Init X Pos | float Init X Pos |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Y Pos | float Y Pos | Variable |  |
| add | float Y Increment | float Y Increment |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Column | int Current Column | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Set Position

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Pos | float X Pos |  |  |
| y | float Y Pos | float Y Pos |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Break

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

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
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Loop Check | 0 | 0 | 0 |
| Init | BREAK | Break | 0 | 0 | 0 |
| Loop Check | LOOP | Increment X | 0 | 0 | 0 |
| Loop Check | FINISHED | Set Position | 0 | 0 | 0 |
| Increment X | SHIFT DOWN | Shift Y Down | 0 | 0 | 0 |
| Increment X | FINISHED | Loop Check | 0 | 0 | 0 |
| Shift Y Down | FINISHED | Loop Check | 0 | 0 | 0 |
| Break | FINISHED | Loop Check | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BREAK | false |
| LOOP | false |
| SHIFT DOWN | false |

