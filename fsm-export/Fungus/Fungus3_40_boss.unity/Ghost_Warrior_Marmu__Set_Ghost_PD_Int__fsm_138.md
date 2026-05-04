# Set Ghost PD Int

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Ghost PD Int |
| GameObject Name | Ghost Warrior Marmu |
| GameObject Path | Warrior/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level221 |
| Start State | Idle |
| FSM PathId | 138 |
| GameObject PathId | 7 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| PD Int | mumCaterpillarDefeated | String: mumCaterpillarDefeated |

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

##### 1. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName |   | string PD Int = "mumCaterpillarDefeated" |   |   |
| value |   | 1 |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "GHOST DEAD" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ZERO HP | false |

