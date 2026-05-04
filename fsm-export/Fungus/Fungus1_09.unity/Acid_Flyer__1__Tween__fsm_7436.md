# Tween

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Tween |
| GameObject Name | Acid Flyer (1) |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level138 |
| Start State | Init |
| FSM PathId | 7436 |
| GameObject PathId | 173 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Speed | 5.25 | Single: 5.25 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Initial Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Inverse Vector | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Move Vector | Vector2(0, 9.5) | Vector2: Vector2(0, 9.5) |

## States

### Tween Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| vector |   | Vector3 Move Vector |   |   |
| time |   | 0f |   |   |
| delay |   | 0f |   |   |
| speed |   | float Speed |   |   |
| easeType | iTween/EaseType::easeInOutSine | 14 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Tween Down | 0 | |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Inverse Vector | Variable |   |
| vector3Value |   | Vector3 Move Vector |   |   |
| everyFrame |   | false |   |   |

##### 2. Vector3Multiply

Full Name: HutongGames.PlayMaker.Actions.Vector3Multiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Inverse Vector | Variable |   |
| multiplyBy |   | -1f |   |   |
| everyFrame |   | false |   |   |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3 Initial Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Tween Up | 0 | |

### Reset Pos

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3 Initial Pos | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Tween Up | 0 | |

### Tween Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| vector |   | Vector3 Inverse Vector |   |   |
| time |   | 0f |   |   |
| delay |   | 0f |   |   |
| speed |   | float Speed |   |   |
| easeType | iTween/EaseType::easeInOutSine | 14 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Reset Pos | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

