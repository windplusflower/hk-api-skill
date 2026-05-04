# Dust

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Dust |
| GameObject Name | Slope |
| GameObject Path | Fk Break Wall/Broken/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level46 |
| Start State | Init |
| FSM PathId | 7868 |
| GameObject PathId | 546 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Dust 1 | [null] | NamedAssetPPtr: [null] |
| Dust 2 | [null] | NamedAssetPPtr: [null] |
| Rock Point | [null] | NamedAssetPPtr: [null] |

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
| childName |   | "Dust 1" |   |   |
| storeResult |   | GameObject Dust 1 | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dust 2" |   |   |
| storeResult |   | GameObject Dust 2 | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Rock Point" |   |   |
| storeResult |   | GameObject Rock Point | Variable |   |

##### 4. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |   |   |
| collideTag |   | "Player" | Tag |   |
| sendEvent |   | Event(HIT) |   |   |
| storeCollider |   |   | Variable |   |
| storeForce |   | 0f | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIT | Effects | 0 | |

### Effects

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust 1 |   |   |
| emit |   | 0 |   |   |

##### 2. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust 2 |   |   |
| emit |   | 0 |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Rocks | 0 | |

### Rocks

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Particle Rock Tiny Transient (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Rock Point |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 7 |   |   |
| spawnMax |   | 7 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 0f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| HIT | true |

