# Mage

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Mage |
| GameObject Name | Mage |
| GameObject Path | Battle Scene/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level96 |
| Start State | Init |
| FSM PathId | 1264 |
| GameObject PathId | 321 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Distance From Self | 0 | Single: 0 |
| Final Tele Distance | 0 | Single: 0 |
| Random Z | 0 | Single: 0 |
| Tele Angle | 0 | Single: 0 |
| Tele Distance | 0 | Single: 0 |
| Tele Distance Max | 8 | Single: 8 |
| Tele Distance Min | 5.6500001 | Single: 5.6500001 |
| Tele X | 0 | Single: 0 |
| Tele Y | 0 | Single: 0 |
| Translate X | 0 | Single: 0 |
| Translate Y | 0 | Single: 0 |
| X Max | 0 | Single: 0 |
| X Min | 0 | Single: 0 |
| Y Max | 0 | Single: 0 |
| Y Min | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Balls | 0 | Int32: 0 |
| Count Ball Fire | 0 | Int32: 0 |
| Count Ball Tele | 0 | Int32: 0 |
| Count Summon | 0 | Int32: 0 |
| Count Teleport | 0 | Int32: 0 |
| Tele Attempts | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Can See Hero | false | Boolean: false |
| Far from hero | false | Boolean: false |
| Far from self | false | Boolean: false |
| Firing Range | false | Boolean: false |
| Got Orb | false | Boolean: false |
| Manual Appear | true | Boolean: true |
| Return To Idle | true | Boolean: true |
| Roam Range | false | Boolean: false |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Tele Point 2D | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Fire Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Hero Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Init Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Line Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Self Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Teleport Point | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Appear Flash | [null] | NamedAssetPPtr: [null] |
| Fire Point | Battle Scene/Mage/Fire Effect (Hollow Knight/hollow_knight_Data\level96) | NamedAssetPPtr: [Battle Scene/Mage/Fire Effect (Hollow Knight/hollow_knight_Data\level96)] |
| Firing Range Obj | [null] | NamedAssetPPtr: [null] |
| Hero | [null] | NamedAssetPPtr: [null] |
| Next Orb | [null] | NamedAssetPPtr: [null] |
| Orb 1 | [null] | NamedAssetPPtr: [null] |
| Orb 2 | [null] | NamedAssetPPtr: [null] |
| Orb 3 | [null] | NamedAssetPPtr: [null] |
| Orb Spinner | Battle Scene/Mage/Orb Spinner (Hollow Knight/hollow_knight_Data\level96) | NamedAssetPPtr: [Battle Scene/Mage/Orb Spinner (Hollow Knight/hollow_knight_Data\level96)] |
| Self | [null] | NamedAssetPPtr: [null] |
| Tele Line | [null] | NamedAssetPPtr: [null] |
| Tele Out Anim | Battle Scene/Mage/Tele Out Anim (Hollow Knight/hollow_knight_Data\level96) | NamedAssetPPtr: [Battle Scene/Mage/Tele Out Anim (Hollow Knight/hollow_knight_Data\level96)] |
| Teleplane | [null] | NamedAssetPPtr: [null] |
| White Flash | Battle Scene/Mage/White Flash (Hollow Knight/hollow_knight_Data\level96) | NamedAssetPPtr: [Battle Scene/Mage/White Flash (Hollow Knight/hollow_knight_Data\level96)] |
| Zero Point | Battle Scene/Mage/Zero Point (Hollow Knight/hollow_knight_Data\level96) | NamedAssetPPtr: [Battle Scene/Mage/Zero Point (Hollow Knight/hollow_knight_Data\level96)] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetHero

Full Name: GetHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult |   | GameObject Hero | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Firing Range" |   |   |
| storeResult |   | GameObject Firing Range Obj | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Orb Spinner" |   |   |
| storeResult |   | [Battle Scene/Mage/Orb Spinner (Hollow Knight/hollow_knight_Data\level96)] | Variable |   |

##### 4. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3 Init Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Zero Point |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 7. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Zero Point |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Sleep | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Return To Idle | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. DistanceFlySmooth

Full Name: HutongGames.PlayMaker.Actions.DistanceFlySmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | GameObject Hero | Variable |   |
| distance |   | 7f |   |   |
| speedMax |   | 4.5f |   |   |
| accelerationForce |   | 30f |   |   |
| targetRadius |   | 1f |   |   |
| deceleration |   | 0.9f |   |   |
| offset |   | Vector3(0, 0, 0) |   |   |

##### 3. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | GameObject Hero | Variable |   |
| spriteFacesRight |   | false |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "Turn To Idle" |   |   |
| resetFrame |   | true |   |   |
| everyFrame |   | true |   |   |

##### 4. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 2f |   |   |
| timeMax |   | 3f |   |   |
| finishEvent |   | Event(SUMMON) |   |   |
| realTime |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Orb Spinner |   |   |
| sendEvent |   | "STOP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Roam Range | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(LOST HERO) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SUMMON | Summon Choice | 0 | |
| LOST HERO | Tele Away | 0 | |
| GO UP | Select Target | 0 | |

### Summon Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DistanceFlySmooth

Full Name: HutongGames.PlayMaker.Actions.DistanceFlySmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | GameObject Hero | Variable |   |
| distance |   | 7f |   |   |
| speedMax |   | 3f |   |   |
| accelerationForce |   | 15f |   |   |
| targetRadius |   | 1f |   |   |
| deceleration |   | 0.9f |   |   |
| offset |   | Vector3(0, 0, 0) |   |   |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [mage_summon_projectiles (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Cast" |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Summon 3 | 0 | |

### Summon 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Got Orb | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. DistanceFlySmooth

Full Name: HutongGames.PlayMaker.Actions.DistanceFlySmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | GameObject Hero | Variable |   |
| distance |   | 7f |   |   |
| speedMax |   | 3f |   |   |
| accelerationForce |   | 15f |   |   |
| targetRadius |   | 1f |   |   |
| deceleration |   | 0.9f |   |   |
| offset |   | Vector3(0, 0, 0) |   |   |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Mage Orb (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 2.4, -0.0005) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Orb 3 | Variable |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Orb 3 |   |   |
| sendEvent |   | "ORBIT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Orb 3 |   |   |
| parent |   | [Battle Scene/Mage/Orb Spinner (Hollow Knight/hollow_knight_Data\level96)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Orb Spinner |   |   |
| sendEvent |   | "SPIN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Cast End" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Summoned | 0 | |

### Summoned

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Return To Idle | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. DistanceFlySmooth

Full Name: HutongGames.PlayMaker.Actions.DistanceFlySmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | GameObject Hero | Variable |   |
| distance |   | 9f |   |   |
| speedMax |   | 4.25f |   |   |
| accelerationForce |   | 30f |   |   |
| targetRadius |   | 1f |   |   |
| deceleration |   | 0.9f |   |   |
| offset |   | Vector3(0, 0, 0) |   |   |

##### 3. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | GameObject Hero | Variable |   |
| spriteFacesRight |   | false |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "Turn To Idle" |   |   |
| resetFrame |   | true |   |   |
| everyFrame |   | true |   |   |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

##### 5. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0.7f |   |   |
| timeMax |   | 1f |   |   |
| finishEvent |   | Event(ATTACK) |   |   |
| realTime |   | false |   |   |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Roam Range | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(LOST HERO) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ATTACK | Line of Sight? | 0 | |
| LOST HERO | Tele Away | 0 | |
| GO UP | Select Target | 0 | |

### Attack Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Fire Point |   |   |
| vector |   | Vector3 Fire Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Fire Start" |   |   |

##### 3. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| deceleration |   | 0.9f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fire | 0 | |

### Fire

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Mage Orb (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 1, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Next Orb | Variable |   |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [mage_knight_projectile_shoot (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Fire Point |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetIsKinematic2d

Full Name: HutongGames.PlayMaker.Actions.SetIsKinematic2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Next Orb |   |   |
| isKinematic |   | false |   |   |

##### 5. FireAtTarget

Full Name: HutongGames.PlayMaker.Actions.FireAtTarget
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Next Orb |   |   |
| target |   | GameObject Hero |   |   |
| speed |   | 20f |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spread |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Fire" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Next Orb |   |   |
| sendEvent |   | "FIRE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Summoned | 0 | |

### One Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | GameObject Next Orb | Variable |   |
| gameObject |   | GameObject Orb 3 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Summoned | 0 | |

### Two Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | GameObject Next Orb | Variable |   |
| gameObject |   | GameObject Orb 2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Summoned | 0 | |

### Remaining Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Balls |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Balls | Variable |   |
| everyFrame |   | false |   |   |

##### 2. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Balls | Variable |   |
| compareTo |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NONE LEFT | Idle | 0 | |
| ONE LEFT | One Left | 0 | |
| TWO LEFT | Two Left | 0 | |

### Summon Choice

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Tele Attempts | Variable |   |
| intValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. SendRandomEventV2

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trackingInts |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| eventMax |   | FSMViewAvalonia2.FsmArray2 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SUMMON | Summon Start | 0 | |
| TELEPORT | Select Target | 0 | |

### Select Target

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Tele Attempts | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 2. GetRandomObject

Full Name: HutongGames.PlayMaker.Actions.GetRandomObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| withTag |   | "Teleplane" | Tag |   |
| storeResult |   | GameObject Teleplane | Variable |   |
| everyFrame |   | false |   |   |

##### 3. GetColliderRange

Full Name: HutongGames.PlayMaker.Actions.GetColliderRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Teleplane |   |   |
| minX |   | float X Min | Variable |   |
| maxX |   | float X Max | Variable |   |
| minY |   | float Y Min | Variable |   |
| maxY |   | float Y Max | Variable |   |
| everyFrame |   | false |   |   |

##### 4. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | float X Min |   |   |
| max |   | float X Max |   |   |
| storeResult |   | float Tele X | Variable |   |

##### 5. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | float Y Min |   |   |
| max |   | float Y Max |   |   |
| storeResult |   | float Tele Y | Variable |   |

##### 6. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Teleport Point | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Tele X |   |   |
| y |   | float Tele Y |   |   |
| z |   | 0.006f |   |   |
| everyFrame |   | false |   |   |

##### 7. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable |   | Vector2 Tele Point 2D | Variable |   |
| vector2Value |   | Vector2(0, 0) | Variable |   |
| x |   | float Tele X |   |   |
| y |   | float Tele Y |   |   |
| everyFrame |   | false |   |   |

##### 8. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3 Hero Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 9. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3 Self Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 10. DistanceBetweenPoints

Full Name: HutongGames.PlayMaker.Actions.DistanceBetweenPoints
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| distanceResult |   | float Tele Distance | Variable |   |
| point1 |   | Vector3 Teleport Point |   |   |
| point2 |   | Vector3 Hero Pos |   |   |
| ignoreZ |   | false |   |   |
| everyFrame |   | false |   |   |

##### 11. DistanceBetweenPoints

Full Name: HutongGames.PlayMaker.Actions.DistanceBetweenPoints
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| distanceResult |   | float Distance From Self | Variable |   |
| point1 |   | Vector3 Teleport Point |   |   |
| point2 |   | Vector3 Self Pos |   |   |
| ignoreZ |   | false |   |   |
| everyFrame |   | false |   |   |

##### 12. FloatInRange

Full Name: HutongGames.PlayMaker.Actions.FloatInRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Tele Distance |   |   |
| lowerValue |   | float Tele Distance Min |   |   |
| upperValue |   | float Tele Distance Max |   |   |
| boolVariable |   | bool Far from hero | Variable |   |
| trueEvent |   | Event() |   |   |
| falseEvent |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 13. FloatInRange

Full Name: HutongGames.PlayMaker.Actions.FloatInRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Distance From Self |   |   |
| lowerValue |   | 8f |   |   |
| upperValue |   | 99999f |   |   |
| boolVariable |   | bool Far from self | Variable |   |
| trueEvent |   | Event() |   |   |
| falseEvent |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 14. LineCast2d

Full Name: HutongGames.PlayMaker.Actions.LineCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject |   | OwnerDefault Zero Point |   | Setup |
| fromPosition |   | Vector2 Tele Point 2D |   |   |
| toGameObject |   | GameObject Hero |   |   |
| toPosition |   | Vector2(0, -0.5) |   |   |
| minDepth |   | 0 |   |   |
| maxDepth |   | 0 |   |   |
| hitEvent |   | Event() | Variable | Result |
| storeDidHit |   | bool Can See Hero | Variable |   |
| storeHitObject |   |   | Variable |   |
| storeHitPoint |   | Vector2(0, 0) | Variable |   |
| storeHitNormal |   | Vector2(0, 0) | Variable |   |
| storeHitDistance |   | 0f | Variable |   |
| repeatInterval |   | 1 |   | Filter |
| layerMask |   | FSMViewAvalonia2.FsmArray2 | Layer |   |
| invertMask |   | false |   |   |
| debugColor |   | Color(1, 0.92156863, 0.015686275, 1) |   | Debug |
| debug |   | false |   |   |

##### 15. BoolFlip

Full Name: HutongGames.PlayMaker.Actions.BoolFlip
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can See Hero | Variable |   |

##### 16. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(TELEPORT) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 17. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Tele Attempts |   |   |
| integer2 |   | 50 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(CANCEL) |   |   |
| everyFrame |   | false |   |   |

##### 18. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| sendEvent |   | Event(FINISHED) |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TELEPORT | Teleport | 0 | |
| CANCEL | Idle or Summoned? | 0 | |
| FINISHED | Try Again! | 0 | |

### Teleport

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
| vector |   | Vector3 Teleport Point | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 0.00501f |   |   |
| max |   | 0.00699f |   |   |
| storeResult |   | float Random Z | Variable |   |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | float Random Z |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [mage_appear (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele Out Anim |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 7. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Appear Flash |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 8. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele Out Anim |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 9. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele Out Anim |   |   |
| vector |   | Vector3 Self Pos | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 10. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault White Flash |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 11. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Tele Line | 0 | |

### Try Again!

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Select Target | 0 | |

### Tele Line

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Vector3Lerp

Full Name: HutongGames.PlayMaker.Actions.Vector3Lerp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromVector |   | Vector3 Teleport Point |   |   |
| toVector |   | Vector3 Self Pos |   |   |
| amount |   | 0.5f |   |   |
| storeResult |   | Vector3 Line Pos | Variable |   |
| everyFrame |   | false |   |   |

##### 2. GetAngleBetweenPoints

Full Name: HutongGames.PlayMaker.Actions.GetAngleBetweenPoints
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| point1 |   | Vector3 Teleport Point |   |   |
| point2 |   | Vector3 Self Pos |   |   |
| storeAngle |   | float Tele Angle |   |   |
| everyFrame |   | false |   |   |

##### 3. DistanceBetweenPoints

Full Name: HutongGames.PlayMaker.Actions.DistanceBetweenPoints
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| distanceResult |   | float Final Tele Distance | Variable |   |
| point1 |   | Vector3 Self Pos |   |   |
| point2 |   | Vector3 Teleport Point |   |   |
| ignoreZ |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Tele Line (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3 Line Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Tele Line | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 5. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele Line |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Final Tele Distance |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 6. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele Line |   |   |
| quaternion |   | Quaternion(0, 0, 0, 0) | Variable |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | float Tele Angle |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 7. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele Line |   |   |
| emit |   | 0 |   |   |

##### 8. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Teleport In" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle or Summoned? | 0 | |

### Line of Sight?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Firing Range | Variable |   |
| isTrue |   | Event(IN RANGE) |   |   |
| isFalse |   | Event(OUT OF RANGE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| OUT OF RANGE | Out of Range | 0 | |
| IN RANGE | Fire or Tele? | 0 | |

### Out of Range

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendRandomEvent

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
| TELEPORT | Select Target | 0 | |
| WAIT | Summoned 2 | 0 | |

### Idle After Tele

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Return To Idle | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. DistanceFlySmooth

Full Name: HutongGames.PlayMaker.Actions.DistanceFlySmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | GameObject Hero | Variable |   |
| distance |   | 7f |   |   |
| speedMax |   | 4.5f |   |   |
| accelerationForce |   | 30f |   |   |
| targetRadius |   | 1f |   |   |
| deceleration |   | 0.9f |   |   |
| offset |   | Vector3(0, 0, 0) |   |   |

##### 3. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | GameObject Hero | Variable |   |
| spriteFacesRight |   | false |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "Turn To Idle" |   |   |
| resetFrame |   | true |   |   |
| everyFrame |   | true |   |   |

##### 4. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 1f |   |   |
| timeMax |   | 2f |   |   |
| finishEvent |   | Event(SUMMON) |   |   |
| realTime |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Orb Spinner |   |   |
| sendEvent |   | "STOP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Roam Range | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(LOST HERO) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SUMMON | Summon Choice | 0 | |
| LOST HERO | Tele Away | 0 | |

### Idle or Summoned?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Tele Distance Max | Variable |   |
| floatValue |   | 13f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Tele Attempts | Variable |   |
| intValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Got Orb | Variable |   |
| isTrue |   | Event(SUMMON) |   |   |
| isFalse |   | Event(IDLE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| IDLE | Summon Start | 0 | |
| SUMMON | Summoned | 0 | |

### Fire or Tele?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendRandomEventV2

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trackingInts |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| eventMax |   | FSMViewAvalonia2.FsmArray2 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TELEPORT | Select Target | 0 | |
| ATTACK | Attack Antic | 0 | |

### Sleep

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Manual Appear | Variable |   |
| isTrue |   | Event(MANUAL) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Firing Range | Variable |   |
| isTrue |   | Event(IN RANGE) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| IN RANGE | Wake | 0 | |
| MANUAL | Manual Sleep | 0 | |

### Wake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Firing Range Obj |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 20f |   |   |
| max |   | 30f |   |   |
| storeResult |   | float Translate X | Variable |   |

##### 3. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 20f |   |   |
| max |   | 30f |   |   |
| storeResult |   | float Translate Y | Variable |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Translate X |   |   |
| y |   | float Translate Y |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

##### 6. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

##### 7. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Select Target | 0 | |

### Manual Sleep

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Roam Range | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| WAKE | Wake | 0 | |
| UNMANUAL | Sleep | 0 | |

### Summoned 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Return To Idle | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. DistanceFlySmooth

Full Name: HutongGames.PlayMaker.Actions.DistanceFlySmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | GameObject Hero | Variable |   |
| distance |   | 9f |   |   |
| speedMax |   | 4.25f |   |   |
| accelerationForce |   | 30f |   |   |
| targetRadius |   | 1f |   |   |
| deceleration |   | 0.9f |   |   |
| offset |   | Vector3(0, 0, 0) |   |   |

##### 3. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | GameObject Hero | Variable |   |
| spriteFacesRight |   | false |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "Turn To Idle" |   |   |
| resetFrame |   | true |   |   |
| everyFrame |   | true |   |   |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

##### 5. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0.1f |   |   |
| timeMax |   | 0.5f |   |   |
| finishEvent |   | Event(ATTACK) |   |   |
| realTime |   | false |   |   |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Roam Range | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(LOST HERO) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ATTACK | Line of Sight? | 0 | |
| LOST HERO | Tele Away | 0 | |

### Tele Away

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Return To Idle | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Got Orb | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Balls | Variable |   |
| intValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele Out Anim |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3 Current Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 6. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele Out Anim |   |   |
| vector |   | Vector3 Current Pos | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 7. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Tele Out Anim |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 8. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3 Init Pos | Variable |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 9. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 10. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 11. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 12. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Orb 1 |   |   |
| sendEvent |   | "DESTROY" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Orb 2 |   |   |
| sendEvent |   | "DESTROY" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 15. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Orb 3 |   |   |
| sendEvent |   | "DESTROY" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 16. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Orb 1 |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 17. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Orb 2 |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 18. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Orb 3 |   |   |
| parent |   |   |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Sleep | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ATTACK | false |
| CANCEL | false |
| FINISHED | false |
| GO UP | false |
| IDLE | false |
| IN RANGE | false |
| LOST HERO | false |
| MANUAL | false |
| NONE LEFT | false |
| ONE LEFT | false |
| OUT OF RANGE | false |
| SUMMON | false |
| TELEPORT | false |
| TWO LEFT | false |
| UNMANUAL | false |
| WAIT | true |
| WAKE | true |

