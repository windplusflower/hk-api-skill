# Spawn Drops

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spawn Drops |
| GameObject Name | Dripper Black |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets50.assets |
| Start State | Init |
| FSM PathId | 107 |
| GameObject PathId | 51 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Emission Rate | 0 | Single: 0 |
| Frequency | 0 | Single: 0 |
| Hero Y Velocity | 0 | Single: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero | [null] | NamedAssetPPtr:  |
| OriginalParent | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SpawnRandomObjectsV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsV2
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 12 | 12 |  |  |
| spawnMax | 15 | 15 |  |  |
| speedMin | 5f | 5f |  |  |
| speedMax | 12f | 12f |  |  |
| angleMin | 80f | 80f |  |  |
| angleMax | 110f | 110f |  |  |
| originVariationX | 1f | 1f |  |  |
| originVariationY | 0.5f | 0.5f |  |  |

##### 2. SpawnRandomObjectsOverTimeV2

Full Name: HutongGames.PlayMaker.Actions.SpawnRandomObjectsOverTimeV2
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| frequency | 0.025f | 0.025f |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 0f | 0f |  |  |
| speedMax | 1f | 1f |  |  |
| angleMin | 90f | 90f |  |  |
| angleMax | 90f | 90f |  |  |
| originVariationX | 0.25f | 0.25f |  |  |
| originVariationY | 0.5f | 0.5f |  |  |
| scaleMin | 1f | 1f |  |  |
| scaleMax | 1f | 1f |  |  |

##### 3. FlingObjectsFromGlobalPoolTime

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPoolTime
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Black (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| frequency | 0.025f | 0.025f |  |  |
| spawnMin | 1 | 1 |  |  |
| spawnMax | 1 | 1 |  |  |
| speedMin | 0f | 0f |  |  |
| speedMax | 1f | 1f |  |  |
| angleMin | 90f | 90f |  |  |
| angleMax | 90f | 90f |  |  |
| originVariationX | 0.5f | 0.5f |  |  |
| originVariationY | 0.5f | 0.5f |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.4f | 0.4f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| parent | GameObject OriginalParent | GameObject OriginalParent |  |  |
| resetLocalPosition | true | true |  |  |
| resetLocalRotation | true | true |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "Player" | "Player" | Tag |  |
| store | GameObject Hero | GameObject Hero | Variable |  |

##### 3. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| parent | GameObject Hero | GameObject Hero |  |  |
| resetLocalPosition | true | true |  |  |
| resetLocalRotation | false | false |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -0.5f | -0.5f |  |  |
| z | 0.01f | 0.01f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.04f | 0.04f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Recycle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Spawn | FINISHED | Recycle | 0 | 0 | 0 |
| Init | FINISHED | Spawn | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| FALLING | false |

