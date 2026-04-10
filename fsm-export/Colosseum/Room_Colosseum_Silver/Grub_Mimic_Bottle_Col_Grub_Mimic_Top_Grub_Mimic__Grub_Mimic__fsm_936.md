# Grub Mimic

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Grub Mimic |
| GameObject Name | Grub Mimic |
| GameObject Path | Grub Mimic Bottle Col/Grub Mimic Top |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets |
| Start State | Init |
| FSM PathId | 936 |
| GameObject PathId | 238 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hop Speed | 0 | Single: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Burst Point | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Slob Point | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Burst Point" | "Burst Point" |  |  |
| storeResult | GameObject Burst Point | GameObject Burst Point | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Slob Point" | "Slob Point" |  |  |
| storeResult | GameObject Slob Point | GameObject Slob Point | Variable |  |

##### 4. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

### Burst

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [grub_mimic_transform_start (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | [grub_mimic_transform_start (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Burst" | "Burst" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Scream

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 2. SetDamageHeroAmount

Full Name: SetDamageHeroAmount
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| damageDealt | 1 | 1 |  |  |

##### 3. SetInvincible

Full Name: SetInvincible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| Invincible | false | false |  |  |
| InvincibleFromDirection | 0 | 0 |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "CROWD LAUGH" | "CROWD LAUGH" |  |  |
| delay | 0.5f | 0.5f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | SetActive(false) | SetActive(false) |  |  |

##### 7. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [grub_mimic_initial_roar (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | [grub_mimic_initial_roar (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] |  |  |

### Start Run

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

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "IdleToRun" | "IdleToRun" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Chase

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ChaseObjectGround

Full Name: HutongGames.PlayMaker.Actions.ChaseObjectGround
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| speedMax | 15f | 15f |  |  |
| acceleration | 0.5f | 0.5f |  |  |
| animateTurnAndRun | false | false |  |  |
| runAnimation | "" | "" |  |  |
| turnAnimation | "" | "" |  |  |
| turnRange | 0f | 0f |  |  |

##### 2. SetInvincible

Full Name: SetInvincible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| Invincible | false | false |  |  |
| InvincibleFromDirection | 0 | 0 |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Run" | "Run" |  |  |

##### 4. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | "TurnToRun" | "TurnToRun" |  |  |
| resetFrame | true | true |  |  |
| everyFrame | true | true |  |  |

##### 5. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event() | Event() |  |  |
| rightHitEvent | Event(WALL) | Event(WALL) |  |  |
| bottomHitEvent | Event() | Event() |  |  |
| leftHitEvent | Event(WALL) | Event(WALL) |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

##### 6. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event() | Event() |  |  |
| rightHitEvent | Event(WALL) | Event(WALL) |  |  |
| bottomHitEvent | Event() | Event() |  |  |
| leftHitEvent | Event(WALL) | Event(WALL) |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

### Hit Slow

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Hop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 10f | 10f |  |  |
| max | 10f | 10f |  |  |
| storeResult | float Hop Speed | float Hop Speed | Variable |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | float Hop Speed | float Hop Speed |  |  |
| everyFrame | false | false |  |  |

### Burst 2

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

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [grub_mimic_transform_end (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | [grub_mimic_transform_end (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] |  |  |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Burst 2" | "Burst 2" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Burst Point | GameObject Burst Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 20 | 20 |  |  |
| spawnMax | 20 | 20 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 25f | 25f |  |  |
| angleMin | 40f | 40f |  |  |
| angleMax | 140f | 140f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Burst | 0 | 0 | 0 |
| Burst | FINISHED | Burst 2 | 0 | 0 | 0 |
| Scream | FINISHED | Start Run | 0 | 0 | 0 |
| Scream | TOOK DAMAGE | Start Run | 0 | 0 | 0 |
| Start Run | FINISHED | Chase | 0 | 0 | 0 |
| Chase | TOOK DAMAGE | Hit Slow | 0 | 0 | 0 |
| Chase | WALL | Hop | 0 | 0 | 0 |
| Hit Slow | FINISHED | Chase | 0 | 0 | 0 |
| Hop | FINISHED | Chase | 0 | 0 | 0 |
| Burst 2 | FINISHED | Scream | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| TOOK DAMAGE | false |
| WALL | false |

