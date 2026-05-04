# Spawn

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spawn |
| GameObject Name | Dormant Warriors |
| GameObject Path | Battle Control/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level481 |
| Start State | Init |
| FSM PathId | 2129 |
| GameObject PathId | 365 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Active Max | 2 | Int32: 2 |
| Current Active | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Active Warriors | Battle Control/Active Warriors (Hollow Knight/hollow_knight_Data\level481) | NamedAssetPPtr: [Battle Control/Active Warriors (Hollow Knight/hollow_knight_Data\level481)] |
| Next Spawn | [null] | NamedAssetPPtr: [null] |
| Zote To Spawn | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Dormant | 0 | |

### Dormant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| START | Spawn | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 2f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Spawn | 0 | |

### Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetChildCount

Full Name: HutongGames.PlayMaker.Actions.GetChildCount
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Active Warriors |   |   |
| storeResult |   | int Current Active | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Current Active |   |   |
| integer2 |   | int Active Max |   |   |
| equal |   | FINISHED |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | FINISHED |   |   |
| everyFrame |   | false |   |   |

##### 3. GetRandomChild

Full Name: HutongGames.PlayMaker.Actions.GetRandomChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Zote To Spawn | Variable |   |

##### 4. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Zote To Spawn | Variable |   |
| isNull |   | FINISHED |   |   |
| isNotNull |   |   |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 5. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Zote To Spawn |   |   |
| parent |   | [Battle Control/Active Warriors (Hollow Knight/hollow_knight_Data\level481)] |   |   |
| resetLocalPosition |   | false |   |   |
| resetLocalRotation |   | false |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Zote To Spawn |   |   |
| sendEvent |   | "SPAWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| START | false |
| TRY SPAWN | false |

