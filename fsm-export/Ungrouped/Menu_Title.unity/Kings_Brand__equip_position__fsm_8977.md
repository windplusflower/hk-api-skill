# equip_position

## Summary

| Field | Value |
| --- | --- |
| FSM Name | equip_position |
| GameObject Name | Kings Brand |
| GameObject Path | _GameCameras/HudCamera/Inventory/Inv/Equipment/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Pause |
| FSM PathId | 8977 |
| GameObject PathId | 783 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Init X Pos | 1.10000002 | Single: 1.10000002 |
| Init Y Pos | -3.79999995 | Single: -3.79999995 |
| X Increment | 2.07999992 | Single: 2.07999992 |
| X Pos | 0 | Single: 0 |
| Y Increment | -2.18000007 | Single: -2.18000007 |
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
| Self | [null] | NamedAssetPPtr: [null] |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Item Counter | Variable |   |
| intValue |   | int Item Number |   |   |
| everyFrame |   | false |   |   |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Init X Pos |   |   |
| y |   | float Init Y Pos |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float X Pos | Variable |   |
| y |   | float Y Pos | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |

##### 5. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Loops | Variable |   |
| intValue |   | int Item Number |   |   |
| everyFrame |   | false |   |   |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Current Column | Variable |   |
| intValue |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Break | Variable |   |
| isTrue |   | Event(BREAK) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Loop Check | 0 | |
| BREAK | Break | 0 | |

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
| integer1 |   | int Loops |   |   |
| integer2 |   | 1 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(LOOP) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LOOP | Increment X | 0 | |
| FINISHED | Set Position | 0 | |

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
| floatVariable |   | float X Pos | Variable |   |
| add |   | float X Increment |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 2. IntAddV2

Full Name: HutongGames.PlayMaker.Actions.IntAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Loops | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

##### 3. IntAddV2

Full Name: HutongGames.PlayMaker.Actions.IntAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Current Column | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Current Column |   |   |
| integer2 |   | int Columns |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(SHIFT DOWN) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SHIFT DOWN | Shift Y Down | 0 | |
| FINISHED | Loop Check | 0 | |

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
| floatVariable |   | float X Pos | Variable |   |
| floatValue |   | float Init X Pos |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Y Pos | Variable |   |
| add |   | float Y Increment |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Current Column | Variable |   |
| intValue |   | 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Loop Check | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float X Pos |   |   |
| y |   | float Y Pos |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

(none)

### Break

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Loop Check | 0 | |

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
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BREAK | false |
| FINISHED | false |
| LOOP | false |
| SHIFT DOWN | false |

