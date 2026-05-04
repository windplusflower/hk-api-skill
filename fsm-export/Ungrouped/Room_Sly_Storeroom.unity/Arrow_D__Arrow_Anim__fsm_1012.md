# Arrow Anim

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Arrow Anim |
| GameObject Name | Arrow D |
| GameObject Path | Shop Menu/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level18 |
| Start State | Init |
| FSM PathId | 1012 |
| GameObject PathId | 194 |

## Variables

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Init Pos | Vector2(-6.83, -0.92) | Vector2: Vector2(-6.83, -0.92) |
| Move Pos | Vector2(-6.83, -0.92) | Vector2: Vector2(-6.83, -0.92) |

## States

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
| vector3Variable |   | Vector3 Move Pos | Variable |   |
| vector3Value |   | Vector3 Init Pos |   |   |
| everyFrame |   | false |   |   |

##### 2. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Move Pos | Variable |   |
| addX |   | 0f |   |   |
| addY |   | -0.15f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| transformPosition |   |   |   |   |
| vectorPosition |   | Vector3 Init Pos |   |   |
| time |   | 0.1f |   |   |
| delay |   | 0f |   |   |
| speed |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| easeType | iTween/EaseType::easeOutSine | 13 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| moveToPath |   | false |   | Path |
| lookAhead |   | 0f |   |   |
| transforms |   | FSMViewAvalonia2.FsmArray2 |   |   |
| vectors |   | FSMViewAvalonia2.FsmArray2 |   |   |
| reverse |   | false |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MOVE | Up | 0 | |

### Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| transformPosition |   |   |   |   |
| vectorPosition |   | Vector3 Move Pos |   |   |
| time |   | 0.05f |   |   |
| delay |   | 0f |   |   |
| speed |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| easeType | iTween/EaseType::linear | 21 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| moveToPath |   | false |   | Path |
| lookAhead |   | 0f |   |   |
| transforms |   | FSMViewAvalonia2.FsmArray2 |   |   |
| vectors |   | FSMViewAvalonia2.FsmArray2 |   |   |
| reverse |   | false |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |
| MOVE | Repeat | 0 | |

### Repeat

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Up | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| MOVE | false |

