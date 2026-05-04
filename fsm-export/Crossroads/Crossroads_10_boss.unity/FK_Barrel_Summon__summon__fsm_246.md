# summon

## Summary

| Field | Value |
| --- | --- |
| FSM Name | summon |
| GameObject Name | FK Barrel Summon |
| GameObject Path | Battle Scene/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level48 |
| Start State | Idle |
| FSM PathId | 246 |
| GameObject PathId | 8 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self Y | 0 | Single: 0 |
| Spawn X | 0 | Single: 0 |
| Summon Max | 44.2700005 | Single: 44.2700005 |
| Summon Min | 13.1800003 | Single: 13.1800003 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spawns | 0 | Int32: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spawn Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SUMMON | Determine Spawns | 0 | |

### Determine Spawns

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomInt

Full Name: HutongGames.PlayMaker.Actions.RandomInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 6 |   |   |
| max |   | 8 |   |   |
| storeResult |   | int Spawns | Variable |   |
| inclusiveMax |   | true |   |   |

##### 2. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0.15f |   |   |
| timeMax |   | 0.25f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check Spawns | 0 | |

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
| min |   | float Summon Min |   |   |
| max |   | float Summon Max |   |   |
| storeResult |   | float Spawn X | Variable |   |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Self Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Spawn X |   |   |
| y |   | float Self Y |   |   |
| z |   | 0.006f |   |   |
| everyFrame |   | false |   |   |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Falling Barrel (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets48.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Falling Barrel (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets48.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

##### 6. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Spawns |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Spawns | Variable |   |
| everyFrame |   | false |   |   |

##### 7. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0.15f |   |   |
| timeMax |   | 0.25f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check Spawns | 0 | |

### Check Spawns

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Spawns |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(ENDED) |   |   |
| lessThan |   | Event(ENDED) |   |   |
| greaterThan |   | Event(SUMMON) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SUMMON | Spawn | 0 | |
| ENDED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ENDED | false |
| FINISHED | false |
| SUMMON | false |

