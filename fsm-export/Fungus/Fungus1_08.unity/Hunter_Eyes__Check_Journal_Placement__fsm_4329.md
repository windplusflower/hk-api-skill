# Check Journal Placement

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Check Journal Placement |
| GameObject Name | Hunter Eyes |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level137 |
| Start State | Init |
| FSM PathId | 4329 |
| GameObject PathId | 58 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Shiny Item | Hunter Eyes/Shiny Item (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level137) | NamedAssetPPtr: [Hunter Eyes/Shiny Item (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level137)] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check Journal | 0 | |

### Check Journal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| trueBool |   | "metHunter" |   |   |
| falseBool |   | "hasJournal" |   |   |
| isTrue |   | Event(PLACE) |   |   |
| isFalse |   | Event() |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| PLACE | Place | 0 | |

### Place

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Shiny Item |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| PLACE | false |

