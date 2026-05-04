# Reactivate HUD

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Reactivate HUD |
| GameObject Name | Land of Storms Doors |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level473 |
| Start State | Wait |
| FSM PathId | 4843 |
| GameObject PathId | 1182 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dream Returning | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Door Entered |   | String:  |
| Door Entry |   | String:  |
| Door Name Contains | door_Land_of_Storms | String: door_Land_of_Storms |

## States

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |
| skipIfAlreadyPositioned |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Door Entry | 0 | |

### Door Entry

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| behaviour |   | "HeroController" | Behaviour |   |
| methodName |   | "GetEntryGateName" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var Door Entered =  | Variable | Store Result |

##### 2. StringContains

Full Name: HutongGames.PlayMaker.Actions.StringContains
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable |   | string Door Entered | Variable |   |
| containsString |   | string Door Name Contains = "door_Land_of_Storms" |   |   |
| trueEvent |   |   |   |   |
| falseEvent |   | INACTIVE |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| INACTIVE | Inert | 0 | |
| FINISHED | Show HUD | 0 | |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Show HUD

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):HUD Canvas |   |   |
| sendEvent |   | "IN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| INACTIVE | false |
| WAKE | true |

