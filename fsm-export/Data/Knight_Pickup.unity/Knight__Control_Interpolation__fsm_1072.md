# Control Interpolation

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control Interpolation |
| GameObject Name | Knight |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | Idle |
| FSM PathId | 1072 |
| GameObject PathId | 161 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Tag Count | 0 | Int32: 0 |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEVEL LOADED | Check Pause | 0 | |

### Check Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | FINISHED |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Interpolate | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetTagCount

Full Name: HutongGames.PlayMaker.Actions.GetTagCount
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| tag |   | "Set Extrapolate" | Tag |   |
| storeResult |   | int Tag Count | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Tag Count |   |   |
| integer2 |   | 0 |   |   |
| equal |   | INTERPOLATE |   |   |
| lessThan |   | INTERPOLATE |   |   |
| greaterThan |   | EXTRAPOLATE |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| INTERPOLATE | Set Interpolate | 0 | |
| EXTRAPOLATE | Set Extrapolate | 0 | |

### Set Interpolate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetInterpolate

Full Name: HutongGames.PlayMaker.Actions.SetInterpolate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Set Extrapolate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetExtrapolate

Full Name: HutongGames.PlayMaker.Actions.SetExtrapolate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| EXTRAPOLATE | false |
| FINISHED | false |
| INTERPOLATE | false |
| LEVEL LOADED | false |

