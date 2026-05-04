# Waker

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Waker |
| GameObject Name | Waker |
| GameObject Path | Colosseum_Miner/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level35 |
| Start State | Detect |
| FSM PathId | 1617 |
| GameObject PathId | 468 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Collider | [null] | NamedAssetPPtr: [null] |

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
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(NAIL HIT) |   |   |
| storeCollider |   | GameObject Collider | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NAIL HIT | Send | 0 | |

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
| eventTarget |   | EventTarget(GameObject):Collider |   |   |
| sendEvent |   | "HERO IN RANGE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| NAIL HIT | false |

