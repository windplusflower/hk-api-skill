# Weaverling Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Weaverling Control |
| GameObject Name | Charm Effects |
| GameObject Path | Knight/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | Init |
| FSM PathId | 1076 |
| GameObject PathId | 147 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Weaverling Count | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Is Gameplay Scene | false | Boolean: false |
| Is Gameplay Scene | false | Boolean: false |
| No Charms | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Weaverling | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "equippedCharm_39" |   |   |
| isTrue |   | EQUIPPED |   |   |
| isFalse |   | UNEQUIPPED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EQUIPPED | Wait Frame | 0 | |
| UNEQUIPPED | Unequipped | 0 | |

### Unequipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Weaverling (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(0, -0.5, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Weaverling | Variable |   |

##### 2. SetAudioClip

Full Name: HutongGames.PlayMaker.Actions.SetAudioClip
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Weaverling |   |   |
| audioClip |   | [spider_buddy_loop_1 (AudioClip) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

##### 3. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Weaverling (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(0, -0.5, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Weaverling | Variable |   |

##### 4. SetAudioClip

Full Name: HutongGames.PlayMaker.Actions.SetAudioClip
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Weaverling |   |   |
| audioClip |   | [spider_buddy_loop_2 (AudioClip) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Weaverling (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| position |   | Vector3(0, -0.5, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Weaverling | Variable |   |

##### 6. SetAudioClip

Full Name: HutongGames.PlayMaker.Actions.SetAudioClip
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Weaverling |   |   |
| audioClip |   | [spider_buddy_loop_3 (AudioClip) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

(none)

### Spawn Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Charms Allowed? | 0 | |

### Charms Allowed?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| fsmName |   | "ProxyFSM" | FsmName |   |
| variableName |   | "No Charms" | FsmBool |   |
| storeValue |   | bool No Charms | Variable |   |
| everyFrame |   | false |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool No Charms | Variable |   |
| isTrue |   | CANCEL |   |   |
| isFalse |   |   |   |   |
| everyFrame |   | false |   |   |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| behaviour |   | "GameManager" | Behaviour |   |
| methodName |   | "IsGameplayScene" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var Is Gameplay Scene = False | Variable | Store Result |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Is Gameplay Scene | Variable |   |
| isTrue |   |   |   |   |
| isFalse |   | CANCEL |   |   |
| everyFrame |   | false |   |   |

##### 5. GetTagCount

Full Name: HutongGames.PlayMaker.Actions.GetTagCount
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| tag |   | "Weaverling" | Tag |   |
| storeResult |   | int Weaverling Count | Variable |   |

##### 6. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Weaverling Count |   |   |
| integer2 |   | 0 |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | CANCEL |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |
| CANCEL | Unequipped | 0 | |

### Wait Frame

Description: Allow scene refs to be setup
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEVEL LOADED | Spawn Pause | 0 | |
| CHARM EQUIP CHECK | Check | 0 | |

## Events

| Name | Global |
| --- | --- |
| CANCEL | false |
| CHARM EQUIP CHECK | false |
| EQUIPPED | false |
| FINISHED | false |
| LEVEL LOADED | false |
| UNEQUIPPED | false |

