# Fade In

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Fade In |
| GameObject Name | Fade In |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level472 |
| Start State | Fade Instant |
| FSM PathId | 192 |
| GameObject PathId | 21 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Skip Fader | false | Boolean: false |

## States

### Fade Instant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetStaticVariable

Full Name: GetStaticVariable
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName |   | "skipEndWhiteFader" |   |   |
| storeValue |   | Var Skip Fader = False | Variable |   |

##### 2. SetStaticVariable

Full Name: SetStaticVariable
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variableName |   | "skipEndWhiteFader" |   |   |
| setValue |   | Var unnamed = False |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Skip Fader | Variable |   |
| isTrue |   | CANCEL |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault HUD Blanker White |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):HUD Blanker White |   |   |
| sendEvent |   | "FADE IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fade Out | 0 | |
| CANCEL | Wait | 0 | |

### Fade Out

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
| setValue |   | 1f |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):HUD Blanker White |   |   |
| sendEvent |   | "FADE OUT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |   | 0 | |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):2dtk Blanker |   |   |
| sendEvent |   | "FADE OUT INSTANT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Inert | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CANCEL | false |
| FINISHED | false |

