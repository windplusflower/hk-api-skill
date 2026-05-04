# map_customcompass

## Summary

| Field | Value |
| --- | --- |
| FSM Name | map_customcompass |
| GameObject Name | _SceneManager |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level9 |
| Start State | Pause |
| FSM PathId | 1256 |
| GameObject PathId | 334 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Compass X | 142 | Single: 142 |
| Compass Y | 11.5 | Single: 11.5 |
| Offset X | 0 | Single: 0 |
| Offset Y | 3 | Single: 3 |
| Tilemap Height | 100 | Single: 100 |
| Tilemap Width | 263 | Single: 263 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| z_Allow Dreamgate Set | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Map Zone | TOWN | String: TOWN |
| Scene Name | Town | String: Town |

## States

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitForFinishedEnteringScene

Full Name: WaitForFinishedEnteringScene
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

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
| methodName |   | "SetCustomCompassPos" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = False | Variable | Store Result |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Quick Map |   |   |
| fsmName |   | "Quick Map" | FsmName |   |
| variableName |   | "In Room" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| fsmName |   | "Dream Nail" | FsmName |   |
| variableName |   | "Room Override" | FsmBool |   |
| setValue |   | bool z_Allow Dreamgate Set |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

