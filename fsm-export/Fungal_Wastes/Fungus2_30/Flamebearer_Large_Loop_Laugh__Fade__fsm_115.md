# Fade

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Fade |
| GameObject Name | Loop Laugh |
| GameObject Path | Flamebearer Large |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets192.assets |
| Start State | Idle |
| FSM PathId | 115 |
| GameObject PathId | 46 |

## Variables

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

### Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| startVolume | 1f | 1f |  |  |
| endVolume | 0f | 0f |  |  |
| time | 0.15f | 0.15f |  |  |

### In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| startVolume | 0f | 0f |  |  |
| endVolume | 1f | 1f |  |  |
| time | 0.5f | 0.5f |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | START | Start | 0 | 0 | 0 |
| Start | OUT | Out | 0 | 0 | 0 |
| Out | IN | In | 0 | 0 | 0 |
| In | OUT | Out | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| IN | false |
| OUT | false |
| START | false |

