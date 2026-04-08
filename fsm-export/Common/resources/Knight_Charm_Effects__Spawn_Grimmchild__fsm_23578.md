# Spawn Grimmchild

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spawn Grimmchild |
| GameObject Name | Charm Effects |
| GameObject Path | Knight |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 23578 |
| GameObject PathId | 4312 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dream Appear | false | Boolean: false |
| Is Gameplay Scene | false | Boolean: false |
| Is Gameplay Scene | false | Boolean: false |
| No Charms | false | Boolean: false |
| Quick Spawn | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Scene Name |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Child | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

##### 2. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |
| skipIfAlreadyPositioned | true | true |  |  |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "destroyedNightmareLantern" | "destroyedNightmareLantern" |  |  |
| isTrue | UNEQUIPPED | UNEQUIPPED |  |  |
| isFalse |  |  |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_40" | "equippedCharm_40" |  |  |
| isTrue | EQUIPPED | EQUIPPED |  |  |
| isFalse | UNEQUIPPED | UNEQUIPPED |  |  |

### Unequipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "Grimmchild" | "Grimmchild" | Tag |  |
| store | GameObject Child | GameObject Child | Variable |  |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Child | GameObject Child | Variable |  |
| isNull |  |  |  |  |
| isNotNull | CANCEL | CANCEL |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Grimmchild (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Grimmchild (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Child | GameObject Child | Variable |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Quick Spawn | bool Quick Spawn | Variable |  |
| isTrue |  |  |  |  |
| isFalse | FINISHED | FINISHED |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Child | OwnerDefault Child |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Scene Appear" | "Scene Appear" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Spawn Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Quick Spawn | bool Quick Spawn | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 3. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |
| skipIfAlreadyPositioned | true | true |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Nightmare?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "GetSceneNameString" | "GetSceneNameString" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Scene Name =  | Var Scene Name =  | Variable | Store Result |

##### 2. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Scene Name | string Scene Name | Variable |  |
| compareTo | "Grimm_Nightmare" | "Grimm_Nightmare" |  |  |
| equalEvent | NIGHTMARE | NIGHTMARE |  |  |
| notEqualEvent |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Scene Name | string Scene Name | Variable |  |
| compareTo | "GG_Grimm_Nightmare" | "GG_Grimm_Nightmare" |  |  |
| equalEvent | NIGHTMARE | NIGHTMARE |  |  |
| notEqualEvent |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 4. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Scene Name | string Scene Name | Variable |  |
| compareTo | "GG_Grimm" | "GG_Grimm" |  |  |
| equalEvent | NIGHTMARE | NIGHTMARE |  |  |
| notEqualEvent |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

### No Summon

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Charms Allowed?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "ProxyFSM" | "ProxyFSM" | FsmName |  |
| variableName | "No Charms" | "No Charms" | FsmBool |  |
| storeValue | bool No Charms | bool No Charms | Variable |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool No Charms | bool No Charms | Variable |  |
| isTrue | CANCEL | CANCEL |  |  |
| isFalse |  |  |  |  |
| everyFrame | false | false |  |  |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "IsGameplayScene" | "IsGameplayScene" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Is Gameplay Scene = False | Var Is Gameplay Scene = False | Variable | Store Result |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Is Gameplay Scene | bool Is Gameplay Scene | Variable |  |
| isTrue |  |  |  |  |
| isFalse | CANCEL | CANCEL |  |  |
| everyFrame | false | false |  |  |

### Normal Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Quick Spawn | bool Quick Spawn | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |
| skipIfAlreadyPositioned | true | true |  |  |

### Wait for Hero in Position

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |
| skipIfAlreadyPositioned | true | true |  |  |

### Dream?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CheckCurrentMapZone

Full Name: CheckCurrentMapZone
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| mapZone | "DREAM_WORLD" | "DREAM_WORLD" |  |  |
| equalEvent |  |  |  |  |
| notEqualEvent | FINISHED | FINISHED |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Appear | bool Dream Appear | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Dream Appear

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Dream Appear | bool Dream Appear | Variable |  |
| isTrue |  |  |  |  |
| isFalse | FINISHED | FINISHED |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Child | OwnerDefault Child |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Dream Appear" | "Dream Appear" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Check | 0 | 0 | 0 |
| Check | EQUIPPED | Spawn | 0 | 0 | 0 |
| Check | UNEQUIPPED | Unequipped | 0 | 0 | 0 |
| Spawn | CANCEL | Idle | 0 | 0 | 0 |
| Spawn | FINISHED | Dream Appear | 0 | 0 | 0 |
| Spawn Pause | FINISHED | Dream? | 0 | 0 | 0 |
| Nightmare? | FINISHED | Charms Allowed? | 0 | 0 | 0 |
| Nightmare? | NIGHTMARE | No Summon | 0 | 0 | 0 |
| Charms Allowed? | FINISHED | Check | 0 | 0 | 0 |
| Charms Allowed? | CANCEL | No Summon | 0 | 0 | 0 |
| Normal Spawn | FINISHED | Check | 0 | 0 | 0 |
| Wait for Hero in Position | FINISHED | Spawn | 0 | 0 | 0 |
| Dream? | FINISHED | Nightmare? | 0 | 0 | 0 |
| Dream Appear | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| LEVEL LOADED | Spawn Pause | 0 | 0 | 0 |
| CHARM EQUIP CHECK | Normal Spawn | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
| AWAKE | false |
| CANCEL | false |
| CHARM EQUIP CHECK | false |
| EQUIPPED | false |
| NIGHTMARE | false |
| UNEQUIPPED | false |

