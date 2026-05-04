# Combo Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Combo Control |
| GameObject Name | Brothers |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level454 |
| Start State | Init |
| FSM PathId | 1777 |
| GameObject PathId | 73 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attacks Until Combo | 0 | Int32: 0 |
| Ct Cyclone | 0 | Int32: 0 |
| Ct Dash | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Battlers | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Mato | Brothers/Mato (Hollow Knight/hollow_knight_Data\level454) | NamedAssetPPtr: [Brothers/Mato (Hollow Knight/hollow_knight_Data\level454)] |
| Oro | Brothers/Oro (Hollow Knight/hollow_knight_Data\level454) | NamedAssetPPtr: [Brothers/Oro (Hollow Knight/hollow_knight_Data\level454)] |

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
| FINISHED | Oro Battle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Attacks Until Combo |   |   |
| integer2 |   | 0 |   |   |
| equal |   | COMBO |   |   |
| lessThan |   | COMBO |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ATTACK | Decrement | 0 | |
| COMBO | Combo Choice | 0 | |
| DEFEATED | Defeated 1 | 0 | |

### Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. RandomInt

Full Name: HutongGames.PlayMaker.Actions.RandomInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 4 |   |   |
| max |   | 6 |   |   |
| storeResult |   | int Attacks Until Combo | Variable |   |
| inclusiveMax |   | true |   |   |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Mato |   |   |
| fsmName |   | "nailmaster" | FsmName |   |
| variableName |   | "Do Dash Slash" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Oro |   |   |
| fsmName |   | "nailmaster" | FsmName |   |
| variableName |   | "Do Dash Slash" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Mato |   |   |
| fsmName |   | "nailmaster" | FsmName |   |
| variableName |   | "Do Cyclone" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Oro |   |   |
| fsmName |   | "nailmaster" | FsmName |   |
| variableName |   | "Do Cyclone" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |
| DEFEATED | Defeated 1 | 0 | |

### Decrement

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Attacks Until Combo |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Attacks Until Combo | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |
| DEFEATED | Defeated 1 | 0 | |

### Combo Choice

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| sendEvent |   | "CYCLONE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SendRandomEventV2

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trackingInts |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| eventMax |   | FSMViewAvalonia2.FsmArray2 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CYCLONE | Set Cyclone | 0 | |
| DASH | Set Dash | 0 | |
| DEFEATED | Defeated 1 | 0 | |

### Set Dash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Mato |   |   |
| fsmName |   | "nailmaster" | FsmName |   |
| variableName |   | "Do Dash Slash" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Oro |   |   |
| fsmName |   | "nailmaster" | FsmName |   |
| variableName |   | "Do Dash Slash" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| COMBO COMPLETED | Reset | 0 | |
| DEFEATED | Defeated 1 | 0 | |

### Set Cyclone

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Mato |   |   |
| fsmName |   | "nailmaster" | FsmName |   |
| variableName |   | "Do Cyclone" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Oro |   |   |
| fsmName |   | "nailmaster" | FsmName |   |
| variableName |   | "Do Cyclone" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| COMBO COMPLETED | Reset | 0 | |
| DEFEATED | Defeated 1 | 0 | |

### Oro Battle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEXT | Reset | 0 | |

### Defeated 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DEFEATED | Journal | 0 | |

### Defeated 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.75f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

##### 2. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot |   | [Silent (AudioMixerSnapshotController) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| transitionTime |   | 1f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Bow | 0 | |

### Bow

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Mato |   |   |
| sendEvent |   | "BOW" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Oro |   |   |
| sendEvent |   | "BOW" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Journal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "killedNailBros" |   |   |
| isTrue |   | FINISHED |   |   |
| isFalse |   |   |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "killedNailBros" |   |   |
| value |   | true |   |   |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "newDataNailBros" |   |   |
| value |   | true |   |   |

##### 4. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName |   | "killsNailBros" |   |   |
| value |   | 0 |   |   |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasJournal" |   |   |
| isTrue |   |   |   |   |
| isFalse |   | FINISHED |   |   |

##### 6. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Journal Update Msg (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   |   |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Defeated 2 | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ATTACK | false |
| COMBO | false |
| COMBO COMPLETED | false |
| CYCLONE | false |
| DASH | false |
| DEFEATED | false |
| FINISHED | false |
| NEXT | false |

