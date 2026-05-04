# break_floor

## Summary

| Field | Value |
| --- | --- |
| FSM Name | break_floor |
| GameObject Name | Break Floor 1 |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level45 |
| Start State | Pause |
| FSM PathId | 1815 |
| GameObject PathId | 131 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Direction | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Type | 0 | Int32: 0 |
| Hits | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activated | false | Boolean: false |
| Set PlayerData | true | Boolean: true |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| PlayerData Name |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Audio Player | [null] | NamedAssetPPtr: [null] |
| Camera | [null] | NamedAssetPPtr: [null] |
| Damager | [null] | NamedAssetPPtr: [null] |
| Dust Hit 1 | [null] | NamedAssetPPtr: [null] |
| Dust Hit 2 | [null] | NamedAssetPPtr: [null] |
| Dust Hit 3 | [null] | NamedAssetPPtr: [null] |
| Dust break 1 | [null] | NamedAssetPPtr: [null] |
| Dust break 2 | [null] | NamedAssetPPtr: [null] |
| Floor 1 | [null] | NamedAssetPPtr: [null] |
| Floor 2 | [null] | NamedAssetPPtr: [null] |
| Large Pool | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |
| Small Pool | [null] | NamedAssetPPtr: [null] |
| Small Pool 2 | [null] | NamedAssetPPtr: [null] |
| Strike Effect | [null] | NamedAssetPPtr: [null] |
| Wood 1 | [null] | NamedAssetPPtr: [null] |
| Wood 2 | [null] | NamedAssetPPtr: [null] |
| mask | [null] | NamedAssetPPtr: [null] |

### Objects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Box Collider | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ReceivedDamage

Full Name: HutongGames.PlayMaker.Actions.ReceivedDamage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collideTag |   | "" | Tag |   |
| sendEvent |   | Event(HIT) |   |   |
| fsmName |   | "damages_enemy" |   |   |
| storeGameObject |   | GameObject Damager | Variable |   |
| ignoreAcid |   | false |   |   |
| ignoreWater |   | false |   |   |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "Nail Attack" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(HIT) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIT | Hit | 0 | |

### Check If Nail

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "attackType" | FsmInt |   |
| storeValue |   | int Attack Type | Variable |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "direction" | FsmFloat |   |
| storeValue |   | float Attack Direction | Variable |   |
| everyFrame |   | false |   |   |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Attack Direction |   |   |
| float2 |   | 270f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event(FINISHED) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 4. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Attack Type | Variable |   |
| compareTo |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TRUE | Hit | 0 | |
| FINISHED | Idle | 0 | |

### Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Hits | Variable |   |
| compareTo |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIT 1 | Hit 1 | 0 | |
| HIT 2 | Hit 2 | 0 | |
| HIT 3 | Break | 0 | |

### Initiate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName |   | "" |   |   |
| withTag |   | "CameraParent" | Tag |   |
| store |   | GameObject Camera | Variable |   |

##### 2. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "msk_generic" |   |   |
| storeResult |   | GameObject mask | Variable |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dust Break 1" |   |   |
| storeResult |   | GameObject Dust break 1 | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dust Break 2" |   |   |
| storeResult |   | GameObject Dust break 2 | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "wood small" |   |   |
| storeResult |   | GameObject Wood 1 | Variable |   |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "wood large" |   |   |
| storeResult |   | GameObject Wood 2 | Variable |   |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "floor 1" |   |   |
| storeResult |   | GameObject Floor 1 | Variable |   |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "floor 2" |   |   |
| storeResult |   | GameObject Floor 2 | Variable |   |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dust Hit 1" |   |   |
| storeResult |   | GameObject Dust Hit 1 | Variable |   |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dust Hit 2" |   |   |
| storeResult |   | GameObject Dust Hit 2 | Variable |   |

##### 12. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dust Hit 3" |   |   |
| storeResult |   | GameObject Dust Hit 3 | Variable |   |

##### 13. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Small Pool" |   |   |
| storeResult |   | GameObject Small Pool | Variable |   |

##### 14. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Small Pool 2" |   |   |
| storeResult |   | GameObject Small Pool 2 | Variable |   |

##### 15. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Large Pool" |   |   |
| storeResult |   | GameObject Large Pool | Variable |   |

##### 16. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| isTrue |   | Event(ACTIVATE) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 17. CreatePoolObjects

Full Name: HutongGames.PlayMaker.Actions.CreatePoolObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Small Transient Pool (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| pool |   | GameObject Small Pool |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| amount |   | 30 |   |   |
| originVariationX |   | 2.2f |   |   |
| originVariationY |   | 1f |   |   |
| deactivate |   | false |   |   |

##### 18. CreatePoolObjects

Full Name: HutongGames.PlayMaker.Actions.CreatePoolObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Small Pool (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| pool |   | GameObject Small Pool 2 |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| amount |   | 20 |   |   |
| originVariationX |   | 2.2f |   |   |
| originVariationY |   | 1f |   |   |
| deactivate |   | false |   |   |

##### 19. CreatePoolObjects

Full Name: HutongGames.PlayMaker.Actions.CreatePoolObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Large Pool (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| pool |   | GameObject Large Pool |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| amount |   | 15 |   |   |
| originVariationX |   | 2.2f |   |   |
| originVariationY |   | 1f |   |   |
| deactivate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |
| ACTIVATE | Activated | 0 | |

### Break

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust break 1 |   |   |
| emit |   | 0 |   |   |

##### 2. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust break 2 |   |   |
| emit |   | 0 |   |   |

##### 3. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust break 1 |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 4. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust break 2 |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 5. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "crossroadsMawlekWall" |   |   |
| value |   | true |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):mask |   |   |
| sendEvent |   | "HIT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault mask |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 8. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 9. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust Hit 3 |   |   |
| emit |   | 0 |   |   |

##### 10. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust Hit 3 |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 11. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [barrel_death_1 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 0.85f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 12. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Piece Wood 3 (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0.2, -2, 0) |   |   |
| spawnMin |   | 10 |   |   |
| spawnMax |   | 12 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 360f |   |   |
| originVariation |   | 1f |   |   |

##### 13. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Piece Wood 2 (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0.2, -2, 0) |   |   |
| spawnMin |   | 4 |   |   |
| spawnMax |   | 4 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 360f |   |   |
| originVariation |   | 1f |   |   |

##### 14. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Piece Wood 1 (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0.2, -2, 0) |   |   |
| spawnMin |   | 2 |   |   |
| spawnMax |   | 2 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 360f |   |   |
| originVariation |   | 1f |   |   |

##### 15. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [breakable_wall_death (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 16. SetProperty

Full Name: HutongGames.PlayMaker.Actions.SetProperty
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| targetProperty |   | Property {object Box Collider}.enabled |   |   |
| everyFrame |   | false |   |   |

##### 17. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "AverageShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 18. SpawnFromPool

Full Name: HutongGames.PlayMaker.Actions.SpawnFromPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| pool |   | GameObject Large Pool |   |   |
| adjustPosition |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 15 |   |   |
| spawnMax |   | 15 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 6f |   |   |
| angleMin |   | 80f |   |   |
| angleMax |   | 100f |   |   |

##### 19. SpawnFromPool

Full Name: HutongGames.PlayMaker.Actions.SpawnFromPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| pool |   | GameObject Small Pool 2 |   |   |
| adjustPosition |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 20 |   |   |
| spawnMax |   | 20 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 6f |   |   |
| angleMin |   | 80f |   |   |
| angleMax |   | 100f |   |   |

##### 20. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Small (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0.2, 0, 0) |   |   |
| spawnMin |   | 15 |   |   |
| spawnMax |   | 15 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 20f |   |   |
| angleMin |   | 20f |   |   |
| angleMax |   | 160f |   |   |
| originVariation |   | 1.5f |   |   |

##### 21. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Large (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0.2, 0, 0) |   |   |
| spawnMin |   | 8 |   |   |
| spawnMax |   | 8 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 5f |   |   |
| angleMin |   | 20f |   |   |
| angleMax |   | 160f |   |   |
| originVariation |   | 1f |   |   |

##### 22. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Dust Break Wall (Hollow Knight/hollow_knight_Data\sharedassets31.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(-72.5, -180, -180) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 23. DestroyAllChildren

Full Name: HutongGames.PlayMaker.Actions.DestroyAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| disable |   | false |   |   |

#### Transitions

(none)

### Break Wood

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 1 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | -0.1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 2. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 2 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | -0.2f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 3. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 1 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | -5f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 2 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | 7f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Audio Player | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 6. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Audio Player |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [barrel_death_1 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| finishedEvent |   | Event() |   |   |

##### 7. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName |   | "tk2dCamera" |   |   |
| withTag |   | "Untagged" | Tag |   |
| store |   | GameObject Camera | Variable |   |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 9. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Piece Wood 3 (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0.2, -2, 0) |   |   |
| spawnMin |   | 10 |   |   |
| spawnMax |   | 12 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 360f |   |   |
| originVariation |   | 1f |   |   |

##### 10. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Piece Wood 2 (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0.2, -2, 0) |   |   |
| spawnMin |   | 4 |   |   |
| spawnMax |   | 4 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 360f |   |   |
| originVariation |   | 1f |   |   |

##### 11. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Piece Wood 1 (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0.2, -2, 0) |   |   |
| spawnMin |   | 2 |   |   |
| spawnMax |   | 2 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 360f |   |   |
| originVariation |   | 1f |   |   |

##### 12. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Dust Hit Med Down (Hollow Knight/hollow_knight_Data\sharedassets39.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -2, 0) |   |   |
| rotation |   | Vector3(-72.5, -180, -180) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 13. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Wood 1 |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 14. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Wood 2 |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 15. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.4f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Break | 0 | |

### Hit 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Hits | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Strike Nail R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -2, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Strike Effect | Variable |   |

##### 3. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Strike Nail (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -2, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Strike Effect | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 1 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -0.05f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 2 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -0.1f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 6. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 1 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | -2.5f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 7. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 2 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | 3.5f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 8. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [barrel_death_1 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 9. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Audio Player | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 10. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Audio Player |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [barrel_death_1 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| finishedEvent |   | Event() |   |   |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 12. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Piece Wood 3 (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0.2, -2, 0) |   |   |
| spawnMin |   | 10 |   |   |
| spawnMax |   | 12 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 360f |   |   |
| originVariation |   | 1f |   |   |

##### 13. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust Hit 1 |   |   |
| emit |   | 0 |   |   |

##### 14. SpawnFromPool

Full Name: HutongGames.PlayMaker.Actions.SpawnFromPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| pool |   | GameObject Small Pool |   |   |
| adjustPosition |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 6 |   |   |
| spawnMax |   | 7 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 6f |   |   |
| angleMin |   | 80f |   |   |
| angleMax |   | 100f |   |   |

##### 15. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.25f |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Hit 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Hits | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Strike Nail R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -2, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Strike Effect | Variable |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 1 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -0.1f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 2 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -0.2f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 1 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | -2.5f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 6. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 2 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | 2.5f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 7. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [barrel_death_1 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 0.85f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor 2 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | -0.15f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 10. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Piece Wood 3 (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0.2, -2, 0) |   |   |
| spawnMin |   | 10 |   |   |
| spawnMax |   | 12 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 360f |   |   |
| originVariation |   | 1f |   |   |

##### 11. SpawnFromPool

Full Name: HutongGames.PlayMaker.Actions.SpawnFromPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| pool |   | GameObject Small Pool |   |   |
| adjustPosition |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 6 |   |   |
| spawnMax |   | 7 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 6f |   |   |
| angleMin |   | 80f |   |   |
| angleMax |   | 100f |   |   |

##### 12. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust Hit 2 |   |   |
| emit |   | 0 |   |   |

##### 13. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.25f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

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
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Initiate | 0 | |

### Activated

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroyAllChildren

Full Name: HutongGames.PlayMaker.Actions.DestroyAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| disable |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTIVATE | false |
| FINISHED | false |
| HIT | true |
| HIT 1 | false |
| HIT 2 | false |
| HIT 3 | false |
| TRUE | false |

