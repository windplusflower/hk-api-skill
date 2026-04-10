# ui_list_getinput

## Summary

| Field | Value |
| --- | --- |
| FSM Name | ui_list_getinput |
| GameObject Name | Charms |
| GameObject Path | _GameCameras/HudCamera/Inventory |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20978 |
| GameObject PathId | 6719 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Item | 0 | Int32: 0 |
| Direction Pressed | 0 | Int32: 0 |
| Initial Item | 1 | Int32: 1 |
| Repeats | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Allow Horizontal Selection | true | Boolean: true |
| Allow Vertical Selection | true | Boolean: true |
| Ignore Attack | false | Boolean: false |
| Repeating | false | Boolean: false |
| Right Stick Speed | true | Boolean: true |
| Start Inactive | true | Boolean: true |

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
Local Transitions: 8

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Repeating | bool Repeating | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Repeats | int Repeats | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 3. ListenForRight

Full Name: HutongGames.PlayMaker.Actions.ListenForRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(RIGHT PRESS) | Event(RIGHT PRESS) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 4. ListenForLeft

Full Name: HutongGames.PlayMaker.Actions.ListenForLeft
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(LEFT PRESS) | Event(LEFT PRESS) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 5. ListenForUp

Full Name: HutongGames.PlayMaker.Actions.ListenForUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(UP PRESS) | Event(UP PRESS) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 6. ListenForDown

Full Name: HutongGames.PlayMaker.Actions.ListenForDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(DOWN PRESS) | Event(DOWN PRESS) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |
| isPressedBool | false | false | Variable |  |
| stateEntryOnly | false | false |  |  |

##### 7. ListenForMenuActions

Full Name: HutongGames.PlayMaker.Actions.ListenForMenuActions
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| submitPressed | Event(SELECTION MADE) | Event(SELECTION MADE) |  |  |
| cancelPressed | Event(PRESS CANCEL) | Event(PRESS CANCEL) |  |  |
| ignoreAttack | bool Ignore Attack | bool Ignore Attack |  |  |

##### 8. ListenForRsDown

Full Name: HutongGames.PlayMaker.Actions.ListenForRsDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event(RS DOWN PRESS) | Event(RS DOWN PRESS) |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 9. ListenForRsUp

Full Name: HutongGames.PlayMaker.Actions.ListenForRsUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event(RS UP PRESS) | Event(RS UP PRESS) |  |  |
| isNotPressed | Event() | Event() |  |  |

### Select Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Allow Vertical Selection | bool Allow Vertical Selection | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Direction Pressed | int Direction Pressed | Variable |  |
| intValue | 2 | 2 |  |  |
| everyFrame | false | false |  |  |

##### 3. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UI UP" | "UI UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Select Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Allow Horizontal Selection | bool Allow Horizontal Selection | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Direction Pressed | int Direction Pressed | Variable |  |
| intValue | 3 | 3 |  |  |
| everyFrame | false | false |  |  |

##### 3. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UI LEFT" | "UI LEFT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Select Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Allow Vertical Selection | bool Allow Vertical Selection | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Direction Pressed | int Direction Pressed | Variable |  |
| intValue | 4 | 4 |  |  |
| everyFrame | false | false |  |  |

##### 3. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Add | 0 |  |  |
| storeResult | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UI DOWN" | "UI DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Select Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Direction Pressed | int Direction Pressed | Variable |  |
| intValue | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Allow Horizontal Selection | bool Allow Horizontal Selection | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 3. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Current Item | int Current Item |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Add | 0 |  |  |
| storeResult | int Current Item | int Current Item | Variable |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UI RIGHT" | "UI RIGHT" |  |  |
| delay | 0f | 0f |  |  |
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

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: false

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

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Repeats | int Repeats | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. ListenForUp

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

##### 4. Wait

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

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Repeats | int Repeats | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. ListenForDown

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

##### 4. Wait

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

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Repeats | int Repeats | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. ListenForRight

Full Name: HutongGames.PlayMaker.Actions.ListenForRight
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |

##### 4. Wait

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

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Repeats | int Repeats | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. ListenForLeft

Full Name: HutongGames.PlayMaker.Actions.ListenForLeft
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(CANCEL) | Event(CANCEL) |  |  |

##### 4. Wait

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

### Confirm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UI CONFIRM" | "UI CONFIRM" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### RS Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Right Stick Speed | bool Right Stick Speed | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. ListenForRsUp

Full Name: HutongGames.PlayMaker.Actions.ListenForRsUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UI RS UP" | "UI RS UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### RS Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Right Stick Speed | bool Right Stick Speed | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. ListenForRsDown

Full Name: HutongGames.PlayMaker.Actions.ListenForRsDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event() | Event() |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UI RS DOWN" | "UI RS DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Cancel

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UI CANCEL" | "UI CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | UI ACTIVE | Activate | 0 | 0 | 0 |
| Idle | UP PRESS | Select Up | 0 | 0 | 0 |
| Idle | DOWN PRESS | Select Down | 0 | 0 | 0 |
| Idle | LEFT PRESS | Select Left | 0 | 0 | 0 |
| Idle | RIGHT PRESS | Select Right | 0 | 0 | 0 |
| Idle | SELECTION MADE | Confirm | 0 | 0 | 0 |
| Idle | RS UP PRESS | RS Up | 0 | 0 | 0 |
| Idle | RS DOWN PRESS | RS Down | 0 | 0 | 0 |
| Idle | PRESS CANCEL | Cancel | 0 | 0 | 0 |
| Select Up | CANCEL | Idle | 0 | 0 | 0 |
| Select Up | FINISHED | Update | 0 | 0 | 0 |
| Select Left | CANCEL | Idle | 0 | 0 | 0 |
| Select Left | FINISHED | Update | 0 | 0 | 0 |
| Select Down | CANCEL | Idle | 0 | 0 | 0 |
| Select Down | FINISHED | Update | 0 | 0 | 0 |
| Select Right | CANCEL | Idle | 0 | 0 | 0 |
| Select Right | FINISHED | Update | 0 | 0 | 0 |
| Update | UP PRESS | Still Up? | 0 | 0 | 0 |
| Update | DOWN PRESS | Still Down? | 0 | 0 | 0 |
| Update | RIGHT PRESS | Still Right? | 0 | 0 | 0 |
| Update | LEFT PRESS | Still Left? | 0 | 0 | 0 |
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
| Confirm | FINISHED | Idle | 0 | 0 | 0 |
| Confirm | CONFIRM CANCEL | Idle | 0 | 0 | 0 |
| RS Up | FINISHED | Idle | 0 | 0 | 0 |
| RS Down | FINISHED | Idle | 0 | 0 | 0 |
| Cancel | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| UI INACTIVE | Inactive | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CANCEL | false |
| CONFIRM CANCEL | false |
| DOWN PRESS | false |
| LEFT PRESS | false |
| PRESS CANCEL | false |
| REPEAT | false |
| RIGHT PRESS | false |
| RS DOWN PRESS | false |
| RS UP PRESS | false |
| SELECT UPDATE | false |
| SELECTION MADE | false |
| UI ACTIVE | false |
| UI CONFIRM | false |
| UI INACTIVE | false |
| UP PRESS | false |

