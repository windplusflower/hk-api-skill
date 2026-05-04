# Spawn

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spawn |
| GameObject Name | Scuttler Spawner |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level397 |
| Start State | Init |
| FSM PathId | 2487 |
| GameObject PathId | 565 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Jump | 0 | Single: 0 |
| Pos X | 0 | Single: 0 |
| Pos Y | 27.7000008 | Single: 27.7000008 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Pos Vector | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Scuttler | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SCUTTLER SPAWN START | Spawn | 0 | |

### Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 15.3f |   |   |
| max |   | 36.4f |   |   |
| storeResult |   | float Pos X | Variable |   |

##### 2. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Pos Vector | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Pos X |   |   |
| y |   | float Pos Y |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Orange Scuttler IK (Hollow Knight/hollow_knight_Data\sharedassets343.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3 Pos Vector |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Scuttler | Variable |   |

##### 4. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 2f |   |   |
| max |   | 8f |   |   |
| storeResult |   | float Jump | Variable |   |

##### 5. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Scuttler |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | float Jump |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0.05f |   |   |
| timeMax |   | 0.2f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SCUTTLER SPAWN END | Idle | 0 | |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SCUTTLER SPAWN END | false |
| SCUTTLER SPAWN START | false |

