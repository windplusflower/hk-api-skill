# Atmos Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Atmos Control |
| GameObject Name | Deepnest |
| GameObject Path | _GameManager/AudioManager/Atmos |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20023 |
| GameObject PathId | 6518 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Fade Time | 0.3 | Single: 0.3 |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetAudioVolume

Full Name: HutongGames.PlayMaker.Actions.SetAudioVolume
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Off

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
| time | float Fade Time | float Fade Time |  |  |

### On

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
| time | float Fade Time | float Fade Time |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | START | On | 0 | 0 | 0 |
| Off | START | On | 0 | 0 | 0 |
| On | STOP | Off | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| START | false |
| STOP | false |

