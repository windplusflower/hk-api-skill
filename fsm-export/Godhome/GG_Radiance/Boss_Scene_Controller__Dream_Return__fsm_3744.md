# Dream Return

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Dream Return |
| GameObject Name | Boss Scene Controller |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level459.assets |
| Start State | Idle |
| FSM PathId | 3744 |
| GameObject PathId | 833 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cinematic Scene |  | String:  |
| Entry Gate |  | String:  |
| Return Scene | Crossroads_10 | String: Crossroads_10 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dream Fall Catcher | [null] | NamedAssetPPtr:  |

## States

### Fade Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):MainCamera | EventTarget(GameObject):MainCamera |  |  |
| sendEvent | "FADE OUT INSTANT" | "FADE OUT INSTANT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Blanker White | OwnerDefault HUD Blanker White |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker White | EventTarget(GameObject):HUD Blanker White |  |  |
| sendEvent | "FADE IN" | "FADE IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### New Scene

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Canvas | EventTarget(GameObject):HUD Canvas |  |  |
| sendEvent | "OUT" | "OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControl(???) | RelinquishControl(???) |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "EnterWithoutInput" | "EnterWithoutInput" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 5. BeginSceneTransition

Full Name: HutongGames.PlayMaker.Actions.BeginSceneTransition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sceneName | string Return Scene = "Crossroads_10" | string Return Scene = "Crossroads_10" |  |  |
| entryGateName | string Entry Gate | string Entry Gate |  |  |
| entryDelay | 0f | 0f |  |  |
| visualization | Enum(GameManager+SceneLoadVisualizations, 5) | Enum(GameManager+SceneLoadVisualizations, 5) |  |  |
| preventCameraFadeOut | true | true |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

_None_

### Get PlayerData

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault MainCamera | OwnerDefault MainCamera |  |  |
| fsmName | "CameraFade" | "CameraFade" | FsmName |  |
| variableName | "No Fade" | "No Fade" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. GetPlayerDataString

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| stringName | "bossReturnEntryGate" | "bossReturnEntryGate" |  |  |
| storeValue | string Entry Gate | string Entry Gate | Variable |  |

##### 3. SetStaticVariable

Full Name: SetStaticVariable
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "finishedBossReturning" | "finishedBossReturning" |  |  |
| setValue | Var unnamed = True | Var unnamed = True |  |  |

##### 4. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

### Statue

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Return" | "Dream Return" | FsmName |  |
| variableName | "Dream Returning" | "Dream Returning" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. GetPlayerDataString

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| stringName | "dreamReturnScene" | "dreamReturnScene" |  |  |
| storeValue | string Return Scene = "Crossroads_10" | string Return Scene = "Crossroads_10" | Variable |  |

### Door

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetStaticVariable

Full Name: GetStaticVariable
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "ggEndScene" | "ggEndScene" |  |  |
| storeValue | Var Return Scene = Crossroads_10 | Var Return Scene = Crossroads_10 | Variable |  |

### Heal

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
| methodName | "MaxHealth" | "MaxHealth" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Cinematic?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CheckStaticBool

Full Name: CheckStaticBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "ggCinematicEnding" | "ggCinematicEnding" |  |  |
| trueEvent | CINEMATIC | CINEMATIC |  |  |
| falseEvent | FINISHED | FINISHED |  |  |

### Cinematic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetStaticVariable

Full Name: SetStaticVariable
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "ggCinematicEnding" | "ggCinematicEnding" |  |  |
| setValue | Var unnamed = False | Var unnamed = False |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "givenGodseekerFlower" | "givenGodseekerFlower" |  |  |
| isTrue | ENDING E | ENDING E |  |  |
| isFalse | ENDING D | ENDING D |  |  |

### Change Scene

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetStaticVariable

Full Name: SetStaticVariable
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "skipEndWhiteFader" | "skipEndWhiteFader" |  |  |
| setValue | Var unnamed = True | Var unnamed = True |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "ChangeToScene" | "ChangeToScene" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

### Get Scene D

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetConstantsValue

Full Name: GetConstantsValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "ENDING_D_CINEMATIC" | "ENDING_D_CINEMATIC" |  |  |
| storeValue | Var Cinematic Scene =  | Var Cinematic Scene =  | Variable |  |

### Get Scene E

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetConstantsValue

Full Name: GetConstantsValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName | "ENDING_E_CINEMATIC" | "ENDING_E_CINEMATIC" |  |  |
| storeValue | Var Cinematic Scene =  | Var Cinematic Scene =  | Variable |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Fade Out | FINISHED | Heal | 0 | 0 | 0 |
| Idle | DREAM EXIT | Cinematic? | 0 | 0 | 0 |
| Idle | DREAM RETURN | Statue | 0 | 0 | 0 |
| Get PlayerData | FINISHED | New Scene | 0 | 0 | 0 |
| Statue | FINISHED | Fade Out | 0 | 0 | 0 |
| Door | FINISHED | Get PlayerData | 0 | 0 | 0 |
| Heal | FINISHED | Get PlayerData | 0 | 0 | 0 |
| Cinematic? | CINEMATIC | Cinematic | 0 | 0 | 0 |
| Cinematic? | FINISHED | Door | 0 | 0 | 0 |
| Cinematic | ENDING D | Get Scene D | 0 | 0 | 0 |
| Cinematic | ENDING E | Get Scene E | 0 | 0 | 0 |
| Get Scene D | FINISHED | Change Scene | 0 | 0 | 0 |
| Get Scene E | FINISHED | Change Scene | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CINEMATIC | false |
| DREAM EXIT | false |
| DREAM RETURN | false |
| ENDING D | false |
| ENDING E | false |

