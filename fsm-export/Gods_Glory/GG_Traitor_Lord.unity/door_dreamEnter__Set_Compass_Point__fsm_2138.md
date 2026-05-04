# Set Compass Point

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Compass Point |
| GameObject Name | door_dreamEnter |
| GameObject Path | Boss Scene Controller/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level464 |
| Start State | Idle |
| FSM PathId | 2138 |
| GameObject PathId | 375 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero X | 0 | Single: 0 |
| Hero Y | 0 | Single: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Map Zone |   | String:  |
| Scene Name |   | String:  |

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
| SET COMPASS POINT | Set | 0 | |

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition2D

Full Name: HutongGames.PlayMaker.Actions.GetPosition2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | float Hero X | Variable |   |
| y |   | float Hero Y | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| behaviour |   | "GameManager" | Behaviour |   |
| methodName |   | "GetSceneNameString" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var Scene Name =  | Variable | Store Result |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| behaviour |   | "GameManager" | Behaviour |   |
| methodName |   | "GetCurrentMapZone" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var Map Zone =  | Variable | Store Result |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Game Map |   |   |
| behaviour |   | "GameMap" | Behaviour |   |
| methodName |   | "SetDoorValues" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

##### 5. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| floatName |   | "gMap_doorX" |   |   |
| value |   | float Hero X |   |   |

##### 6. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| floatName |   | "gMap_doorY" |   |   |
| value |   | float Hero Y |   |   |

##### 7. SetPlayerDataString

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| stringName |   | "gMap_doorScene" |   |   |
| value |   | string Scene Name |   |   |

##### 8. SetPlayerDataString

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| stringName |   | "gMap_doorMapZone" |   |   |
| value |   | string Map Zone |   |   |

##### 9. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Game Map |   |   |
| behaviour |   | "GameMap" | Behaviour |   |
| methodName |   | "SetCompassPoint" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SET COMPASS POINT | false |

