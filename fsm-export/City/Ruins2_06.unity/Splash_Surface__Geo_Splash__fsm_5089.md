# Geo Splash

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Geo Splash |
| GameObject Name | Splash Surface |
| GameObject Path | Surface Water Region/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level118 |
| Start State | Detect |
| FSM PathId | 5089 |
| GameObject PathId | 1422 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Geo | [null] | NamedAssetPPtr: [null] |

## States

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | 16 | Layer |   |
| sendEvent |   | Event(SPLASH) |   |   |
| storeCollider |   | GameObject Geo | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SPLASH | Splash | 0 | |

### Splash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Spatter Black (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Geo |   |   |
| position |   | Vector3(0, 1, 0) |   |   |
| spawnMin |   | 3 |   |   |
| spawnMax |   | 5 |   |   |
| speedMin |   | 8f |   |   |
| speedMax |   | 15f |   |   |
| angleMin |   | 70f |   |   |
| angleMax |   | 110f |   |   |
| originVariationX |   | 0.5f |   |   |
| originVariationY |   | 0.5f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SPLASH | false |

