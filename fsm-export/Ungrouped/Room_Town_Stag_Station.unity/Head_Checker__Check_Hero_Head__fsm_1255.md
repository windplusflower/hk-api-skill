# Check Hero Head

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Check Hero Head |
| GameObject Name | Head Checker |
| GameObject Path | Stag Lift/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level9 |
| Start State | Init |
| FSM PathId | 1255 |
| GameObject PathId | 332 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Parent | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Parent | Variable |   |

##### 2. SendTrigger2DEvent

Full Name: HutongGames.PlayMaker.Actions.SendTrigger2DEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Parent |   |   |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | 0 | Layer |   |
| sendEvent |   | Event(SEND COLLIDE) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |   | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SEND COLLIDE | true |

