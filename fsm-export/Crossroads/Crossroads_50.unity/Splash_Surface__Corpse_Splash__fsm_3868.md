# Corpse Splash

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Corpse Splash |
| GameObject Name | Splash Surface |
| GameObject Path | Surface Water Region/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level81 |
| Start State | Detect |
| FSM PathId | 3868 |
| GameObject PathId | 124 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Corpse | [null] | NamedAssetPPtr: [null] |

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
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | 26 | Layer |   |
| sendEvent |   | Event(SPLASH) |   |   |
| storeCollider |   | GameObject Corpse | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SPLASH | Splash | 0 | |

### Splash

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
| spawnPoint |   | GameObject Corpse |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 0.8f |   |   |
| pitchMax |   | 1.2f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Splash Out Black (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Corpse |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Spatter Black (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Corpse |   |   |
| position |   | Vector3(0, 1, 0) |   |   |
| spawnMin |   | 12 |   |   |
| spawnMax |   | 16 |   |   |
| speedMin |   | 12f |   |   |
| speedMax |   | 20f |   |   |
| angleMin |   | 70f |   |   |
| angleMax |   | 110f |   |   |
| originVariationX |   | 0.5f |   |   |
| originVariationY |   | 0.5f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SPLASH | false |

