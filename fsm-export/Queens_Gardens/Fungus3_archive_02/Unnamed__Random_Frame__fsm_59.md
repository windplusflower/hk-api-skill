# Random Frame

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Random Frame |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets228.assets |
| Start State | State 1 |
| FSM PathId | 59 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Z Shift | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Frame | 0 | Int32: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Start Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0f | 0f |  |  |
| max | 4f | 4f |  |  |
| storeResult | float Z Shift | float Z Shift | Variable |  |

##### 2. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | float Z Shift | float Z Shift |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 3. RandomInt

Full Name: HutongGames.PlayMaker.Actions.RandomInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0 | 0 |  |  |
| max | 18 | 18 |  |  |
| storeResult | int Frame | int Frame | Variable |  |
| inclusiveMax | true | true |  |  |

##### 4. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| frame | int Frame | int Frame |  |  |

##### 5. IdleBuzzV2

Full Name: HutongGames.PlayMaker.Actions.IdleBuzzV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| waitMin | 0.75f | 0.75f |  |  |
| waitMax | 1f | 1f |  |  |
| speedMax | 1.5f | 1.5f |  |  |
| accelerationMax | 10f | 10f |  |  |
| roamingRangeX | 1f | 1f |  |  |
| roamingRangeY | 1f | 1f |  |  |
| manualStartPos | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |  |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| _(none)_ |  |

