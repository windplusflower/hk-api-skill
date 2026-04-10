# ui_list_button_listen

## Summary

| Field | Value |
| --- | --- |
| FSM Name | ui_list_button_listen |
| GameObject Name | UI List |
| GameObject Path | _GameCameras/HudCamera/DialogueManager/Text YN |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 22599 |
| GameObject PathId | 4079 |

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
| Self | [null] | NamedAssetPPtr:  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Start Inactive | bool Start Inactive | Variable |  |
| isTrue | Event(INACTIVE) | Event(INACTIVE) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

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
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| submitPressed | Event(SELECT PRESSED) | Event(SELECT PRESSED) |  |  |
| cancelPressed | Event(CANCEL PRESSED) | Event(CANCEL PRESSED) |  |  |
| ignoreAttack | false | false |  |  |

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
| eventTarget | EventTarget(GameObject)[SendToChildren]:Self | EventTarget(GameObject)[SendToChildren]:Self |  |  |
| sendEvent | "SELECTION MADE" | "SELECTION MADE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

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
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Cancel Item" | "Cancel Item" | FsmInt |  |
| storeValue | int Cancel Item | int Cancel Item | Variable |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Current Item" | "Current Item" | FsmInt |  |
| setValue | int Cancel Item | int Cancel Item |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Self | EventTarget(GameObject)[SendToChildren]:Self |  |  |
| sendEvent | "SELECTION MADE CANCEL" | "SELECTION MADE CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [button (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [button (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 0.65f | 0.65f |  |  |
| pitchMax | 0.65f | 0.65f |  |  |
| volume | 0.6f | 0.6f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### UI Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Detect | 0 | 0 | 0 |
| Init | INACTIVE | UI Inactive | 0 | 0 | 0 |
| Detect | SELECT PRESSED | Select Pressed | 0 | 0 | 0 |
| Detect | CANCEL PRESSED | Cancel Pressed | 0 | 0 | 0 |
| Select Pressed | FINISHED | Detect | 0 | 0 | 0 |
| Cancel Pressed | FINISHED | Detect | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| UI ACTIVE | Detect | 0 | 0 | 0 |
| UI INACTIVE | UI Inactive | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CANCEL PRESSED | false |
| INACTIVE | false |
| SELECT PRESSED | false |
| UI ACTIVE | false |
| UI INACTIVE | false |

