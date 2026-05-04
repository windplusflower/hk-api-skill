# Audio

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Audio |
| GameObject Name | Brilliant_Style |
| GameObject Path | Menu_Styles/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Frame 1 |
| FSM PathId | 8120 |
| GameObject PathId | 116 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Audio Player Cave | [null] | NamedAssetPPtr: [null] |
| Audio Player Water | [null] | NamedAssetPPtr: [null] |

## States

### Frame 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Audio | 0 | |

### Audio

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Audio Player Cave" |   |   |
| storeResult |   | GameObject Audio Player Cave | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Audio Player Water" |   |   |
| storeResult |   | GameObject Audio Player Water | Variable |   |

##### 3. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Audio Player Water |   |   |
| volume |   | 0f |   |   |
| oneShotClip |   | [] |   |   |

##### 4. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Audio Player Cave |   |   |
| volume |   | 0f |   |   |
| oneShotClip |   | [] |   |   |

##### 5. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Audio Player Cave |   |   |
| startVolume |   | 0f |   |   |
| endVolume |   | 1f |   |   |
| time |   | 1f |   |   |

##### 6. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Audio Player Water |   |   |
| startVolume |   | 0f |   |   |
| endVolume |   | 1f |   |   |
| time |   | 1f |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |

