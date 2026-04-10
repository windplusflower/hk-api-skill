# Hero Saver

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Hero Saver |
| GameObject Name | Radiant Spike (18) |
| GameObject Path | Boss Control/Spike Control/Far R |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level407.assets |
| Start State | Idle |
| FSM PathId | 2498 |
| GameObject PathId | 447 |

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
| collideTag | "HeroBox" | "HeroBox" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | TRIGGER | TRIGGER |  |  |
| storeCollider |  |  | Variable |  |

### Send

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "SPIKES DOWN" | "SPIKES DOWN" |  |  |
| delay | 0.2f | 0.2f |  |  |
| everyFrame | false | false |  |  |

### No Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | TRIGGER | Send | 0 | 0 | 0 |
| Send | FINISHED | Idle | 0 | 0 | 0 |
| No Check | SHADOW DASH END | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| SHADOW DASH START | No Check | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SHADOW DASH END | false |
| SHADOW DASH START | false |
| TRIGGER | false |

