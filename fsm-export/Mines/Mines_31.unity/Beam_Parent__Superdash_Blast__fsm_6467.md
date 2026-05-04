# Superdash Blast

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Superdash Blast |
| GameObject Name | Beam Parent |
| GameObject Path | Super Dash Get/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level270 |
| Start State | Idle |
| FSM PathId | 6467 |
| GameObject PathId | 1336 |

## Variables

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
| SUPERDASH BLAST | Destroy Self | 0 | |

### Tween

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 3.330269f |   |   |
| y |   | 3.465246f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| transformScale |   |   |   |   |
| vectorScale |   | Vector3(0.153749, 2.01, 1) |   |   |
| time |   | 0.3f |   |   |
| delay |   | 0.001f |   |   |
| speed |   | 0f |   |   |
| easeType | iTween/EaseType::linear | 21 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Destroy Self | 0 | |

### Destroy Self

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SUPERDASH BLAST | false |

