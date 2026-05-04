# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | _SceneManager |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level242 |
| Start State | Pause |
| FSM PathId | 595 |
| GameObject PathId | 169 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Compass X | 6.5 | Single: 6.5 |
| Compass Y | 40 | Single: 40 |
| Offset X | 0 | Single: 0 |
| Offset Y | 0 | Single: 0 |
| Tilemap Height | 45 | Single: 45 |
| Tilemap Width | 95 | Single: 95 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| z_Allow Dreamgate Set | true | Boolean: true |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Map Zone | RESTING_GROUNDS | String: RESTING_GROUNDS |
| Scene Name | RestingGrounds_05 | String: RestingGrounds_05 |

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

