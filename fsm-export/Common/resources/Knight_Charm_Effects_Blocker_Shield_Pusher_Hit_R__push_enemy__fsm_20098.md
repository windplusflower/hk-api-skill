# push_enemy

## Summary

| Field | Value |
| --- | --- |
| FSM Name | push_enemy |
| GameObject Name | Hit R |
| GameObject Path | Knight/Charm Effects/Blocker Shield/Pusher |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Detect |
| FSM PathId | 20098 |
| GameObject PathId | 7263 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Direction | 0 | Single: 0 |
| Magnitude | 2 | Single: 2 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Type | 1 | Int32: 1 |

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

##### 1. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 11 | 11 | Layer |  |
| sendEvent | Event(HIT) | Event(HIT) |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

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
| target | OwnerDefault Collider | OwnerDefault Collider | Variable |  |
| attackDirection | float Attack Direction | float Attack Direction | Variable |  |
| attackType | int Attack Type | int Attack Type | Variable |  |
| attackMagnitude | float Magnitude | float Magnitude | Variable |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Detect | HIT | Send Event | 0 | 0 | 0 |
| Send Event | FINISHED | Detect | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| HIT | true |

