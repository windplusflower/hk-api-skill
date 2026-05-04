# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | _SceneManager |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level385 |
| Start State | Pause |
| FSM PathId | 6474 |
| GameObject PathId | 709 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Height | 86 | Single: 86 |
| Offset X | -103 | Single: -103 |
| Offset Y | 0 | Single: 0 |
| Width | 95 | Single: 95 |

## States

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 2. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |
| skipIfAlreadyPositioned |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set | 0 | |

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Game Map |   |   |
| behaviour |   | "GameMap" | Behaviour |   |
| methodName |   | "SetManualTilemap" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

##### 2. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| floatName |   | "gMap_doorOriginOffsetX" |   |   |
| value |   | float Offset X |   |   |

##### 3. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| floatName |   | "gMap_doorOriginOffsetY" |   |   |
| value |   | float Offset Y |   |   |

##### 4. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| floatName |   | "gMap_doorSceneWidth" |   |   |
| value |   | float Width |   |   |

##### 5. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| floatName |   | "gMap_doorSceneHeight" |   |   |
| value |   | float Height |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| REFRESH | Pause | 0 | |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| REFRESH | true |

