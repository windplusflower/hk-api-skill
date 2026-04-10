# Blanker Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Blanker Control |
| GameObject Name | 2dtk Blanker |
| GameObject Path | _GameCameras/HudCamera |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 23878 |
| GameObject PathId | 7390 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Fade Time | 1 | Single: 1 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cancel Reset | false | Boolean: false |

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Colour | Color(0, 0, 0, 1) | UnityColor: Color(0, 0, 0, 1) |
| End Colour | Color(0, 0, 0, 1) | UnityColor: Color(0, 0, 0, 1) |
| Start Colour | Color(0, 0, 0, 0) | UnityColor: Color(0, 0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |
| asdf | [null] | NamedAssetPPtr:  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| active | false | false |  |  |

##### 3. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault MainCamera | OwnerDefault MainCamera |  |  |
| fsmName | "CameraFade" | "CameraFade" | FsmName |  |
| variableName | "Blanker" | "Blanker" | FsmGameObject |  |
| setValue | GameObject Self | GameObject Self |  |  |
| everyFrame | false | false |  |  |

### Fade In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable | Color Colour | Color Colour | Variable |  |
| color | Color Start Colour | Color Start Colour |  |  |
| everyFrame | false | false |  |  |

##### 2. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue | Color Start Colour | Color Start Colour |  |  |
| toValue | Color End Colour | Color End Colour |  |  |
| colorVariable | Color Colour | Color Colour | Variable |  |
| time | float Fade Time | float Fade Time |  |  |
| speed | 0f | 0f |  |  |
| delay | 0f | 0f |  |  |
| easeType | 21 | 21 |  |  |
| reverse | false | false |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | true | true |  |  |

##### 3. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color Colour | Color Colour |  |  |
| everyFrame | true | true |  |  |

##### 4. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 5. GetEventSender

Full Name: HutongGames.PlayMaker.Actions.GetEventSender
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sentByGameObject | GameObject asdf | GameObject asdf | Variable |  |

### Fade Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable | Color Colour | Color Colour | Variable |  |
| color | Color End Colour | Color End Colour |  |  |
| everyFrame | false | false |  |  |

##### 2. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue | Color End Colour | Color End Colour |  |  |
| toValue | Color Start Colour | Color Start Colour |  |  |
| colorVariable | Color Colour | Color Colour | Variable |  |
| time | float Fade Time | float Fade Time |  |  |
| speed | 0f | 0f |  |  |
| delay | 0f | 0f |  |  |
| easeType | 21 | 21 |  |  |
| reverse | false | false |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | true | true |  |  |

##### 3. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color Colour | Color Colour |  |  |
| everyFrame | true | true |  |  |

##### 4. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### Fade In Instant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### Fade Out Instant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(0, 0, 0, 0) | Color(0, 0, 0, 0) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObjectSelf

Full Name: HutongGames.PlayMaker.Actions.SetGameObjectSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | [Global] GameObject 2dtk Blanker | [Global] GameObject 2dtk Blanker | Variable |  |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| everyFrame | false | false |  |  |

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Faded Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Fade In | FADE OUT | Fade Out | 0 | 0 | 0 |
| Fade Out | FADE IN | Fade In | 0 | 0 | 0 |
| Fade Out | FINISHED | Faded Out | 0 | 0 | 0 |
| Idle | FADE IN | Fade In | 0 | 0 | 0 |
| Fade In Instant | FADE OUT | Fade Out | 0 | 0 | 0 |
| Fade Out Instant | FADE IN | Fade In | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |
| Faded Out | FADE IN | Fade In | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| FADE IN INSTANT | Fade In Instant | 0 | 0 | 0 |
| FADE OUT INSTANT | Fade Out Instant | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
| CANCEL | false |
| FADE IN | false |
| FADE IN INSTANT | false |
| FADE OUT | false |
| FADE OUT INSTANT | false |

