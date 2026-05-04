# Get Quake

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Get Quake |
| GameObject Name | Knight Get Quake |
| GameObject Path | Quake Real Parent/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level101 |
| Start State | Start |
| FSM PathId | 6937 |
| GameObject PathId | 1200 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cutscene Knight | [null] | NamedAssetPPtr: [null] |
| Knight Flame | [null] | NamedAssetPPtr: [null] |
| Light 2 | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |
| UI Msg | [null] | NamedAssetPPtr: [null] |
| Wave | [null] | NamedAssetPPtr: [null] |

## States

### Start

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

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [spell_pickup_pickup (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets27.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "hasSpell" |   |   |
| value |   | true |   |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "white_light 1" |   |   |
| storeResult |   | GameObject Light 2 | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Knight Cutscene Animator" |   |   |
| storeResult |   | GameObject Cutscene Knight | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cutscene Knight |   |   |
| childName |   | "Corpse Flame" |   |   |
| storeResult |   | GameObject Knight Flame | Variable |   |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cutscene Knight |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Collect Magical 1" |   |   |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 9. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault MainCamera |   |   |
| id |   | "" |   |   |
| vector |   | Vector3(0, 0, -2.5) |   |   |
| time |   | 1.2f |   |   |
| delay |   | 0f |   |   |
| speed |   | 0f |   |   |
| easeType | iTween/EaseType::easeOutSine | 13 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

##### 10. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault MainCamera |   |   |
| id |   | "" |   |   |
| vector |   | Vector3(0, 0, 1.25) |   |   |
| time |   | 0.5f |   |   |
| delay |   | 2.5f |   |   |
| speed |   | 0f |   |   |
| easeType | iTween/EaseType::linear | 21 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

##### 11. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 3f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Rumble | 0 | |

### Rumble

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cutscene Knight |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Collect Magical 2" |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):CameraParent |   |   |
| sendEvent |   | "MedRumble" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault CameraParent |   |   |
| fsmName |   | "CameraShake" | FsmName |   |
| variableName |   | "RumblingMed" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 4. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault MainCamera |   |   |
| id |   | "" |   |   |
| vector |   | Vector3(0, 0, 5) |   |   |
| time |   | 2f |   |   |
| delay |   | 0f |   |   |
| speed |   | 0f |   |   |
| easeType | iTween/EaseType::linear | 21 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 2f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Get | 0 | |

### Get

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | AddMPCharge(9999) |   |   |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault CameraParent |   |   |
| fsmName |   | "CameraShake" | FsmName |   |
| variableName |   | "RumblingMed" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault MainCamera |   |   |
| id |   | "" |   |   |
| vector |   | Vector3(0, 0, -3.75) |   |   |
| time |   | 0.25f |   |   |
| delay |   | 0f |   |   |
| speed |   | 0f |   |   |
| easeType | iTween/EaseType::easeOutSine | 13 |   |   |
| loopType | iTween/LoopType::none | 0 |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| orientToPath |   | false |   | LookAt |
| lookAtObject |   |   |   |   |
| lookAtVector |   | Vector3(0, 0, 0) |   |   |
| lookTime |   | 0f |   |   |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |   |   |
| startEvent |   | Event() |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |
| stopOnExit |   | true |   |   |
| loopDontFinish |   | true |   |   |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [spell_pickup_final_boom (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets10.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Light 2 |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 6. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [White Wave (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Wave | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 7. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Wave |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 2.5f |   |   |
| y |   | 2.5f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):CameraParent |   |   |
| sendEvent |   | "BigShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 9. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cutscene Knight |   |   |
| clipName |   | "Collect Magical 3b" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fall | 0 | |

### Fall

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cutscene Knight |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Collect Magical Fall" |   |   |

##### 2. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cutscene Knight |   |   |
| gravityScale |   | 0.75f |   |   |

##### 3. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Knight Flame |   |   |
| emit |   | 0 |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cutscene Knight |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| active |   | true |   |   |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | AffectedByGravity(true) |   |   |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.4f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 8. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Airborne" |   |   |

##### 9. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| frame |   | 7 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Msg Up | 0 | |

### Msg Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CreateUIMsgGetItem

Full Name: HutongGames.PlayMaker.Actions.CreateUIMsgGetItem
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [UI Msg Get Item (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |   |   |
| storeObject |   | GameObject UI Msg | Variable |   |
| sprite |   | [_0003_quake_spell (Sprite) (Hollow Knight/hollow_knight_Data\sharedassets101.assets)] |   |   |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault UI Msg |   |   |
| fsmName |   | "Msg Control" | FsmName |   |
| variableName |   | "Item" | FsmString |   |
| setValue |   | "Quake" |   |   |
| everyFrame |   | false |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Collect Normal 2" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| GET ITEM MSG END | Get Up | 0 | |

### Regain Control

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | RegainControl(???) |   |   |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | StartAnimationControl(???) |   |   |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "disablePause" |   |   |
| value |   | false |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "BG OPEN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "B2 OFF" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |   |   |
| functionCall |   | SaveGame(???) |   |   |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |   |   |
| functionCall |   | TimePasses(???) |   |   |

#### Transitions

(none)

### Get Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| clipName |   | "Collect Normal 3" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Regain Control | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| GET ITEM MSG END | false |

