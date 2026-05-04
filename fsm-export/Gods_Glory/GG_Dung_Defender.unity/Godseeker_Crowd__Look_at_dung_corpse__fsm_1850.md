# Look at dung corpse

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Look at dung corpse |
| GameObject Name | Godseeker Crowd |
| GameObject Path | GG_Arena_Prefab/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level430 |
| Start State | State 1 |
| FSM PathId | 1850 |
| GameObject PathId | 598 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Corpse | GG_Arena_Prefab/Dung Corpse BG (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level430) | NamedAssetPPtr: [GG_Arena_Prefab/Dung Corpse BG (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level430)] |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DUNG CORPSE FALL | State 2 | 0 | |

### State 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "Control" | FsmName |   |
| variableName |   | "Target" | FsmGameObject |   |
| setValue |   | GameObject Corpse |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DUNG CORPSE FALL | false |

