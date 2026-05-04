# Rotate

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Rotate |
| GameObject Name | Burst |
| GameObject Path | Boss Control/break_chains/hollow_knight_chain_base 2/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level409 |
| Start State | State 1 |
| FSM PathId | 2436 |
| GameObject PathId | 383 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Chooser | 0 | Single: 0 |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 0f |   |   |
| max |   | 360f |   |   |
| storeResult |   | float Chooser | Variable |   |

##### 2. SetRotation

Full Name: HutongGames.PlayMaker.Actions.SetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| quaternion |   | Quaternion(0, 0, 0, 0) | Variable |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xAngle |   | 0f |   |   |
| yAngle |   | 0f |   |   |
| zAngle |   | float Chooser |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

