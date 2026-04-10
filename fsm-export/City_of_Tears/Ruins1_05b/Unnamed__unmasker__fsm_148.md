# unmasker

## Summary

| Field | Value |
| --- | --- |
| FSM Name | unmasker |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets93.assets |
| Start State | Pause |
| FSM PathId | 148 |
| GameObject PathId |  |

## Variables

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "Player" | "Player" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(HIT) | Event(HIT) |  |  |
| storeCollider |  |  | Variable |  |

### Fade Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenFadeTo

Full Name: HutongGames.PlayMaker.Actions.iTweenFadeTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| alpha | 0f | 0f |  |  |
| includeChildren | true | true |  |  |
| namedValueColor | "_Color" | "_Color" |  |  |
| time | 0.5f | 0.5f |  |  |
| delay | 0f | 0f |  |  |
| easeType | iTween/EaseType::linear | 21 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |  |  |
| collideTag | "Player" | "Player" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(LEAVE) | Event(LEAVE) |  |  |
| storeCollider |  |  | Variable |  |

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

### Fade In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenFadeTo

Full Name: HutongGames.PlayMaker.Actions.iTweenFadeTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| alpha | 1f | 1f |  |  |
| includeChildren | true | true |  |  |
| namedValueColor | "_Color" | "_Color" |  |  |
| time | 0.5f | 0.5f |  |  |
| delay | 0f | 0f |  |  |
| easeType | iTween/EaseType::linear | 21 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "Player" | "Player" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(HIT) | Event(HIT) |  |  |
| storeCollider |  |  | Variable |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | HIT | Fade Out | 0 | 0 | 0 |
| Fade Out | LEAVE | Fade In | 0 | 0 | 0 |
| Pause | FINISHED | Idle | 0 | 0 | 0 |
| Fade In | HIT | Fade Out | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| HIT | true |
| LEAVE | false |

