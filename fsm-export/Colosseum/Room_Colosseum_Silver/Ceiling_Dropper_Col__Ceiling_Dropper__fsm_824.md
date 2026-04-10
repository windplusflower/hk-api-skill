# Ceiling Dropper

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Ceiling Dropper |
| GameObject Name | Ceiling Dropper Col |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets |
| Start State | Startle |
| FSM PathId | 824 |
| GameObject PathId | 173 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self X | 0 | Single: 0 |
| Self Y | 0 | Single: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Death Skull | [null] | NamedAssetPPtr:  |
| Explosion | [null] | NamedAssetPPtr:  |

## States

### Startle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Idle To Dive" | "Idle To Dive" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [ceiling_dropper_emerge (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | [ceiling_dropper_emerge (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] |  |  |

### Dive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |
| finishedEvent | Event() | Event() |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | -20f | -20f |  |  |
| everyFrame | true | true |  |  |

##### 3. ChaseObjectV2

Full Name: HutongGames.PlayMaker.Actions.ChaseObjectV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| speedMax | 25f | 25f |  |  |
| accelerationForce | 60f | 60f |  |  |
| offsetX | 0f | 0f |  |  |
| offsetY | 0f | 0f |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Dive" | "Dive" |  |  |

##### 5. FaceAngle

Full Name: HutongGames.PlayMaker.Actions.FaceAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angleOffset | 90f | 90f |  |  |
| everyFrame | true | true |  |  |

##### 6. Collision2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Collision2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | PlayMakerUnity2d/Collision2DType::OnCollisionEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 8 | 8 | Layer |  |
| sendEvent | Event(COLLIDE) | Event(COLLIDE) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 7. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "HeroBox" | "HeroBox" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(COLLIDE) | Event(COLLIDE) |  |  |
| storeCollider |  |  | Variable |  |

### Explode

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Self X | float Self X | Variable |  |
| y | float Self Y | float Self Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Explosion | OwnerDefault Explosion |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Self X | float Self X |  |  |
| y | float Self Y | float Self Y |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. InstaDeath

Full Name: InstaDeath
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| direction | 0f | 0f |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Startle | FINISHED | Dive | 0 | 0 | 0 |
| Startle | TOOK DAMAGE | Explode | 0 | 0 | 0 |
| Dive | COLLIDE | Explode | 0 | 0 | 0 |
| Dive | TOOK DAMAGE | Explode | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| 1 | false |
| 2 | false |
| ALERT | true |
| COLLIDE | false |
| TOOK DAMAGE | false |

