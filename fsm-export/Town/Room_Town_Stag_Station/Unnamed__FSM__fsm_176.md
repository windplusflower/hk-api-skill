# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets9.assets |
| Start State | Pause |
| FSM PathId | 176 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Compass X | 0 | Single: 0 |
| Compass Y | 0 | Single: 0 |
| Offset X | 0 | Single: 0 |
| Offset Y | 0 | Single: 0 |
| Tilemap Height | 0 | Single: 0 |
| Tilemap Width | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| z_Allow Dreamgate Set | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Map Zone |  | String:  |
| Scene Name |  | String:  |

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
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

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
| methodName | "SetCustomCompassPos" | "SetCustomCompassPos" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = False | Var unnamed = False | Variable | Store Result |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Quick Map | OwnerDefault Quick Map |  |  |
| fsmName | "Quick Map" | "Quick Map" | FsmName |  |
| variableName | "In Room" | "In Room" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Nail" | "Dream Nail" | FsmName |  |
| variableName | "Room Override" | "Room Override" | FsmBool |  |
| setValue | bool z_Allow Dreamgate Set | bool z_Allow Dreamgate Set |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Pause | FINISHED | Set | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

