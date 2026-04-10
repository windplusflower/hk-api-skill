# Bottle Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Bottle Control |
| GameObject Name | Grub Mimic Bottle Col |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets |
| Start State | Pause |
| FSM PathId | 766 |
| GameObject PathId | 121 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Speed Max | 30 | Single: 30 |
| Speed Min | 15 | Single: 15 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activated | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Debris | Grub Mimic Bottle/Debris (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets) | NamedAssetPPtr: Grub Mimic Bottle/Debris (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets) |
| Grub | Grub Mimic Bottle Col/Grub Mimic Top (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets) | NamedAssetPPtr: Grub Mimic Bottle Col/Grub Mimic Top (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets) |
| Phys Box | [null] | NamedAssetPPtr:  |
| Pool | [null] | NamedAssetPPtr:  |
| Pt Glass L | Grub Mimic Bottle/Pt Glass L (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets) | NamedAssetPPtr: Grub Mimic Bottle/Pt Glass L (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets) |
| Pt Glass S | Grub Mimic Bottle/Pt Glass S (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets) | NamedAssetPPtr: Grub Mimic Bottle/Pt Glass S (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets) |
| Self | [null] | NamedAssetPPtr:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "Nail Attack" | "Nail Attack" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(COLLIDE) | Event(COLLIDE) |  |  |
| storeCollider |  |  | Variable |  |

### Shatter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Phys Box | GameObject Phys Box |  |  |
| delay | 0f | 0f |  |  |
| detachChildren | false | false |  |  |

##### 2. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1.3f | 1.3f |  |  |
| pitchMax | 1.3f | 1.3f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Strike Nail R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Strike Nail R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent |  |  |
| sendEvent | "EnemyKillShake" | "EnemyKillShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Grub | EventTarget(GameObject):Grub |  |  |
| sendEvent | "FREE" | "FREE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Destroy Self

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Bottle Lid (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | [Global] [Bottle Lid (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] |  |  |
| spawnPoint | GameObject Phys Box | GameObject Phys Box |  |  |
| position | Vector3(0, 1.69, 0) | Vector3(0, 1.69, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 7f | 7f |  |  |
| speedMax | 8f | 8f |  |  |
| angleMin | 85f | 85f |  |  |
| angleMax | 95f | 95f |  |  |
| originVariation | 0f | 0f |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Debris | OwnerDefault Debris |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. FlingObjects

Full Name: HutongGames.PlayMaker.Actions.FlingObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| containerObject | [Grub Mimic Bottle/Debris (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | [Grub Mimic Bottle/Debris (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] |  |  |
| adjustPosition | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| randomisePosition | false | false |  |  |
| speedMin | 10f | 10f |  |  |
| speedMax | 15f | 15f |  |  |
| angleMin | 40f | 40f |  |  |
| angleMax | 140f | 140f |  |  |

##### 5. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Glass S | OwnerDefault Pt Glass S |  |  |
| emit | 0 | 0 |  |  |

##### 6. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Glass L | OwnerDefault Pt Glass L |  |  |
| emit | 0 | 0 |  |  |

##### 7. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

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
| childName | "Debris" | "Debris" |  |  |
| storeResult | [Grub Mimic Bottle/Debris (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | [Grub Mimic Bottle/Debris (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Grub Mimic Top" | "Grub Mimic Top" |  |  |
| storeResult | [Grub Mimic Bottle Col/Grub Mimic Top (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | [Grub Mimic Bottle Col/Grub Mimic Top (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Bottle Physical" | "Bottle Physical" |  |  |
| storeResult | GameObject Phys Box | GameObject Phys Box | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Glass L" | "Pt Glass L" |  |  |
| storeResult | [Grub Mimic Bottle/Pt Glass L (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | [Grub Mimic Bottle/Pt Glass L (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Glass S" | "Pt Glass S" |  |  |
| storeResult | [Grub Mimic Bottle/Pt Glass S (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | [Grub Mimic Bottle/Pt Glass S (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets)] | Variable |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | COLLIDE | Shatter | 0 | 0 | 0 |
| Shatter | FINISHED | Destroy Self | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Init | ACTIVATE |  | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ACTIVATE | false |
| COLLIDE | false |
| TRUE | false |

