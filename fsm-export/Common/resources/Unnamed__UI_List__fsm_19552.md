# UI List

## Summary

| Field | Value |
| --- | --- |
| FSM Name | UI List |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 19552 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Axis Horizontal | 0 | Single: 0 |
| Axis Vertical | 0 | Single: 0 |
| Selection Pause | 0.25 | Single: 0.25 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cancel Item | 0 | Int32: 0 |
| Current Item | 0 | Int32: 0 |
| Direction Pressed | 0 | Int32: 0 |
| Initial Item | 1 | Int32: 1 |
| Items | 2 | Int32: 2 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Allow Horizontal Selection | true | Boolean: true |
| Allow Vertical Selection | true | Boolean: true |
| Repeating | false | Boolean: false |
| Selected Unselectable | false | Boolean: false |
| Start Inactive | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Selection |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |

## States

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

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Start Inactive | bool Start Inactive | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(UI ACTIVE) | Event(UI ACTIVE) |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. ListenForRight

Full Name: HutongGames.PlayMaker.Actions.ListenForRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(RIGHT) | Event(RIGHT) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 3. ListenForLeft

Full Name: HutongGames.PlayMaker.Actions.ListenForLeft
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(LEFT) | Event(LEFT) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 4. ListenForDown

Full Name: HutongGames.PlayMaker.Actions.ListenForDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(DOWN) | Event(DOWN) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 5. ListenForUp

Full Name: HutongGames.PlayMaker.Actions.ListenForUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(UP) | Event(UP) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

### Select Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 0.65f | 0.65f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Allow Vertical Selection | bool Allow Vertical Selection | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Direction Pressed | int Direction Pressed | Variable |  |
| intValue | 2 | 2 |  |  |
| everyFrame | false | false |  |  |

##### 4. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

### Wrap Back?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| intValue | int Items | int Items |  |  |
| everyFrame | false | false |  |  |

### Select Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 0.65f | 0.65f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Allow Horizontal Selection | bool Allow Horizontal Selection | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Direction Pressed | int Direction Pressed | Variable |  |
| intValue | 3 | 3 |  |  |
| everyFrame | false | false |  |  |

##### 4. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

### Select Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 0.65f | 0.65f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Allow Vertical Selection | bool Allow Vertical Selection | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Direction Pressed | int Direction Pressed | Variable |  |
| intValue | 4 | 4 |  |  |
| everyFrame | false | false |  |  |

##### 4. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Add | 0 |  |  |
| storeResult | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

### Wrap Forward?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | int Items | int Items |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Select Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_change_selection (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 0.65f | 0.65f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Direction Pressed | int Direction Pressed | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Allow Horizontal Selection | bool Allow Horizontal Selection | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 4. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Add | 0 |  |  |
| storeResult | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

### Update

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "SELECT UPDATE" | "SELECT UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Direction Pressed | int Direction Pressed | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Selection Made

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [ui_button_confirm (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] | [ui_button_confirm (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets0.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 0.75f | 0.75f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Notify

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Selected Unselectable | bool Selected Unselectable | Variable |  |
| isTrue | Event(CANCEL) | Event(CANCEL) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "UI SELECTION MADE" | "UI SELECTION MADE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Current Item | int Current Item | Variable |  |
| intValue | int Initial Item | int Initial Item |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "SELECT UPDATE" | "SELECT UPDATE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Still Up?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ListenForUp

Full Name: HutongGames.PlayMaker.Actions.ListenForUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| isTrue | Event(REPEAT) | Event(REPEAT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(REPEAT) | Event(REPEAT) |  |  |
| realTime | false | false |  |  |

### Repeat Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. ListenForUp

Full Name: HutongGames.PlayMaker.Actions.ListenForUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(REPEAT) | Event(REPEAT) |  |  |
| realTime | false | false |  |  |

### Still Down?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ListenForDown

Full Name: HutongGames.PlayMaker.Actions.ListenForDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| isTrue | Event(REPEAT) | Event(REPEAT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(REPEAT) | Event(REPEAT) |  |  |
| realTime | false | false |  |  |

### Repeat Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. ListenForDown

Full Name: HutongGames.PlayMaker.Actions.ListenForDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(REPEAT) | Event(REPEAT) |  |  |
| realTime | false | false |  |  |

### Still Right?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ListenForRight

Full Name: HutongGames.PlayMaker.Actions.ListenForRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| isTrue | Event(REPEAT) | Event(REPEAT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(REPEAT) | Event(REPEAT) |  |  |
| realTime | false | false |  |  |

### Repeat Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. ListenForRight

Full Name: HutongGames.PlayMaker.Actions.ListenForRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(REPEAT) | Event(REPEAT) |  |  |
| realTime | false | false |  |  |

### Still Left?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ListenForLeft

Full Name: HutongGames.PlayMaker.Actions.ListenForLeft
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| isTrue | Event(REPEAT) | Event(REPEAT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(REPEAT) | Event(REPEAT) |  |  |
| realTime | false | false |  |  |

### Repeat Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. ListenForLeft

Full Name: HutongGames.PlayMaker.Actions.ListenForLeft
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(REPEAT) | Event(REPEAT) |  |  |
| realTime | false | false |  |  |

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Selection Made Cancel

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.2f | 0.2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### CancelToIdle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | UI ACTIVE | Activate | 0 | 0 | 0 |
| Idle | UP | Select Up | 0 | 0 | 0 |
| Idle | DOWN | Select Down | 0 | 0 | 0 |
| Idle | LEFT | Select Left | 0 | 0 | 0 |
| Idle | RIGHT | Select Right | 0 | 0 | 0 |
| Select Up | CANCEL | CancelToIdle | 0 | 0 | 0 |
| Select Up | FINISHED | Wrap Back? | 0 | 0 | 0 |
| Wrap Back? | CANCEL | Update | 0 | 0 | 0 |
| Wrap Back? | FINISHED | Update | 0 | 0 | 0 |
| Select Left | CANCEL | CancelToIdle | 0 | 0 | 0 |
| Select Left | FINISHED | Wrap Back? | 0 | 0 | 0 |
| Select Down | CANCEL | CancelToIdle | 0 | 0 | 0 |
| Select Down | FINISHED | Wrap Forward? | 0 | 0 | 0 |
| Wrap Forward? | CANCEL | Update | 0 | 0 | 0 |
| Wrap Forward? | FINISHED | Update | 0 | 0 | 0 |
| Select Right | CANCEL | CancelToIdle | 0 | 0 | 0 |
| Select Right | FINISHED | Wrap Forward? | 0 | 0 | 0 |
| Update | UP | Still Up? | 0 | 0 | 0 |
| Update | DOWN | Still Down? | 0 | 0 | 0 |
| Update | RIGHT | Still Right? | 0 | 0 | 0 |
| Update | LEFT | Still Left? | 0 | 0 | 0 |
| Selection Made | FINISHED | Notify | 0 | 0 | 0 |
| Notify | CANCEL | Idle | 0 | 0 | 0 |
| Activate | FINISHED | Idle | 0 | 0 | 0 |
| Still Up? | CANCEL | Idle | 0 | 0 | 0 |
| Still Up? | REPEAT | Repeat Up | 0 | 0 | 0 |
| Repeat Up | CANCEL | Idle | 0 | 0 | 0 |
| Repeat Up | REPEAT | Select Up | 0 | 0 | 0 |
| Still Down? | CANCEL | Idle | 0 | 0 | 0 |
| Still Down? | REPEAT | Repeat Down | 0 | 0 | 0 |
| Repeat Down | CANCEL | Idle | 0 | 0 | 0 |
| Repeat Down | REPEAT | Select Down | 0 | 0 | 0 |
| Still Right? | CANCEL | Idle | 0 | 0 | 0 |
| Still Right? | REPEAT | Repeat Right | 0 | 0 | 0 |
| Repeat Right | CANCEL | Idle | 0 | 0 | 0 |
| Repeat Right | REPEAT | Select Right | 0 | 0 | 0 |
| Still Left? | CANCEL | Idle | 0 | 0 | 0 |
| Still Left? | REPEAT | Repeat Left | 0 | 0 | 0 |
| Repeat Left | CANCEL | Idle | 0 | 0 | 0 |
| Repeat Left | REPEAT | Select Left | 0 | 0 | 0 |
| Inactive | UI ACTIVE | Activate | 0 | 0 | 0 |
| Selection Made Cancel | FINISHED | Notify | 0 | 0 | 0 |
| CancelToIdle | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| SELECTION MADE | Selection Made | 0 | 0 | 0 |
| UI INACTIVE | Inactive | 0 | 0 | 0 |
| SELECTION MADE CANCEL | Selection Made Cancel | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CANCEL | false |
| DOWN | false |
| LEFT | false |
| REPEAT | false |
| RIGHT | false |
| SELECT UPDATE | false |
| SELECTION MADE | false |
| SELECTION MADE CANCEL | false |
| UI ACTIVE | false |
| UI INACTIVE | false |
| UP | false |

