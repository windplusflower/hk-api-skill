# Nail Splashes

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Nail Splashes |
| GameObject Name | NailSlash Effects |
| GameObject Path | Spa Region/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level62 |
| Start State | Detect |
| FSM PathId | 1427 |
| GameObject PathId | 88 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Direction | 0 | Single: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Damager | [null] | NamedAssetPPtr: [null] |
| Effect | [null] | NamedAssetPPtr: [null] |

## States

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ReceivedDamage

Full Name: HutongGames.PlayMaker.Actions.ReceivedDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collideTag |   | "Nail Attack" | Tag |   |
| sendEvent |   | Event(NAIL HIT) |   |   |
| fsmName |   | "damages_enemy" |   |   |
| storeGameObject |   | GameObject Damager | Variable |   |
| ignoreAcid |   | false |   |   |
| ignoreWater |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NAIL HIT | Check Direction | 0 | |

### Check Direction

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "SPLASH WATER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "direction" | FsmFloat |   |
| storeValue |   | float Direction | Variable |   |
| everyFrame |   | false |   |   |

##### 3. FloatSwitch

Full Name: HutongGames.PlayMaker.Actions.FloatSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Direction | Variable |   |
| lessThan |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UP | Slash Up | 0 | |
| DOWN | Pause | 0 | |
| LEFT | Slash Left | 0 | |
| RIGHT | Slash Right | 0 | |
| FINISHED | Pause | 0 | |

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
| time |   | 0.15f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect | 0 | |

### Slash Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Spatter White R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(-2, -0.5, -0.01) |   |   |
| spawnMin |   | 6 |   |   |
| spawnMax |   | 8 |   |   |
| speedMin |   | 10f |   |   |
| speedMax |   | 20f |   |   |
| angleMin |   | 120f |   |   |
| angleMax |   | 150f |   |   |
| originVariationX |   | 0.75f |   |   |
| originVariationY |   | 0f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Spatter White R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(0.5, -0.25, -0.01) |   |   |
| spawnMin |   | 2 |   |   |
| spawnMax |   | 6 |   |   |
| speedMin |   | 9f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 20f |   |   |
| angleMax |   | 55f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 3. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 0.8f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 4. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Water Cut (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(-3.3, -0.25, -0.01) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Effect | Variable |   |

##### 5. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Effect |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | -1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |

### Slash Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Spatter White R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(2, -0.25, -0.01) |   |   |
| spawnMin |   | 6 |   |   |
| spawnMax |   | 8 |   |   |
| speedMin |   | 10f |   |   |
| speedMax |   | 20f |   |   |
| angleMin |   | 30f |   |   |
| angleMax |   | 60f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Spatter White R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(-0.5, -0.5, -0.01) |   |   |
| spawnMin |   | 2 |   |   |
| spawnMax |   | 6 |   |   |
| speedMin |   | 9f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 125f |   |   |
| angleMax |   | 160f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Water Cut (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(3.3, -0.25, -0.01) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Effect | Variable |   |

##### 4. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 0.8f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 5. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Effect |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |

### Slash Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Spatter White R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(0, -0.5, -0.01) |   |   |
| spawnMin |   | 18 |   |   |
| spawnMax |   | 20 |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 25f |   |   |
| angleMin |   | 85f |   |   |
| angleMax |   | 95f |   |   |
| originVariationX |   | 0.75f |   |   |
| originVariationY |   | 0f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 2. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 0.8f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Splash Out Small (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(0, -1, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DOWN | false |
| FINISHED | false |
| LEFT | false |
| NAIL HIT | false |
| RIGHT | false |
| UP | false |

