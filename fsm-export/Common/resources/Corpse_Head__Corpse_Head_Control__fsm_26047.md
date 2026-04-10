# Corpse Head Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Corpse Head Control |
| GameObject Name | Corpse Head |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Detect |
| FSM PathId | 26047 |
| GameObject PathId | 6424 |

## Variables

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Colour | Color(1, 1, 1, 1) | UnityColor: Color(1, 1, 1, 1) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Acid Bubble | [null] | NamedAssetPPtr:  |
| Acid Spore | [null] | NamedAssetPPtr:  |
| Corpse Flame | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| sendEvent | Event(COLLIDE) | Event(COLLIDE) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

### Chip

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Death Head Cracked" | "Death Head Cracked" |  |  |

##### 3. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [skull_chip1 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [skull_chip1 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 10f | 10f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 20f | 20f |  |  |
| angleMax | 160f | 160f |  |  |
| originVariation | 0f | 0f |  |  |

##### 4. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [skull_chip2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [skull_chip2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 2 | 2 |  |  |
| speedMin | 10f | 10f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 20f | 20f |  |  |
| angleMax | 160f | 160f |  |  |
| originVariation | 0f | 0f |  |  |

### Acid

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Acid Bubble | GameObject Acid Bubble |  |  |
| audioClip | [acid_splash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [acid_splash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Corpse Acid Steam (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Corpse Acid Steam (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Acid Bubble | GameObject Acid Bubble |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 3. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| gravityScale | 0.05f | 0.05f |  |  |

##### 4. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Acid Bubble | OwnerDefault Acid Bubble |  |  |
| deceleration | 0.65f | 0.65f |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 6. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Acid Spore | OwnerDefault Acid Spore |  |  |
| emit | 0 | 0 |  |  |

##### 7. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Corpse Flame | OwnerDefault Corpse Flame |  |  |
| emit | 0 | 0 |  |  |

### Sizzle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| color | Color Colour | Color Colour | FsmColor |  |
| everyframe | true | true |  |  |

##### 2. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Acid Bubble | OwnerDefault Acid Bubble |  |  |
| deceleration | 0.65f | 0.65f |  |  |

##### 3. ColorInterpolate

Full Name: HutongGames.PlayMaker.Actions.ColorInterpolate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colors | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| time | 1f | 1f |  |  |
| storeColor | Color Colour | Color Colour | Variable |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Finish

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Acid Spore | OwnerDefault Acid Spore |  |  |

##### 2. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Corpse Flame | OwnerDefault Corpse Flame |  |  |

### Splash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Acid Bubble | GameObject Acid Bubble | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Spore Cloud" | "Spore Cloud" |  |  |
| storeResult | GameObject Corpse Flame | GameObject Corpse Flame | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Bub Cloud" | "Bub Cloud" |  |  |
| storeResult | GameObject Acid Spore | GameObject Acid Spore | Variable |  |

##### 4. SetPolygonCollider

Full Name: HutongGames.PlayMaker.Actions.SetPolygonCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 5. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Acid Splash (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Acid Splash (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Acid Bubble | GameObject Acid Bubble |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Detect | COLLIDE | Chip | 0 | 0 | 0 |
| Acid | FINISHED | Sizzle | 0 | 0 | 0 |
| Sizzle | FINISHED | Finish | 0 | 0 | 0 |
| Splash | FINISHED | Acid | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| ACID | Splash | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| COLLIDE | false |
| FINISHED | false |
| ACID | false |

