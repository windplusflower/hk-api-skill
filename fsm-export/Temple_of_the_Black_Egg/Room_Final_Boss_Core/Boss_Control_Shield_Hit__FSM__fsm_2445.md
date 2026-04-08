# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Shield Hit |
| GameObject Path | Boss Control |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level409.assets |
| Start State | Initiate |
| FSM PathId | 2445 |
| GameObject PathId | 407 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Direction | 0 | Single: 0 |
| Attack Magnitude | 0 | Single: 0 |
| Attack Y | 0 | Single: 0 |
| Chooser | 0 | Single: 0 |
| Collider Height | 0 | Single: 0 |
| Collider Origin X | 0 | Single: 0 |
| Collider Origin Y | 0 | Single: 0 |
| Collider Width | 0 | Single: 0 |
| Damager X | 0 | Single: 0 |
| Damager Y | 0 | Single: 0 |
| X Scale | 0 | Single: 0 |
| Y Scale | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Strength | 0 | Int32: 0 |
| Attack Type | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Circle Direction | false | Boolean: false |
| Use Nail Pos | true | Boolean: true |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Block Spawn Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Corpse Instance | [null] | NamedAssetPPtr:  |
| Damager | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Detecting

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Corpse Instance | OwnerDefault Corpse Instance |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 1f | 1f |  |  |
| z | 1f | 1f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Initiate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xScale | float X Scale | float X Scale | Variable |  |
| yScale | float Y Scale | float Y Scale | Variable |  |
| zScale | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

### Get Damager Parameters

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetEventSender

Full Name: HutongGames.PlayMaker.Actions.GetEventSender
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sentByGameObject | GameObject Damager | GameObject Damager | Variable |  |

##### 2. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "direction" | "direction" | FsmFloat |  |
| storeValue | float Attack Direction | float Attack Direction | Variable |  |
| everyFrame | false | false |  |  |

##### 3. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| storeValue | float Attack Magnitude | float Attack Magnitude | Variable |  |
| everyFrame | false | false |  |  |

##### 4. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "attackType" | "attackType" | FsmInt |  |
| storeValue | int Attack Type | int Attack Type | Variable |  |
| everyFrame | false | false |  |  |

##### 5. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| storeValue | int Attack Strength | int Attack Strength | Variable |  |
| everyFrame | false | false |  |  |

##### 6. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "circleDirection" | "circleDirection" | FsmBool |  |
| storeValue | bool Circle Direction | bool Circle Direction | Variable |  |
| everyFrame | false | false |  |  |

### Blocked Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.85f | 0.85f |  |  |
| max | 1.15f | 1.15f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent |  |  |
| sendEvent | "EnemyKillShake" | "EnemyKillShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| pitch | float Chooser | float Chooser |  |  |
| everyFrame | false | false |  |  |

##### 4. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 0.85f | 0.85f |  |  |
| pitchMax | 1.15f | 1.15f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 5. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | Event(BLOCKED HIT) | Event(BLOCKED HIT) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. FloatSwitch

Full Name: HutongGames.PlayMaker.Actions.FloatSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Attack Direction | float Attack Direction | Variable |  |
| lessThan | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Blocked Right

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
| methodName | "RecoilLeft" | "RecoilLeft" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "TINK RIGHT" | "TINK RIGHT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Use Nail Pos | bool Use Nail Pos | Variable |  |
| isTrue | Event(NO BOX) | Event(NO BOX) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. HasComponent

Full Name: HutongGames.PlayMaker.Actions.HasComponent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| component | "BoxCollider2D" | "BoxCollider2D" | ScriptComponent |  |
| removeOnExit | false | false |  |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event(NO BOX) | Event(NO BOX) |  |  |
| store | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Damager Y | float Damager Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 6. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Damager X | float Damager X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 7. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault Self | OwnerDefault Self |  |  |
| offsetVector2 | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| offsetX | float Collider Origin X | float Collider Origin X | Variable |  |
| offsetY | 0f | 0f | Variable |  |
| everyFrame | false | false |  |  |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damager X | float Damager X | Variable |  |
| add | float Collider Origin X | float Collider Origin X |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 9. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault Self | OwnerDefault Self |  |  |
| scaleVector2 | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| scaleX | float Collider Width | float Collider Width | Variable |  |
| scaleY | 0f | 0f | Variable |  |
| everyFrame | false | false |  |  |

##### 10. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Collider Width | float Collider Width | Variable |  |
| divideBy | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 11. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damager X | float Damager X | Variable |  |
| subtract | float Collider Width | float Collider Width |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 12. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Block Spawn Pos | Vector3 Block Spawn Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Damager X | float Damager X |  |  |
| y | float Damager Y | float Damager Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Block Spawn Pos | Vector3 Block Spawn Pos |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |

### Blocked Left

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
| methodName | "RecoilRight" | "RecoilRight" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "TINK LEFT" | "TINK LEFT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Use Nail Pos | bool Use Nail Pos | Variable |  |
| isTrue | Event(NO BOX) | Event(NO BOX) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. HasComponent

Full Name: HutongGames.PlayMaker.Actions.HasComponent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| component | "BoxCollider2D" | "BoxCollider2D" | ScriptComponent |  |
| removeOnExit | false | false |  |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event(NO BOX) | Event(NO BOX) |  |  |
| store | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Damager Y | float Damager Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 6. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Damager X | float Damager X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 7. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault Self | OwnerDefault Self |  |  |
| offsetVector2 | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| offsetX | float Collider Origin X | float Collider Origin X | Variable |  |
| offsetY | 0f | 0f | Variable |  |
| everyFrame | false | false |  |  |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damager X | float Damager X | Variable |  |
| add | float Collider Origin X | float Collider Origin X |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 9. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault Self | OwnerDefault Self |  |  |
| scaleVector2 | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| scaleX | float Collider Width | float Collider Width | Variable |  |
| scaleY | 0f | 0f | Variable |  |
| everyFrame | false | false |  |  |

##### 10. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Collider Width | float Collider Width | Variable |  |
| divideBy | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 11. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damager X | float Damager X | Variable |  |
| add | float Collider Width | float Collider Width |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 12. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Block Spawn Pos | Vector3 Block Spawn Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Damager X | float Damager X |  |  |
| y | float Damager Y | float Damager Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Block Spawn Pos | Vector3 Block Spawn Pos |  |  |
| rotation | Vector3(0, 0, 180) | Vector3(0, 0, 180) |  |  |
| storeObject |  |  | Variable |  |

### Blocked Up

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
| methodName | "RecoilDown" | "RecoilDown" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "TINK UP" | "TINK UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Use Nail Pos | bool Use Nail Pos | Variable |  |
| isTrue | Event(NO BOX) | Event(NO BOX) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. HasComponent

Full Name: HutongGames.PlayMaker.Actions.HasComponent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| component | "BoxCollider2D" | "BoxCollider2D" | ScriptComponent |  |
| removeOnExit | false | false |  |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event(NO BOX) | Event(NO BOX) |  |  |
| store | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Damager X | float Damager X | Variable |  |
| y | float Attack Y | float Attack Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 6. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Damager Y | float Damager Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 7. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault Self | OwnerDefault Self |  |  |
| offsetVector2 | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| offsetX | 0f | 0f | Variable |  |
| offsetY | float Collider Origin Y | float Collider Origin Y | Variable |  |
| everyFrame | false | false |  |  |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damager Y | float Damager Y | Variable |  |
| add | float Collider Origin Y | float Collider Origin Y |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 9. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault Self | OwnerDefault Self |  |  |
| scaleVector2 | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| scaleX | 0f | 0f | Variable |  |
| scaleY | float Collider Height | float Collider Height | Variable |  |
| everyFrame | false | false |  |  |

##### 10. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Collider Height | float Collider Height | Variable |  |
| divideBy | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 11. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damager Y | float Damager Y | Variable |  |
| subtract | float Collider Height | float Collider Height |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 12. SetFloatToHighest

Full Name: HutongGames.PlayMaker.Actions.SetFloatToHighest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damager Y | float Damager Y | Variable |  |
| value1 | float Damager Y | float Damager Y |  |  |
| value2 | float Attack Y | float Attack Y |  |  |
| everyFrame | false | false |  |  |

##### 13. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Block Spawn Pos | Vector3 Block Spawn Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Damager X | float Damager X |  |  |
| y | float Damager Y | float Damager Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 14. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Block Spawn Pos | Vector3 Block Spawn Pos |  |  |
| rotation | Vector3(0, 0, 90) | Vector3(0, 0, 90) |  |  |
| storeObject |  |  | Variable |  |

### Blocked Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "TINK DOWN" | "TINK DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Use Nail Pos | bool Use Nail Pos | Variable |  |
| isTrue | Event(NO BOX) | Event(NO BOX) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. HasComponent

Full Name: HutongGames.PlayMaker.Actions.HasComponent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| component | "BoxCollider2D" | "BoxCollider2D" | ScriptComponent |  |
| removeOnExit | false | false |  |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event(NO BOX) | Event(NO BOX) |  |  |
| store | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Damager | OwnerDefault Damager |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Damager X | float Damager X | Variable |  |
| y | float Attack Y | float Attack Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Damager Y | float Damager Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 6. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault Self | OwnerDefault Self |  |  |
| offsetVector2 | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| offsetX | 0f | 0f | Variable |  |
| offsetY | float Collider Origin Y | float Collider Origin Y | Variable |  |
| everyFrame | false | false |  |  |

##### 7. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damager Y | float Damager Y | Variable |  |
| add | float Collider Origin Y | float Collider Origin Y |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 8. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault Self | OwnerDefault Self |  |  |
| scaleVector2 | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| scaleX | 0f | 0f | Variable |  |
| scaleY | float Collider Height | float Collider Height | Variable |  |
| everyFrame | false | false |  |  |

##### 9. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Collider Height | float Collider Height | Variable |  |
| divideBy | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 10. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damager Y | float Damager Y | Variable |  |
| add | float Collider Height | float Collider Height |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 11. SetFloatToSmallest

Full Name: HutongGames.PlayMaker.Actions.SetFloatToSmallest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damager Y | float Damager Y | Variable |  |
| value1 | float Damager Y | float Damager Y |  |  |
| value2 | float Attack Y | float Attack Y |  |  |
| everyFrame | false | false |  |  |

##### 12. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Block Spawn Pos | Vector3 Block Spawn Pos | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Damager X | float Damager X |  |  |
| y | float Damager Y | float Damager Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3 Block Spawn Pos | Vector3 Block Spawn Pos |  |  |
| rotation | Vector3(0, 0, 270) | Vector3(0, 0, 270) |  |  |
| storeObject |  |  | Variable |  |

### Damage Zero?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Attack Type | int Attack Type |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(TRUE) | Event(TRUE) |  |  |
| greaterThan | Event(TRUE) | Event(TRUE) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Attack Strength | int Attack Strength |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(TRUE) | Event(TRUE) |  |  |
| lessThan | Event(TRUE) | Event(TRUE) |  |  |
| greaterThan | Event(FALSE) | Event(FALSE) |  |  |
| everyFrame | false | false |  |  |

### Pause Frame

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### No Box Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(0, -2, 0) | Vector3(0, -2, 0) |  |  |
| rotation | Vector3(0, 0, 270) | Vector3(0, 0, 270) |  |  |
| storeObject |  |  | Variable |  |

### No Box Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(0, 2, 0) | Vector3(0, 2, 0) |  |  |
| rotation | Vector3(0, 0, 90) | Vector3(0, 0, 90) |  |  |
| storeObject |  |  | Variable |  |

### No Box Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(-2, 0, 0) | Vector3(-2, 0, 0) |  |  |
| rotation | Vector3(0, 0, 180) | Vector3(0, 0, 180) |  |  |
| storeObject |  |  | Variable |  |

### No Box Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Block Hit (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(2, 0, 0) | Vector3(2, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |

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
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Detecting | TAKE DAMAGE | Get Damager Parameters | 0 | 0 | 0 |
| Initiate | FINISHED | Detecting | 0 | 0 | 0 |
| Get Damager Parameters | FINISHED | Damage Zero? | 0 | 0 | 0 |
| Blocked Hit | RIGHT | Blocked Right | 0 | 0 | 0 |
| Blocked Hit | LEFT | Blocked Left | 0 | 0 | 0 |
| Blocked Hit | UP | Blocked Up | 0 | 0 | 0 |
| Blocked Hit | DOWN | Blocked Down | 0 | 0 | 0 |
| Blocked Right | FINISHED | Pause | 0 | 0 | 0 |
| Blocked Right | NO BOX | No Box Right | 0 | 0 | 0 |
| Blocked Left | FINISHED | Pause | 0 | 0 | 0 |
| Blocked Left | NO BOX | No Box Left | 0 | 0 | 0 |
| Blocked Up | FINISHED | Pause | 0 | 0 | 0 |
| Blocked Up | NO BOX | No Box Up | 0 | 0 | 0 |
| Blocked Down | FINISHED | Pause | 0 | 0 | 0 |
| Blocked Down | NO BOX | No Box Down | 0 | 0 | 0 |
| Damage Zero? | FALSE | Blocked Hit | 0 | 0 | 0 |
| Damage Zero? | TRUE | Pause Frame | 0 | 0 | 0 |
| Pause Frame | FINISHED | Detecting | 0 | 0 | 0 |
| No Box Down | FINISHED | Pause | 0 | 0 | 0 |
| No Box Up | FINISHED | Pause | 0 | 0 | 0 |
| No Box Left | FINISHED | Pause | 0 | 0 | 0 |
| No Box Right | FINISHED | Pause | 0 | 0 | 0 |
| Pause | FINISHED | Detecting | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| DOWN | false |
| FALSE | false |
| LEFT | false |
| NO BOX | false |
| RIGHT | false |
| TAKE DAMAGE | false |
| TRUE | false |
| UP | false |

