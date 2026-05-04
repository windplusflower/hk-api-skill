# Rotate

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Rotate |
| GameObject Name | cog2 |
| GameObject Path | Stag Lift/sprites/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level233 |
| Start State | Idle |
| FSM PathId | 4940 |
| GameObject PathId | 1447 |

## Variables

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MOVING UP | Moving Up | 0 | |
| MOVING DOWN | Moving Down | 0 | |

### Moving Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | -360f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | true |   |   |
| everyFrame |   | true |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MOVING DOWN | Moving Down | 0 | |
| STOP MOVING | Idle | 0 | |

### Moving Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | 360f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | true |   |   |
| everyFrame |   | true |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MOVING UP | Moving Up | 0 | |
| STOP MOVING | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| MOVING DOWN | false |
| MOVING UP | false |
| STOP MOVING | false |

