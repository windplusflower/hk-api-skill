# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets |
| Start State | Pause |
| FSM PathId | 100 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Direction | 0 | Single: 0 |
| Chooser | 0 | Single: 0 |
| Recoil Speed | 1 | Single: 1 |
| Recoil Speed Neg | 0 | Single: 0 |
| Start X | 0 | Single: 0 |
| Start Y | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Type | 0 | Int32: 0 |
| Facing | 0 | Int32: 0 |
| Hits | 4 | Int32: 4 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activated | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| CamLock Name |  | String:  |
| Mask Name |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Audio Player | [null] | NamedAssetPPtr:  |
| CamLock | [null] | NamedAssetPPtr:  |
| Camera | [null] | NamedAssetPPtr:  |
| Damager | [null] | NamedAssetPPtr:  |
| Dust Break 1 | [null] | NamedAssetPPtr:  |
| Dust Break 2 | [null] | NamedAssetPPtr:  |
| Mask | [null] | NamedAssetPPtr:  |
| Particles Large | [null] | NamedAssetPPtr:  |
| Particles Small | [null] | NamedAssetPPtr:  |
| Pool L | [null] | NamedAssetPPtr:  |
| Pool S | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Strike Effect | [null] | NamedAssetPPtr:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "Hero Spell" | "Hero Spell" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(SPELL) | Event(SPELL) |  |  |
| storeCollider |  |  | Variable |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Start X | float Start X |  |  |
| y | float Start Y | float Start Y |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Check If Nail

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetEventSender

Full Name: HutongGames.PlayMaker.Actions.GetEventSender
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sentByGameObject | GameObject Damager | GameObject Damager | Variable |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "attackType" | "attackType" | FsmInt |  |
| storeValue | int Attack Type | int Attack Type | Variable |  |
| everyFrame | false | false |  |  |

##### 3. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "direction" | "direction" | FsmFloat |  |
| storeValue | float Attack Direction | float Attack Direction | Variable |  |
| everyFrame | false | false |  |  |

##### 4. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Attack Type | int Attack Type | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Strike Nail R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Strike Nail R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Strike Effect | GameObject Strike Effect | Variable |  |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Strike Effect | OwnerDefault Strike Effect |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1.5f | 1.5f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Initiate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Particle_rocks_large" | "Particle_rocks_large" |  |  |
| storeResult | GameObject Particles Large | GameObject Particles Large | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Particle_rocks_small" | "Particle_rocks_small" |  |  |
| storeResult | GameObject Particles Small | GameObject Particles Small | Variable |  |

##### 3. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Dust Break 1" | "Dust Break 1" |  |  |
| storeResult | GameObject Dust Break 1 | GameObject Dust Break 1 | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Dust Break 2" | "Dust Break 2" |  |  |
| storeResult | GameObject Dust Break 2 | GameObject Dust Break 2 | Variable |  |

##### 6. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "CameraParent" | "CameraParent" | Tag |  |
| store | GameObject Camera | GameObject Camera | Variable |  |

##### 7. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Recoil Speed Neg | float Recoil Speed Neg | Variable |  |
| floatValue | float Recoil Speed | float Recoil Speed |  |  |
| everyFrame | false | false |  |  |

##### 8. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Recoil Speed Neg | float Recoil Speed Neg | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 9. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Start X | float Start X | Variable |  |
| y | float Start Y | float Start Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 10. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | string Mask Name | string Mask Name |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| store | GameObject Mask | GameObject Mask | Variable |  |

##### 11. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | string CamLock Name | string CamLock Name |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| store | GameObject CamLock | GameObject CamLock | Variable |  |

##### 12. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Activated | bool Activated | Variable |  |
| isTrue | Event(ACTIVATE) | Event(ACTIVATE) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Check Direction

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.85f | 0.85f |  |  |
| max | 1.1f | 1.1f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 2. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| pitch | float Chooser | float Chooser |  |  |
| everyFrame | false | false |  |  |

##### 3. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 0.85f | 0.85f |  |  |
| pitchMax | 1.15f | 1.15f |  |  |

##### 4. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Facing | int Facing | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Break

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dust Break 1 | OwnerDefault Dust Break 1 |  |  |
| emit | 0 | 0 |  |  |

##### 2. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dust Break 2 | OwnerDefault Dust Break 2 |  |  |
| emit | 0 | 0 |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [breakable_wall_death (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [breakable_wall_death (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [secret_discovered_temp (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [secret_discovered_temp (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 5. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| active | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Particle Rock Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Particle Rock Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 25 | 25 |  |  |
| spawnMax | 25 | 25 |  |  |
| speedMin | 5f | 5f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 20f | 20f |  |  |
| angleMax | 160f | 160f |  |  |
| originVariation | 1.5f | 1.5f |  |  |

##### 8. SpawnFromPool

Full Name: HutongGames.PlayMaker.Actions.SpawnFromPool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| pool | GameObject Pool S | GameObject Pool S |  |  |
| adjustPosition | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 30 | 30 |  |  |
| spawnMax | 30 | 30 |  |  |
| speedMin | 5f | 5f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 20f | 20f |  |  |
| angleMax | 160f | 160f |  |  |

##### 9. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Particle Rock Large (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Particle Rock Large (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 10 | 10 |  |  |
| spawnMax | 10 | 10 |  |  |
| speedMin | 5f | 5f |  |  |
| speedMax | 5f | 5f |  |  |
| angleMin | 20f | 20f |  |  |
| angleMax | 160f | 160f |  |  |
| originVariation | 1f | 1f |  |  |

##### 10. SpawnFromPool

Full Name: HutongGames.PlayMaker.Actions.SpawnFromPool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| pool | GameObject Pool L | GameObject Pool L |  |  |
| adjustPosition | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 25 | 25 |  |  |
| spawnMax | 25 | 25 |  |  |
| speedMin | 5f | 5f |  |  |
| speedMax | 15f | 15f |  |  |
| angleMin | 20f | 20f |  |  |
| angleMax | 160f | 160f |  |  |

##### 11. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Crumble" | "Crumble" |  |  |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mask | EventTarget(GameObject):Mask |  |  |
| sendEvent | "UNCOVER" | "UNCOVER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Dust Break Wall (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets31.assets)] | [Global] [Dust Break Wall (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets31.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(-72.5, -180, -180) | Vector3(-72.5, -180, -180) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 14. SetProperty

Full Name: HutongGames.PlayMaker.Actions.SetProperty
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| targetProperty | Property {[]}. | Property {[]}. |  |  |
| everyFrame | false | false |  |  |

##### 15. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particles Large | OwnerDefault Particles Large |  |  |
| emit | 0 | 0 |  |  |

##### 16. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Hit Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Particle Rock Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Particle Rock Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(1.12, 0, 0) | Vector3(1.12, 0, 0) |  |  |
| spawnMin | 3 | 3 |  |  |
| spawnMax | 5 | 5 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 40f | 40f |  |  |
| angleMax | 80f | 80f |  |  |
| originVariation | 0f | 0f |  |  |

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 3. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 340f | 340f |  |  |
| max | 380f | 380f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 4. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault  | OwnerDefault  |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Chooser | float Chooser |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault  | OwnerDefault  |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -1.5f | -1.5f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. SpawnFromPool

Full Name: HutongGames.PlayMaker.Actions.SpawnFromPool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| pool | GameObject Pool S | GameObject Pool S |  |  |
| adjustPosition | Vector3(1.12, 0, 0) | Vector3(1.12, 0, 0) |  |  |
| spawnMin | 8 | 8 |  |  |
| spawnMax | 10 | 10 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 40f | 40f |  |  |
| angleMax | 80f | 80f |  |  |

##### 7. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Dust Hit Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Dust Hit Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(-1, 0, 0) | Vector3(-1, 0, 0) |  |  |
| rotation | Vector3(0, 90, 270) | Vector3(0, 90, 270) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 8. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Hits | int Hits |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Hits | int Hits | Variable |  |
| everyFrame | false | false |  |  |

##### 9. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Hits | int Hits |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(HIT) | Event(HIT) |  |  |
| lessThan | Event(HIT) | Event(HIT) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 10. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Recoil Speed Neg | float Recoil Speed Neg |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 11. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 12. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particles Small | OwnerDefault Particles Small |  |  |
| emit | 5 | 5 |  |  |

### Return Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Recoil Speed | float Recoil Speed |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Hit Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Particle Rock Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Particle Rock Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(-1.12, 0, 0) | Vector3(-1.12, 0, 0) |  |  |
| spawnMin | 3 | 3 |  |  |
| spawnMax | 5 | 5 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 100f | 100f |  |  |
| angleMax | 140f | 140f |  |  |
| originVariation | 0f | 0f |  |  |

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | [Global] GameObject Hit Effect | [Global] GameObject Hit Effect | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 3. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 340f | 340f |  |  |
| max | 380f | 380f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 4. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault  | OwnerDefault  |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Chooser | float Chooser |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault  | OwnerDefault  |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1.5f | 1.5f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. SpawnFromPool

Full Name: HutongGames.PlayMaker.Actions.SpawnFromPool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| pool | GameObject Pool S | GameObject Pool S |  |  |
| adjustPosition | Vector3(-1.12, 0, 0) | Vector3(-1.12, 0, 0) |  |  |
| spawnMin | 8 | 8 |  |  |
| spawnMax | 10 | 10 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 100f | 100f |  |  |
| angleMax | 140f | 140f |  |  |

##### 7. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Dust Hit Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Dust Hit Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(-1, 0, 0) | Vector3(-1, 0, 0) |  |  |
| rotation | Vector3(180, 90, 270) | Vector3(180, 90, 270) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 8. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Hits | int Hits |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Hits | int Hits | Variable |  |
| everyFrame | false | false |  |  |

##### 9. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Hits | int Hits |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(HIT) | Event(HIT) |  |  |
| lessThan | Event(HIT) | Event(HIT) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 10. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Recoil Speed | float Recoil Speed |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 11. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 12. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particles Small | OwnerDefault Particles Small |  |  |
| emit | 5 | 5 |  |  |

### Return Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Recoil Speed Neg | float Recoil Speed Neg |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Hit Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Particle Rock Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Particle Rock Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 3 | 3 |  |  |
| spawnMax | 5 | 5 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 70f | 70f |  |  |
| angleMax | 110f | 110f |  |  |
| originVariation | 0f | 0f |  |  |

##### 2. SpawnFromPool

Full Name: HutongGames.PlayMaker.Actions.SpawnFromPool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| pool | GameObject Pool S | GameObject Pool S |  |  |
| adjustPosition | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 8 | 8 |  |  |
| spawnMax | 10 | 10 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 70f | 70f |  |  |
| angleMax | 110f | 110f |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | float Recoil Speed Neg | float Recoil Speed Neg |  |  |
| everyFrame | true | true |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Dust Hit Med Down (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] | [Global] [Dust Hit Med Down (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(-72.5, -180, -180) | Vector3(-72.5, -180, -180) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 6. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particles Small | OwnerDefault Particles Small |  |  |
| emit | 5 | 5 |  |  |

### Return Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | float Recoil Speed Neg | float Recoil Speed Neg |  |  |
| everyFrame | true | true |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Hit Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Particle Rock Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Particle Rock Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 3 | 3 |  |  |
| spawnMax | 5 | 5 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 70f | 70f |  |  |
| angleMax | 110f | 110f |  |  |
| originVariation | 0f | 0f |  |  |

##### 2. SpawnFromPool

Full Name: HutongGames.PlayMaker.Actions.SpawnFromPool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| pool | GameObject Pool S | GameObject Pool S |  |  |
| adjustPosition | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 8 | 8 |  |  |
| spawnMax | 10 | 10 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 70f | 70f |  |  |
| angleMax | 110f | 110f |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.2f | 0.2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Dust Hit Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Dust Hit Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(270, 90, 270) | Vector3(270, 90, 270) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 5. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Particles Small | OwnerDefault Particles Small |  |  |
| emit | 5 | 5 |  |  |

### Pause Frame

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Damage

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Hits | int Hits |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Hits | int Hits | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Hits | int Hits |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(HIT) | Event(HIT) |  |  |
| lessThan | Event(HIT) | Event(HIT) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Activated | bool Activated | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject CamLock | GameObject CamLock |  |  |
| delay | 0f | 0f |  |  |
| detachChildren | false | false |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
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

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Activated

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 3. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject CamLock | GameObject CamLock |  |  |
| delay | 0f | 0f |  |  |
| detachChildren | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mask | EventTarget(GameObject):Mask |  |  |
| sendEvent | "UNCOVER" | "UNCOVER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Spell Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Fireball Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Fireball Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | [Global] Vector3 Effect Origin | [Global] Vector3 Effect Origin |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | [Global] GameObject Hit Effect | [Global] GameObject Hit Effect | Variable |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | TAKE DAMAGE | Check If Nail | 0 | 0 | 0 |
| Idle | SPELL | Spell Destroy | 0 | 0 | 0 |
| Check If Nail | TRUE | Hit | 0 | 0 | 0 |
| Check If Nail | FINISHED | Idle | 0 | 0 | 0 |
| Check If Nail | SPELL | Spell Destroy | 0 | 0 | 0 |
| Hit | FINISHED | Check Direction | 0 | 0 | 0 |
| Initiate | FINISHED | Idle | 0 | 0 | 0 |
| Initiate | ACTIVATE | Activated | 0 | 0 | 0 |
| Check Direction | RIGHT | Hit Right | 0 | 0 | 0 |
| Check Direction | UP | Hit Up | 0 | 0 | 0 |
| Check Direction | LEFT | Hit Left | 0 | 0 | 0 |
| Check Direction | DOWN | Hit Down | 0 | 0 | 0 |
| Break | FINISHED | Destroy | 0 | 0 | 0 |
| Hit Right | FINISHED | Return Right | 0 | 0 | 0 |
| Hit Right | HIT | Pause Frame | 0 | 0 | 0 |
| Return Right | FINISHED | Idle | 0 | 0 | 0 |
| Hit Left | FINISHED | Return Left | 0 | 0 | 0 |
| Hit Left | HIT | Pause Frame | 0 | 0 | 0 |
| Return Left | FINISHED | Idle | 0 | 0 | 0 |
| Hit Down | FINISHED | Return Down | 0 | 0 | 0 |
| Return Down | FINISHED | Idle | 0 | 0 | 0 |
| Hit Up | FINISHED | Idle | 0 | 0 | 0 |
| Pause Frame | FINISHED | Break | 0 | 0 | 0 |
| Damage | FINISHED | Idle | 0 | 0 | 0 |
| Pause | FINISHED | Initiate | 0 | 0 | 0 |
| Spell Destroy | FINISHED | Break | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ACTIVATE | false |
| DOWN | false |
| HIT | true |
| LEFT | false |
| RIGHT | false |
| SPELL | false |
| TAKE DAMAGE | false |
| TRUE | false |
| UP | false |
| WAIT | true |

