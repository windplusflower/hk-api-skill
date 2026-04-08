# Set Ghost PD Int

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Set Ghost PD Int |
| GameObject Name | Ghost Warrior Slug |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets194.assets |
| Start State | Idle |
| FSM PathId | 94 |
| GameObject PathId | 25 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| PD Int | aladarSlugDefeated | String: aladarSlugDefeated |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

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
| intName | string PD Int = "aladarSlugDefeated" | string PD Int = "aladarSlugDefeated" |  |  |
| value | 1 | 1 |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | ZERO HP | Set | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| ZERO HP | false |

