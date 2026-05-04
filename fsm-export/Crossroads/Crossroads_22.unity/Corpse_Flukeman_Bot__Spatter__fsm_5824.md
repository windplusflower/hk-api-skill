# Spatter

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spatter |
| GameObject Name | Corpse Flukeman Bot |
| GameObject Path | Hatcher/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level59 |
| Start State | Spatter |
| FSM PathId | 5824 |
| GameObject PathId | 237 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. SpawnBlood

Full Name: SpawnBlood
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 20 |   |   |
| spawnMax |   | 20 |   |   |
| speedMin |   | 10f |   |   |
| speedMax |   | 20f |   |   |
| angleMin |   | 40f |   |   |
| angleMax |   | 140f |   |   |
| colorOverride |   | Color(0, 0, 0, 1) |   |   |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

