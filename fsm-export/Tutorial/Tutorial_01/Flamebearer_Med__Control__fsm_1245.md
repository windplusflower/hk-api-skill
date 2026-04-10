# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Flamebearer Med |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets |
| Start State | Init |
| FSM PathId | 1245 |
| GameObject PathId | 531 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle Adjust | 0 | Single: 0 |
| Dash Time | 0 | Single: 0 |
| Flameball Speed | 8 | Single: 8 |
| Hero X | 0 | Single: 0 |
| Hero Y | 0 | Single: 0 |
| Pillar X | 0 | Single: 0 |
| Pillar Y | 0 | Single: 0 |
| Scene Height | 0 | Single: 0 |
| Scene Width | 0 | Single: 0 |
| Self X | 0 | Single: 0 |
| Self Y | 0 | Single: 0 |
| Speed | 40 | Single: 40 |
| X Distance | 0 | Single: 0 |
| X Target | 0 | Single: 0 |
| Y Distance | 0 | Single: 0 |
| Y Target | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Ct Dash | 0 | Int32: 0 |
| Ct Pillar | 0 | Int32: 0 |
| Ct Shoot | 0 | Int32: 0 |
| Ct Spiral | 0 | Int32: 0 |
| Decrement | -1 | Int32: -1 |
| Grimmchild Level | 0 | Int32: 0 |
| Ms Dash | 0 | Int32: 0 |
| Ms Pillar | 0 | Int32: 0 |
| Ms Shoot | 0 | Int32: 0 |
| Ms Spiral | 0 | Int32: 0 |
| Pillars | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Force Left | false | Boolean: false |
| Force Right | false | Boolean: false |
| Ray Did Hit | false | Boolean: false |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Ray Hit Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Follow Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dash Burst | [null] | NamedAssetPPtr:  |
| Explode Effects | [null] | NamedAssetPPtr:  |
| Flame Spawn Point | [null] | NamedAssetPPtr:  |
| Flameball | [null] | NamedAssetPPtr:  |
| Flameball Obj | Flameball Shot (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: Flameball Shot (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Flare In | [null] | NamedAssetPPtr:  |
| Flash | [null] | NamedAssetPPtr:  |
| Follow Target | [null] | NamedAssetPPtr:  |
| Hero Detector | [null] | NamedAssetPPtr:  |
| Idle Pt | [null] | NamedAssetPPtr:  |
| Laugh Loop | [null] | NamedAssetPPtr:  |
| Loop Pillars | [null] | NamedAssetPPtr:  |
| Projectile | [null] | NamedAssetPPtr:  |
| Pt Dash | [null] | NamedAssetPPtr:  |
| Pt Dying | [null] | NamedAssetPPtr:  |
| Pt Orbs | [null] | NamedAssetPPtr:  |
| Pt Smoke | [null] | NamedAssetPPtr:  |
| Pt Spiral Charge | [null] | NamedAssetPPtr:  |
| Pt Spiral Fire | [null] | NamedAssetPPtr:  |
| Pt Start | [null] | NamedAssetPPtr:  |
| Red Flash 1 | [null] | NamedAssetPPtr:  |
| Red Flash 2 | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Slash Pt | [null] | NamedAssetPPtr:  |
| Spiral | [null] | NamedAssetPPtr:  |
| Teleport Effects | Flamebearer Small/Teleport Effects (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: Flamebearer Small/Teleport Effects (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Voice Player | [null] | NamedAssetPPtr:  |

### Objects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Death Clip | Grimmkin_big_death (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: Grimmkin_big_death (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "GetSceneWidth" | "GetSceneWidth" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Scene Width = 0 | Var Scene Width = 0 | Variable | Store Result |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "GetSceneHeight" | "GetSceneHeight" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Scene Height = 0 | Var Scene Height = 0 | Variable | Store Result |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "grimmChildLevel" | "grimmChildLevel" |  |  |
| storeValue | int Grimmchild Level | int Grimmchild Level | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Hero Detector" | "Hero Detector" |  |  |
| storeResult | GameObject Hero Detector | GameObject Hero Detector | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Red Flash 1" | "Red Flash 1" |  |  |
| storeResult | GameObject Red Flash 1 | GameObject Red Flash 1 | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Red Flash 2" | "Red Flash 2" |  |  |
| storeResult | GameObject Red Flash 2 | GameObject Red Flash 2 | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Orbs" | "Pt Orbs" |  |  |
| storeResult | GameObject Pt Orbs | GameObject Pt Orbs | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Smoke" | "Pt Smoke" |  |  |
| storeResult | GameObject Pt Smoke | GameObject Pt Smoke | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Dash" | "Pt Dash" |  |  |
| storeResult | GameObject Pt Dash | GameObject Pt Dash | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Start" | "Pt Start" |  |  |
| storeResult | GameObject Pt Start | GameObject Pt Start | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Flame Spawn Point" | "Flame Spawn Point" |  |  |
| storeResult | GameObject Flame Spawn Point | GameObject Flame Spawn Point | Variable |  |

##### 12. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Follow Target" | "Follow Target" |  |  |
| storeResult | GameObject Follow Target | GameObject Follow Target | Variable |  |

##### 13. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Dying" | "Pt Dying" |  |  |
| storeResult | GameObject Pt Dying | GameObject Pt Dying | Variable |  |

##### 14. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Explode Effects" | "Explode Effects" |  |  |
| storeResult | GameObject Explode Effects | GameObject Explode Effects | Variable |  |

##### 15. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Teleport Effects" | "Teleport Effects" |  |  |
| storeResult | [Flamebearer Small/Teleport Effects (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Flamebearer Small/Teleport Effects (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | Variable |  |

##### 16. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Flash" | "Flash" |  |  |
| storeResult | GameObject Flash | GameObject Flash | Variable |  |

##### 17. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Loop Pillars" | "Loop Pillars" |  |  |
| storeResult | GameObject Loop Pillars | GameObject Loop Pillars | Variable |  |

##### 18. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Loop Laugh" | "Loop Laugh" |  |  |
| storeResult | GameObject Laugh Loop | GameObject Laugh Loop | Variable |  |

##### 19. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Follow Target | OwnerDefault Follow Target |  |  |
| parent |  |  |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 20. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 21. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Spiral Fire" | "Pt Spiral Fire" |  |  |
| storeResult | GameObject Pt Spiral Fire | GameObject Pt Spiral Fire | Variable |  |

##### 22. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Spiral Charge" | "Pt Spiral Charge" |  |  |
| storeResult | GameObject Pt Spiral Charge | GameObject Pt Spiral Charge | Variable |  |

##### 23. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| color | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) | FsmColor |  |
| everyframe | false | false |  |  |

### Set Level

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Grimmchild Level | int Grimmchild Level | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Alert Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.5f | 1.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Follow

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "IN" | "IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Smoke | OwnerDefault Pt Smoke |  |  |
| emission | true | true |  |  |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | float Hero Y | float Hero Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 5. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | float X Distance | float X Distance |  |  |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Add | 0 |  |  |
| storeResult | float X Target | float X Target | Variable |  |
| everyFrame | true | true |  |  |

##### 6. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero Y | float Hero Y |  |  |
| float2 | float Y Distance | float Y Distance |  |  |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Add | 0 |  |  |
| storeResult | float Y Target | float Y Target | Variable |  |
| everyFrame | true | true |  |  |

##### 7. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Follow Target | OwnerDefault Follow Target |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Target | float X Target |  |  |
| y | float Y Target | float Y Target |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |
| lateUpdate | false | false |  |  |

##### 8. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| resetFrame | false | false |  |  |
| everyFrame | true | true |  |  |

##### 9. DistanceFlySmooth

Full Name: HutongGames.PlayMaker.Actions.DistanceFlySmooth
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | GameObject Follow Target | GameObject Follow Target | Variable |  |
| distance | 0.5f | 0.5f |  |  |
| speedMax | 30f | 30f |  |  |
| accelerationForce | 220f | 220f |  |  |
| targetRadius | 1f | 1f |  |  |
| deceleration | 0.9f | 0.9f |  |  |
| offset | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |

##### 10. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 0.5f | 0.5f |  |  |
| timeMax | 0.75f | 0.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 11. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Follow Pos | Vector3 Follow Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Target | float X Target |  |  |
| y | float Y Target | float Y Target |  |  |
| z | 0.00111f | 0.00111f |  |  |
| everyFrame | false | false |  |  |

### Tele In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [mage_knight_teleport (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [mage_knight_teleport (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1.25f | 1.25f |  |  |
| pitchMax | 1.25f | 1.25f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Orbs | OwnerDefault Pt Orbs |  |  |
| emission | true | true |  |  |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Smoke | OwnerDefault Pt Smoke |  |  |
| emission | true | true |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Target | float X Target |  |  |
| y | float Y Target | float Y Target |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | float Hero Y | float Hero Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 6. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | float X Distance | float X Distance |  |  |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Add | 0 |  |  |
| storeResult | float X Target | float X Target | Variable |  |
| everyFrame | true | true |  |  |

##### 8. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero Y | float Hero Y |  |  |
| float2 | float Y Distance | float Y Distance |  |  |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Add | 0 |  |  |
| storeResult | float Y Target | float Y Target | Variable |  |
| everyFrame | true | true |  |  |

##### 9. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Target | float X Target |  |  |
| y | float Y Target | float Y Target |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |
| lateUpdate | false | false |  |  |

##### 10. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Tele In" | "Tele In" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 11. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| resetFrame | false | false |  |  |
| everyFrame | true | true |  |  |

##### 12. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 13. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Teleport Effects | EventTarget(GameObject):Teleport Effects |  |  |
| sendEvent | "TELEPORT" | "TELEPORT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 15. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Red Flash 1 | OwnerDefault Red Flash 1 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Set Angle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Distance | float X Distance | Variable |  |
| floatValue | 12f | 12f |  |  |
| everyFrame | false | false |  |  |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0f | 0f |  |  |
| max | 6f | 6f |  |  |
| storeResult | float Y Distance | float Y Distance | Variable |  |

##### 3. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Distance | float X Distance | Variable |  |
| subtract | float Y Distance | float Y Distance |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 4. RandomlyFlipFloat

Full Name: HutongGames.PlayMaker.Actions.RandomlyFlipFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | float X Distance | float X Distance | Variable |  |

##### 5. RandomlyFlipFloat

Full Name: HutongGames.PlayMaker.Actions.RandomlyFlipFloat
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | float Y Distance | float Y Distance | Variable |  |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Force Left | bool Force Left | Variable |  |
| isTrue | L | L |  |  |
| isFalse |  |  |  |  |
| everyFrame | false | false |  |  |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Force Right | bool Force Right | Variable |  |
| isTrue | R | R |  |  |
| isFalse |  |  |  |  |
| everyFrame | false | false |  |  |

### Dash Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [flamebearer_dash_prepare (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_dash_prepare (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. FireAtTarget

Full Name: HutongGames.PlayMaker.Actions.FireAtTarget
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| speed | -12f | -12f |  |  |
| position | Vector3(0, -0.5, 0) | Vector3(0, -0.5, 0) |  |  |
| spread | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 5. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Dash Antic" | "Dash Antic" |  |  |

##### 6. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Smoke | OwnerDefault Pt Smoke |  |  |
| emission | false | false |  |  |

##### 7. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.9f | 0.9f |  |  |

### L or R?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Adjust | float Angle Adjust | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| xScale | true | true |  |  |
| positiveEvent |  |  |  |  |
| negativeEvent | FINISHED | FINISHED |  |  |
| space | UnityEngine.Space::World | 0 |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Adjust | float Angle Adjust | Variable |  |
| floatValue | 180f | 180f |  |  |
| everyFrame | false | false |  |  |

### Dash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Dash" | "Dash" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [flamebearer_dash_dash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_dash_dash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. FireAtTarget

Full Name: HutongGames.PlayMaker.Actions.FireAtTarget
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| speed | float Speed | float Speed |  |  |
| position | Vector3(0, -0.5, 0) | Vector3(0, -0.5, 0) |  |  |
| spread | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. FaceAngle

Full Name: HutongGames.PlayMaker.Actions.FaceAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angleOffset | float Angle Adjust | float Angle Adjust |  |  |
| everyFrame | true | true |  |  |

##### 5. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Orbs | OwnerDefault Pt Orbs |  |  |
| emission | false | false |  |  |

##### 6. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Dash | OwnerDefault Pt Dash |  |  |
| emission | true | true |  |  |

##### 7. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Burst | OwnerDefault Dash Burst |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Dash Time | float Dash Time |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Tele Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Tele Out" | "Tele Out" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "IN" | "IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Spiral Charge | OwnerDefault Pt Spiral Charge |  |  |

##### 4. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Pillars | OwnerDefault Loop Pillars |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [flamebearer_teleport_out (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_teleport_out (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 6. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 7. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flare In | OwnerDefault Flare In |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 8. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Slash Pt | OwnerDefault Slash Pt |  |  |
| emission | false | false |  |  |

##### 10. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Smoke | OwnerDefault Pt Smoke |  |  |
| emission | false | false |  |  |

##### 11. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Attack Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 1f | 1f |  |  |
| timeMax | 1.5f | 1.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### Dash End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Pt | OwnerDefault Idle Pt |  |  |
| emission | true | true |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "IN" | "IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Dash | OwnerDefault Pt Dash |  |  |
| emission | false | false |  |  |

##### 4. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.7f | 0.7f |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 7. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 8. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Smoke | OwnerDefault Pt Smoke |  |  |
| emission | true | true |  |  |

##### 9. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Orbs | OwnerDefault Pt Orbs |  |  |
| emission | true | true |  |  |

### Appear

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Tele Out" | "Tele Out" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Start | OwnerDefault Pt Start |  |  |
| emit | 0 | 0 |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [flamebearer_teleport_out (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_teleport_out (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 5. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) | FsmColor |  |
| everyframe | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Red Flash 1 | OwnerDefault Red Flash 1 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [grimm_area_effect (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [grimm_area_effect (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

### Tele Effect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Teleport Effects | EventTarget(GameObject):Teleport Effects |  |  |
| sendEvent | "TELEPORT" | "TELEPORT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Tele Effect 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Teleport Effects | EventTarget(GameObject):Teleport Effects |  |  |
| sendEvent | "TELEPORT" | "TELEPORT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Orbs | OwnerDefault Pt Orbs |  |  |
| emission | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Red Flash 1 | OwnerDefault Red Flash 1 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Damage End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Pt | OwnerDefault Idle Pt |  |  |
| emission | true | true |  |  |

##### 2. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Dash | OwnerDefault Pt Dash |  |  |
| emission | false | false |  |  |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Smoke | OwnerDefault Pt Smoke |  |  |
| emission | true | true |  |  |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Orbs | OwnerDefault Pt Orbs |  |  |
| emission | true | true |  |  |

##### 5. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "IN" | "IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Move Choice S

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "OUT" | "OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendRandomEventV2

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trackingInts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| eventMax | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |

### Shoot Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Throw Antic" | "Throw Antic" |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Smoke | OwnerDefault Pt Smoke |  |  |
| emission | false | false |  |  |

##### 4. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.8f | 0.8f |  |  |

### Shoot L1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Throw" | "Throw" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | float Flameball Speed | float Flameball Speed |  |  |
| speedMax | float Flameball Speed | float Flameball Speed |  |  |
| angleMin | 180f | 180f |  |  |
| angleMax | 180f | 180f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | float Flameball Speed | float Flameball Speed |  |  |
| speedMax | float Flameball Speed | float Flameball Speed |  |  |
| angleMin | 135f | 135f |  |  |
| angleMax | 135f | 135f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | float Flameball Speed | float Flameball Speed |  |  |
| speedMax | float Flameball Speed | float Flameball Speed |  |  |
| angleMin | 225f | 225f |  |  |
| angleMax | 225f | 225f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

### Shoot Recover

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Smoke | OwnerDefault Pt Smoke |  |  |
| emission | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "IN" | "IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.5f | 1.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

### Shoot Dir1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| xScale | true | true |  |  |
| positiveEvent | L | L |  |  |
| negativeEvent | R | R |  |  |
| space | UnityEngine.Space::World | 0 |  |  |

### Shoot R1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Throw" | "Throw" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | float Flameball Speed | float Flameball Speed |  |  |
| speedMax | float Flameball Speed | float Flameball Speed |  |  |
| angleMin | 0f | 0f |  |  |
| angleMax | 0f | 0f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | float Flameball Speed | float Flameball Speed |  |  |
| speedMax | float Flameball Speed | float Flameball Speed |  |  |
| angleMin | 45f | 45f |  |  |
| angleMax | 45f | 45f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | float Flameball Speed | float Flameball Speed |  |  |
| speedMax | float Flameball Speed | float Flameball Speed |  |  |
| angleMin | -45f | -45f |  |  |
| angleMax | -45f | -45f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

### Death Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [flamebearer_death_and_absorb (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_death_and_absorb (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | object Death Clip | object Death Clip |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Death" | "Death" |  |  |

##### 6. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 8. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Dash | OwnerDefault Pt Dash |  |  |

##### 9. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Orbs | OwnerDefault Pt Orbs |  |  |

##### 10. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Smoke | OwnerDefault Pt Smoke |  |  |

##### 11. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Start | OwnerDefault Pt Start |  |  |

##### 12. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Dying | OwnerDefault Pt Dying |  |  |
| emit | 0 | 0 |  |  |

##### 13. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.5f | 1.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 14. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| resetFrame | false | false |  |  |
| everyFrame | false | false |  |  |

##### 15. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Pillars | OwnerDefault Loop Pillars |  |  |

##### 16. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Laugh Loop | OwnerDefault Laugh Loop |  |  |

### Explode

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. ApplyMusicCue

Full Name: HutongGames.PlayMaker.Actions.ApplyMusicCue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| musicCue | [None (Script MusicCue) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [None (Script MusicCue) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| delayTime | 0f | 0f |  |  |
| transitionTime | 0f | 0f |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "DREAM AREA DISABLE" | "DREAM AREA DISABLE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Explode Effects | OwnerDefault Explode Effects |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Dying | OwnerDefault Pt Dying |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "FLAMEBEARER KILLED" | "FLAMEBEARER KILLED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3f | 3f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Level 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Speed | float Speed | Variable |  |
| floatValue | 40f | 40f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Dash Time | float Dash Time | Variable |  |
| floatValue | 0.475f | 0.475f |  |  |
| everyFrame | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimmkin_little_intro_01 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Grimmkin_little_intro_01 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Laugh Loop | OwnerDefault Laugh Loop |  |  |
| pitch | 1.15f | 1.15f |  |  |
| everyFrame | false | false |  |  |

### Level 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Speed | float Speed | Variable |  |
| floatValue | 50f | 50f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Dash Time | float Dash Time | Variable |  |
| floatValue | 0.425f | 0.425f |  |  |
| everyFrame | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimmkin_big_short_laugh_01 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Grimmkin_big_short_laugh_01 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Laugh Loop | OwnerDefault Laugh Loop |  |  |
| pitch | 1.15f | 1.15f |  |  |
| everyFrame | false | false |  |  |

### Shoot Lv

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [flamebearer_shoot (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_shoot (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Grimmchild Level | int Grimmchild Level | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Shoot L2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Throw" | "Throw" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 14f | 14f |  |  |
| angleMin | 180f | 180f |  |  |
| angleMax | 180f | 180f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 14f | 14f |  |  |
| angleMin | 135f | 135f |  |  |
| angleMax | 135f | 135f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 14f | 14f |  |  |
| angleMin | 225f | 225f |  |  |
| angleMax | 225f | 225f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 5. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 8f | 8f |  |  |
| speedMax | 8f | 8f |  |  |
| angleMin | 157.5f | 157.5f |  |  |
| angleMax | 155f | 155f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 6. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 8f | 8f |  |  |
| speedMax | 8f | 8f |  |  |
| angleMin | 202.5f | 202.5f |  |  |
| angleMax | 202.5f | 202.5f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

### Shoot Dir2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| xScale | true | true |  |  |
| positiveEvent | L | L |  |  |
| negativeEvent | R | R |  |  |
| space | UnityEngine.Space::World | 0 |  |  |

### Shoot R2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Throw" | "Throw" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 14f | 14f |  |  |
| angleMin | 0f | 0f |  |  |
| angleMax | 0f | 0f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 14f | 14f |  |  |
| angleMin | 45f | 45f |  |  |
| angleMax | 45f | 45f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 14f | 14f |  |  |
| angleMin | -45f | -45f |  |  |
| angleMax | -45f | -45f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 5. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 8f | 8f |  |  |
| speedMax | 8f | 8f |  |  |
| angleMin | 22.5f | 22.5f |  |  |
| angleMax | 22.5f | 22.5f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 6. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 8f | 8f |  |  |
| speedMax | 8f | 8f |  |  |
| angleMin | -22.5f | -22.5f |  |  |
| angleMax | -22.5f | -22.5f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

### Shoot L3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Throw" | "Throw" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 16f | 16f |  |  |
| speedMax | 16f | 16f |  |  |
| angleMin | 180f | 180f |  |  |
| angleMax | 180f | 180f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 16f | 16f |  |  |
| speedMax | 16f | 16f |  |  |
| angleMin | 135f | 135f |  |  |
| angleMax | 135f | 135f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 16f | 16f |  |  |
| speedMax | 16f | 16f |  |  |
| angleMin | 225f | 225f |  |  |
| angleMax | 225f | 225f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 5. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 10f | 10f |  |  |
| speedMax | 10f | 10f |  |  |
| angleMin | 157.5f | 157.5f |  |  |
| angleMax | 155f | 155f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 6. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 10f | 10f |  |  |
| speedMax | 10f | 10f |  |  |
| angleMin | 202.5f | 202.5f |  |  |
| angleMax | 202.5f | 202.5f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

### Shoot Dir3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| xScale | true | true |  |  |
| positiveEvent | L | L |  |  |
| negativeEvent | R | R |  |  |
| space | UnityEngine.Space::World | 0 |  |  |

### Shoot R3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Throw" | "Throw" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 14f | 14f |  |  |
| angleMin | 0f | 0f |  |  |
| angleMax | 0f | 0f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 14f | 14f |  |  |
| angleMin | 45f | 45f |  |  |
| angleMax | 45f | 45f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 14f | 14f |  |  |
| speedMax | 14f | 14f |  |  |
| angleMin | -45f | -45f |  |  |
| angleMax | -45f | -45f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 5. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 8f | 8f |  |  |
| speedMax | 8f | 8f |  |  |
| angleMin | 22.5f | 22.5f |  |  |
| angleMax | 22.5f | 22.5f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 6. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Flameball Obj | GameObject Flameball Obj |  |  |
| spawnPoint | GameObject Flame Spawn Point | GameObject Flame Spawn Point |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 8f | 8f |  |  |
| speedMax | 8f | 8f |  |  |
| angleMin | -22.5f | -22.5f |  |  |
| angleMax | -22.5f | -22.5f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

### Level 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Speed | float Speed | Variable |  |
| floatValue | 60f | 60f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Dash Time | float Dash Time | Variable |  |
| floatValue | 0.39f | 0.39f |  |  |
| everyFrame | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimmkin_big_short_laugh_01 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Grimmkin_big_short_laugh_01 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Laugh Loop | OwnerDefault Laugh Loop |  |  |
| pitch | 0.9f | 0.9f |  |  |
| everyFrame | false | false |  |  |

### In Bounds?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Force Left | bool Force Left | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Force Right | bool Force Right | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Self X | float Self X | Variable |  |
| y | float Self Y | float Self Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Self X | float Self X |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan | OUT OF BOUNDS L | OUT OF BOUNDS L |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Self X | float Self X |  |  |
| float2 | float Scene Width | float Scene Width |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan |  |  |  |  |
| greaterThan | OUT OF BOUNDS R | OUT OF BOUNDS R |  |  |
| everyFrame | false | false |  |  |

##### 6. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Self Y | float Self Y |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan | OUT OF BOUNDS | OUT OF BOUNDS |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 7. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Self Y | float Self Y |  |  |
| float2 | float Scene Height | float Scene Height |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan |  |  |  |  |
| greaterThan | OUT OF BOUNDS | OUT OF BOUNDS |  |  |
| everyFrame | false | false |  |  |

##### 8. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Grimmchild Level | int Grimmchild Level |  |  |
| integer2 | 1 | 1 |  |  |
| equal | LEVEL 1 | LEVEL 1 |  |  |
| lessThan | LEVEL 1 | LEVEL 1 |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 9. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Grimmchild Level | int Grimmchild Level |  |  |
| integer2 | 3 | 3 |  |  |
| equal | LEVEL 3 | LEVEL 3 |  |  |
| lessThan |  |  |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

### Force Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Force Right | bool Force Right | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Force Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Force Left | bool Force Left | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Stay L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float X Distance | float X Distance |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan | FINISHED | FINISHED |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Distance | float X Distance | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

### Stay R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float X Distance | float X Distance |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan |  |  |  |  |
| greaterThan | FINISHED | FINISHED |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Distance | float X Distance | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

### Move Choice

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "OUT" | "OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1.15f | 1.15f |  |  |
| pitchMax | 1.15f | 1.15f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SendRandomEventV3

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trackingInts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| eventMax | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trackingIntsMissed | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| missedMax | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |

### Spiral Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Death" | "Death" |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.65f | 0.65f |  |  |

##### 4. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Spiral Charge | OwnerDefault Pt Spiral Charge |  |  |
| emit | 0 | 0 |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [flamebearer_fire_spiral_prepare (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_fire_spiral_prepare (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Spawn Spiral

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Spiral Charge | OwnerDefault Pt Spiral Charge |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [flamebearer_fire_spiral_cast (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_fire_spiral_cast (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Spiral Fire | OwnerDefault Pt Spiral Fire |  |  |
| emit | 0 | 0 |  |  |

##### 5. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Grimmchild Level | int Grimmchild Level | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Spiral Med

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "IN" | "IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 4. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Flameball Shot (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Flameball Shot (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flameball | GameObject Flameball | Variable |  |

##### 5. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Angle" | "Angle" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flameball | EventTarget(GameObject):Flameball |  |  |
| sendEvent | "SPIRAL" | "SPIRAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Flameball Shot (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Flameball Shot (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flameball | GameObject Flameball | Variable |  |

##### 8. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Angle" | "Angle" | FsmFloat |  |
| setValue | 90f | 90f |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flameball | EventTarget(GameObject):Flameball |  |  |
| sendEvent | "SPIRAL" | "SPIRAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Flameball Shot (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Flameball Shot (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flameball | GameObject Flameball | Variable |  |

##### 11. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Angle" | "Angle" | FsmFloat |  |
| setValue | 180f | 180f |  |  |
| everyFrame | false | false |  |  |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flameball | EventTarget(GameObject):Flameball |  |  |
| sendEvent | "SPIRAL" | "SPIRAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Flameball Shot (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Flameball Shot (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flameball | GameObject Flameball | Variable |  |

##### 14. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Angle" | "Angle" | FsmFloat |  |
| setValue | 270f | 270f |  |  |
| everyFrame | false | false |  |  |

##### 15. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flameball | EventTarget(GameObject):Flameball |  |  |
| sendEvent | "SPIRAL" | "SPIRAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Spiral Large

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "IN" | "IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 4. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Flameball Shot 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Flameball Shot 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flameball | GameObject Flameball | Variable |  |

##### 5. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Angle" | "Angle" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flameball | EventTarget(GameObject):Flameball |  |  |
| sendEvent | "SPIRAL" | "SPIRAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Flameball Shot 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Flameball Shot 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flameball | GameObject Flameball | Variable |  |

##### 8. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Angle" | "Angle" | FsmFloat |  |
| setValue | 72f | 72f |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flameball | EventTarget(GameObject):Flameball |  |  |
| sendEvent | "SPIRAL" | "SPIRAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Flameball Shot 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Flameball Shot 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flameball | GameObject Flameball | Variable |  |

##### 11. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Angle" | "Angle" | FsmFloat |  |
| setValue | 144f | 144f |  |  |
| everyFrame | false | false |  |  |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flameball | EventTarget(GameObject):Flameball |  |  |
| sendEvent | "SPIRAL" | "SPIRAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Flameball Shot 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Flameball Shot 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flameball | GameObject Flameball | Variable |  |

##### 14. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Angle" | "Angle" | FsmFloat |  |
| setValue | 216f | 216f |  |  |
| everyFrame | false | false |  |  |

##### 15. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flameball | EventTarget(GameObject):Flameball |  |  |
| sendEvent | "SPIRAL" | "SPIRAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 16. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Flameball Shot 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Flameball Shot 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flameball | GameObject Flameball | Variable |  |

##### 17. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flameball | OwnerDefault Flameball |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Angle" | "Angle" | FsmFloat |  |
| setValue | 288f | 288f |  |  |
| everyFrame | false | false |  |  |

##### 18. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flameball | EventTarget(GameObject):Flameball |  |  |
| sendEvent | "SPIRAL" | "SPIRAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren | false | false |  |  |

### Flash Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flash | OwnerDefault Flash |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Flash | OwnerDefault Flash |  |  |
| clipName | "Flash" | "Flash" |  |  |
| animationTriggerEvent | FINISHED | FINISHED |  |  |
| animationCompleteEvent |  |  |  |  |

### Fanfare Level

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Grimmchild Level | int Grimmchild Level | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Fanfare 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [accordion_sting_04 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [accordion_sting_04 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "killedFlameBearerSmall" | "killedFlameBearerSmall" |  |  |
| isTrue | FINISHED | FINISHED |  |  |
| isFalse |  |  |  |  |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "killedFlameBearerSmall" | "killedFlameBearerSmall" |  |  |
| value | true | true |  |  |

##### 4. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "newDataFlameBearerSmall" | "newDataFlameBearerSmall" |  |  |
| value | true | true |  |  |

##### 5. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | "killsFlameBearerSmall" | "killsFlameBearerSmall" |  |  |
| value | 0 | 0 |  |  |

### Fanfare 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [accordion_sting_04 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [accordion_sting_04 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "killedFlameBearerMed" | "killedFlameBearerMed" |  |  |
| isTrue | FINISHED | FINISHED |  |  |
| isFalse |  |  |  |  |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "killedFlameBearerMed" | "killedFlameBearerMed" |  |  |
| value | true | true |  |  |

##### 4. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "newDataFlameBearerMed" | "newDataFlameBearerMed" |  |  |
| value | true | true |  |  |

##### 5. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | "killsFlameBearerMed" | "killsFlameBearerMed" |  |  |
| value | 0 | 0 |  |  |

### Fanfare 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [accordion_sting_05 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [accordion_sting_05 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "killedFlameBearerLarge" | "killedFlameBearerLarge" |  |  |
| isTrue | FINISHED | FINISHED |  |  |
| isFalse |  |  |  |  |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "killedFlameBearerLarge" | "killedFlameBearerLarge" |  |  |
| value | true | true |  |  |

##### 4. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "newDataFlameBearerLarge" | "newDataFlameBearerLarge" |  |  |
| value | true | true |  |  |

##### 5. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | "killsFlameBearerLarge" | "killsFlameBearerLarge" |  |  |
| value | 0 | 0 |  |  |

### Move Choice L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "OUT" | "OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer | GameObject Voice Player | GameObject Voice Player |  |  |

##### 3. SendRandomEventV3

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trackingInts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| eventMax | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trackingIntsMissed | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| missedMax | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |

### Pillar Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Death" | "Death" |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.5f | 0.5f |  |  |

##### 4. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Spiral Charge | OwnerDefault Pt Spiral Charge |  |  |
| emit | 0 | 0 |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [flamebearer_fire_spiral_prepare (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_fire_spiral_prepare (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 6. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimmkin_big_long_gasp (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Grimmkin_big_long_gasp (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 7. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| x | 0.1f | 0.1f |  |  |
| y | 0.1f | 0.1f |  |  |
| z | 0f | 0f |  |  |
| allowMovement | false | false |  |  |

##### 8. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Pillars | int Pillars | Variable |  |
| intValue | 3 | 3 |  |  |
| everyFrame | false | false |  |  |

##### 9. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Pillars | OwnerDefault Loop Pillars |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

##### 10. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Voice Player | OwnerDefault Voice Player |  |  |

### Check Ground

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. RayCast2dV2

Full Name: HutongGames.PlayMaker.Actions.RayCast2dV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject | OwnerDefault Hero | OwnerDefault Hero |  | Setup |
| fromPosition | Vector2(0, 0) | Vector2(0, 0) |  |  |
| direction | Vector2(0, -1) | Vector2(0, -1) |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| distance | 20f | 20f |  |  |
| minDepth | 0 | 0 |  |  |
| maxDepth | 0 | 0 |  |  |
| hitEvent | HIT | HIT | Variable | Result |
| storeDidHit | bool Ray Did Hit | bool Ray Did Hit | Variable |  |
| storeHitObject |  |  | Variable |  |
| storeHitPoint | Vector2 Ray Hit Pos | Vector2 Ray Hit Pos | Variable |  |
| storeHitNormal | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitDistance | 0f | 0f | Variable |  |
| storeDistance | 0f | 0f | Variable |  |
| repeatInterval | 1 | 1 |  | Filter |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| debugColor | Color(1, 0.92156863, 0.015686275, 1) | Color(1, 0.92156863, 0.015686275, 1) |  | Debug |
| debug | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | CANCEL | CANCEL |  |  |
| realTime | false | false |  |  |

##### 3. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| x | 0.1f | 0.1f |  |  |
| y | 0.1f | 0.1f |  |  |
| z | 0f | 0f |  |  |
| allowMovement | false | false |  |  |

### Spawn Pillar

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Grimm_flare_pillar (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Grimm_flare_pillar (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Projectile | GameObject Projectile | Variable |  |

##### 2. GetVector2XY

Full Name: HutongGames.PlayMaker.Actions.GetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable | Vector2 Ray Hit Pos | Vector2 Ray Hit Pos | Variable |  |
| storeX | float Pillar X | float Pillar X | Variable |  |
| storeY | float Pillar Y | float Pillar Y | Variable |  |
| everyFrame | false | false |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Projectile | OwnerDefault Projectile |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Pillar X | float Pillar X |  |  |
| y | float Pillar Y | float Pillar Y |  |  |
| z | 0.008f | 0.008f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 5. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| x | 0.1f | 0.1f |  |  |
| y | 0.1f | 0.1f |  |  |
| z | 0f | 0f |  |  |
| allowMovement | false | false |  |  |

### Pillar Repeat?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Pillars | int Pillars |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Pillars | int Pillars | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Pillars | int Pillars |  |  |
| integer2 | 0 | 0 |  |  |
| equal | FINISHED | FINISHED |  |  |
| lessThan | FINISHED | FINISHED |  |  |
| greaterThan | REPEAT | REPEAT |  |  |
| everyFrame | false | false |  |  |

### Music

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 0f | 0f |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Laugh Loop | EventTarget(GameObject):Laugh Loop |  |  |
| sendEvent | "START" | "START" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. ApplyMusicCue

Full Name: HutongGames.PlayMaker.Actions.ApplyMusicCue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| musicCue | [Grimmkin (Script MusicCue) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Grimmkin (Script MusicCue) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| delayTime | 0f | 0f |  |  |
| transitionTime | 0f | 0f |  |  |

### Tele Pos

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Target | float X Target |  |  |
| y | float Y Target | float Y Target |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | START | Set Level | 0 | 0 | 0 |
| Set Level | LEVEL 1 | Level 1 | 0 | 0 | 0 |
| Set Level | LEVEL 2 | Level 2 | 0 | 0 | 0 |
| Set Level | LEVEL 3 | Level 3 | 0 | 0 | 0 |
| Set Level | FINISHED | Level 1 | 0 | 0 | 0 |
| Alert Pause | FINISHED | Music | 0 | 0 | 0 |
| Follow | FINISHED | In Bounds? | 0 | 0 | 0 |
| Tele In | FINISHED | Follow | 0 | 0 | 0 |
| Set Angle | FINISHED | Tele Pos | 0 | 0 | 0 |
| Set Angle | L | Stay L | 0 | 0 | 0 |
| Set Angle | R | Stay R | 0 | 0 | 0 |
| Dash Antic | FINISHED | L or R? | 0 | 0 | 0 |
| L or R? | FINISHED | Dash | 0 | 0 | 0 |
| Dash | FINISHED | Dash End | 0 | 0 | 0 |
| Dash | TAKE DAMAGE | Damage End | 0 | 0 | 0 |
| Tele Out | FINISHED | Tele Effect 3 | 0 | 0 | 0 |
| Attack Pause | FINISHED | Set Angle | 0 | 0 | 0 |
| Dash End | FINISHED | Tele Out | 0 | 0 | 0 |
| Appear | FINISHED | Tele Effect | 0 | 0 | 0 |
| Tele Effect | FINISHED | Alert Pause | 0 | 0 | 0 |
| Tele Effect 3 | FINISHED | Attack Pause | 0 | 0 | 0 |
| Damage End | FINISHED | Tele Out | 0 | 0 | 0 |
| Move Choice S | DASH | Dash Antic | 0 | 0 | 0 |
| Move Choice S | SHOOT | Shoot Antic | 0 | 0 | 0 |
| Shoot Antic | FINISHED | Shoot Lv | 0 | 0 | 0 |
| Shoot L1 | FINISHED | Shoot Recover | 0 | 0 | 0 |
| Shoot Recover | FINISHED | Tele Out | 0 | 0 | 0 |
| Shoot Dir1 | L | Shoot L1 | 0 | 0 | 0 |
| Shoot Dir1 | R | Shoot R1 | 0 | 0 | 0 |
| Shoot R1 | FINISHED | Shoot Recover | 0 | 0 | 0 |
| Death Start | FINISHED | Fanfare Level | 0 | 0 | 0 |
| Explode | FINISHED | Destroy | 0 | 0 | 0 |
| Level 1 | FINISHED | Appear | 0 | 0 | 0 |
| Level 2 | FINISHED | Appear | 0 | 0 | 0 |
| Shoot Lv | LEVEL 1 | Shoot Dir1 | 0 | 0 | 0 |
| Shoot Lv | LEVEL 2 | Shoot Dir2 | 0 | 0 | 0 |
| Shoot Lv | LEVEL 3 | Shoot Dir3 | 0 | 0 | 0 |
| Shoot Lv | FINISHED |  | 0 | 0 | 0 |
| Shoot L2 | FINISHED | Shoot Recover | 0 | 0 | 0 |
| Shoot Dir2 | L | Shoot L2 | 0 | 0 | 0 |
| Shoot Dir2 | R | Shoot R2 | 0 | 0 | 0 |
| Shoot R2 | FINISHED | Shoot Recover | 0 | 0 | 0 |
| Shoot L3 | FINISHED | Shoot Recover | 0 | 0 | 0 |
| Shoot Dir3 | L | Shoot L3 | 0 | 0 | 0 |
| Shoot Dir3 | R | Shoot R3 | 0 | 0 | 0 |
| Shoot R3 | FINISHED | Shoot Recover | 0 | 0 | 0 |
| Level 3 | FINISHED | Appear | 0 | 0 | 0 |
| In Bounds? | FINISHED | Move Choice | 0 | 0 | 0 |
| In Bounds? | OUT OF BOUNDS | Tele Out | 0 | 0 | 0 |
| In Bounds? | OUT OF BOUNDS L | Force Right | 0 | 0 | 0 |
| In Bounds? | OUT OF BOUNDS R | Force Left | 0 | 0 | 0 |
| In Bounds? | LEVEL 1 | Move Choice S | 0 | 0 | 0 |
| In Bounds? | LEVEL 3 | Move Choice L | 0 | 0 | 0 |
| Force Right | FINISHED | Tele Out | 0 | 0 | 0 |
| Force Left | FINISHED | Tele Out | 0 | 0 | 0 |
| Stay L | FINISHED | Tele Pos | 0 | 0 | 0 |
| Stay R | FINISHED | Tele Pos | 0 | 0 | 0 |
| Move Choice | DASH | Dash Antic | 0 | 0 | 0 |
| Move Choice | SHOOT | Shoot Antic | 0 | 0 | 0 |
| Move Choice | SPIRAL | Spiral Antic | 0 | 0 | 0 |
| Spiral Antic | FINISHED | Spawn Spiral | 0 | 0 | 0 |
| Spawn Spiral | LEVEL 2 | Spiral Med | 0 | 0 | 0 |
| Spawn Spiral | LEVEL 3 | Spiral Large | 0 | 0 | 0 |
| Spiral Med | FINISHED | Tele Out | 0 | 0 | 0 |
| Spiral Large | FINISHED | Tele Out | 0 | 0 | 0 |
| Flash Start | FINISHED | Explode | 0 | 0 | 0 |
| Fanfare Level | LEVEL 1 | Fanfare 1 | 0 | 0 | 0 |
| Fanfare Level | LEVEL 2 | Fanfare 2 | 0 | 0 | 0 |
| Fanfare Level | LEVEL 3 | Fanfare 3 | 0 | 0 | 0 |
| Fanfare Level | FINISHED | Fanfare 1 | 0 | 0 | 0 |
| Fanfare 1 | FINISHED | Flash Start | 0 | 0 | 0 |
| Fanfare 2 | FINISHED | Flash Start | 0 | 0 | 0 |
| Fanfare 3 | FINISHED | Flash Start | 0 | 0 | 0 |
| Move Choice L | DASH | Dash Antic | 0 | 0 | 0 |
| Move Choice L | SHOOT | Shoot Antic | 0 | 0 | 0 |
| Move Choice L | SPIRAL | Spiral Antic | 0 | 0 | 0 |
| Move Choice L | PILLAR | Pillar Antic | 0 | 0 | 0 |
| Pillar Antic | FINISHED | Check Ground | 0 | 0 | 0 |
| Check Ground | CANCEL | Tele Out | 0 | 0 | 0 |
| Check Ground | HIT | Spawn Pillar | 0 | 0 | 0 |
| Spawn Pillar | FINISHED | Pillar Repeat? | 0 | 0 | 0 |
| Pillar Repeat? | REPEAT | Check Ground | 0 | 0 | 0 |
| Pillar Repeat? | FINISHED | Tele Out | 0 | 0 | 0 |
| Music | FINISHED | Set Angle | 0 | 0 | 0 |
| Tele Pos | FINISHED | State 1 | 0 | 0 | 0 |
| State 1 | FINISHED | Tele In | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| ZERO HP | Death Start | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ALERT | true |
| BLOCKED HIT | true |
| CANCEL | false |
| DASH | false |
| DREAM IMPACT | false |
| FLAMEBEARER KILLED | false |
| HIT | true |
| L | false |
| LEVEL 1 | false |
| LEVEL 2 | false |
| LEVEL 3 | false |
| OUT OF BOUNDS | false |
| OUT OF BOUNDS L | false |
| OUT OF BOUNDS R | false |
| PILLAR | false |
| R | false |
| REPEAT | false |
| SHOOT | false |
| SPIRAL | false |
| START | false |
| TAKE DAMAGE | false |
| ZERO HP | false |

