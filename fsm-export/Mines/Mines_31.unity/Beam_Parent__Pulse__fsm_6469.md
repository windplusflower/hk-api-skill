# Pulse

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Pulse |
| GameObject Name | Beam Parent |
| GameObject Path | Super Dash Get/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level270 |
| Start State | Idle |
| FSM PathId | 6469 |
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
| PULSE | Pulse | 0 | |

### Pulse

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [] |   |   |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1.06f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 3. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| transformScale |   |   |   |   |
| vectorScale |   | Vector3(0.57, 1.487794, 1.0608) |   |   |
| time |   | 1.2f |   |   |
| delay |   | 0f |   |   |
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
| FINISHED | Idle | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| PULSE | Pulse | 0 | |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| PULSE | false |

