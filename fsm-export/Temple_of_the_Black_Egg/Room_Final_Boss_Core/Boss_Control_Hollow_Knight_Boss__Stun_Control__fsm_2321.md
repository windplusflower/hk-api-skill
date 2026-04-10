# Stun Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Stun Control |
| GameObject Name | Hollow Knight Boss |
| GameObject Path | Boss Control |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level409.assets |
| Start State | Init |
| FSM PathId | 2321 |
| GameObject PathId | 149 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Combo Time | 1 | Single: 1 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Combo Counter | 0 | Int32: 0 |
| Decrement | 0 | Int32: 0 |
| Hits Total | 0 | Int32: 0 |
| Stun Combo | 10 | Int32: 10 |
| Stun Hit Max | 12 | Int32: 12 |
| Stuns Max | 5 | Int32: 5 |
| Stuns Total | 0 | Int32: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Tag |  | String:  |

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

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### In Combo

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Combo Counter | int Combo Counter | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Hits Total | int Hits Total | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Combo Counter | int Combo Counter |  |  |
| integer2 | int Stun Combo | int Stun Combo |  |  |
| equal | Event(STUN) | Event(STUN) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Combo Time | float Combo Time |  |  |
| finishEvent | Event(TIME OUT) | Event(TIME OUT) |  |  |
| realTime | false | false |  |  |

### Reset Counter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Combo Counter | int Combo Counter | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

### Continue Combo

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Hits Total | int Hits Total |  |  |
| integer2 | int Stun Hit Max | int Stun Hit Max |  |  |
| equal | Event(STUN) | Event(STUN) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(STUN) | Event(STUN) |  |  |
| everyFrame | false | false |  |  |

### Stun

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Stuns Total | int Stuns Total |  |  |
| integer2 | int Stuns Max | int Stuns Max |  |  |
| equal | Event(MAX) | Event(MAX) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(MAX) | Event(MAX) |  |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Stuns Total | int Stuns Total | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "STUN" | "STUN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Combo Counter | int Combo Counter | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 5. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Hits Total | int Hits Total | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

### Max Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetTag

Full Name: HutongGames.PlayMaker.Actions.GetTag
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |  |  |  |  |
| storeResult | "" | "" | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Hits Total | int Hits Total |  |  |
| integer2 | int Stun Hit Max | int Stun Hit Max |  |  |
| equal | Event(STUN) | Event(STUN) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(STUN) | Event(STUN) |  |  |
| everyFrame | false | false |  |  |

### Stop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

_None_

### Unstun Increment

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Hits Total | int Hits Total | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Heavy Blow

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_15" | "equippedCharm_15" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Stun Hit Max | int Stun Hit Max |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Stun Hit Max | int Stun Hit Max | Variable |  |
| everyFrame | false | false |  |  |

##### 3. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Stun Combo | int Stun Combo |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Stun Combo | int Stun Combo | Variable |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Heavy Blow | 0 | 0 | 0 |
| Idle | STUN DAMAGE | Max Check | 0 | 0 | 0 |
| In Combo | TIME OUT | Reset Counter | 0 | 0 | 0 |
| In Combo | STUN DAMAGE | Continue Combo | 0 | 0 | 0 |
| In Combo | STUN | Stun | 0 | 0 | 0 |
| Reset Counter | FINISHED | Idle | 0 | 0 | 0 |
| Continue Combo | FINISHED | In Combo | 0 | 0 | 0 |
| Continue Combo | STUN | Stun | 0 | 0 | 0 |
| Stun | FINISHED | Idle | 0 | 0 | 0 |
| Max Check | FINISHED | In Combo | 0 | 0 | 0 |
| Max Check | STUN | Stun | 0 | 0 | 0 |
| Stop | STUN CONTROL START | Reset Counter | 0 | 0 | 0 |
| Stop | STUN DAMAGE | Unstun Increment | 0 | 0 | 0 |
| Unstun Increment | FINISHED | Stop | 0 | 0 | 0 |
| Reset | STUN CONTROL START | Reset Counter | 0 | 0 | 0 |
| Heavy Blow | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| STUN CONTROL STOP | Stop | 0 | 0 | 0 |
| STUN CONTROL RESET | Reset | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| MAX | false |
| STUN | false |
| STUN CONTROL RESET | false |
| STUN CONTROL START | false |
| STUN CONTROL STOP | false |
| STUN DAMAGE | false |
| TIME OUT | false |
| TOOK DAMAGE | false |

