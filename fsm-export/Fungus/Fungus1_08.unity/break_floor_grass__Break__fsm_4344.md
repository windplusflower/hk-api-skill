# Break

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Break |
| GameObject Name | break_floor_grass |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level137 |
| Start State | Init |
| FSM PathId | 4344 |
| GameObject PathId | 543 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Break Effects | [null] | NamedAssetPPtr: [null] |
| Floor | [null] | NamedAssetPPtr: [null] |

## States

### Init

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
| childName |   | "Break Effects" |   |   |
| storeResult |   | GameObject Break Effects | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Floor" |   |   |
| storeResult |   | GameObject Floor | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BREAK GRASS FLOOR | Break | 0 | |

### Break

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Break Effects |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Floor |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Break Effects | Variable |   |
| activate |   | true |   |   |

##### 4. FlingObjects

Full Name: HutongGames.PlayMaker.Actions.FlingObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| containerObject |   | GameObject Break Effects |   |   |
| adjustPosition |   | Vector3(0, 0, 0) |   |   |
| randomisePosition |   | false |   |   |
| speedMin |   | 5f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 80f |   |   |
| angleMax |   | 100f |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BREAK GRASS FLOOR | false |

