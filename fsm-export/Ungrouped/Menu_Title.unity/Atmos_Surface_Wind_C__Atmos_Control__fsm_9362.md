# Atmos Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Atmos Control |
| GameObject Name | Atmos Surface Wind C |
| GameObject Path | _GameManager/AudioManager/Atmos/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9362 |
| GameObject PathId | 1461 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Fade Time | 0.300000012 | Single: 0.300000012 |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| START | On | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| startVolume |   | 1f |   |   |
| endVolume |   | 0f |   |   |
| time |   | float Fade Time |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| START | On | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| startVolume |   | 0f |   |   |
| endVolume |   | 1f |   |   |
| time |   | float Fade Time |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| STOP | Off | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| START | false |
| STOP | false |

