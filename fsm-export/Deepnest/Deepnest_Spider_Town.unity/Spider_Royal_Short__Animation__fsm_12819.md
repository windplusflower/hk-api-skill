# Animation

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Animation |
| GameObject Name | Spider Royal Short |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level304 |
| Start State | Idle |
| FSM PathId | 12819 |
| GameObject PathId | 3283 |

## Variables

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
| BEHIND | Behind | 0 | |

### Stop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

### Front

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Short LookRight" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BEHIND | Behind | 0 | |

### Behind

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Short LookLeft" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FRONT | Front | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FIRST STRUGGLE | Stop | 0 | |

## Events

| Name | Global |
| --- | --- |
| BEHIND | false |
| FIRST STRUGGLE | false |
| FRONT | false |

