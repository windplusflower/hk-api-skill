# ui_list_button_listen

## Summary

| Field | Value |
| --- | --- |
| FSM Name | ui_list_button_listen |
| GameObject Name | UI List |
| GameObject Path | Shop Menu/Confirm/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level10 |
| Start State | Init |
| FSM PathId | 485 |
| GameObject PathId | 60 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cancel Item | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Start Inactive | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.25f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Start Inactive | Variable |   |
| isTrue |   | Event(INACTIVE) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect | 0 | |
| INACTIVE | UI Inactive | 0 | |

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ListenForMenuActions

Full Name: HutongGames.PlayMaker.Actions.ListenForMenuActions
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| submitPressed |   | Event(SELECT PRESSED) |   |   |
| cancelPressed |   | Event(CANCEL PRESSED) |   |   |
| ignoreAttack |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SELECT PRESSED | Select Pressed | 0 | |
| CANCEL PRESSED | Cancel Pressed | 0 | |

### Select Pressed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:Self |   |   |
| sendEvent |   | "SELECTION MADE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. Wait

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
| FINISHED | Detect | 0 | |

### Cancel Pressed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| fsmName |   | "ui_list" | FsmName |   |
| variableName |   | "Cancel Item" | FsmInt |   |
| storeValue |   | int Cancel Item | Variable |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| fsmName |   | "ui_list" | FsmName |   |
| variableName |   | "Current Item" | FsmInt |   |
| setValue |   | int Cancel Item |   |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject)[SendToChildren]:Self |   |   |
| sendEvent |   | "SELECTION MADE CANCEL" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player UI (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | [Global] GameObject Hero |   |   |
| audioClip |   | [button (AudioClip) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| pitchMin |   | 0.65f |   |   |
| pitchMax |   | 0.65f |   |   |
| volume |   | 0.6f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Detect | 0 | |

### UI Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UI ACTIVE | Detect | 0 | |
| UI INACTIVE | UI Inactive | 0 | |

## Events

| Name | Global |
| --- | --- |
| CANCEL PRESSED | false |
| FINISHED | false |
| INACTIVE | false |
| SELECT PRESSED | false |
| UI ACTIVE | false |
| UI INACTIVE | false |

