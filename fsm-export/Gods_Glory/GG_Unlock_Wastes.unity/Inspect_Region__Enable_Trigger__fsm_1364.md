# Enable Trigger

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Enable Trigger |
| GameObject Name | Inspect Region |
| GameObject Path | Sequence/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level500 |
| Start State | Inert |
| FSM PathId | 1364 |
| GameObject PathId | 316 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Trigger Region | Sequence/Trigger Region (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level500) | NamedAssetPPtr: [Sequence/Trigger Region (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level500)] |

## States

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Enable Trigger

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Trigger Region |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DO INSPECT | Enable Trigger | 0 | |

## Events

| Name | Global |
| --- | --- |
| DO INSPECT | false |

