# Door Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Door Control |
| GameObject Name | Door R |
| GameObject Path | elev_main/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level80 |
| Start State | Init |
| FSM PathId | 839 |
| GameObject PathId | 201 |

## Variables

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DOORS OPEN | Open | 0 | |

### Open

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
| clipName |   | "Lift Door Open" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DOORS CLOSE | Close | 0 | |

### Close

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
| clipName |   | "Lift Door Close" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DOORS OPEN | Open | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DOORS CLOSE | false |
| DOORS OPEN | false |

