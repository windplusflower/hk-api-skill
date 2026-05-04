# Follow Camera

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Follow Camera |
| GameObject Name | dream_area_effect |
| GameObject Path | Nightmare Lantern/lantern_dream/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level236 |
| Start State | Follow |
| FSM PathId | 1538 |
| GameObject PathId | 10 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cam X | 0 | Single: 0 |
| Cam Y | 0 | Single: 0 |

## States

### Follow

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault MainCamera |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Cam X | Variable |   |
| y |   | float Cam Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Cam X |   |   |
| y |   | float Cam Y |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

