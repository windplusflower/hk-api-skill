# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 19541 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Damage Float | 0 | Single: 0 |
| Multiplier | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| nailDamage | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Fury | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Log |  | String:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetNailDamage

Full Name: GetNailDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeValue | int nailDamage | int nailDamage | Variable |  |

##### 2. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int nailDamage | int nailDamage | Variable |  |
| floatVariable | float Damage Float | float Damage Float | Variable |  |
| everyFrame | false | false |  |  |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damage Float | float Damage Float | Variable |  |
| multiplyBy | float Multiplier | float Multiplier |  |  |
| everyFrame | false | false |  |  |

##### 4. FormatString

Full Name: HutongGames.PlayMaker.Actions.FormatString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| format | "nailDamage: {0}, multiplied: {1}" | "nailDamage: {0}, multiplied: {1}" |  |  |
| variables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | string Log | string Log | Variable |  |
| everyFrame | false | false |  |  |

##### 5. DebugLogConsole

Full Name: HutongGames.PlayMaker.Actions.DebugLogConsole
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| logLevel | HutongGames.PlayMaker.LogLevel::Info | 0 |  |  |
| text | string Log | string Log |  |  |
| sendToUnityLog | true | true |  |  |

### Fury?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "FURY REFRESH" | "FURY REFRESH" |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Fury | bool Fury | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damage Float | float Damage Float | Variable |  |
| multiplyBy | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 4. FormatString

Full Name: HutongGames.PlayMaker.Actions.FormatString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| format | "Applied fury, new: {0}" | "Applied fury, new: {0}" |  |  |
| variables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | string Log | string Log | Variable |  |
| everyFrame | false | false |  |  |

##### 5. DebugLogConsole

Full Name: HutongGames.PlayMaker.Actions.DebugLogConsole
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| logLevel | HutongGames.PlayMaker.LogLevel::Info | 0 |  |  |
| text | string Log | string Log |  |  |
| sendToUnityLog | true | true |  |  |

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ConvertFloatToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertFloatToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Damage Float | float Damage Float | Variable |  |
| intVariable | int nailDamage | int nailDamage | Variable |  |
| rounding | HutongGames.PlayMaker.Actions.ConvertFloatToInt/FloatRounding::Nearest | 2 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | int nailDamage | int nailDamage |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Fury? | 0 | 0 | 0 |
| Fury? | FINISHED | Set | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

