# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | blue stuff |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level463 |
| Start State | Get Bindings |
| FSM PathId | 1762 |
| GameObject PathId | 270 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Completed Bindings | 0 | Int32: 0 |
| Scuttler Amount | 0 | Int32: 0 |

## States

### Get Bindings

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. GGGetCompletedBindings

Full Name: GGGetCompletedBindings
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeValue |   | int Completed Bindings |   |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Completed Bindings |   |   |
| integer2 |   | 16 |   |   |
| equal |   | LEVEL 3 |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | LEVEL 3 |   |   |
| everyFrame |   | false |   |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Completed Bindings |   |   |
| integer2 |   | 12 |   |   |
| equal |   | LEVEL 2 |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | LEVEL 2 |   |   |
| everyFrame |   | false |   |   |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Completed Bindings |   |   |
| integer2 |   | 8 |   |   |
| equal |   | LEVEL 1 |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | LEVEL 1 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Inert | 0 | |
| LEVEL 1 | Level 1 | 0 | |
| LEVEL 2 | Level 2 | 0 | |
| LEVEL 3 | Level 3 | 0 | |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Set Amount

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault blue stuff/Health Cocoon (1) |   |   |
| behaviour |   | "HealthCocoon" | Behaviour |   |
| methodName |   | "SetScuttlerAmount" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var | Variable | Store Result |

#### Transitions

(none)

### Level 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Scuttler Amount | Variable |   |
| intValue |   | 3 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Amount | 0 | |

### Level 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Scuttler Amount | Variable |   |
| intValue |   | 4 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Amount | 0 | |

### Level 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Scuttler Amount | Variable |   |
| intValue |   | 5 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Amount | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL 1 | false |
| LEVEL 2 | false |
| LEVEL 3 | false |

