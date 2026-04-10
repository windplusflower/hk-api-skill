# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets |
| Start State | Pause |
| FSM PathId | 1073 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Height | 0 | Single: 0 |
| Offset X | 0 | Single: 0 |
| Offset Y | 0 | Single: 0 |
| Width | 0 | Single: 0 |

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
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| skipIfAlreadyPositioned | false | false |  |  |

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
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| behaviour | "GameMap" | "GameMap" | Behaviour |  |
| methodName | "SetManualTilemap" | "SetManualTilemap" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 2. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| floatName | "gMap_doorOriginOffsetX" | "gMap_doorOriginOffsetX" |  |  |
| value | float Offset X | float Offset X |  |  |

##### 3. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| floatName | "gMap_doorOriginOffsetY" | "gMap_doorOriginOffsetY" |  |  |
| value | float Offset Y | float Offset Y |  |  |

##### 4. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| floatName | "gMap_doorSceneWidth" | "gMap_doorSceneWidth" |  |  |
| value | float Width | float Width |  |  |

##### 5. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| floatName | "gMap_doorSceneHeight" | "gMap_doorSceneHeight" |  |  |
| value | float Height | float Height |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Pause | FINISHED | Set | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| REFRESH | Pause | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| REFRESH | false |

