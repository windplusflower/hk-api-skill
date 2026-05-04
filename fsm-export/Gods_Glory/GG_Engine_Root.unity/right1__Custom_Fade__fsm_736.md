# Custom Fade

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Custom Fade |
| GameObject Name | right1 |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level477 |
| Start State | Idle |
| FSM PathId | 736 |
| GameObject PathId | 52 |

## Variables

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
| FADE | Fade Out | 0 | |

### Fade Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault HUD Blanker White |   |   |
| fsmName |   | "Blanker Control" | FsmName |   |
| variableName |   | "Fade Time" | FsmFloat |   |
| setValue |   | 0.33f |   |   |
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

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault MainCamera |   |   |
| behaviour |   | "CameraController" | Behaviour |   |
| methodName |   | "FreezeInPlace" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var | Variable | Store Result |

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

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FADE | false |
| FINISHED | false |

