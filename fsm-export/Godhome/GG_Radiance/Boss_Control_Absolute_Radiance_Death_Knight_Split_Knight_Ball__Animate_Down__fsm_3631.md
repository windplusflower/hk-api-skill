# Animate Down

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Animate Down |
| GameObject Name | Knight Ball |
| GameObject Path | Boss Control/Absolute Radiance/Death/Knight Split |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level459.assets |
| Start State | State 1 |
| FSM PathId | 3631 |
| GameObject PathId | 910 |

## Variables

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Knight Unform" | "Knight Unform" |  |  |

### State 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Knight Unform" | "Knight Unform" |  |  |

##### 2. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| vector | Vector3(0, -20, 0) | Vector3(0, -20, 0) |  |  |
| time | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| speed | 10f | 10f |  |  |
| easeType | iTween/EaseType::easeInSine | 12 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| startEvent |  |  |  |  |
| finishEvent |  |  |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| State 1 | FINISHED | State 2 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| KILL HIT | false |

