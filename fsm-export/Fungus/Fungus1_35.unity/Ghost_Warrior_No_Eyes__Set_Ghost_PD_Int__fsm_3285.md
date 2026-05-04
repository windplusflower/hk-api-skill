# Set Ghost PD Int

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Ghost PD Int |
| GameObject Name | Ghost Warrior No Eyes |
| GameObject Path | Warrior/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level161 |
| Start State | Idle |
| FSM PathId | 3285 |
| GameObject PathId | 324 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| PD Int | noEyesDefeated | String: noEyesDefeated |

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
| ZERO HP | Set | 0 | |

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "GHOST DEATH" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName |   | string PD Int = "noEyesDefeated" |   |   |
| value |   | 1 |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ZERO HP | false |

