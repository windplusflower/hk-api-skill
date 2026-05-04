# Lost Hero Check

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Lost Hero Check |
| GameObject Name | Ruins Flying Sentry |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level97 |
| Start State | Out |
| FSM PathId | 5881 |
| GameObject PathId | 1056 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Lost Counter | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Lost Region | false | Boolean: false |

## States

### Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Lost Region | Variable |   |
| isTrue |   | Event(IN) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 2. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Lost Counter | Variable |   |
| add |   | 1f |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | true |   |   |

##### 3. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Lost Counter | Variable |   |
| minValue |   | 0f |   |   |
| maxValue |   | 1000f |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| IN | In | 0 | |

### In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Lost Region | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(OUT) |   |   |
| everyFrame |   | true |   |   |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Lost Counter | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| OUT | Out | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| IN | false |
| OUT | false |

