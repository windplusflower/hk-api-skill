# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Radiant Nail Comb (1) |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level407 |
| Start State | Init |
| FSM PathId | 2617 |
| GameObject PathId | 334 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Increment | 2 | Single: 2 |
| Nail Speed | 13 | Single: 13 |
| Rotation | 0 | Single: 0 |
| Self X | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spawn Sets | 0 | Int32: 0 |
| Type | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Radiant | false | Boolean: false |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spawn Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Nail | [null] | NamedAssetPPtr: [null] |
| Nails | Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407) | NamedAssetPPtr: [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |
| Self | Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407) | NamedAssetPPtr: [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nails |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Increment | Variable |   |
| floatValue |   | 2f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) |   |   |
| everyFrame |   | false |   |   |

##### 4. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| quaternion |   | Quaternion(0, 0, 0, 0) | Variable |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 5. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Type | 0 | |

### Spawn Centre

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 3. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 4. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Spawn Sets | Variable |   |
| intValue |   | 4 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn R | 0 | |

### Spawn R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Spawn Sets |   |   |
| integer2 |   | 0 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   | NEXT |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | false |   |   |

##### 2. SendRandomEvent

Full Name: HutongGames.PlayMaker.Actions.SendRandomEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| delay |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| GAP 1 | RG1 | 0 | |
| GAP 2 | RG2 | 0 | |
| GAP 3 | RG3 | 0 | |
| NEXT | Ready L | 0 | |

### RG1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 3. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 4. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 6. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 7. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Spawn Sets | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

##### 8. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn R | 0 | |

### RG2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 3. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 4. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 6. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 7. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Spawn Sets | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

##### 8. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn R | 0 | |

### RG3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 3. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 4. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 5. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 6. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Spawn Sets | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

##### 7. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 8. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn R | 0 | |

### Ready L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| vector3Value |   | Vector3(-2, 0, 0) |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Increment | Variable |   |
| floatValue |   | -2f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Spawn Sets | Variable |   |
| intValue |   | 4 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn L | 0 | |

### Spawn L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Spawn Sets |   |   |
| integer2 |   | 0 |   |   |
| equal |   | NEXT |   |   |
| lessThan |   | NEXT |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | false |   |   |

##### 2. SendRandomEvent

Full Name: HutongGames.PlayMaker.Actions.SendRandomEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| delay |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| GAP 1 | LG1 | 0 | |
| GAP 2 | LG2 | 0 | |
| GAP 3 | LG3 | 0 | |
| NEXT | Antic | 0 | |

### LG1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 3. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 4. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 6. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 7. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Spawn Sets | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

##### 8. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn L | 0 | |

### LG2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 3. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 4. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 6. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 7. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Spawn Sets | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

##### 8. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn L | 0 | |

### LG3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 3. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 4. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Radiant Nail (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| position |   | Vector3 Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Nail | Variable |   |

##### 5. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nail |   |   |
| parent |   | [Radiant Nail Comb (1)/Nails (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 6. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Spawn Sets | Variable |   |
| add |   | -1 |   |   |
| everyFrame |   | false |   |   |

##### 7. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 8. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Spawn Pos | Variable |   |
| addX |   | float Increment |   |   |
| addY |   | 0f |   |   |
| addZ |   | 0f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn L | 0 | |

### Tween

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Nails |   |   |
| id |   | "" |   |   |
| vector |   | Vector3(0, 50, 0) |   |   |
| time |   | 1f |   |   |
| delay |   | 0f |   |   |
| speed |   | float Nail Speed |   |   |
| easeType | iTween/EaseType::linear | 21 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| startEvent |   |   |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Reset | 0 | |

### Antic

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
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 2. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| quaternion |   | Quaternion(0, 0, 0, 0) | Variable |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | float Rotation |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor 2D (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Radiant Nail Comb (1) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level407)] |   |   |
| audioClip |   | [radiance_sword_shoot (AudioClip) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets407.assets)] |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 1.15f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Tween | 0 | |

### Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:Nails |   |   |
| sendEvent |   | "RECYCLE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Recycle | 0 | |

### Recycle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

#### Transitions

(none)

### Type

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 8

#### Actions

##### 1. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Type | Variable |   |
| compareTo |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TL | TL | 0 | |
| TR | TR | 0 | |
| TOP | Top | 0 | |
| L | L | 0 | |
| R | R | 0 | |
| TOP2 | Top 2 | 0 | |
| L2 | L 2 | 0 | |
| R2 | R 2 | 0 | |

### TL

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 46f |   |   |
| y |   | 43f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Rotation | Variable |   |
| floatValue |   | 225f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 14f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn Centre | 0 | |

### TR

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 74f |   |   |
| y |   | 43f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Rotation | Variable |   |
| floatValue |   | 135f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 14f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn Centre | 0 | |

### Top

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 59.7f |   |   |
| max |   | 61.7f |   |   |
| storeResult |   | float Self X | Variable |   |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X |   |   |
| y |   | 33.5f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Rotation | Variable |   |
| floatValue |   | 180f |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 16f |   |   |
| everyFrame |   | false |   |   |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Radiant | Variable |   |
| isTrue |   |   |   |   |
| isFalse |   | FINISHED |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 20f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn Centre | 0 | |

### L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 42.46f |   |   |
| y |   | 26.73f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Rotation | Variable |   |
| floatValue |   | 270f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 13f |   |   |
| everyFrame |   | false |   |   |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Radiant | Variable |   |
| isTrue |   |   |   |   |
| isFalse |   | FINISHED |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 17f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn Centre | 0 | |

### R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 78.46f |   |   |
| y |   | 28.73f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Rotation | Variable |   |
| floatValue |   | 90f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 13f |   |   |
| everyFrame |   | false |   |   |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Radiant | Variable |   |
| isTrue |   |   |   |   |
| isFalse |   | FINISHED |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 17f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn Centre | 0 | |

### Top 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 60.7f |   |   |
| y |   | 58f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Rotation | Variable |   |
| floatValue |   | 180f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 12f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn Centre | 0 | |

### L 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 35.4f |   |   |
| y |   | 36.73f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Rotation | Variable |   |
| floatValue |   | 270f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 10f |   |   |
| everyFrame |   | false |   |   |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Radiant | Variable |   |
| isTrue |   |   |   |   |
| isFalse |   | FINISHED |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 13f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn Centre | 0 | |

### R 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 84.8f |   |   |
| y |   | 38.73f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Rotation | Variable |   |
| floatValue |   | 90f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 10f |   |   |
| everyFrame |   | false |   |   |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Radiant | Variable |   |
| isTrue |   |   |   |   |
| isFalse |   | FINISHED |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Nail Speed | Variable |   |
| floatValue |   | 13f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn Centre | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| GAP 1 | false |
| GAP 2 | false |
| GAP 3 | false |
| L | false |
| L2 | false |
| NEXT | false |
| R | false |
| R2 | false |
| TL | false |
| TOP | false |
| TOP2 | false |
| TR | false |

