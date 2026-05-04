# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Door Destroyer |
| GameObject Path | _Props/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level7 |
| Start State | Pause Frame |
| FSM PathId | 4065 |
| GameObject PathId | 1057 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activated | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Camera | [null] | NamedAssetPPtr: [null] |
| Pt Rock | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| isTrue |   | Event(ACTIVATED) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [break_wall_after_tutorial_area (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [breakable_wall_death (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| finishedEvent |   | Event() |   |   |

##### 4. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 5. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Dust DoorDestroy1 (Hollow Knight/hollow_knight_Data\sharedassets7.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(3.1, -4.88, -0.1) |   |   |
| rotation |   | Vector3(0.9, 0.16, -180) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 6. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Dust DoorDestroy2 (Hollow Knight/hollow_knight_Data\sharedassets7.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(-0.61, 0.45, -0.1) |   |   |
| rotation |   | Vector3(0.9, -270, -180) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "AverageShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 8. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [break_door_large_piece_01 (Hollow Knight/hollow_knight_Data\sharedassets7.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 20f |   |   |
| speedMax |   | 40f |   |   |
| angleMin |   | 45f |   |   |
| angleMax |   | 55f |   |   |
| originVariationX |   | 1f |   |   |
| originVariationY |   | 3f |   |   |

##### 9. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [break_door_large_piece_02 (Hollow Knight/hollow_knight_Data\sharedassets7.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 20f |   |   |
| speedMax |   | 40f |   |   |
| angleMin |   | 45f |   |   |
| angleMax |   | 55f |   |   |
| originVariationX |   | 3f |   |   |
| originVariationY |   | 3f |   |   |

##### 10. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [break_door_large_piece_04 (Hollow Knight/hollow_knight_Data\sharedassets7.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 20f |   |   |
| speedMax |   | 30f |   |   |
| angleMin |   | 45f |   |   |
| angleMax |   | 55f |   |   |
| originVariationX |   | 3f |   |   |
| originVariationY |   | 3f |   |   |

##### 11. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [break_door_large_piece_05 (Hollow Knight/hollow_knight_Data\sharedassets7.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 20f |   |   |
| speedMax |   | 30f |   |   |
| angleMin |   | 45f |   |   |
| angleMax |   | 55f |   |   |
| originVariationX |   | 3f |   |   |
| originVariationY |   | 3f |   |   |

##### 12. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [break_door_large_piece_06 (Hollow Knight/hollow_knight_Data\sharedassets7.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 20f |   |   |
| speedMax |   | 40f |   |   |
| angleMin |   | 45f |   |   |
| angleMax |   | 55f |   |   |
| originVariationX |   | 1f |   |   |
| originVariationY |   | 3f |   |   |

##### 13. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [break_door_large_piece_07 (Hollow Knight/hollow_knight_Data\sharedassets7.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 20f |   |   |
| speedMax |   | 40f |   |   |
| angleMin |   | 45f |   |   |
| angleMax |   | 55f |   |   |
| originVariationX |   | 3f |   |   |
| originVariationY |   | 3f |   |   |

##### 14. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Small (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 40 |   |   |
| spawnMax |   | 40 |   |   |
| speedMin |   | 15f |   |   |
| speedMax |   | 40f |   |   |
| angleMin |   | 45f |   |   |
| angleMax |   | 55f |   |   |
| originVariationX |   | 1f |   |   |
| originVariationY |   | 3f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 15. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Large (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 20 |   |   |
| spawnMax |   | 20 |   |   |
| speedMin |   | 15f |   |   |
| speedMax |   | 40f |   |   |
| angleMin |   | 45f |   |   |
| angleMax |   | 55f |   |   |
| originVariationX |   | 1f |   |   |
| originVariationY |   | 3f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 16. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 17. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Pt Rock" |   |   |
| storeResult |   | GameObject Pt Rock | Variable |   |

##### 18. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pt Rock |   |   |
| emit |   | 0 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ACTIVATED | Activate | 0 | |

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren |   | false |   |   |

#### Transitions

(none)

### Pause Frame

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

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
| FINISHED | Destroy | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTIVATED | false |
| FINISHED | false |

