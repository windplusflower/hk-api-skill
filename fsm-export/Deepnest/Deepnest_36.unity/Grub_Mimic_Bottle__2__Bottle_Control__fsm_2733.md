# Bottle Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Bottle Control |
| GameObject Name | Grub Mimic Bottle (2) |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level294 |
| Start State | Pool |
| FSM PathId | 2733 |
| GameObject PathId | 262 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Type | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activated | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Damager | [null] | NamedAssetPPtr: [null] |
| Debris | Grub Mimic Top (2) (Hollow Knight/hollow_knight_Data\level294) | NamedAssetPPtr: [Grub Mimic Top (2) (Hollow Knight/hollow_knight_Data\level294)] |
| Grub | Grub Mimic Top (2) (Hollow Knight/hollow_knight_Data\level294) | NamedAssetPPtr: [Grub Mimic Top (2) (Hollow Knight/hollow_knight_Data\level294)] |
| Phys Box | Grub Mimic Top (2) (Hollow Knight/hollow_knight_Data\level294) | NamedAssetPPtr: [Grub Mimic Top (2) (Hollow Knight/hollow_knight_Data\level294)] |
| Pool | [null] | NamedAssetPPtr: [null] |
| Pt Glass L | Grub Mimic Bottle (2)/Pt Glass L (Hollow Knight/hollow_knight_Data\level294) | NamedAssetPPtr: [Grub Mimic Bottle (2)/Pt Glass L (Hollow Knight/hollow_knight_Data\level294)] |
| Pt Glass S | Grub Mimic Bottle (2)/Pt Glass S (Hollow Knight/hollow_knight_Data\level294) | NamedAssetPPtr: [Grub Mimic Bottle (2)/Pt Glass S (Hollow Knight/hollow_knight_Data\level294)] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Bottle Physical" |   |   |
| storeResult |   | [Grub Mimic Bottle (2)/Bottle Physical (Hollow Knight/hollow_knight_Data\level294)] | Variable |   |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "Nail Attack" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(COLLIDE) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| COLLIDE | Shatter | 0 | |

### Shatter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1.3f |   |   |
| pitchMax |   | 1.3f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 2. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Grub Mimic Bottle (2)/Bottle Physical (Hollow Knight/hollow_knight_Data\level294)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Strike Nail R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Grub |   |   |
| sendEvent |   | "FREE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Destroy Self | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 2. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Bottle Lid (Hollow Knight/hollow_knight_Data\sharedassets33.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 1.69, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 7f |   |   |
| speedMax |   | 8f |   |   |
| angleMin |   | 85f |   |   |
| angleMax |   | 95f |   |   |
| originVariation |   | 0f |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Debris |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. FlingObjects

Full Name: HutongGames.PlayMaker.Actions.FlingObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| containerObject |   | [Grub Mimic Bottle (2)/Debris (Hollow Knight/hollow_knight_Data\level294)] |   |   |
| adjustPosition |   | Vector3(0, 0, 0) |   |   |
| randomisePosition |   | false |   |   |
| speedMin |   | 10f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 40f |   |   |
| angleMax |   | 140f |   |   |

##### 5. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pt Glass L |   |   |
| emit |   | 0 |   |   |

##### 6. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pt Glass S |   |   |
| emit |   | 0 |   |   |

##### 7. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

#### Transitions

(none)

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
| time |   | 0.5f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init | 0 | |

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "GRUB SAVED" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 4. DestroyAllChildren

Full Name: HutongGames.PlayMaker.Actions.DestroyAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| disable |   | false |   |   |

##### 5. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Bottle Lid (Hollow Knight/hollow_knight_Data\sharedassets33.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -0.5, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 85f |   |   |
| angleMax |   | 95f |   |   |
| originVariation |   | 0f |   |   |

##### 6. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

#### Transitions

(none)

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| isTrue |   | Event(ACTIVATE) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Grub |   |   |
| sendEvent |   | "IN BOTTLE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Bottle Physical" |   |   |
| storeResult |   | [Grub Mimic Bottle (2)/Bottle Physical (Hollow Knight/hollow_knight_Data\level294)] | Variable |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Phys Box |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |
| ACTIVATE | Activate | 0 | |

### Pool

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pool |   |   |
| parent |   | GameObject Self |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pool |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTIVATE | false |
| COLLIDE | false |
| FINISHED | false |
| TRUE | false |

