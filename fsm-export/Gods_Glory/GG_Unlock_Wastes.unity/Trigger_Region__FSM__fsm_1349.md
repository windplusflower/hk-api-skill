# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Trigger Region |
| GameObject Path | Sequence/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level500 |
| Start State | Idle |
| FSM PathId | 1349 |
| GameObject PathId | 209 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Anim Wait Time | 1.5 | Single: 1.5 |
| Fade Time | 2 | Single: 2 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Animator | Sequence/Hallownest_call_event (Hollow Knight/hollow_knight_Data\level500) | NamedAssetPPtr: [Sequence/Hallownest_call_event (Hollow Knight/hollow_knight_Data\level500)] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TRIGGER ENTER 2D | Anim | 0 | |

### Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Animator |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| fsmName |   | "Roar Lock" | FsmName |   |
| variableName |   | "Roar Object" | FsmGameObject |   |
| setValue |   | GameObject Self |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hero |   |   |
| sendEvent |   | "ROAR ENTER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | float Anim Wait Time |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fade | 0 | |

### Fade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault HUD Blanker White |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 1.5f |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):HUD Blanker White |   |   |
| sendEvent |   | "FADE IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | float Fade Time |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Godseeker Dialogue | 0 | |

### Godseeker Dialogue

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault DialogueText |   |   |
| color |   | Color(0, 0, 0, 1) |   |   |
| everyFrame |   | false |   |   |

##### 2. SetTextMeshProAlignment

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProAlignment
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault DialogueText |   |   |
| topLeft |   | false |   |   |
| topRight |   | false |   |   |
| topCentre |   | false |   |   |
| topJustified |   | false |   |   |
| centreLeft |   | false |   |   |
| centreRight |   | false |   |   |
| centreCentre |   | true |   |   |
| centreJustified |   | false |   |   |
| bottomLeft |   | false |   |   |
| bottomRight |   | false |   |   |
| bottomCentre |   | false |   |   |
| bottomJustified |   | false |   |   |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault DialogueText |   |   |
| behaviour |   | "DialogueBox" | Behaviour |   |
| methodName |   | "StartConversation" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor 2D (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [GS_standard_06 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets500.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CONVO_FINISH | To Atrium | 0 | |

### To Atrium

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetTextMeshProAlignment

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProAlignment
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault DialogueText |   |   |
| topLeft |   | true |   |   |
| topRight |   | false |   |   |
| topCentre |   | false |   |   |
| topJustified |   | false |   |   |
| centreLeft |   | false |   |   |
| centreRight |   | false |   |   |
| centreCentre |   | false |   |   |
| centreJustified |   | false |   |   |
| bottomLeft |   | false |   |   |
| bottomRight |   | false |   |   |
| bottomCentre |   | false |   |   |
| bottomJustified |   | false |   |   |

##### 2. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault DialogueText |   |   |
| color |   | Color(1, 1, 1, 1) |   |   |
| everyFrame |   | false |   |   |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "seenGGWastes" |   |   |
| value |   | true |   |   |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| behaviour |   | "HeroController" | Behaviour |   |
| methodName |   | "EnterWithoutInput" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var | Variable | Store Result |

##### 5. BeginSceneTransition

Full Name: HutongGames.PlayMaker.Actions.BeginSceneTransition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sceneName |   | "GG_Atrium" |   |   |
| entryGateName |   | "door_dreamEnter" |   |   |
| entryDelay |   | 0f |   |   |
| visualization |   | Enum(GameManager+SceneLoadVisualizations, 5) |   |   |
| preventCameraFadeOut |   | true |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CONVO_FINISH | false |
| FINISHED | false |
| TRIGGER ENTER 2D | false |

