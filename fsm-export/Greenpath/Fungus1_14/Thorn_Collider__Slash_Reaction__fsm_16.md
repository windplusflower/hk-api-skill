# Slash Reaction

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Slash Reaction |
| GameObject Name | Thorn Collider |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets143.assets |
| Start State | Init |
| FSM PathId | 16 |
| GameObject PathId | 11 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Direction | 0 | Single: 0 |
| Chooser | 0 | Single: 0 |
| Effect Origin X | 0 | Single: 0 |
| Effect Origin Y | 0 | Single: 0 |
| Rotation | 0 | Single: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Effect Origin | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Audio Player | [null] | NamedAssetPPtr:  |
| Hit Effect | [null] | NamedAssetPPtr:  |
| Slash Object | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Detect

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
| sendEvent | Event(SLASH) | Event(SLASH) |  |  |
| storeCollider | GameObject Slash Object | GameObject Slash Object | Variable |  |

### Get Direction

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.7f | 0.7f |  |  |
| max | 1f | 1f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Audio Player | GameObject Audio Player | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 3. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Audio Player | OwnerDefault Audio Player |  |  |
| pitch | float Chooser | float Chooser |  |  |
| everyFrame | false | false |  |  |

##### 4. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Audio Player | OwnerDefault Audio Player |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [enemy_damage (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [enemy_damage (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| finishedEvent | Event() | Event() |  |  |

##### 5. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Slash Object | OwnerDefault Slash Object |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "direction" | "direction" | FsmFloat |  |
| storeValue | float Attack Direction | float Attack Direction | Variable |  |
| everyFrame | false | false |  |  |

##### 6. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Slash Object | OwnerDefault Slash Object |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Effect Origin X | float Effect Origin X | Variable |  |
| y | float Effect Origin Y | float Effect Origin Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 7. FloatSwitch

Full Name: HutongGames.PlayMaker.Actions.FloatSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Attack Direction | float Attack Direction | Variable |  |
| lessThan | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Hit Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Effect Origin X | float Effect Origin X | Variable |  |
| add | -1.62f | -1.62f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 2. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Effect Origin | Vector3 Effect Origin | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Effect Origin X | float Effect Origin X |  |  |
| y | float Effect Origin Y | float Effect Origin Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 3 | 3 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 18f | 18f |  |  |
| angleMin | 30f | 30f |  |  |
| angleMax | 70f | 70f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0.5f | 0.5f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Hit Effect | GameObject Hit Effect | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 5. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 340f | 340f |  |  |
| max | 380f | 380f |  |  |
| storeResult | float Rotation | float Rotation | Variable |  |

##### 6. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Rotation | float Rotation |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -0.85f | -0.85f |  |  |
| y | 0.85f | 0.85f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 8. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Thorn Cut Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets134.assets)] | [Global] [Thorn Cut Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets134.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| rotation | Vector3(0, 90, 0) | Vector3(0, 90, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

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
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Hit Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Effect Origin X | float Effect Origin X | Variable |  |
| add | 1.62f | 1.62f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 2. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Effect Origin | Vector3 Effect Origin | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Effect Origin X | float Effect Origin X |  |  |
| y | float Effect Origin Y | float Effect Origin Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 3 | 3 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 18f | 18f |  |  |
| angleMin | 110f | 110f |  |  |
| angleMax | 150f | 150f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0.5f | 0.5f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Hit Effect | GameObject Hit Effect | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 5. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 340f | 340f |  |  |
| max | 380f | 380f |  |  |
| storeResult | float Rotation | float Rotation | Variable |  |

##### 6. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Rotation | float Rotation |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.85f | 0.85f |  |  |
| y | 0.85f | 0.85f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 8. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Thorn Cut Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets134.assets)] | [Global] [Thorn Cut Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets134.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| rotation | Vector3(0, 270, 180) | Vector3(0, 270, 180) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

### Hit Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Effect Origin Y | float Effect Origin Y | Variable |  |
| add | -1.26f | -1.26f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 2. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Effect Origin | Vector3 Effect Origin | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Effect Origin X | float Effect Origin X |  |  |
| y | float Effect Origin Y | float Effect Origin Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 3 | 3 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 18f | 18f |  |  |
| angleMin | 45f | 45f |  |  |
| angleMax | 115f | 115f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0.5f | 0.5f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Hit Effect | GameObject Hit Effect | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 5. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 340f | 340f |  |  |
| max | 380f | 380f |  |  |
| storeResult | float Rotation | float Rotation | Variable |  |

##### 6. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Rotation | float Rotation | Variable |  |
| add | 90f | 90f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Rotation | float Rotation |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 8. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -0.85f | -0.85f |  |  |
| y | 0.85f | 0.85f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 9. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Thorn Cut Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets134.assets)] | [Global] [Thorn Cut Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets134.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| rotation | Vector3(270, 90, 0) | Vector3(270, 90, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

### Hit Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Effect Origin Y | float Effect Origin Y | Variable |  |
| add | 1.1f | 1.1f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 2. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Effect Origin | Vector3 Effect Origin | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Effect Origin X | float Effect Origin X |  |  |
| y | float Effect Origin Y | float Effect Origin Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 3 | 3 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 18f | 18f |  |  |
| angleMin | 225f | 225f |  |  |
| angleMax | 315f | 315f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0.5f | 0.5f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] | [Global] [Slash Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets39.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Hit Effect | GameObject Hit Effect | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 5. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 340f | 340f |  |  |
| max | 380f | 380f |  |  |
| storeResult | float Rotation | float Rotation | Variable |  |

##### 6. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Rotation | float Rotation | Variable |  |
| add | 270f | 270f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Rotation | float Rotation |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 8. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -0.85f | -0.85f |  |  |
| y | 0.85f | 0.85f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 9. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Thorn Cut Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets134.assets)] | [Global] [Thorn Cut Grass (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets134.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Effect Origin | Vector3 Effect Origin |  |  |
| rotation | Vector3(90, 90, 0) | Vector3(90, 90, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Detect | 0 | 0 | 0 |
| Detect | SLASH | Get Direction | 0 | 0 | 0 |
| Get Direction | RIGHT | Hit Right | 0 | 0 | 0 |
| Get Direction | LEFT | Hit Left | 0 | 0 | 0 |
| Get Direction | DOWN | Hit Down | 0 | 0 | 0 |
| Get Direction | UP | Hit Up | 0 | 0 | 0 |
| Hit Left | FINISHED | Pause | 0 | 0 | 0 |
| Pause | FINISHED | Detect | 0 | 0 | 0 |
| Hit Right | FINISHED | Pause | 0 | 0 | 0 |
| Hit Down | FINISHED | Pause | 0 | 0 | 0 |
| Hit Up | FINISHED | Pause | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| DOWN | false |
| LEFT | false |
| RIGHT | false |
| SLASH | false |
| UP | false |

