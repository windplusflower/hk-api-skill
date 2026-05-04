# breakable_soul_jar

## Summary

| Field | Value |
| --- | --- |
| FSM Name | breakable_soul_jar |
| GameObject Name | Ruins Vial Empty |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level100 |
| Start State | Idle |
| FSM PathId | 7199 |
| GameObject PathId | 1403 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BREAK | Soul | 0 | |

### Soul

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Soul Orb R (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 10 |   |   |
| spawnMax |   | 12 |   |   |
| speedMin |   | 8f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 360f |   |   |
| originVariationX |   | 0.5f |   |   |
| originVariationY |   | 0.5f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BREAK | false |

