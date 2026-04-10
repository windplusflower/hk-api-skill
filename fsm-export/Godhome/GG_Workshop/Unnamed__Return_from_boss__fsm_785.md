# Return from boss

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Return from boss |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets470.assets |
| Start State | Pause |
| FSM PathId | 785 |
| GameObject PathId |  |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Door Entered |  | String:  |
| Door Entry |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Inspect | GG_Statue/Inspect (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets470.assets) | NamedAssetPPtr: GG_Statue/Inspect (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets470.assets) |
| Self | [null] | NamedAssetPPtr:  |
| Transitions | [null] | NamedAssetPPtr:  |

## States

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObjectSelf

Full Name: HutongGames.PlayMaker.Actions.SetGameObjectSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Self | GameObject Self | Variable |  |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| everyFrame | false | false |  |  |

##### 2. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| skipIfAlreadyPositioned | true | true |  |  |

### Door Entry

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self |  |  |
| storeName | string Door Entry | string Door Entry | Variable |  |
| everyFrame | false | false |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "GetEntryGateName" | "GetEntryGateName" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Door Entered =  | Var Door Entered =  | Variable | Store Result |

##### 3. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Door Entry | string Door Entry | Variable |  |
| compareTo | string Door Entered | string Door Entered |  |  |
| equalEvent | Event() | Event() |  |  |
| notEqualEvent | Event(INACTIVE) | Event(INACTIVE) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 4. SetPlayerDataString

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| stringName | "bossReturnEntryGate" | "bossReturnEntryGate" |  |  |
| value | "" | "" |  |  |

### Not Returning

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Transition Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [gg_battle_transitions (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] | [Global] [gg_battle_transitions (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Transitions | GameObject Transitions | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Transitions | EventTarget(GameObject):Transitions |  |  |
| sendEvent | "GG TRANSITION OUT INSTANT" | "GG TRANSITION OUT INSTANT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Canvas | EventTarget(GameObject):HUD Canvas |  |  |
| sendEvent | "IN" | "IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inspect | OwnerDefault Inspect |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "ClearMPSendEvents" | "ClearMPSendEvents" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

##### 3. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "K HATCHLING END" | "K HATCHLING END" |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Gotten Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Inspect | OwnerDefault Inspect |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Get Up Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Transition In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Transitions | EventTarget(GameObject):Transitions |  |  |
| sendEvent | "GG TRANSITION IN STATUE" | "GG TRANSITION IN STATUE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Pause | FINISHED | Door Entry | 0 | 0 | 0 |
| Door Entry | INACTIVE | Not Returning | 0 | 0 | 0 |
| Door Entry | FINISHED | Wait | 0 | 0 | 0 |
| Transition Wait | FINISHED | Transition In | 0 | 0 | 0 |
| Wait | FINISHED | Transition Wait | 0 | 0 | 0 |
| Get Up Wait | FINISHED | Gotten Up | 0 | 0 | 0 |
| Transition In | DREAM WAKE | Get Up Wait | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| DREAM WAKE | false |
| INACTIVE | false |

