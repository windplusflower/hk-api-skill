# particle_cleanup

## Summary

| Field | Value |
| --- | --- |
| FSM Name | particle_cleanup |
| GameObject Name | Bottle Glass S 3 (12) |
| GameObject Path | Top Pool/Glass Pool/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level125 |
| Start State | Idle |
| FSM PathId | 4310 |
| GameObject PathId | 572 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| No Cleanup | false | Boolean: false |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool No Cleanup | Variable |   |
| isTrue |   | Event(NO CLEANUP) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| PARTICLE CLEANUP | Destroy | 0 | |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool No Cleanup | Variable |   |
| isTrue |   | Event(NO CLEANUP) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren |   | false |   |   |

#### Transitions

(none)

### No Cleanup

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NO CLEANUP | No Cleanup | 0 | |

## Events

| Name | Global |
| --- | --- |
| NO CLEANUP | false |
| PARTICLE CLEANUP | false |

