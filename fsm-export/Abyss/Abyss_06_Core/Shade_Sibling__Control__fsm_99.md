# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Shade Sibling |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets |
| Start State | Pause |
| FSM PathId | 99 |
| GameObject PathId | 52 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Max Speed | 0 | Single: 0 |
| Tween Distance | 0 | Single: 0 |
| Tween Time | 0 | Single: 0 |
| Unalert Timer | 0 | Single: 0 |
| zPos | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| PD Kills | 0 | Int32: 0 |
| Royal Charm State | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alert Range | false | Boolean: false |
| Friendly | false | Boolean: false |
| No Spawn | false | Boolean: false |
| Out of Alert | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Fly Anim |  | String:  |
| Number |  | String:  |
| PD Killed Name |  | String:  |
| PlayerData Name | Sibling | String: Sibling |
| Startle Anim |  | String:  |
| Turn Anim |  | String:  |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Tween Vector | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alert Range Obj | Shade Sibling/Alert Range (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) | NamedAssetPPtr: Shade Sibling/Alert Range (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) |
| Death Wave | Shade Sibling/Death Wave (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) | NamedAssetPPtr: Shade Sibling/Death Wave (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) |
| Enemy Pusher | Shade Sibling/Enemy Pusher (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) | NamedAssetPPtr: Shade Sibling/Enemy Pusher (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) |
| Light | Shade Sibling/Light (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) | NamedAssetPPtr: Shade Sibling/Light (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) |
| Msg | [null] | NamedAssetPPtr:  |
| Pt Emerge | Shade Sibling/Pt Emerge (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) | NamedAssetPPtr: Shade Sibling/Pt Emerge (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) |
| Self | [null] | NamedAssetPPtr:  |
| Shade Particles | Shade Sibling/Shade Particles (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) | NamedAssetPPtr: Shade Sibling/Shade Particles (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) |
| Terrain Block | Shade Sibling/Terrain Block (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) | NamedAssetPPtr: Shade Sibling/Terrain Block (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets334.assets) |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SelectRandomString

Full Name: HutongGames.PlayMaker.Actions.SelectRandomString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| strings | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeString | string Number | string Number | Variable |  |

##### 2. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Fly Anim | string Fly Anim | Variable |  |
| everyFrame | false | false |  |  |

##### 3. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Startle Anim | string Startle Anim | Variable |  |
| everyFrame | false | false |  |  |

##### 4. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string Turn Anim | string Turn Anim | Variable |  |
| everyFrame | false | false |  |  |

##### 5. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Blob" | "Blob" |  |  |

##### 6. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 7. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 8. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Pusher | OwnerDefault Enemy Pusher |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 9. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Light | OwnerDefault Light |  |  |
| active | true | true |  |  |

##### 10. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool No Spawn | bool No Spawn | Variable |  |
| isTrue | Event(NO SPAWN) | Event(NO SPAWN) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Blob Up

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
| clipName | "Blob" | "Blob" |  |  |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 6f | 6f |  |  |
| max | 7f | 7f |  |  |
| storeResult | float Tween Distance | float Tween Distance | Variable |  |

##### 3. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.75f | 0.75f |  |  |
| max | 1.25f | 1.25f |  |  |
| storeResult | float Tween Time | float Tween Time | Variable |  |

##### 4. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Tween Vector | Vector3 Tween Vector | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Tween Distance | float Tween Distance |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| vector | Vector3 Tween Vector | Vector3 Tween Vector |  |  |
| time | float Tween Time | float Tween Time |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::easeOutCubic | 4 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 6. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [hollow_shade_startle (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hollow_shade_startle (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 0.8f | 0.8f |  |  |
| pitchMax | 0.9f | 0.9f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 7. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [shadow_gate_pass_through (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets208.assets)] | [shadow_gate_pass_through (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets208.assets)] |  |  |
| pitchMin | 1.1f | 1.1f |  |  |
| pitchMax | 1.2f | 1.2f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Form

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
| clipName | "Form" | "Form" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

##### 3. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.005f | 0.005f |  |  |
| max | 0.009f | 0.009f |  |  |
| storeResult | float zPos | float zPos | Variable |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | float zPos | float zPos |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Idle

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
| clipName | string Fly Anim | string Fly Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. SetIsKinematic2d

Full Name: HutongGames.PlayMaker.Actions.SetIsKinematic2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| isKinematic | false | false |  |  |

##### 3. IdleBuzzV3

Full Name: HutongGames.PlayMaker.Actions.IdleBuzzV3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| waitMin | 0.75f | 0.75f |  |  |
| waitMax | 1f | 1f |  |  |
| speedMax | 1.75f | 1.75f |  |  |
| accelerationMin | 5f | 5f |  |  |
| accelerationMax | 20f | 20f |  |  |
| roamingRangeX | 3f | 3f |  |  |
| roamingRangeY | 3f | 3f |  |  |
| manualStartPos | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |

##### 4. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | string Turn Anim | string Turn Anim |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | true | true |  |  |
| pauseTime | 0.5f | 0.5f |  |  |

##### 5. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Pusher | OwnerDefault Enemy Pusher |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Terrain Block | OwnerDefault Terrain Block |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 8. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Alert Range | bool Alert Range | Variable |  |
| isTrue | Event(ALERT) | Event(ALERT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

### Startle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Friendly | bool Friendly | Variable |  |
| isTrue | Event(FRIENDLY) | Event(FRIENDLY) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. FaceObject

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

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | string Startle Anim | string Startle Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Unalert Timer | float Unalert Timer | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. BehaviourListAdd

Full Name: BehaviourListAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| owner | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

### Chase

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
| clipName | string Fly Anim | string Fly Anim |  |  |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 3.5f | 3.5f |  |  |
| max | 5f | 5f |  |  |
| storeResult | float Max Speed | float Max Speed | Variable |  |

##### 3. ChaseObject

Full Name: HutongGames.PlayMaker.Actions.ChaseObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| speedMax | float Max Speed | float Max Speed |  |  |
| acceleration | 0.2f | 0.2f |  |  |
| targetSpread | 1f | 1f |  |  |
| spreadResetTimeMin | 1f | 1f |  |  |
| spreadResetTimeMax | 3f | 3f |  |  |

##### 4. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | string Turn Anim | string Turn Anim |  |  |
| resetFrame | true | true |  |  |
| everyFrame | true | true |  |  |

##### 5. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Out of Alert | bool Out of Alert | Variable |  |
| boolValue | bool Alert Range | bool Alert Range |  |  |
| everyFrame | true | true |  |  |

##### 6. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Out of Alert | bool Out of Alert | Variable |  |
| everyFrame | true | true |  |  |

##### 7. FloatAddV2

Full Name: HutongGames.PlayMaker.Actions.FloatAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Unalert Timer | float Unalert Timer | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |
| fixedUpdate | false | false |  |  |
| activeBool | bool Out of Alert | bool Out of Alert | Variable |  |

##### 8. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Unalert Timer | float Unalert Timer |  |  |
| float2 | 8f | 8f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(UNALERT) | Event(UNALERT) |  |  |
| everyFrame | true | true |  |  |

### Chase End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | string Turn Anim | string Turn Anim |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | true | true |  |  |
| pauseTime | 0.5f | 0.5f |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 3. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.85f | 0.85f |  |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Alert Range | bool Alert Range | Variable |  |
| isTrue | Event(ALERT) | Event(ALERT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

### Death

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
| clipName | "Blob" | "Blob" |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Terrain Block | OwnerDefault Terrain Block |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.6f | 0.6f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 4. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Light | EventTarget(GameObject):Light |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Retreat

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenMoveBy

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveBy
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| vector | Vector3(0, -50, 0) | Vector3(0, -50, 0) |  |  |
| time | 2f | 2f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::easeInCubic | 3 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Recycle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool No Spawn | bool No Spawn | Variable |  |
| isTrue | Event(NO SPAWN) | Event(NO SPAWN) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. SetHP

Full Name: SetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| hp | 20 | 20 |  |  |

##### 3. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### Journal Entry?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PD Killed Name | string PD Killed Name | Variable |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | string PD Killed Name | string PD Killed Name |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string PD Killed Name | string PD Killed Name |  |  |
| value | true | true |  |  |

##### 4. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PD Killed Name | string PD Killed Name | Variable |  |
| everyFrame | false | false |  |  |

##### 5. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string PD Killed Name | string PD Killed Name |  |  |
| value | true | true |  |  |

##### 6. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasJournal" | "hasJournal" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 7. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PD Killed Name | string PD Killed Name | Variable |  |
| everyFrame | false | false |  |  |

##### 8. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | string PD Killed Name | string PD Killed Name |  |  |
| storeValue | int PD Kills | int PD Kills | Variable |  |

##### 9. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int PD Kills | int PD Kills |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll)[ExcludeSelf]:FSM Owner | EventTarget(BroadcastAll)[ExcludeSelf]:FSM Owner |  |  |
| sendEvent | "DESTROY JOURNAL MSG" | "DESTROY JOURNAL MSG" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 11. IncrementPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.IncrementPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "journalEntriesCompleted" | "journalEntriesCompleted" |  |  |

##### 12. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Journal Update Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Journal Update Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

### Journal Update?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PD Killed Name | string PD Killed Name | Variable |  |
| everyFrame | false | false |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | string PD Killed Name | string PD Killed Name |  |  |
| storeValue | int PD Kills | int PD Kills | Variable |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int PD Kills | int PD Kills |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int PD Kills | int PD Kills | Variable |  |
| add | -1 | -1 |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | string PD Killed Name | string PD Killed Name |  |  |
| value | int PD Kills | int PD Kills |  |  |

##### 6. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int PD Kills | int PD Kills |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 7. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PD Killed Name | string PD Killed Name | Variable |  |
| everyFrame | false | false |  |  |

##### 8. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string PD Killed Name | string PD Killed Name |  |  |
| value | true | true |  |  |

##### 9. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasJournal" | "hasJournal" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll)[ExcludeSelf]:FSM Owner | EventTarget(BroadcastAll)[ExcludeSelf]:FSM Owner |  |  |
| sendEvent | "DESTROY JOURNAL MSG" | "DESTROY JOURNAL MSG" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 11. IncrementPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.IncrementPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "journalNotesCompleted" | "journalNotesCompleted" |  |  |

##### 12. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Journal Update Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Journal Update Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Msg | GameObject Msg | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 13. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg | OwnerDefault Msg |  |  |
| fsmName | "Journal Msg" | "Journal Msg" | FsmName |  |
| variableName | "Full" | "Full" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Disable Collider

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

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "CANCEL RECOIL" | "CANCEL RECOIL" |  |  |
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

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Pusher | OwnerDefault Enemy Pusher |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. WaitForFinishedEnteringScene

Full Name: WaitForFinishedEnteringScene
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Friendly?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetHP

Full Name: SetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| hp | 20 | 20 |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Friendly | bool Friendly | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "royalCharmState" | "royalCharmState" |  |  |
| storeValue | int Royal Charm State | int Royal Charm State | Variable |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Royal Charm State | int Royal Charm State |  |  |
| integer2 | 4 | 4 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 5. SetDamageHeroAmount

Full Name: SetDamageHeroAmount
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| damageDealt | 0 | 0 |  |  |

##### 6. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Alert Range Obj | OwnerDefault Alert Range Obj |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.5f | 0.5f |  |  |
| y | 0.5f | 0.5f |  |  |
| z | 0.5f | 0.5f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 7. SetHP

Full Name: SetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| hp | 1 | 1 |  |  |

##### 8. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Friendly | bool Friendly | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### F Approach

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Fly Anim | string Fly Anim |  |  |

##### 2. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.85f | 0.85f |  |  |

##### 3. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 2.5f | 2.5f |  |  |
| max | 3.5f | 3.5f |  |  |
| storeResult | float Max Speed | float Max Speed | Variable |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | string Turn Anim | string Turn Anim |  |  |
| resetFrame | true | true |  |  |
| everyFrame | true | true |  |  |

##### 6. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Out of Alert | bool Out of Alert | Variable |  |
| boolValue | bool Alert Range | bool Alert Range |  |  |
| everyFrame | true | true |  |  |

##### 7. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Out of Alert | bool Out of Alert | Variable |  |
| everyFrame | true | true |  |  |

##### 8. FloatAddV2

Full Name: HutongGames.PlayMaker.Actions.FloatAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Unalert Timer | float Unalert Timer | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |
| fixedUpdate | false | false |  |  |
| activeBool | bool Out of Alert | bool Out of Alert | Variable |  |

### Approach End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | string Turn Anim | string Turn Anim |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | true | true |  |  |
| pauseTime | 0.5f | 0.5f |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 3. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| deceleration | 0.85f | 0.85f |  |  |

### Explode

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

##### 2. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Death Wave | OwnerDefault Death Wave |  |  |
| emit | 0 | 0 |  |  |

##### 3. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

### Unform

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Terrain Block | OwnerDefault Terrain Block |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Unform" | "Unform" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

### Audio

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.005f | 0.005f |  |  |
| max | 0.009f | 0.009f |  |  |
| storeResult | float zPos | float zPos | Variable |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | float zPos | float zPos |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

### Loop Pause

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

### Force End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Alert Range | bool Alert Range | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3f | 3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Remove From List

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BehaviourListRemove

Full Name: BehaviourListRemove
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| owner | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Blob Up | 0 | 0 | 0 |
| Init | NO SPAWN | Audio | 0 | 0 | 0 |
| Blob Up | FINISHED | Form | 0 | 0 | 0 |
| Form | FINISHED | Idle | 0 | 0 | 0 |
| Idle | ALERT | Startle | 0 | 0 | 0 |
| Startle | FINISHED | Chase | 0 | 0 | 0 |
| Startle | FRIENDLY | F Approach | 0 | 0 | 0 |
| Chase | UNALERT | Chase End | 0 | 0 | 0 |
| Chase End | FINISHED | Remove From List | 0 | 0 | 0 |
| Chase End | ALERT | Loop Pause | 0 | 0 | 0 |
| Death | FINISHED | Disable Collider | 0 | 0 | 0 |
| Retreat | FINISHED | Recycle | 0 | 0 | 0 |
| Recycle | NO SPAWN | Destroy | 0 | 0 | 0 |
| Journal Entry? | FINISHED | Journal Update? | 0 | 0 | 0 |
| Journal Update? | FINISHED | Explode | 0 | 0 | 0 |
| Disable Collider | FINISHED | Retreat | 0 | 0 | 0 |
| Pause | FINISHED | Friendly? | 0 | 0 | 0 |
| Friendly? | FINISHED | Init | 0 | 0 | 0 |
| F Approach | UNALERT | Approach End | 0 | 0 | 0 |
| F Approach | FINISHED | Unform | 0 | 0 | 0 |
| Approach End | FINISHED | Idle | 0 | 0 | 0 |
| Explode | FINISHED | Death | 0 | 0 | 0 |
| Unform | FINISHED | Death | 0 | 0 | 0 |
| Audio | FINISHED | Idle | 0 | 0 | 0 |
| Loop Pause | FINISHED | Chase | 0 | 0 | 0 |
| Force End | FINISHED | Idle | 0 | 0 | 0 |
| Remove From List | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| ZERO HP | Journal Entry? | 0 | 0 | 0 |
| REMOVE | Force End | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ALERT | true |
| FRIENDLY | false |
| NO SPAWN | false |
| REMOVE | true |
| UNALERT | false |
| ZERO HP | false |

