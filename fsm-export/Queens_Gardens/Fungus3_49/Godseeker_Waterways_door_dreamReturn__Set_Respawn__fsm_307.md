# Set Respawn

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Respawn |
| GameObject Name | door_dreamReturn |
| GameObject Path | Godseeker Waterways |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets225.assets |
| Start State | Pause |
| FSM PathId | 307 |
| GameObject PathId | 98 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dream Returning | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Door Entered |  | String:  |
| Door Entry |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Inspect | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

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
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "SetBenchRespawn" | "SetBenchRespawn" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "SetCurrentMapZoneAsRespawn" | "SetCurrentMapZoneAsRespawn" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

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
Local Transitions: 3

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

##### 4. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Return" | "Dream Return" | FsmName |  |
| variableName | "Dream Returning" | "Dream Returning" | FsmBool |  |
| storeValue | bool Dream Returning | bool Dream Returning | Variable |  |
| everyFrame | false | false |  |  |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Returning | bool Dream Returning | Variable |  |
| isTrue | Event(WAKE) | Event(WAKE) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Not Returning

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault  | OwnerDefault  |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Dream Return

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Return" | "Dream Return" | FsmName |  |
| variableName | "Dream Returning" | "Dream Returning" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Blanker White | OwnerDefault HUD Blanker White |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "" | "" | FsmFloat |  |
| setValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker White | EventTarget(GameObject):HUD Blanker White |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Wait for dream return

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Pause | FINISHED | Door Entry | 0 | 0 | 0 |
| Door Entry | INACTIVE | Not Returning | 0 | 0 | 0 |
| Door Entry | FINISHED | Not Returning | 0 | 0 | 0 |
| Door Entry | WAKE | Set | 0 | 0 | 0 |
| Dream Return | DREAM WAKE | Set | 0 | 0 | 0 |
| Wait for dream return | FINISHED | Dream Return | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| DREAM ENTER | false |
| FINISHED | false |
| INACTIVE | false |
| WAKE | true |
| DREAM WAKE | false |

