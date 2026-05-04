# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Subtitle |
| GameObject Path | LogoTitle/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 8103 |
| GameObject PathId | 72 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Text |   | String:  |

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Colour | Color(0, 0, 0, 1) | UnityColor: Color(0, 0, 0, 1) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

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

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fade In | 0 | |

### Fade In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DestroyAllChildren

Full Name: HutongGames.PlayMaker.Actions.DestroyAllChildren
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| disable |   | false |   |   |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName |   | "General" |   |   |
| convName |   | "GAME_DISPLAY_TITLE" |   |   |
| storeValue |   | string Text | Variable |   |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| textString |   | string Text |   |   |

##### 4. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable |   | Color Colour | Variable |   |
| color |   | Color(1, 1, 1, 0) |   |   |
| everyFrame |   | false |   |   |

##### 5. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue |   | Color(1, 1, 1, 0) |   |   |
| toValue |   | Color(1, 1, 1, 1) |   |   |
| colorVariable |   | Color Colour | Variable |   |
| time |   | 0.25f |   |   |
| speed |   | 0f |   |   |
| delay |   | 0f |   |   |
| easeType |   | 21 |   |   |
| reverse |   | false |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 6. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| color |   | Color Colour |   |   |
| everyFrame |   | true |   |   |

##### 7. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| behaviour |   | "ChangeFontByLanguage" | Behaviour |   |
| methodName |   | "SetFont" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var | Variable | Store Result |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE OUT | Fade Out | 0 | |

### Fade Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable |   | Color Colour | Variable |   |
| color |   | Color(1, 1, 1, 1) |   |   |
| everyFrame |   | false |   |   |

##### 2. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue |   | Color(1, 1, 1, 1) |   |   |
| toValue |   | Color(1, 1, 1, 0) |   |   |
| colorVariable |   | Color Colour | Variable |   |
| time |   | 0.25f |   |   |
| speed |   | 0f |   |   |
| delay |   | 0f |   |   |
| easeType |   | 21 |   |   |
| reverse |   | false |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 3. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| color |   | Color Colour |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FADE IN | Fade In | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FADE IN | false |
| FADE OUT | false |
| FINISHED | false |

