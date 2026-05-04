# constrain_x

## Summary

| Field | Value |
| --- | --- |
| FSM Name | constrain_x |
| GameObject Name | Mimic Spider |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level496 |
| Start State | Idle |
| FSM PathId | 2062 |
| GameObject PathId | 102 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Edge L | 73.3499985 | Single: 73.3499985 |
| Edge R | 115.703003 | Single: 115.703003 |
| X Pos | 0 | Single: 0 |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float X Pos | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Pos |   |   |
| float2 |   | float Edge L |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   | CONSTRAIN L |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | true |   |   |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Pos |   |   |
| float2 |   | float Edge R |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | CONSTRAIN R |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CONSTRAIN L | Constrain L | 0 | |
| CONSTRAIN R | Constrain R | 0 | |

### Constrain L

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
| x |   | float Edge L |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

#### Transitions

(none)

### Constrain R

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
| x |   | float Edge R |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

#### Transitions

(none)

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Constrain L Only

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float X Pos | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Pos |   |   |
| float2 |   | float Edge R |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | CONSTRAIN R |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CONSTRAIN R | Constrain R | 0 | |

### Constrain R Only

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float X Pos | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Pos |   |   |
| float2 |   | float Edge R |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | CONSTRAIN R |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CONSTRAIN L | Constrain L | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| END CONSTRAIN R | Constrain R Only | 0 | |
| END CONSTRAIN | Inert | 0 | |
| END CONSTRAIN L | Constrain L Only | 0 | |
| START CONSTRAIN | Idle | 0 | |

## Events

| Name | Global |
| --- | --- |
| CONSTRAIN L | false |
| CONSTRAIN R | false |
| END CONSTRAIN | false |
| END CONSTRAIN L | false |
| END CONSTRAIN R | false |
| FINISHED | false |
| START CONSTRAIN | false |

