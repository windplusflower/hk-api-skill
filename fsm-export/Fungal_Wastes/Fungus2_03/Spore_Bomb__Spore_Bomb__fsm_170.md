# Spore Bomb

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spore Bomb |
| GameObject Name | Spore Bomb |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets167.assets |
| Start State | Init |
| FSM PathId | 170 |
| GameObject PathId | 32 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Accel Force | 0 | Single: 0 |
| Accel Force M | 8 | Single: 8 |
| Speed Max | 0 | Single: 0 |
| Speed Max M | 5 | Single: 5 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Explosion | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Spore Cloud | Spore Bomb/Spore Cloud (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets167.assets) | NamedAssetPPtr: Spore Bomb/Spore Cloud (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets167.assets) |
| Spore Fizzle | Spore Bomb/Spore Fizzle (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets167.assets) | NamedAssetPPtr: Spore Bomb/Spore Fizzle (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets167.assets) |

## States

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 0.3f | 0.3f |  |  |
| timeMax | 0.3f | 0.3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 17 | 17 | Layer |  |
| sendEvent | Event(COLLIDE) | Event(COLLIDE) |  |  |
| storeCollider |  |  | Variable |  |

##### 3. Collision2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Collision2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | PlayMakerUnity2d/Collision2DType::OnCollisionEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 17 | 17 | Layer |  |
| sendEvent | Event(COLLIDE) | Event(COLLIDE) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

### Chase

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. ChaseObjectV2

Full Name: HutongGames.PlayMaker.Actions.ChaseObjectV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| speedMax | float Speed Max | float Speed Max |  |  |
| accelerationForce | float Accel Force | float Accel Force |  |  |
| offsetX | 0f | 0f |  |  |
| offsetY | 0f | 0f |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.9f | 2.9f |  |  |
| finishEvent | Event(READY) | Event(READY) |  |  |
| realTime | false | false |  |  |

##### 3. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 17 | 17 | Layer |  |
| sendEvent | Event(COLLIDE) | Event(COLLIDE) |  |  |
| storeCollider |  |  | Variable |  |

##### 4. Collision2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Collision2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | PlayMakerUnity2d/Collision2DType::OnCollisionEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 17 | 17 | Layer |  |
| sendEvent | Event(COLLIDE) | Event(COLLIDE) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 5. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "HeroBox" | "HeroBox" | Tag |  |
| collideLayer | 0 | 0 | Layer |  |
| sendEvent | Event(COLLIDE) | Event(COLLIDE) |  |  |
| storeCollider |  |  | Variable |  |

### Ready

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.95f | 0.95f |  |  |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Spore Fizzle | OwnerDefault Spore Fizzle |  |  |
| emission | true | true |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Explode" | "Explode" |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.6f | 0.6f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Explode

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Gas Explosion Recycle M (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Gas Explosion Recycle M (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Explosion | GameObject Explosion | Variable |  |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Spore Fizzle | OwnerDefault Spore Fizzle |  |  |
| emission | false | false |  |  |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Spore Cloud | OwnerDefault Spore Cloud |  |  |
| emission | false | false |  |  |

##### 5. SetCircleCollider

Full Name: HutongGames.PlayMaker.Actions.SetCircleCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 6. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Spore Cloud | OwnerDefault Spore Cloud |  |  |
| emission | true | true |  |  |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Spore Fizzle | OwnerDefault Spore Fizzle |  |  |
| emission | false | false |  |  |

##### 3. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Accel Force | float Accel Force | Variable |  |
| floatValue | float Accel Force M | float Accel Force M |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Speed Max | float Speed Max | Variable |  |
| floatValue | float Speed Max M | float Speed Max M |  |  |
| everyFrame | false | false |  |  |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle 2" | "Idle 2" |  |  |

##### 7. SetCircleCollider

Full Name: HutongGames.PlayMaker.Actions.SetCircleCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 8. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### Recycle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Wait | FINISHED | Chase | 0 | 0 | 0 |
| Wait | COLLIDE | Explode | 0 | 0 | 0 |
| Chase | READY | Ready | 0 | 0 | 0 |
| Chase | COLLIDE | Explode | 0 | 0 | 0 |
| Chase | ORBIT SHIELD | Explode | 0 | 0 | 0 |
| Ready | FINISHED | Explode | 0 | 0 | 0 |
| Explode | FINISHED | Recycle | 0 | 0 | 0 |
| Init | FINISHED | Wait | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| COLLIDE | false |
| ORBIT SHIELD | false |
| READY | false |

