# Chandelier Smash

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Chandelier Smash |
| GameObject Name | Black Knight 3 |
| GameObject Path | Battle Control/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level468 |
| Start State | Idle |
| FSM PathId | 2698 |
| GameObject PathId | 673 |

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
| CHANDELIER CRASH | Remove | 0 | |

### Remove

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CHANDELIER CRASH | false |

