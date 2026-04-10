# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Radiant Spike |
| GameObject Path | Boss Control/Spike Control/Far L |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level407.assets |
| Start State | Init |
| FSM PathId | 2437 |
| GameObject PathId | 521 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Floor Antic | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Floor Antic" | "Floor Antic" |  |  |
| storeResult | GameObject Floor Antic | GameObject Floor Antic | Variable |  |

### Downed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPolygonCollider

Full Name: HutongGames.PlayMaker.Actions.SetPolygonCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Floor Antic | OwnerDefault Floor Antic |  |  |
| active | false | false |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### Floor Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Floor Antic | OwnerDefault Floor Antic |  |  |
| active | true | true |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Floor Antic | OwnerDefault Floor Antic |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Spike Floor Antic" | "Spike Floor Antic" |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Spike Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Spike Up" | "Spike Up" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Floor Antic | OwnerDefault Floor Antic |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Spike Floor Idle" | "Spike Floor Idle" |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetPolygonCollider

Full Name: HutongGames.PlayMaker.Actions.SetPolygonCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPolygonCollider

Full Name: HutongGames.PlayMaker.Actions.SetPolygonCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Floor Antic | OwnerDefault Floor Antic |  |  |
| clipName | "Spike Floor End" | "Spike Floor End" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Spike Down" | "Spike Down" |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Downed | 0 | 0 | 0 |
| Downed | UP | Floor Antic | 0 | 0 | 0 |
| Floor Antic | FINISHED | Spike Up | 0 | 0 | 0 |
| Floor Antic | SPIKES DOWN | Down | 0 | 0 | 0 |
| Floor Antic | DOWN | Down | 0 | 0 | 0 |
| Spike Up | FINISHED | Up | 0 | 0 | 0 |
| Spike Up | SPIKES DOWN | Down | 0 | 0 | 0 |
| Spike Up | DOWN | Down | 0 | 0 | 0 |
| Up | DOWN | Down | 0 | 0 | 0 |
| Up | SPIKES DOWN | Down | 0 | 0 | 0 |
| Down | FINISHED | Downed | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| DOWN | false |
| HERO DAMAGED | true |
| SPIKES DOWN | false |
| UP | false |

