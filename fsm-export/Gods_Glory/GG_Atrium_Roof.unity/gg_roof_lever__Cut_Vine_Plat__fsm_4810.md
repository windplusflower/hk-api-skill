# Cut Vine Plat

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Cut Vine Plat |
| GameObject Name | gg_roof_lever |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level473 |
| Start State | State 1 |
| FSM PathId | 4810 |
| GameObject PathId | 1416 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Vine Plat Cut | GG Fall Platform (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level473) | NamedAssetPPtr: [GG Fall Platform (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level473)] |

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
| OPEN | State 2 | 0 | |

### State 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendMessageV2

Full Name: HutongGames.PlayMaker.Actions.SendMessageV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Vine Plat Cut |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessageV2/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | Cut(???) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| OPEN | false |

