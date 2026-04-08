# recoil

## Summary

| Field | Value |
| --- | --- |
| FSM Name | recoil |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets397.assets |
| Start State | Initiate |
| FSM PathId | 12 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Direction | 0 | Single: 0 |
| Attack Magnitude | 0 | Single: 0 |
| Modified Recoil per second | 0 | Single: 0 |
| Recoil Time | 0 | Single: 0 |
| Recoil per second | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Type | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Freeze In Place | false | Boolean: false |
| Freeze Recoil Up | false | Boolean: false |
| No Recoil Up | false | Boolean: false |
| Recoiling | false | Boolean: false |
| Stop Freezing | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Recoiling | bool Recoiling | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Initiate

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

### Receive Damager Parameters

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| fsmName | "health_manager_enemy" | "health_manager_enemy" | FsmName |  |
| variableName | "Attack Direction" | "Attack Direction" | FsmFloat |  |
| storeValue | float Attack Direction | float Attack Direction | Variable |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Recoiling | bool Recoiling | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 3. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| fsmName | "health_manager_enemy" | "health_manager_enemy" | FsmName |  |
| variableName | "Attack Type" | "Attack Type" | FsmInt |  |
| storeValue | int Attack Type | int Attack Type | Variable |  |
| everyFrame | false | false |  |  |

##### 4. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| fsmName | "health_manager_enemy" | "health_manager_enemy" | FsmName |  |
| variableName | "Attack Magnitude" | "Attack Magnitude" | FsmFloat |  |
| storeValue | float Attack Magnitude | float Attack Magnitude | Variable |  |
| everyFrame | false | false |  |  |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Freeze In Place | bool Freeze In Place | Variable |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 6. FloatSwitch

Full Name: HutongGames.PlayMaker.Actions.FloatSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Attack Direction | float Attack Direction | Variable |  |
| lessThan | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Recoil Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| floatValue | float Recoil per second | float Recoil per second |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| multiplyBy | float Attack Magnitude | float Attack Magnitude |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| divideBy | 50f | 50f |  |  |
| everyFrame | false | false |  |  |

##### 4. TranslateContinuous

Full Name: HutongGames.PlayMaker.Actions.TranslateContinuous
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| x | float Modified Recoil per second | float Modified Recoil per second |  |  |
| y | 0f | 0f |  |  |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Recoil Time | float Recoil Time |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 6. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | Event(RECOIL HORIZONTAL) | Event(RECOIL HORIZONTAL) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "HIT RIGHT" | "HIT RIGHT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Recoil Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| floatValue | float Recoil per second | float Recoil per second |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| multiplyBy | float Attack Magnitude | float Attack Magnitude |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| divideBy | 50f | 50f |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 5. TranslateContinuous

Full Name: HutongGames.PlayMaker.Actions.TranslateContinuous
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| x | float Modified Recoil per second | float Modified Recoil per second |  |  |
| y | 0f | 0f |  |  |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Recoil Time | float Recoil Time |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 7. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | Event(RECOIL HORIZONTAL) | Event(RECOIL HORIZONTAL) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "HIT LEFT" | "HIT LEFT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Recoil Up Normal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| floatValue | float Recoil per second | float Recoil per second |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| multiplyBy | float Attack Magnitude | float Attack Magnitude |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| divideBy | 50f | 50f |  |  |
| everyFrame | false | false |  |  |

##### 4. TranslateContinuous

Full Name: HutongGames.PlayMaker.Actions.TranslateContinuous
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| x | 0f | 0f |  |  |
| y | float Modified Recoil per second | float Modified Recoil per second |  |  |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Recoil Time | float Recoil Time |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Recoil Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| floatValue | float Recoil per second | float Recoil per second |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| multiplyBy | float Attack Magnitude | float Attack Magnitude |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| divideBy | 50f | 50f |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 5. TranslateContinuous

Full Name: HutongGames.PlayMaker.Actions.TranslateContinuous
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| x | 0f | 0f |  |  |
| y | float Modified Recoil per second | float Modified Recoil per second |  |  |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Recoil Time | float Recoil Time |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "HIT DOWN" | "HIT DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Freezes?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "HIT UP" | "HIT UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | false | false | Variable |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |
| everyFrame | false | false |  |  |

### Recoil Up Freeze X

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| floatValue | float Recoil per second | float Recoil per second |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| multiplyBy | float Attack Magnitude | float Attack Magnitude |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatDivide

Full Name: HutongGames.PlayMaker.Actions.FloatDivide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| divideBy | 50f | 50f |  |  |
| everyFrame | false | false |  |  |

##### 5. TranslateContinuous

Full Name: HutongGames.PlayMaker.Actions.TranslateContinuous
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| x | 0f | 0f |  |  |
| y | float Modified Recoil per second | float Modified Recoil per second |  |  |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Recoil Time | float Recoil Time |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Freeze In Place

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Stop Freezing | bool Stop Freezing | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: Climber Control]:Self | EventTarget(GameObjectFSM)[SendToFSM: Climber Control]:Self |  |  |
| sendEvent | "FREEZE IN PLACE" | "FREEZE IN PLACE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Recoil Time | float Recoil Time |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Recoil Hero Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Attack Type | int Attack Type |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault  | OwnerDefault  |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RecoilLeft(???) | RecoilLeft(???) |  |  |

### Recoil Hero Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Attack Type | int Attack Type |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault  | OwnerDefault  |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RecoilRight(???) | RecoilRight(???) |  |  |

### Recoil Right N

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| floatValue | float Recoil per second | float Recoil per second |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| multiplyBy | float Attack Magnitude | float Attack Magnitude |  |  |
| everyFrame | false | false |  |  |

##### 3. AddForce2d

Full Name: HutongGames.PlayMaker.Actions.AddForce2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| forceMode | UnityEngine.ForceMode2D::Force | 0 |  |  |
| atPosition | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Modified Recoil per second | float Modified Recoil per second |  |  |
| y | 0f | 0f |  |  |
| vector3 | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| everyFrame | true | true |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Recoil Time | float Recoil Time |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | Event(RECOIL HORIZONTAL) | Event(RECOIL HORIZONTAL) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "HIT RIGHT" | "HIT RIGHT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Recoil Left N

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| floatValue | float Recoil per second | float Recoil per second |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| multiplyBy | float Attack Magnitude | float Attack Magnitude |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Modified Recoil per second | float Modified Recoil per second | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 4. AddForce2d

Full Name: HutongGames.PlayMaker.Actions.AddForce2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| forceMode | UnityEngine.ForceMode2D::Force | 0 |  |  |
| atPosition | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Modified Recoil per second | float Modified Recoil per second |  |  |
| y | 0f | 0f |  |  |
| vector3 | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| everyFrame | true | true |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Recoil Time | float Recoil Time |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 6. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | Event(RECOIL HORIZONTAL) | Event(RECOIL HORIZONTAL) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Self | EventTarget(GameObject):Self |  |  |
| sendEvent | "HIT RIGHT" | "HIT RIGHT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### No Recoil Up?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool No Recoil Up | bool No Recoil Up | Variable |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | BEGIN RECOIL | Receive Damager Parameters | 0 | 0 | 0 |
| Idle | RECOIL L | Recoil Left | 0 | 0 | 0 |
| Idle | RECOIL R | Recoil Right | 0 | 0 | 0 |
| Idle | RECOIL U | No Recoil Up? | 0 | 0 | 0 |
| Idle | RECOIL D | Recoil Down | 0 | 0 | 0 |
| Initiate | FINISHED | Idle | 0 | 0 | 0 |
| Receive Damager Parameters | DOWN | Recoil Down | 0 | 0 | 0 |
| Receive Damager Parameters | LEFT | Recoil Hero Right | 0 | 0 | 0 |
| Receive Damager Parameters | RIGHT | Recoil Hero Left | 0 | 0 | 0 |
| Receive Damager Parameters | UP | No Recoil Up? | 0 | 0 | 0 |
| Receive Damager Parameters | TRUE | Freeze In Place | 0 | 0 | 0 |
| Recoil Right | FINISHED | Idle | 0 | 0 | 0 |
| Recoil Left | FINISHED | Idle | 0 | 0 | 0 |
| Recoil Up Normal | FINISHED | Idle | 0 | 0 | 0 |
| Recoil Down | FINISHED | Idle | 0 | 0 | 0 |
| Freezes? | TRUE | Recoil Up Freeze X | 0 | 0 | 0 |
| Freezes? | FALSE | Recoil Up Normal | 0 | 0 | 0 |
| Recoil Up Freeze X | FINISHED | Idle | 0 | 0 | 0 |
| Freeze In Place | FINISHED | Idle | 0 | 0 | 0 |
| Recoil Hero Left | FINISHED | Recoil Right | 0 | 0 | 0 |
| Recoil Hero Right | FINISHED | Recoil Left | 0 | 0 | 0 |
| Recoil Right N | FINISHED | Idle | 0 | 0 | 0 |
| Recoil Left N | FINISHED | Idle | 0 | 0 | 0 |
| No Recoil Up? | TRUE | Idle | 0 | 0 | 0 |
| No Recoil Up? | FALSE | Freezes? | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| CANCEL RECOIL | Idle | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BEGIN RECOIL | true |
| CANCEL RECOIL | false |
| DOWN | false |
| DREAM RECOIL L | false |
| DREAM RECOIL R | false |
| FALSE | false |
| LEFT | false |
| RECOIL D | false |
| RECOIL HORIZONTAL | true |
| RECOIL L | false |
| RECOIL R | false |
| RECOIL U | false |
| RIGHT | false |
| TRUE | false |
| UP | false |

