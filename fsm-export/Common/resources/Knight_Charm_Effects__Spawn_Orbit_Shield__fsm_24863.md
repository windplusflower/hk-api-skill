# Spawn Orbit Shield

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spawn Orbit Shield |
| GameObject Name | Charm Effects |
| GameObject Path | Knight |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 24863 |
| GameObject PathId | 4312 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Is Gameplay Scene | false | Boolean: false |
| Is Gameplay Scene | false | Boolean: false |
| No Charms | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Shield | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

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
| boolName | "equippedCharm_38" | "equippedCharm_38" |  |  |
| isTrue | SPAWN | SPAWN |  |  |
| isFalse | FINISHED | FINISHED |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

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
| withTag | "Orbit Shield" | "Orbit Shield" | Tag |  |
| store | GameObject Shield | GameObject Shield | Variable |  |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Shield | GameObject Shield | Variable |  |
| isNull |  |  |  |  |
| isNotNull | CANCEL | CANCEL |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Orbit Shield (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Orbit Shield (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Shield | GameObject Shield | Variable |  |

### Send Slash Event

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Shield | EventTarget(GameObject):Shield |  |  |
| sendEvent | "SLASH" | "SLASH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Charms Allowed? | 0 | 0 | 0 |
| Check | SPAWN | Spawn | 0 | 0 | 0 |
| Check | FINISHED | Idle | 0 | 0 | 0 |
| Idle | CHARM EQUIP CHECK | Check | 0 | 0 | 0 |
| Idle | SLASH | Send Slash Event | 0 | 0 | 0 |
| Spawn | CANCEL | Idle | 0 | 0 | 0 |
| Spawn | FINISHED | Idle | 0 | 0 | 0 |
| Send Slash Event | FINISHED | Idle | 0 | 0 | 0 |
| Charms Allowed? | FINISHED | Check | 0 | 0 | 0 |
| Charms Allowed? | CANCEL | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| LEVEL LOADED | Init | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
| CANCEL | false |
| CHARM EQUIP CHECK | false |
| SLASH | false |
| SPAWN | true |

