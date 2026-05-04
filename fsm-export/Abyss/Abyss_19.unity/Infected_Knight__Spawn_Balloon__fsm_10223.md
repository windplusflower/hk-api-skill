# Spawn Balloon

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spawn Balloon |
| GameObject Name | Infected Knight |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level343 |
| Start State | Inert |
| FSM PathId | 10223 |
| GameObject PathId | 78 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Wait Max | 5 | Single: 5 |
| Wait Min | 4 | Single: 4 |
| X Max | 36.4599991 | Single: 36.4599991 |
| X Min | 17.3600006 | Single: 17.3600006 |
| X Pos | 0 | Single: 0 |
| Y Max | 37.4199982 | Single: 37.4199982 |
| Y Min | 32.1599998 | Single: 32.1599998 |
| Y Pos | 0 | Single: 0 |
| Z Pos | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Enemy Count | 0 | Int32: 0 |
| HP | 0 | Int32: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spawn Vector | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spawned Enemy | [null] | NamedAssetPPtr: [null] |

## States

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| START SPAWN | Spawn Pause | 0 | |

### Spawn Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | float Wait Min |   |   |
| timeMax |   | float Wait Max |   |   |
| finishEvent |   | SPAWN |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SPAWN | Spawn | 0 | |
| STOP SPAWN | Stop | 0 | |

### Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetTagCount

Full Name: HutongGames.PlayMaker.Actions.GetTagCount
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| tag |   | "Extra Tag" | Tag |   |
| storeResult |   | int Enemy Count | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Enemy Count |   |   |
| integer2 |   | 3 |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | FINISHED |   |   |
| everyFrame |   | false |   |   |

##### 3. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| storeValue |   | int HP | Variable |   |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int HP |   |   |
| integer2 |   | 420 |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | CANCEL |   |   |
| everyFrame |   | false |   |   |

##### 5. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | float X Min |   |   |
| max |   | float X Max |   |   |
| storeResult |   | float X Pos | Variable |   |

##### 6. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | float Y Min |   |   |
| max |   | float Y Max |   |   |
| storeResult |   | float Y Pos | Variable |   |

##### 7. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 0.006001f |   |   |
| max |   | 0.008f |   |   |
| storeResult |   | float Z Pos | Variable |   |

##### 8. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Vector | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float X Pos |   |   |
| y |   | float Y Pos |   |   |
| z |   | float Z Pos |   |   |
| everyFrame |   | false |   |   |

##### 9. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Parasite Balloon Spawner (Hollow Knight/hollow_knight_Data\sharedassets343.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3 Spawn Vector |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Spawned Enemy | Variable |   |

##### 10. EnemyPusherIgnore

Full Name: EnemyPusherIgnore
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner |   |   |
| other |   | GameObject Spawned Enemy |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CANCEL | Spawn Pause | 0 | |
| FINISHED | Spawn Pause | 0 | |
| STOP SPAWN | Stop | 0 | |

### Stop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| START SPAWN | Spawn Pause | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CANCEL | false |
| FINISHED | false |
| SPAWN | true |
| START SPAWN | false |
| STOP SPAWN | false |

