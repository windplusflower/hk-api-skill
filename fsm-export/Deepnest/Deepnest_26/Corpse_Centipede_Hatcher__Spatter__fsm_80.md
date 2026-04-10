# Spatter

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spatter |
| GameObject Name | Corpse Centipede Hatcher |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets286.assets |
| Start State | Spatter |
| FSM PathId | 80 |
| GameObject PathId | 35 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |

## States

### Spatter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, -0.5, 0) | Vector3(0, -0.5, 0) |  |  |
| spawnMin | 20 | 20 |  |  |
| spawnMax | 20 | 20 |  |  |
| speedMin | 5f | 5f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | 0f | 0f |  |  |
| angleMax | 360f | 360f |  |  |
| originVariationX | 1.2f | 1.2f |  |  |
| originVariationY | 1.2f | 1.2f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |  |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| _(none)_ |  |

