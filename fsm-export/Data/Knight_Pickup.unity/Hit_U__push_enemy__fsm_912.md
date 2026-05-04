# push_enemy

## Summary

| Field | Value |
| --- | --- |
| FSM Name | push_enemy |
| GameObject Name | Hit U |
| GameObject Path | Knight/Charm Effects/Blocker Shield/Pusher/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | Detect |
| FSM PathId | 912 |
| GameObject PathId | 111 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Direction | 90 | Single: 90 |
| Magnitude | 2 | Single: 2 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Type | 1 | Int32: 1 |

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

##### 1. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | 11 | Layer |   |
| sendEvent |   | Event(HIT) |   |   |
| storeCollider |   | GameObject Collider | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIT | Send Event | 0 | |

### Send Event

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BeginRecoil

Full Name: BeginRecoil
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault Collider | Variable |   |
| attackDirection |   | float Attack Direction | Variable |   |
| attackType |   | int Attack Type | Variable |   |
| attackMagnitude |   | float Magnitude | Variable |   |

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
| HIT | true |

