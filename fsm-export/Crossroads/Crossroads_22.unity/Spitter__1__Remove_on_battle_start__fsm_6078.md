# Remove on battle start

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Remove on battle start |
| GameObject Name | Spitter (1) |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level59 |
| Start State | Idle |
| FSM PathId | 6078 |
| GameObject PathId | 1357 |

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
| BG CLOSE | Die | 0 | |

### Die

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. InstaDeath

Full Name: InstaDeath
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| direction |   | 0f |   |   |

##### 2. SetGeoDrop

Full Name: SetGeoDrop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| smallGeo |   | 0 |   |   |
| mediumGeo |   | 0 |   |   |
| largeGeo |   | 0 |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BG CLOSE | false |

