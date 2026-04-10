# GG Boss UI

## Summary

| Field | Value |
| --- | --- |
| FSM Name | GG Boss UI |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets470.assets |
| Start State | Inert |
| FSM PathId | 784 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero X | 0 | Single: 0 |
| Self X | 0 | Single: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Boss Name Key |  | String:  |
| Boss Name Sheet |  | String:  |
| Description Key |  | String:  |
| Description Sheet |  | String:  |
| Return Scene | GG_Workshop | String: GG_Workshop |
| To Scene |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| CamLock | [null] | NamedAssetPPtr:  |
| Hero | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Transitions | [null] | NamedAssetPPtr:  |
| Transitions | [null] | NamedAssetPPtr:  |

## States

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetHero

Full Name: GetHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | GameObject Hero | GameObject Hero | Variable |  |

##### 2. SetGameObjectSelf

Full Name: HutongGames.PlayMaker.Actions.SetGameObjectSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Self | GameObject Self | Variable |  |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| everyFrame | false | false |  |  |

### Open UI

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookUp" | "LookUp" |  |  |

##### 2. ShowBossChallengeUI

Full Name: ShowBossChallengeUI
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| prefab | [Global] [GG_Challenge_Statue_Canvas (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets470.assets)] | [Global] [GG_Challenge_Statue_Canvas (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets470.assets)] |  |  |
| bossNameSheet | string Boss Name Sheet | string Boss Name Sheet |  |  |
| bossNameKey | string Boss Name Key | string Boss Name Key |  |  |
| descriptionSheet | string Description Sheet | string Description Sheet |  |  |
| descriptionKey | string Description Key | string Description Key |  |  |
| levelSelectedEvent | DREAM | DREAM |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault CamLock | OwnerDefault CamLock |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Close UI

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByNameV2

Full Name: HutongGames.PlayMaker.Actions.SendEventByNameV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "CONVO END" | "CONVO END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault CamLock | OwnerDefault CamLock |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Take Control

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "RelinquishControl" | "RelinquishControl" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Nail" | "Dream Nail" | FsmName |  |
| variableName | "Dream Convo" | "Dream Convo" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 4. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### Impact

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "DREAM ENTER" | "DREAM ENTER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

##### 3. SetPlayerDataString

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| stringName | "dreamReturnScene" | "dreamReturnScene" |  |  |
| value | string Return Scene = "GG_Workshop" | string Return Scene = "GG_Workshop" |  |  |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [dream_area_effect (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [dream_area_effect (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 5. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self | Variable |  |
| activate | true | true |  |  |

### Change Scene

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | TimePasses(???) | TimePasses(???) |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | ResetSemiPersistentItems(???) | ResetSemiPersistentItems(???) |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault MainCamera | OwnerDefault MainCamera |  |  |
| fsmName | "CameraFade" | "CameraFade" | FsmName |  |
| variableName | "No Fade" | "No Fade" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | EnterWithoutInput(true) | EnterWithoutInput(true) |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | AcceptInput(???) | AcceptInput(???) |  |  |

##### 6. GetStaticVariable

Full Name: GetStaticVariable
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "bossSceneToLoad" | "bossSceneToLoad" |  |  |
| storeValue | Var To Scene =  | Var To Scene =  | Variable |  |

##### 7. BeginSceneTransition

Full Name: HutongGames.PlayMaker.Actions.BeginSceneTransition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sceneName | string To Scene | string To Scene |  |  |
| entryGateName | "door_dreamEnter" | "door_dreamEnter" |  |  |
| entryDelay | 0f | 0f |  |  |
| visualization | Enum(GameManager+SceneLoadVisualizations, 5) | Enum(GameManager+SceneLoadVisualizations, 5) |  |  |
| preventCameraFadeOut | true | true |  |  |

### Dream Box Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "BOX DOWN DREAM" | "BOX DOWN DREAM" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "CONVO CANCEL" | "CONVO CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Set Facing

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Self X | float Self X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | float Self X | float Self X |  |  |
| tolerance | 0f | 0f |  |  |
| equal | ON LEFT | ON LEFT |  |  |
| lessThan | ON LEFT | ON LEFT |  |  |
| greaterThan | ON RIGHT | ON RIGHT |  |  |
| everyFrame | false | false |  |  |

### On Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | FaceLeft(???) | FaceLeft(???) |  |  |

### On Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | FaceRight(???) | FaceRight(???) |  |  |

### Challenge

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Challenge Start" | "Challenge Start" |  |  |

##### 2. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animationTriggerEvent | FINISHED | FINISHED |  |  |
| animationCompleteEvent |  |  |  |  |

### Challenge Audio

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [hero_unsheath (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets180.assets)] | [hero_unsheath (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets180.assets)] |  |  |
| finishedEvent |  |  |  |  |

##### 2. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

### Transition

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [gg_battle_transitions (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] | [Global] [gg_battle_transitions (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Transitions | GameObject Transitions | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Transitions | EventTarget(GameObject):Transitions |  |  |
| sendEvent | "GG TRANSITION OUT" | "GG TRANSITION OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Reset Player

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "ClearMPSendEvents" | "ClearMPSendEvents" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Open UI | FINISHED | Close UI | 0 | 0 | 0 |
| Open UI | DREAM | Take Control | 0 | 0 | 0 |
| Take Control | FINISHED | Set Facing | 0 | 0 | 0 |
| Impact | FINISHED | Dream Box Down | 0 | 0 | 0 |
| Dream Box Down | FINISHED | Transition | 0 | 0 | 0 |
| Set Facing | ON LEFT | On Left | 0 | 0 | 0 |
| Set Facing | ON RIGHT | On Right | 0 | 0 | 0 |
| On Left | FINISHED | Challenge | 0 | 0 | 0 |
| On Right | FINISHED | Challenge | 0 | 0 | 0 |
| Challenge | FINISHED | Challenge Audio | 0 | 0 | 0 |
| Challenge Audio | FINISHED | Impact | 0 | 0 | 0 |
| Transition | GG TRANSITION END | Reset Player | 0 | 0 | 0 |
| Reset Player | FINISHED | Change Scene | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| CONVO START | Open UI | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CONVO START | false |
| DREAM | false |
| GG TRANSITION END | false |
| ON LEFT | false |
| ON RIGHT | false |
| TRUE | false |

