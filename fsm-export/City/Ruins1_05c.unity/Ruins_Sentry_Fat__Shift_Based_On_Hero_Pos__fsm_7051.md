# Shift Based On Hero Pos

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Shift Based On Hero Pos |
| GameObject Name | Ruins Sentry Fat |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level94 |
| Start State | Pause |
| FSM PathId | 7051 |
| GameObject PathId | 512 |

## Variables

## States

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

##### 2. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |
| skipIfAlreadyPositioned |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CheckTargetDirection

Full Name: HutongGames.PlayMaker.Actions.CheckTargetDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | [Global] GameObject Hero |   |   |
| aboveEvent |   |   |   |   |
| belowEvent |   |   |   |   |
| rightEvent |   | HERO RIGHT |   |   |
| leftEvent |   | HERO LEFT |   |   |
| aboveBool |   | false | Variable |   |
| belowBool |   | false | Variable |   |
| rightBool |   | false | Variable |   |
| leftBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HERO LEFT | Hero Left | 0 | |
| HERO RIGHT | Hero Right | 0 | |

### Hero Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 24.85f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

(none)

### Hero Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 5.21f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
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
| HERO LEFT | false |
| HERO RIGHT | false |

