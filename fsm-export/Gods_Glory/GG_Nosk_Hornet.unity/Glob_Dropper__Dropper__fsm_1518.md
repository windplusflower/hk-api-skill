# Dropper

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Dropper |
| GameObject Name | Glob Dropper |
| GameObject Path | Battle Scene/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level487 |
| Start State | Init |
| FSM PathId | 1518 |
| GameObject PathId | 82 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| G1 | [null] | NamedAssetPPtr: [null] |
| G2 | [null] | NamedAssetPPtr: [null] |
| G3 | [null] | NamedAssetPPtr: [null] |
| G4 | [null] | NamedAssetPPtr: [null] |
| G5 | [null] | NamedAssetPPtr: [null] |
| G6 | [null] | NamedAssetPPtr: [null] |
| G7 | [null] | NamedAssetPPtr: [null] |
| G8 | [null] | NamedAssetPPtr: [null] |
| G9 | [null] | NamedAssetPPtr: [null] |
| Glob | [null] | NamedAssetPPtr: [null] |

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
| childName |   | "G1" |   |   |
| storeResult |   | GameObject G1 | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "G2" |   |   |
| storeResult |   | GameObject G2 | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "G3" |   |   |
| storeResult |   | GameObject G3 | Variable |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "G4" |   |   |
| storeResult |   | GameObject G4 | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "G5" |   |   |
| storeResult |   | GameObject G5 | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "G6" |   |   |
| storeResult |   | GameObject G6 | Variable |   |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "G7" |   |   |
| storeResult |   | GameObject G7 | Variable |   |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "G8" |   |   |
| storeResult |   | GameObject G8 | Variable |   |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "G9" |   |   |
| storeResult |   | GameObject G9 | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DROP | Drop | 0 | |

### Drop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [] |   |   |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Vomit Glob Nosk (Hollow Knight/hollow_knight_Data\sharedassets290.assets)] |   |   |
| spawnPoint |   | GameObject G1 |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 0f |   |   |
| originVariationX |   | 1.7f |   |   |
| originVariationY |   | 4f |   |   |
| FSM |   | "Vomit Glob" |   |   |
| FSMEvent |   | "LOW GRAV" |   |   |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Vomit Glob Nosk (Hollow Knight/hollow_knight_Data\sharedassets290.assets)] |   |   |
| spawnPoint |   | GameObject G2 |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 0f |   |   |
| originVariationX |   | 1.1f |   |   |
| originVariationY |   | 4f |   |   |
| FSM |   | "Vomit Glob" |   |   |
| FSMEvent |   | "LOW GRAV" |   |   |

##### 4. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Vomit Glob Nosk (Hollow Knight/hollow_knight_Data\sharedassets290.assets)] |   |   |
| spawnPoint |   | GameObject G3 |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 0f |   |   |
| originVariationX |   | 1.7f |   |   |
| originVariationY |   | 4f |   |   |
| FSM |   | "Vomit Glob" |   |   |
| FSMEvent |   | "LOW GRAV" |   |   |

##### 5. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Vomit Glob Nosk (Hollow Knight/hollow_knight_Data\sharedassets290.assets)] |   |   |
| spawnPoint |   | GameObject G4 |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 0f |   |   |
| originVariationX |   | 1.7f |   |   |
| originVariationY |   | 4f |   |   |
| FSM |   | "Vomit Glob" |   |   |
| FSMEvent |   | "LOW GRAV" |   |   |

##### 6. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Vomit Glob Nosk (Hollow Knight/hollow_knight_Data\sharedassets290.assets)] |   |   |
| spawnPoint |   | GameObject G5 |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 0f |   |   |
| originVariationX |   | 1.7f |   |   |
| originVariationY |   | 4f |   |   |
| FSM |   | "Vomit Glob" |   |   |
| FSMEvent |   | "LOW GRAV" |   |   |

##### 7. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Vomit Glob Nosk (Hollow Knight/hollow_knight_Data\sharedassets290.assets)] |   |   |
| spawnPoint |   | GameObject G6 |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 0f |   |   |
| originVariationX |   | 1.7f |   |   |
| originVariationY |   | 4f |   |   |
| FSM |   | "Vomit Glob" |   |   |
| FSMEvent |   | "LOW GRAV" |   |   |

##### 8. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Vomit Glob Nosk (Hollow Knight/hollow_knight_Data\sharedassets290.assets)] |   |   |
| spawnPoint |   | GameObject G7 |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 0f |   |   |
| originVariationX |   | 1.7f |   |   |
| originVariationY |   | 4f |   |   |
| FSM |   | "Vomit Glob" |   |   |
| FSMEvent |   | "LOW GRAV" |   |   |

##### 9. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Vomit Glob Nosk (Hollow Knight/hollow_knight_Data\sharedassets290.assets)] |   |   |
| spawnPoint |   | GameObject G8 |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 0f |   |   |
| originVariationX |   | 1.7f |   |   |
| originVariationY |   | 4f |   |   |
| FSM |   | "Vomit Glob" |   |   |
| FSMEvent |   | "LOW GRAV" |   |   |

##### 10. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Vomit Glob Nosk (Hollow Knight/hollow_knight_Data\sharedassets290.assets)] |   |   |
| spawnPoint |   | GameObject G9 |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 1 |   |   |
| spawnMax |   | 1 |   |   |
| speedMin |   | 0f |   |   |
| speedMax |   | 0f |   |   |
| angleMin |   | 0f |   |   |
| angleMax |   | 0f |   |   |
| originVariationX |   | 1.7f |   |   |
| originVariationY |   | 4f |   |   |
| FSM |   | "Vomit Glob" |   |   |
| FSMEvent |   | "LOW GRAV" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DROP | false |
| FINISHED | false |

