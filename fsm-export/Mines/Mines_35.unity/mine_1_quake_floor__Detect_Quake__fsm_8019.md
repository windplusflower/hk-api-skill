# Detect Quake

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Detect Quake |
| GameObject Name | mine_1_quake_floor |
| GameObject Path | _Scenery/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level274 |
| Start State | Pause |
| FSM PathId | 8019 |
| GameObject PathId | 370 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activated | false | Boolean: false |
| Quaking | true | Boolean: true |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bot 1 | _Scenery/mine_1_quake_floor/Bot 1 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Bot 1 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Bot 2 | _Scenery/mine_1_quake_floor/Bot 2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Bot 2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Bot 3 | _Scenery/mine_1_quake_floor/Bot 3 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Bot 3 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Cracks 1 | _Scenery/mine_1_quake_floor/Cracks 1 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Cracks 1 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Cracks 2 | _Scenery/mine_1_quake_floor/Cracks 2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Cracks 2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Dust Break 1 | _Scenery/mine_1_quake_floor/Dust Break 1 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Dust Break 1 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Dust Break 2 | _Scenery/mine_1_quake_floor/Dust Break 2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Dust Break 2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Effect Centre | _Scenery/mine_1_quake_floor/Effect Centre (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Effect Centre (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Floor 1 | _Scenery/mine_1_quake_floor/Loose Floor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Loose Floor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Floor 2 | _Scenery/mine_1_quake_floor/Loose Floor 1 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Loose Floor 1 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Floor 3 | _Scenery/mine_1_quake_floor/Loose Floor 2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Loose Floor 2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |
| Hero Obj | [null] | NamedAssetPPtr: [null] |
| Quaked Floor | _Scenery/mine_1_quake_floor/Quaked Floor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274) | NamedAssetPPtr: [_Scenery/mine_1_quake_floor/Quaked Floor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| isTrue |   | Event(ACTIVATE) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect | 0 | |
| ACTIVATE | Activate !!! | 0 | |

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
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(CONTACT) |   |   |
| storeCollider |   | GameObject Hero Obj | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CONTACT | Check Quake | 0 | |

### Check Quake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero Obj |   |   |
| behaviour |   | "HeroController" | Behaviour |   |
| methodName |   | "GetState" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var Quaking = True | Variable | Store Result |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Quaking | Variable |   |
| isTrue |   | Event(QUAKE) |   |   |
| isFalse |   | Event(CANCEL) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| QUAKE | Hit Pause | 0 | |
| CANCEL | Detect | 0 | |

### Quake Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [breakable_wall_hit_2 (AudioClip) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets6.assets)] |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 0.85f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Activated | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:FSM Owner |   |   |
| sendEvent |   | "BREAK 1" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Quaked Floor |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust Break 1 |   |   |
| emit |   | 0 |   |   |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cracks 1 |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.85f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Break 2 | 0 | |

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

### Activate !!!

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren |   | false |   |   |

#### Transitions

(none)

### Hit Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

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
| FINISHED | Quake Hit | 0 | |

### Break 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:FSM Owner |   |   |
| sendEvent |   | "BREAK 2" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [breakable_wall_hit_1 (AudioClip) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets6.assets)] |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 0.85f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [break_wall_after_tutorial_area (AudioClip) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets6.assets)] |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 0.85f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Quaked Floor |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [_Scenery/mine_1_quake_floor/Loose Floor (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 6. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [_Scenery/mine_1_quake_floor/Loose Floor 1 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 7. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [_Scenery/mine_1_quake_floor/Loose Floor 2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 8. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [_Scenery/mine_1_quake_floor/Bot 1 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 9. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [_Scenery/mine_1_quake_floor/Bot 2 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 10. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [_Scenery/mine_1_quake_floor/Bot 3 (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |   |   |
| delay |   | 0f |   |   |
| detachChildren |   | false |   |   |

##### 11. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust Break 2 |   |   |
| emit |   | 0 |   |   |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):CameraParent |   |   |
| sendEvent |   | "BigShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 13. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Small (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [_Scenery/mine_1_quake_floor/Effect Centre (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 70 |   |   |
| spawnMax |   | 70 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 10f |   |   |
| angleMin |   | 85f |   |   |
| angleMax |   | 95f |   |   |
| originVariationX |   | 6f |   |   |
| originVariationY |   | 2f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 14. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Large (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [_Scenery/mine_1_quake_floor/Effect Centre (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level274)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 40 |   |   |
| spawnMax |   | 40 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 10f |   |   |
| angleMin |   | 85f |   |   |
| angleMax |   | 95f |   |   |
| originVariationX |   | 6f |   |   |
| originVariationY |   | 2f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 15. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cracks 2 |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ACTIVATE | false |
| CANCEL | false |
| CONTACT | false |
| FINISHED | false |
| QUAKE | false |

