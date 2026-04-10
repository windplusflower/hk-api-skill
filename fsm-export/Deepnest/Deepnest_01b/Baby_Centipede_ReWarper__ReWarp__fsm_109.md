# ReWarp

## Summary

| Field | Value |
| --- | --- |
| FSM Name | ReWarp |
| GameObject Name | ReWarper |
| GameObject Path | Baby Centipede |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets278.assets |
| Start State | Detect |
| FSM PathId | 109 |
| GameObject PathId | 26 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Collider | [null] | NamedAssetPPtr:  |

## States

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |  |  |
| collideTag | "Baby Centipede" | "Baby Centipede" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(COLLIDE) | Event(COLLIDE) |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

### Send Msg

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Collider | EventTarget(GameObject):Collider |  |  |
| sendEvent | "REWARP" | "REWARP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Collider | OwnerDefault Collider |  |  |
| fsmName | "Centipede" | "Centipede" | FsmName |  |
| variableName | "Rewarp" | "Rewarp" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Detect | COLLIDE | Send Msg | 0 | 0 | 0 |
| Send Msg | FINISHED | Detect | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| COLLIDE | false |

