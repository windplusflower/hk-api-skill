# Bench Sit Anim

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Bench Sit Anim |
| GameObject Name | Quirrel Bench |
| GameObject Path | RestBench/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level89 |
| Start State | Idle |
| FSM PathId | 4555 |
| GameObject PathId | 1178 |

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
| BENCH SIT | Sit | 0 | |

### Sit

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
| clipName |   | "Bench HeroSit" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BENCH UNSIT | Unsit | 0 | |

### Unsit

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
| clipName |   | "Bench Idle" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BENCH SIT | Sit | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BENCH SIT | false |
| BENCH UNSIT | false |

