# nailart_damage

## Summary

| Field | Value |
| --- | --- |
| FSM Name | nailart_damage |
| GameObject Name | Hit L |
| GameObject Path | Knight/Attacks/Cyclone Slash/Hits/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | Init |
| FSM PathId | 917 |
| GameObject PathId | 51 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Damage Float | 0 | Single: 0 |
| Multiplier | 1.25 | Single: 1.25 |

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
| Log |   | String:  |

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
| storeValue |   | int nailDamage | Variable |   |

##### 2. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int nailDamage | Variable |   |
| floatVariable |   | float Damage Float | Variable |   |
| everyFrame |   | false |   |   |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damage Float | Variable |   |
| multiplyBy |   | float Multiplier |   |   |
| everyFrame |   | false |   |   |

##### 4. FormatString

Full Name: HutongGames.PlayMaker.Actions.FormatString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| format |   | "nailDamage: {0}, multiplied: {1}" |   |   |
| variables |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | string Log | Variable |   |
| everyFrame |   | false |   |   |

##### 5. DebugLogConsole

Full Name: HutongGames.PlayMaker.Actions.DebugLogConsole
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| logLevel | HutongGames.PlayMaker.LogLevel::Info | 0 |   |   |
| text |   | string Log |   |   |
| sendToUnityLog |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fury? | 0 | |

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
| eventName |   | "FURY REFRESH" |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Fury | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 3. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Damage Float | Variable |   |
| multiplyBy |   | 1.75f |   |   |
| everyFrame |   | false |   |   |

##### 4. FormatString

Full Name: HutongGames.PlayMaker.Actions.FormatString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| format |   | "Applied fury, new: {0}" |   |   |
| variables |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | string Log | Variable |   |
| everyFrame |   | false |   |   |

##### 5. DebugLogConsole

Full Name: HutongGames.PlayMaker.Actions.DebugLogConsole
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| logLevel | HutongGames.PlayMaker.LogLevel::Info | 0 |   |   |
| text |   | string Log |   |   |
| sendToUnityLog |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set | 0 | |

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
| floatVariable |   | float Damage Float | Variable |   |
| intVariable |   | int nailDamage | Variable |   |
| rounding | HutongGames.PlayMaker.Actions.ConvertFloatToInt/FloatRounding::Nearest | 2 |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "damageDealt" | FsmInt |   |
| setValue |   | int nailDamage |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

