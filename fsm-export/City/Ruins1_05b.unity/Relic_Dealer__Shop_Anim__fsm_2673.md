# Shop Anim

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Shop Anim |
| GameObject Name | Relic Dealer |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level93 |
| Start State | Init |
| FSM PathId | 2673 |
| GameObject PathId | 17 |

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
| SHOP START | Start | 0 | |

### Start

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
| clipName |   | "Inside TalkL" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SHOP STOP | Stop | 0 | |

### Stop

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
| clipName |   | "Inside L" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SHOP START | Start | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| SHOP START | false |
| SHOP STOP | false |

