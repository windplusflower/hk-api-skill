# Spider Spawn

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spider Spawn |
| GameObject Name | deep_egg_set_05 (4) |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level291 |
| Start State | Init |
| FSM PathId | 6636 |
| GameObject PathId | 352 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Always Spawn | false | Boolean: false |
| Can Spawn | false | Boolean: false |
| Hanging | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |
| Spider | [null] | NamedAssetPPtr: [null] |
| Spiders | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Can Spawn | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(NO SPAWN) |   |   |
| everyFrame |   | false |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Always Spawn | Variable |   |
| isTrue |   | Event(SPAWN) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 4. SendRandomEvent

Full Name: HutongGames.PlayMaker.Actions.SendRandomEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| delay |   | 0f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NO SPAWN | No Spawn | 0 | |
| SPAWN | Spawn Init | 0 | |

### No Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Spawn Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Spiders" |   |   |
| storeResult |   | GameObject Spiders | Variable |   |

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Tiny Spider (Hollow Knight/hollow_knight_Data\sharedassets291.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Spider | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Spider |   |   |
| fsmName |   | "Spawn" | FsmName |   |
| variableName |   | "Spawns" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 4. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Spider |   |   |
| parent |   | GameObject Spiders |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Spider |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BREAK | Hanging? | 0 | |

### Hanging?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Spiders | Variable |   |
| activate |   | true |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Hanging | Variable |   |
| isTrue |   | Event(HANGING) |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HANGING | Drop | 0 | |
| FINISHED | Spit | 0 | |

### Drop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FlingObjects

Full Name: HutongGames.PlayMaker.Actions.FlingObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| containerObject |   | GameObject Spiders |   |   |
| adjustPosition |   | Vector3(0, 0, 0) |   |   |
| randomisePosition |   | false |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 10f |   |   |
| angleMin |   | 240f |   |   |
| angleMax |   | 300f |   |   |

#### Transitions

(none)

### Spit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FlingObjects

Full Name: HutongGames.PlayMaker.Actions.FlingObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| containerObject |   | GameObject Spiders |   |   |
| adjustPosition |   | Vector3(0, 0, 0) |   |   |
| randomisePosition |   | false |   |   |
| speedMin |   | 10f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 40f |   |   |
| angleMax |   | 140f |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BREAK | false |
| FINISHED | false |
| HANGING | false |
| NO SPAWN | false |
| SPAWN | true |

