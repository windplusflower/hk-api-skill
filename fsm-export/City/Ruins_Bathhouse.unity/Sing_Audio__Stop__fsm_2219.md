# Stop

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Stop |
| GameObject Name | Sing Audio |
| GameObject Path | Ghost NPC/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level87 |
| Start State | State 1 |
| FSM PathId | 2219 |
| GameObject PathId | 646 |

## Variables

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| startVolume |   | 0f |   |   |
| endVolume |   | 1f |   |   |
| time |   | 0.75f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BOX UP DREAM | State 2 | 0 | |

### State 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| startVolume |   | 1f |   |   |
| endVolume |   | 0f |   |   |
| time |   | 0.5f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BOX DOWN DREAM | State 1 | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| BOX DOWN DREAM | false |
| BOX UP DREAM | false |

