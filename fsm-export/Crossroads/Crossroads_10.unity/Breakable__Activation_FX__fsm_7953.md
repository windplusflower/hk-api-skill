# Activation FX

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Activation FX |
| GameObject Name | Breakable |
| GameObject Path | Fk Break Wall/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level46 |
| Start State | Init |
| FSM PathId | 7953 |
| GameObject PathId | 1077 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Pieces | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Pieces" |   |   |
| storeResult |   | GameObject Pieces | Variable |   |

##### 3. FlingObjects

Full Name: HutongGames.PlayMaker.Actions.FlingObjects
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| containerObject |   | GameObject Pieces |   |   |
| adjustPosition |   | Vector3(0, 0, 0) |   |   |
| randomisePosition |   | false |   |   |
| speedMin |   | 10f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 40f |   |   |
| angleMax |   | 70f |   |   |

##### 4. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Tiny Transient Plain (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(1.5, 0, 0) |   |   |
| spawnMin |   | 30 |   |   |
| spawnMax |   | 30 |   |   |
| speedMin |   | 10f |   |   |
| speedMax |   | 25f |   |   |
| angleMin |   | 30f |   |   |
| angleMax |   | 80f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 1.6f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

