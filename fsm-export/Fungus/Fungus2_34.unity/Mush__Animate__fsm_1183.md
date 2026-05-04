# Animate

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Animate |
| GameObject Name | Mush |
| GameObject Path | Giraffe NPC/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level196 |
| Start State | Idle |
| FSM PathId | 1183 |
| GameObject PathId | 189 |

## Variables

## States

### Idle

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
| clipName |   | "Mush Idle" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EAT START | Eat | 0 | |

### Eat

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
| clipName |   | "Mush Eat" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EAT END | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| EAT END | false |
| EAT START | false |

