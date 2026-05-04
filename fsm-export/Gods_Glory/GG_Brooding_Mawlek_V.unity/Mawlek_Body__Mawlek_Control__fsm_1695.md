# Mawlek Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Mawlek Control |
| GameObject Name | Mawlek Body |
| GameObject Path | Battle Scene/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level485 |
| Start State | Pause |
| FSM PathId | 1695 |
| GameObject PathId | 45 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle Max | 0 | Single: 0 |
| Angle Min | 0 | Single: 0 |
| Chooser Float | 0 | Single: 0 |
| Cooldown Time | 1 | Single: 1 |
| Hero X | 0 | Single: 0 |
| Self X | 0 | Single: 0 |
| Shot Speed | 32 | Single: 32 |
| Shot Speed Max | 35 | Single: 35 |
| Start X | 0 | Single: 0 |
| Start Y | 0 | Single: 0 |
| Super Wait | 0 | Single: 0 |
| X Distance | 0 | Single: 0 |
| X Distance Neg | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Jumps In A Row | 0 | Int32: 0 |
| Spits In A Row | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Active H | false | Boolean: false |
| Active L | false | Boolean: false |
| Active R | false | Boolean: false |
| Return Right | false | Boolean: false |
| Skip Title | false | Boolean: false |
| Super Repeated | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alerter | [null] | NamedAssetPPtr: [null] |
| Area Title | [null] | NamedAssetPPtr: [null] |
| Arm L | [null] | NamedAssetPPtr: [null] |
| Arm R | [null] | NamedAssetPPtr: [null] |
| Battle Scene | Battle Scene (Hollow Knight/hollow_knight_Data\level485) | NamedAssetPPtr: [Battle Scene (Hollow Knight/hollow_knight_Data\level485)] |
| Camera | [null] | NamedAssetPPtr: [null] |
| Dummy | [null] | NamedAssetPPtr: [null] |
| Dust Land Large | [null] | NamedAssetPPtr: [null] |
| Head | [null] | NamedAssetPPtr: [null] |
| Hero | [null] | NamedAssetPPtr: [null] |
| Jump Trail | [null] | NamedAssetPPtr: [null] |
| Roar Emitter | [null] | NamedAssetPPtr: [null] |
| Roar Waves | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |
| Spit Effect | [null] | NamedAssetPPtr: [null] |

## States

### Init

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

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | GameObject Camera | Variable |   |
| gameObject |   | [Global] GameObject CameraParent |   |   |
| everyFrame |   | false |   |   |

##### 3. GetHero

Full Name: GetHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult |   | GameObject Hero | Variable |   |

##### 4. GetChild

Full Name: HutongGames.PlayMaker.Actions.GetChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dummy" |   |   |
| withTag |   | "Untagged" | Tag |   |
| storeResult |   | GameObject Dummy | Variable |   |

##### 5. GetChild

Full Name: HutongGames.PlayMaker.Actions.GetChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Mawlek Arm L" |   |   |
| withTag |   | "Untagged" | Tag |   |
| storeResult |   | GameObject Arm L | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Jump Trail" |   |   |
| storeResult |   | GameObject Jump Trail | Variable |   |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Spit Effect" |   |   |
| storeResult |   | GameObject Spit Effect | Variable |   |

##### 8. GetChild

Full Name: HutongGames.PlayMaker.Actions.GetChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Mawlek Arm R" |   |   |
| withTag |   | "Untagged" | Tag |   |
| storeResult |   | GameObject Arm R | Variable |   |

##### 9. GetChild

Full Name: HutongGames.PlayMaker.Actions.GetChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Mawlek Head" |   |   |
| withTag |   | "Untagged" | Tag |   |
| storeResult |   | GameObject Head | Variable |   |

##### 10. GetChild

Full Name: HutongGames.PlayMaker.Actions.GetChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dust Land Large" |   |   |
| withTag |   | "Untagged" | Tag |   |
| storeResult |   | [Battle Scene/Mawlek Body/Dust Land Large (Hollow Knight/hollow_knight_Data\level485)] | Variable |   |

##### 11. GetChild

Full Name: HutongGames.PlayMaker.Actions.GetChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Alert Range New" |   |   |
| withTag |   | "Untagged" | Tag |   |
| storeResult |   | GameObject Alerter | Variable |   |

##### 12. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Blank" |   |   |

##### 13. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Start Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 14. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| gravityScale |   | 0f |   |   |

##### 15. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Start X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 16. StopWalker

Full Name: StopWalker
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

##### 17. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Dormant | 0 | |

### Dormant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Blank" |   |   |

##### 2. GGCheckIfBossScene

Full Name: GGCheckIfBossScene
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| bossSceneEvent |   | Event(GG BOSS) |   |   |
| regularSceneEvent |   | Event() |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| WAKE | Wake | 0 | |
| GG BOSS | GG Wake | 0 | |

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
| gameObject |   | OwnerDefault Alerter |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: Battle Control]:Battle Scene |   |   |
| sendEvent |   | "START" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Intro Jump" |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.166f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Wake Jump | 0 | |

### Wake Jump

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [mawlek_jump_offscreen (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [mawlek_jump (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Jump Dust (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -1.2, 0.003) |   |   |
| rotation |   | Vector3(-90, -90, 0) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 4. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| angle |   | 90f |   |   |
| speed |   | 53f |   |   |
| everyFrame |   | false |   |   |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "AverageShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Wake In Air | 0 | |

### Wake In Air

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| id |   | "" |   |   |
| vector |   | Vector3(0, 0, -3.16) |   |   |
| time |   | 0.5f |   |   |
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

##### 2. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| gravityScale |   | 3f |   |   |

##### 3. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event(LANDED) |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 4. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event(LANDED) |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LANDED | Wake Land | 0 | |

### Wake Land

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
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [zombie_guard_club (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Intro Land" |   |   |

##### 4. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Slam Effect R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -0.6, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

##### 6. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Dust Land Large (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -1.62, 0) |   |   |
| rotation |   | Vector3(-84, 180, 180) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "BigShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 8. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Small (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -0.5, 0) |   |   |
| spawnMin |   | 30 |   |   |
| spawnMax |   | 30 |   |   |
| speedMin |   | 15f |   |   |
| speedMax |   | 30f |   |   |
| angleMin |   | 30f |   |   |
| angleMax |   | 150f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 9. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Large (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -0.5, 0) |   |   |
| spawnMin |   | 10 |   |   |
| spawnMax |   | 10 |   |   |
| speedMin |   | 15f |   |   |
| speedMax |   | 30f |   |   |
| angleMin |   | 30f |   |   |
| angleMax |   | 150f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 10. SetVelocity2d

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
| FINISHED | Title | 0 | |

### Wake Roar

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| fsmName |   | "Roar Lock" | FsmName |   |
| variableName |   | "Roar Object" | FsmGameObject |   |
| setValue |   | GameObject Self |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hero |   |   |
| sendEvent |   | "ROAR ENTER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Roar Wave Emitter (Hollow Knight/hollow_knight_Data\sharedassets13.assets)] |   |   |
| spawnPoint |   | GameObject Head |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Roar Emitter | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 4. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Roar Emitter |   |   |
| parent |   | GameObject Head |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [mawlek_scream (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets45.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Roar" |   |   |

##### 7. SpawnBloodTime

Full Name: SpawnBloodTime
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| delay |   | 0.1f |   |   |
| spawnPoint |   | GameObject Head |   |   |
| position |   | Vector3(0, 0, 0.002) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 2 |   |   |
| speedMin |   | 20f |   |   |
| speedMax |   | 30f |   |   |
| angleMin |   | 75f |   |   |
| angleMax |   | 105f |   |   |
| colorOverride |   | Color(0, 0, 0, 1) |   |   |

##### 8. Wait

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
| FINISHED | Roar End | 0 | |

### Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Blank" |   |   |

##### 2. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Head |   |   |
| active |   | true |   |   |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Super Repeated | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:FSM Owner |   |   |
| sendEvent |   | Event(WAKE) |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. SetInvincible

Full Name: SetInvincible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| Invincible |   | false |   |   |
| InvincibleFromDirection |   | 0 |   |   |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Body Idle" |   |   |

##### 7. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

##### 8. StartWalker

Full Name: StartWalker
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| walkRight |   | false |   |   |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Roar End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Roar Emitter |   |   |
| sendEvent |   | "END" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hero |   |   |
| sendEvent |   | "ROAR EXIT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Roar Cooldown" |   |   |

##### 4. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Music | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 2f |   |   |
| max |   | 3f |   |   |
| storeResult |   | float Super Wait | Variable |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | float Super Wait |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Super Ready | 0 | |

### Super Ready

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. StopWalker

Full Name: StopWalker
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Arm L |   |   |
| fsmName |   | "Mawlek Arm Control" | FsmName |   |
| variableName |   | "Active" | FsmBool |   |
| storeValue |   | bool Active L | Variable |   |
| everyFrame |   | true |   |   |

##### 3. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Arm R |   |   |
| fsmName |   | "Mawlek Arm Control" | FsmName |   |
| variableName |   | "Active" | FsmBool |   |
| storeValue |   | bool Active R | Variable |   |
| everyFrame |   | true |   |   |

##### 4. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Head |   |   |
| fsmName |   | "Mawlek Head" | FsmName |   |
| variableName |   | "Active" | FsmBool |   |
| storeValue |   | bool Active H | Variable |   |
| everyFrame |   | true |   |   |

##### 5. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Body Idle" |   |   |

##### 7. BoolNoneTrue

Full Name: HutongGames.PlayMaker.Actions.BoolNoneTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(FINISHED) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Super Select | 0 | |

### Super Select

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Head |   |   |
| active |   | false |   |   |

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
| TRUE | Detect Hero Pos 2 | 0 | |
| FALSE | Super Jump | 0 | |

### Super Spit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [mawlek_big_spit (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:FSM Owner |   |   |
| sendEvent |   | "SLEEP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Blank" |   |   |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 5. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Shoot Antic" |   |   |

##### 6. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect Hero Pos | 0 | |

### Shoot

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Spit Effect |   |   |
| sendEvent |   | "PLAY" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Shot Mawlek NoDrip (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0.5, 0) |   |   |
| spawnMin |   | 25 |   |   |
| spawnMax |   | 25 |   |   |
| speedMin |   | float Shot Speed |   |   |
| speedMax |   | float Shot Speed Max |   |   |
| angleMin |   | float Angle Min |   |   |
| angleMax |   | float Angle Max |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 3. SpawnRandomObjects

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjects
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Shot Mawlek (Hollow Knight/hollow_knight_Data\sharedassets32.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0.5, 0) |   |   |
| spawnMin |   | 25 |   |   |
| spawnMax |   | 25 |   |   |
| speedMin |   | float Shot Speed |   |   |
| speedMax |   | float Shot Speed Max |   |   |
| angleMin |   | float Angle Min |   |   |
| angleMax |   | float Angle Max |   |   |
| originVariation |   | 0f |   |   |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Shoot" |   |   |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Cooldown Time | Variable |   |
| floatValue |   | 1.75f |   |   |
| everyFrame |   | false |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Super Cooldown | 0 | |

### Detect Hero Pos

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Hero X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Self X |   |   |
| float2 |   | float Hero X |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event(LEFT) |   |   |
| lessThan |   | Event(RIGHT) |   |   |
| greaterThan |   | Event(LEFT) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEFT | L | 0 | |
| RIGHT | R | 0 | |

### L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Min | Variable |   |
| floatValue |   | 92f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Max | Variable |   |
| floatValue |   | 105f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Shoot | 0 | |

### R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Min | Variable |   |
| floatValue |   | 75f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle Max | Variable |   |
| floatValue |   | 88f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Shoot | 0 | |

### Super Cooldown

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Body Idle" |   |   |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Blank" |   |   |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Arm L |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Arm Idle" |   |   |

##### 5. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Arm R |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Arm Idle" |   |   |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Head |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Head Idle" |   |   |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | float Cooldown Time |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Repeat Check | 0 | |

### Super Jump

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Jumps In A Row |   |   |
| integer2 |   | 3 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(FALSE) |   |   |
| everyFrame |   | false |   |   |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Jumps In A Row | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Spits In A Row | Variable |   |
| intValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:FSM Owner |   |   |
| sendEvent |   | "SLEEP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Blank" |   |   |

##### 6. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Jump Antic" |   |   |

##### 8. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect Hero Pos 3 | 0 | |
| FALSE | Detect Hero Pos 2 | 0 | |

### Detect Hero Pos 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Spits In A Row |   |   |
| integer2 |   | 3 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(FALSE) |   |   |
| everyFrame |   | false |   |   |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Spits In A Row | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Jumps In A Row | Variable |   |
| intValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 5. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Hero X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 6. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Self X |   |   |
| float2 |   | float Hero X |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event(LEFT) |   |   |
| lessThan |   | Event(RIGHT) |   |   |
| greaterThan |   | Event(LEFT) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEFT | L 2 | 0 | |
| RIGHT | R 2 | 0 | |
| FALSE | Super Jump | 0 | |

### L 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Super Spit | 0 | |

### R 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | -1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Super Spit | 0 | |

### Detect Hero Pos 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Hero X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Distance | Variable |   |
| floatValue |   | float Hero X |   |   |
| everyFrame |   | false |   |   |

##### 4. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Distance | Variable |   |
| subtract |   | float Self X |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 5. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Distance | Variable |   |
| multiplyBy |   | 1.25f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Distance Neg | Variable |   |
| floatValue |   | float X Distance |   |   |
| everyFrame |   | false |   |   |

##### 7. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Distance Neg | Variable |   |
| multiplyBy |   | -1f |   |   |
| everyFrame |   | false |   |   |

##### 8. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Self X |   |   |
| float2 |   | float Hero X |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event(LEFT) |   |   |
| lessThan |   | Event(RIGHT) |   |   |
| greaterThan |   | Event(LEFT) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEFT | L 3 | 0 | |
| RIGHT | R 3 | 0 | |

### L 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | -1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Return Right | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Jump | 0 | |

### R 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Return Right | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Jump | 0 | |

### In Air

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float X Distance |   |   |
| y |   | 68f |   |   |
| everyFrame |   | true |   |   |

##### 2. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event(LANDED) |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 3. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event(LANDED) |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LANDED | Land | 0 | |

### Land

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [zombie_guard_club (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 1.15f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Land" |   |   |

##### 4. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Slam Effect R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -0.6, -0.001) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

##### 5. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust Land Large |   |   |
| emit |   | 0 |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "AverageShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | Event(LANDED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LANDED | Aim Return | 0 | |

### Jump

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [mawlek_jump (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 1.15f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Jump" |   |   |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float X Distance |   |   |
| y |   | 68f |   |   |
| everyFrame |   | false |   |   |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Dust Land Large (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -0.6, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 5. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Jump Trail |   |   |
| emit |   | 0 |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | In Air | 0 | |

### L 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Return Right | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Jump 2 | 0 | |

### R 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | -1f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Return Right | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Jump 2 | 0 | |

### In Air 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float X Distance |   |   |
| y |   | 68f |   |   |
| everyFrame |   | true |   |   |

##### 2. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event(LANDED) |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 3. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event() |   |   |
| bottomHitEvent |   | Event(LANDED) |   |   |
| leftHitEvent |   | Event() |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LANDED | Land 2 | 0 | |

### Land 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [zombie_guard_club (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 1.15f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Intro Land" |   |   |

##### 4. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Slam Effect R (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -0.6, -0.001) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |

##### 5. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust Land Large |   |   |
| emit |   | 0 |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "AverageShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Cooldown Time | Variable |   |
| floatValue |   | 0.25f |   |   |
| everyFrame |   | false |   |   |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.25f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Super Cooldown | 0 | |

### Jump 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [mawlek_jump (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 1.15f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Jump" |   |   |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float X Distance |   |   |
| y |   | 68f |   |   |
| everyFrame |   | false |   |   |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Dust Land Large (Hollow Knight/hollow_knight_Data\sharedassets34.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -0.6, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 5. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Jump Trail |   |   |
| emit |   | 0 |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | In Air 2 | 0 | |

### Repeat Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Super Repeated | Variable |   |
| isTrue |   | Event(FALSE) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 0f |   |   |
| max |   | 100f |   |   |
| storeResult |   | float Chooser Float | Variable |   |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Chooser Float |   |   |
| float2 |   | 75f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event(FALSE) |   |   |
| lessThan |   | Event(FALSE) |   |   |
| greaterThan |   | Event(TRUE) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TRUE | Set Repeater | 0 | |
| FALSE | Start | 0 | |

### Pause

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
| FINISHED | Init | 0 | |

### Set Repeater

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Super Repeated | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Super Ready | 0 | |

### Music

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GGCheckIfBossScene

Full Name: GGCheckIfBossScene
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| bossSceneEvent |   | Event(FINISHED) |   |   |
| regularSceneEvent |   | Event() |   |   |

##### 2. ApplyMusicCue

Full Name: HutongGames.PlayMaker.Actions.ApplyMusicCue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| musicCue |   | [EnemyBattle (Script MusicCue) (Hollow Knight/hollow_knight_Data\sharedassets40.assets)] |   |   |
| delayTime |   | 0f |   |   |
| transitionTime |   | 0f |   |   |

##### 3. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot |   | [Normal (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| transitionTime |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Start | 0 | |

### Aim Return

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Self X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Hero X | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Distance | Variable |   |
| floatValue |   | float Start X |   |   |
| everyFrame |   | false |   |   |

##### 4. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Distance | Variable |   |
| subtract |   | float Self X |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 5. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Distance | Variable |   |
| multiplyBy |   | 1.25f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Distance Neg | Variable |   |
| floatValue |   | float X Distance |   |   |
| everyFrame |   | false |   |   |

##### 7. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float X Distance Neg | Variable |   |
| multiplyBy |   | -1f |   |   |
| everyFrame |   | false |   |   |

##### 8. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Distance |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event(LEFT) |   |   |
| lessThan |   | Event(RIGHT) |   |   |
| greaterThan |   | Event(RIGHT) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEFT | L 4 | 0 | |
| RIGHT | R 4 | 0 | |

### GG Wake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dummy |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Dummy Intro Jump" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Wake In Air | 0 | |

### Title

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Skip Title | Variable |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | GameObject Area Title | Variable |   |
| gameObject |   | [Global] GameObject AreaTitle |   |   |
| everyFrame |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Area Title |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Area Title |   |   |
| fsmName |   | "" | FsmName |   |
| variableName |   | "Visited" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Area Title |   |   |
| fsmName |   | "" | FsmName |   |
| variableName |   | "Display Right" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Area Title |   |   |
| fsmName |   | "" | FsmName |   |
| variableName |   | "Area Event" | FsmString |   |
| setValue |   | "MAWLEK" |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Wake Roar | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FALSE | false |
| FINISHED | false |
| GG BOSS | false |
| LANDED | false |
| LEFT | false |
| MOVESTART | true |
| MOVESTOP | true |
| RIGHT | false |
| TRUE | false |
| WAKE | true |

