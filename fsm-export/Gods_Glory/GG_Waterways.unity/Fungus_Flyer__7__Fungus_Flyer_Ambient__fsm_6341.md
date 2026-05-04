# Fungus Flyer Ambient

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Fungus Flyer Ambient |
| GameObject Name | Fungus Flyer (7) |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level423 |
| Start State | Float |
| FSM PathId | 6341 |
| GameObject PathId | 1467 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Scale | 1 | Single: 1 |

## States

### Float

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. IdleBuzzV2

Full Name: HutongGames.PlayMaker.Actions.IdleBuzzV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| waitMin |   | 0.5f |   |   |
| waitMax |   | 0.75f |   |   |
| speedMax |   | 4f |   |   |
| accelerationMax |   | 20f |   |   |
| roamingRangeX |   | 3f |   |   |
| roamingRangeY |   | 3f |   |   |
| manualStartPos |   | Vector3(0, 0, 0) |   |   |

##### 2. RandomlyFlipFloat

Full Name: HutongGames.PlayMaker.Actions.RandomlyFlipFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult |   | float Scale | Variable |   |

##### 3. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Scale |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| HERO ENTER L | false |
| HERO ENTER R | false |
| SLEEP | true |
| WAKE | true |

