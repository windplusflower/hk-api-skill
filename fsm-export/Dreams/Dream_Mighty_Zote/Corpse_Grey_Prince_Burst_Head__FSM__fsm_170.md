# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Head |
| GameObject Path | Corpse Grey Prince/Burst |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets399.assets |
| Start State | Fling |
| FSM PathId | 170 |
| GameObject PathId | 68 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle Max | 85 | Single: 85 |
| Angle Min | 95 | Single: 95 |
| Scale X | 0 | Single: 0 |
| Speed Max | 35 | Single: 35 |
| Speed Min | 35 | Single: 35 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Scale | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

## States

### Fling

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3 Scale | Vector3 Scale | Variable |  |
| xScale | float Scale X | float Scale X | Variable |  |
| yScale | 0f | 0f | Variable |  |
| zScale | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| parent |  |  |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 3. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3 Scale | Vector3 Scale | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. FlingObject

Full Name: HutongGames.PlayMaker.Actions.FlingObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| flungObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| speedMin | float Speed Min | float Speed Min |  |  |
| speedMax | float Speed Max | float Speed Max |  |  |
| angleMin | float Angle Min | float Angle Min |  |  |
| angleMax | float Angle Max | float Angle Max |  |  |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Scale X | float Scale X |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FLIP) | Event(FLIP) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Scale X | float Scale X | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Scale X | float Scale X |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Fling | FLIP | State 1 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FLIP | false |

