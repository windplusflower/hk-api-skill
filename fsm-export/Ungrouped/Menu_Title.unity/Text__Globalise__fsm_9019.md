# Globalise

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Globalise |
| GameObject Name | Text |
| GameObject Path | _GameCameras/HudCamera/DialogueManager/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Set |
| FSM PathId | 9019 |
| GameObject PathId | 849 |

## Variables

## States

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject |   | [Global] GameObject DialogueText | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| LEVEL LOADED | Set | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |

