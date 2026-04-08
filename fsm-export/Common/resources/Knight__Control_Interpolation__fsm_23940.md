# Control Interpolation

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control Interpolation |
| GameObject Name | Knight |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Idle |
| FSM PathId | 23940 |
| GameObject PathId | 3895 |

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

_None_

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
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

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
| tag | "Set Extrapolate" | "Set Extrapolate" | Tag |  |
| storeResult | int Tag Count | int Tag Count | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Tag Count | int Tag Count |  |  |
| integer2 | 0 | 0 |  |  |
| equal | INTERPOLATE | INTERPOLATE |  |  |
| lessThan | INTERPOLATE | INTERPOLATE |  |  |
| greaterThan | EXTRAPOLATE | EXTRAPOLATE |  |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | LEVEL LOADED | Check Pause | 0 | 0 | 0 |
| Check Pause | FINISHED | Set Interpolate | 0 | 0 | 0 |
| Check | INTERPOLATE | Set Interpolate | 0 | 0 | 0 |
| Check | EXTRAPOLATE | Set Extrapolate | 0 | 0 | 0 |
| Set Interpolate | FINISHED | Idle | 0 | 0 | 0 |
| Set Extrapolate | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
| EXTRAPOLATE | false |
| INTERPOLATE | false |

