# Surface Water Region

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Surface Water Region |
| GameObject Name | Surface Water Region |
| GameObject Path | Acid Control v2 |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets173.assets |
| Start State | Init |
| FSM PathId | 29 |
| GameObject PathId | 13 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Offset | -2.73 | Single: -2.73 |
| Hero Surface Y | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Black | false | Boolean: false |
| Will Hard Land | false | Boolean: false |

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Colour | Color(0, 0, 0, 1) | UnityColor: Color(0, 0, 0, 1) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dripper Obj | [null] | NamedAssetPPtr:  |
| HUD Cam Obj | [null] | NamedAssetPPtr:  |
| Hero Obj | [null] | NamedAssetPPtr:  |
| Spatter Obj | [null] | NamedAssetPPtr:  |
| Splash | [null] | NamedAssetPPtr:  |
| Splash Out Obj | [null] | NamedAssetPPtr:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(HERO ENTER) | Event(HERO ENTER) |  |  |
| storeCollider |  |  | Variable |  |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Hero Surface Y | float Hero Surface Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Hero Surface Y | float Hero Surface Y | Variable |  |
| add | float Hero Offset | float Hero Offset |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

### Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(HERO ENTER) | Event(HERO ENTER) |  |  |
| storeCollider |  |  | Variable |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hero | EventTarget(GameObject):Hero |  |  |
| sendEvent | "SURFACE EXIT" | "SURFACE EXIT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Acid Armour | EventTarget(GameObject):Acid Armour |  |  |
| sendEvent | "ACID ARMOUR END" | "ACID ARMOUR END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hero Obj | EventTarget(GameObject):Hero Obj |  |  |
| sendEvent | "SURFACE ENTER" | "SURFACE ENTER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Acid Armour | EventTarget(GameObject):Acid Armour |  |  |
| sendEvent | "ACID ARMOUR START" | "ACID ARMOUR START" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Inventory | EventTarget(GameObject):Inventory |  |  |
| sendEvent | "INVENTORY CANCEL" | "INVENTORY CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerExit2D | 2 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(HERO SURFACE EXIT) | Event(HERO SURFACE EXIT) |  |  |
| storeCollider |  |  | Variable |  |

### Splash In Norm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero Obj | OwnerDefault Hero Obj |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Hero Surface Y | float Hero Surface Y |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Spatter Obj | GameObject Spatter Obj |  |  |
| spawnPoint | GameObject Hero Obj | GameObject Hero Obj |  |  |
| position | Vector3(0.2, -0.7, 0) | Vector3(0.2, -0.7, 0) |  |  |
| spawnMin | 6 | 6 |  |  |
| spawnMax | 8 | 8 |  |  |
| speedMin | 7f | 7f |  |  |
| speedMax | 15f | 15f |  |  |
| angleMin | 120f | 120f |  |  |
| angleMax | 145f | 145f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Spatter Obj | GameObject Spatter Obj |  |  |
| spawnPoint | GameObject Hero Obj | GameObject Hero Obj |  |  |
| position | Vector3(-0.2, -0.7, 0) | Vector3(-0.2, -0.7, 0) |  |  |
| spawnMin | 6 | 6 |  |  |
| spawnMax | 8 | 8 |  |  |
| speedMin | 7f | 7f |  |  |
| speedMax | 15f | 15f |  |  |
| angleMin | 35f | 35f |  |  |
| angleMax | 60f | 60f |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Splash In Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Splash In Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Hero Obj | GameObject Hero Obj |  |  |
| position | Vector3(0, 1, 0) | Vector3(0, 1, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Splash | GameObject Splash | Variable |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Hero Obj | GameObject Hero Obj |  |  |
| audioClip | [water_splash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets31.assets)] | [water_splash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets31.assets)] |  |  |
| pitchMin | 0.8f | 0.8f |  |  |
| pitchMax | 0.95f | 0.95f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 6. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Splash | OwnerDefault Splash |  |  |
| color | Color Colour | Color Colour | FsmColor |  |
| everyframe | false | false |  |  |

### Splash Out effects

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Dripper Obj | GameObject Dripper Obj |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Hero Obj | GameObject Hero Obj |  |  |
| audioClip | [water_splash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets31.assets)] | [water_splash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets31.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1.15f | 1.15f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Splash Out Obj | GameObject Splash Out Obj |  |  |
| spawnPoint | GameObject Hero Obj | GameObject Hero Obj |  |  |
| position | Vector3(0, -1, 0) | Vector3(0, -1, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Splash | GameObject Splash | Variable |  |

### Big Splash?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "GetState" | "GetState" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Will Hard Land = False | Var Will Hard Land = False | Variable | Store Result |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Will Hard Land | bool Will Hard Land | Variable |  |
| isTrue | Event(BIG) | Event(BIG) |  |  |
| isFalse | Event(NORMAL) | Event(NORMAL) |  |  |
| everyFrame | false | false |  |  |

### Splash In Big

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "EnemyKillShake" | "EnemyKillShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Hero Surface Y | float Hero Surface Y |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Spatter Obj | GameObject Spatter Obj |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(0, -0.7, 0) | Vector3(0, -0.7, 0) |  |  |
| spawnMin | 60 | 60 |  |  |
| spawnMax | 60 | 60 |  |  |
| speedMin | 10f | 10f |  |  |
| speedMax | 30f | 30f |  |  |
| angleMin | 80f | 80f |  |  |
| angleMax | 100f | 100f |  |  |
| originVariationX | 1f | 1f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [water_splash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets31.assets)] | [water_splash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets31.assets)] |  |  |
| pitchMin | 0.8f | 0.8f |  |  |
| pitchMax | 0.95f | 0.95f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Splash In Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Splash In Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(0, 1, 0) | Vector3(0, 1, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Splash | GameObject Splash | Variable |  |

##### 6. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Splash | OwnerDefault Splash |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 2.5f | 2.5f |  |  |
| y | 2.5f | 2.5f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Splash | OwnerDefault Splash |  |  |
| color | Color Colour | Color Colour | FsmColor |  |
| everyframe | false | false |  |  |

##### 8. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Splash Out Obj | GameObject Splash Out Obj |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(0, 1, 0) | Vector3(0, 1, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Splash | GameObject Splash | Variable |  |

##### 9. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Splash | OwnerDefault Splash |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 2f | 2f |  |  |
| y | 2f | 2f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Hero Obj | GameObject Hero Obj | Variable |  |
| gameObject | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| everyFrame | false | false |  |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject HUD Cam Obj | GameObject HUD Cam Obj | Variable |  |
| gameObject | GameObject HUD Cam Obj | GameObject HUD Cam Obj |  |  |
| everyFrame | false | false |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Black | bool Black | Variable |  |
| isTrue | Event(BLACK) | Event(BLACK) |  |  |
| isFalse | Event(NORMAL) | Event(NORMAL) |  |  |
| everyFrame | false | false |  |  |

### Black

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable | Color Colour | Color Colour | Variable |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Splash Out Obj | GameObject Splash Out Obj | Variable |  |
| gameObject | [Global] [Splash Out Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Splash Out Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| everyFrame | false | false |  |  |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Spatter Obj | GameObject Spatter Obj | Variable |  |
| gameObject | [Global] [Spatter Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| everyFrame | false | false |  |  |

##### 4. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Dripper Obj | GameObject Dripper Obj | Variable |  |
| gameObject | [Global] [Dripper Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets50.assets)] | [Global] [Dripper Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets50.assets)] |  |  |
| everyFrame | false | false |  |  |

### Blue

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable | Color Colour | Color Colour | Variable |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Splash Out Obj | GameObject Splash Out Obj | Variable |  |
| gameObject | [Global] [Splash Out White (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Splash Out White (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| everyFrame | false | false |  |  |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Spatter Obj | GameObject Spatter Obj | Variable |  |
| gameObject | [Global] [Spatter White R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter White R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| everyFrame | false | false |  |  |

##### 4. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Dripper Obj | GameObject Dripper Obj | Variable |  |
| gameObject | [Global] [Dripper White (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets50.assets)] | [Global] [Dripper White (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets50.assets)] |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | HERO ENTER | Big Splash? | 0 | 0 | 0 |
| Out | HERO ENTER | Big Splash? | 0 | 0 | 0 |
| In | HERO SURFACE EXIT | Splash Out effects | 0 | 0 | 0 |
| Splash In Norm | FINISHED | In | 0 | 0 | 0 |
| Splash Out effects | FINISHED | Out | 0 | 0 | 0 |
| Big Splash? | NORMAL | Splash In Norm | 0 | 0 | 0 |
| Big Splash? | BIG | Splash In Big | 0 | 0 | 0 |
| Splash In Big | FINISHED | In | 0 | 0 | 0 |
| Init | BLACK | Black | 0 | 0 | 0 |
| Init | NORMAL | Blue | 0 | 0 | 0 |
| Black | FINISHED | Idle | 0 | 0 | 0 |
| Blue | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BIG | false |
| BLACK | false |
| HERO ENTER | false |
| HERO SURFACE EXIT | false |
| NORMAL | false |

