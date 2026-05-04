# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Crystal Hazard v2 (1) |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level273 |
| Start State | Initiate |
| FSM PathId | 2515 |
| GameObject PathId | 234 |

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

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Block Spawn Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Camera | [null] | NamedAssetPPtr: [null] |
| Corpse Instance | [null] | NamedAssetPPtr: [null] |
| Damager | [null] | NamedAssetPPtr: [null] |
| Hero | [null] | NamedAssetPPtr: [null] |
| KILLED GameObject | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

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
| gameObject |   | OwnerDefault Corpse Instance |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1f |   |   |
| y |   | 1f |   |   |
| z |   | 1f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Corpse Instance |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TAKE DAMAGE | Get Damager Parameters | 0 | |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName |   | "" |   |   |
| withTag |   | "CameraParent" | Tag |   |
| store |   | GameObject Camera | Variable |   |

##### 3. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName |   | "" |   |   |
| withTag |   | "Player" | Tag |   |
| store |   | GameObject Hero | Variable |   |

##### 4. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xScale |   | float X Scale | Variable |   |
| yScale |   | float Y Scale | Variable |   |
| zScale |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detecting | 0 | |

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
| sentByGameObject |   | GameObject Damager | Variable |   |

##### 2. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "direction" | FsmFloat |   |
| storeValue |   | float Attack Direction | Variable |   |
| everyFrame |   | false |   |   |

##### 3. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| storeValue |   | float Attack Magnitude | Variable |   |
| everyFrame |   | false |   |   |

##### 4. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "attackType" | FsmInt |   |
| storeValue |   | int Attack Type | Variable |   |
| everyFrame |   | false |   |   |

##### 5. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| storeValue |   | int Attack Strength | Variable |   |
| everyFrame |   | false |   |   |

##### 6. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "circleDirection" | FsmBool |   |
| storeValue |   | bool Circle Direction | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Damage Zero? | 0 | |

### Blocked Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Hero |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 1.15f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Self |   |   |
| sendEvent |   | Event(BLOCKED HIT) |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. FloatSwitch

Full Name: HutongGames.PlayMaker.Actions.FloatSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Attack Direction | Variable |   |
| lessThan |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RIGHT | Blocked Right | 0 | |
| LEFT | Blocked Left | 0 | |
| UP | Blocked Up | 0 | |
| DOWN | Blocked Down | 0 | |

### Blocked Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Damager Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | RecoilLeft(???) |   |   |

##### 3. HasComponent

Full Name: HutongGames.PlayMaker.Actions.HasComponent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| component |   | "BoxCollider2D" | ScriptComponent |   |
| removeOnExit |   | false |   |   |
| trueEvent |   | Event() |   |   |
| falseEvent |   | Event(NO BOX) |   |   |
| store |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Damager X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 5. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Self |   |   |
| offsetVector2 |   | Vector2(0, 0) | Variable |   |
| offsetX |   | float Collider Origin X | Variable |   |
| offsetY |   | 0f | Variable |   |
| everyFrame |   | false |   |   |

##### 6. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damager X | Variable |   |
| add |   | float Collider Origin X |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 7. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Self |   |   |
| scaleVector2 |   | Vector2(0, 0) | Variable |   |
| scaleX |   | float Collider Width | Variable |   |
| scaleY |   | 0f | Variable |   |
| everyFrame |   | false |   |   |

##### 8. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Collider Width | Variable |   |
| divideBy |   | 2f |   |   |
| everyFrame |   | false |   |   |

##### 9. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damager X | Variable |   |
| subtract |   | float Collider Width |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 10. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Block Spawn Pos | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Damager X |   |   |
| y |   | float Damager Y |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 11. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Block Hit (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3 Block Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Broadcast | 0 | |
| NO BOX | No Box Right | 0 | |

### Invincible Pause

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
| FINISHED | Detecting | 0 | |

### Blocked Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | RecoilRight(???) |   |   |

##### 2. HasComponent

Full Name: HutongGames.PlayMaker.Actions.HasComponent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| component |   | "BoxCollider2D" | ScriptComponent |   |
| removeOnExit |   | false |   |   |
| trueEvent |   | Event() |   |   |
| falseEvent |   | Event(NO BOX) |   |   |
| store |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Damager Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Damager X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 5. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Self |   |   |
| offsetVector2 |   | Vector2(0, 0) | Variable |   |
| offsetX |   | float Collider Origin X | Variable |   |
| offsetY |   | 0f | Variable |   |
| everyFrame |   | false |   |   |

##### 6. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damager X | Variable |   |
| add |   | float Collider Origin X |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 7. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Self |   |   |
| scaleVector2 |   | Vector2(0, 0) | Variable |   |
| scaleX |   | float Collider Width | Variable |   |
| scaleY |   | 0f | Variable |   |
| everyFrame |   | false |   |   |

##### 8. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Collider Width | Variable |   |
| divideBy |   | 2f |   |   |
| everyFrame |   | false |   |   |

##### 9. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damager X | Variable |   |
| add |   | float Collider Width |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 10. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Block Spawn Pos | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Damager X |   |   |
| y |   | float Damager Y |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 11. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Block Hit (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3 Block Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 180) |   |   |
| storeObject |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Broadcast | 0 | |
| NO BOX | No Box Left | 0 | |

### Blocked Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Damager X | Variable |   |
| y |   | float Attack Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. HasComponent

Full Name: HutongGames.PlayMaker.Actions.HasComponent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| component |   | "BoxCollider2D" | ScriptComponent |   |
| removeOnExit |   | false |   |   |
| trueEvent |   | Event() |   |   |
| falseEvent |   | Event(NO BOX) |   |   |
| store |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Damager Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Self |   |   |
| offsetVector2 |   | Vector2(0, 0) | Variable |   |
| offsetX |   | 0f | Variable |   |
| offsetY |   | float Collider Origin Y | Variable |   |
| everyFrame |   | false |   |   |

##### 5. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damager Y | Variable |   |
| add |   | float Collider Origin Y |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 6. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Self |   |   |
| scaleVector2 |   | Vector2(0, 0) | Variable |   |
| scaleX |   | 0f | Variable |   |
| scaleY |   | float Collider Height | Variable |   |
| everyFrame |   | false |   |   |

##### 7. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Collider Height | Variable |   |
| divideBy |   | 2f |   |   |
| everyFrame |   | false |   |   |

##### 8. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damager Y | Variable |   |
| subtract |   | float Collider Height |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 9. SetFloatToHighest

Full Name: HutongGames.PlayMaker.Actions.SetFloatToHighest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damager Y | Variable |   |
| value1 |   | float Damager Y |   |   |
| value2 |   | float Attack Y |   |   |
| everyFrame |   | false |   |   |

##### 10. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Block Spawn Pos | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Damager X |   |   |
| y |   | float Damager Y |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 11. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Block Hit (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3 Block Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 90) |   |   |
| storeObject |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Broadcast | 0 | |
| NO BOX | No Box Up | 0 | |

### Blocked Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Damager |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Damager X | Variable |   |
| y |   | float Attack Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. HasComponent

Full Name: HutongGames.PlayMaker.Actions.HasComponent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| component |   | "BoxCollider2D" | ScriptComponent |   |
| removeOnExit |   | false |   |   |
| trueEvent |   | Event() |   |   |
| falseEvent |   | Event(NO BOX) |   |   |
| store |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Damager Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. BoxColliderOffset

Full Name: HutongGames.PlayMaker.Actions.BoxColliderOffset
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Self |   |   |
| offsetVector2 |   | Vector2(0, 0) | Variable |   |
| offsetX |   | 0f | Variable |   |
| offsetY |   | float Collider Origin Y | Variable |   |
| everyFrame |   | false |   |   |

##### 5. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damager Y | Variable |   |
| add |   | float Collider Origin Y |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 6. BoundsBoxCollider

Full Name: HutongGames.PlayMaker.Actions.BoundsBoxCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 |   | OwnerDefault Self |   |   |
| scaleVector2 |   | Vector2(0, 0) | Variable |   |
| scaleX |   | 0f | Variable |   |
| scaleY |   | float Collider Height | Variable |   |
| everyFrame |   | false |   |   |

##### 7. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Collider Height | Variable |   |
| divideBy |   | 2f |   |   |
| everyFrame |   | false |   |   |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damager Y | Variable |   |
| add |   | float Collider Height |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 9. SetFloatToSmallest

Full Name: HutongGames.PlayMaker.Actions.SetFloatToSmallest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damager Y | Variable |   |
| value1 |   | float Damager Y |   |   |
| value2 |   | float Attack Y |   |   |
| everyFrame |   | false |   |   |

##### 10. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable |   | Vector3 Block Spawn Pos | Variable |   |
| vector3Value |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Damager X |   |   |
| y |   | float Damager Y |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 11. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Block Hit (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3 Block Spawn Pos |   |   |
| rotation |   | Vector3(0, 0, 270) |   |   |
| storeObject |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Broadcast | 0 | |
| NO BOX | No Box Down | 0 | |

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
| integer1 |   | int Attack Type |   |   |
| integer2 |   | 2 |   |   |
| equal |   | Event(TRUE) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Attack Type |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FALSE) |   |   |
| greaterThan |   | Event(FALSE) |   |   |
| everyFrame |   | false |   |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Attack Strength |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(TRUE) |   |   |
| lessThan |   | Event(TRUE) |   |   |
| greaterThan |   | Event(FALSE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FALSE | Blocked Hit | 0 | |
| TRUE | Pause Frame | 0 | |

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
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detecting | 0 | |

### Broadcast

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "SPIKE RECOIL" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

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
| gameObject |   | [Global] [Block Hit (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Hero |   |   |
| position |   | Vector3(0, -2, 0) |   |   |
| rotation |   | Vector3(0, 0, 270) |   |   |
| storeObject |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Broadcast | 0 | |

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
| gameObject |   | [Global] [Block Hit (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Hero |   |   |
| position |   | Vector3(0, 2, 0) |   |   |
| rotation |   | Vector3(0, 0, 90) |   |   |
| storeObject |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Broadcast | 0 | |

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
| gameObject |   | [Global] [Block Hit (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Hero |   |   |
| position |   | Vector3(-2, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 180) |   |   |
| storeObject |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Broadcast | 0 | |

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
| gameObject |   | [Global] [Block Hit (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Hero |   |   |
| position |   | Vector3(2, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Broadcast | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SPIKE RECOIL | Invincible Pause | 0 | |

## Events

| Name | Global |
| --- | --- |
| ACID | false |
| ARMOURED | false |
| BUBBLE | false |
| DOWN | false |
| FALSE | false |
| FINISHED | false |
| GENERIC | false |
| INFECTED | false |
| LARGE INFECTED | false |
| LEFT | false |
| NAIL | false |
| NO BOX | false |
| NO EFFECT | false |
| PLAY ANIM | false |
| RETURN | false |
| RIGHT | false |
| SHADE | false |
| SMALL INFECTED | false |
| SPELL | false |
| SPIKE RECOIL | false |
| TAKE DAMAGE | false |
| TRUE | false |
| UP | false |
| ZERO HP | false |

