# Set Compass Point

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Compass Point |
| GameObject Name | door_dreamEnter |
| GameObject Path | Boss Scene Controller |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level459.assets |
| Start State | Idle |
| FSM PathId | 3632 |
| GameObject PathId | 841 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero X | 0 | Single: 0 |
| Hero Y | 0 | Single: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Map Zone |  | String:  |
| Scene Name |  | String:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

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
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | float Hero Y | float Hero Y | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "GetSceneNameString" | "GetSceneNameString" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Scene Name =  | Var Scene Name =  | Variable | Store Result |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "GetCurrentMapZone" | "GetCurrentMapZone" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Map Zone =  | Var Map Zone =  | Variable | Store Result |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| behaviour | "GameMap" | "GameMap" | Behaviour |  |
| methodName | "SetDoorValues" | "SetDoorValues" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 5. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| floatName | "gMap_doorX" | "gMap_doorX" |  |  |
| value | float Hero X | float Hero X |  |  |

##### 6. SetPlayerDataFloat

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| floatName | "gMap_doorY" | "gMap_doorY" |  |  |
| value | float Hero Y | float Hero Y |  |  |

##### 7. SetPlayerDataString

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| stringName | "gMap_doorScene" | "gMap_doorScene" |  |  |
| value | string Scene Name | string Scene Name |  |  |

##### 8. SetPlayerDataString

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| stringName | "gMap_doorMapZone" | "gMap_doorMapZone" |  |  |
| value | string Map Zone | string Map Zone |  |  |

##### 9. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Game Map | OwnerDefault Game Map |  |  |
| behaviour | "GameMap" | "GameMap" | Behaviour |  |
| methodName | "SetCompassPoint" | "SetCompassPoint" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | SET COMPASS POINT | Set | 0 | 0 | 0 |
| Set | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SET COMPASS POINT | false |

