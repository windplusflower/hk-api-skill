# Resize 60-10

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Resize 60-10 |
| GameObject Name | Bottle Glass L 2 (5) |
| GameObject Path | ruind_dressing_light_01/Debris/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level207 |
| Start State | State 1 |
| FSM PathId | 6167 |
| GameObject PathId | 490 |

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
| min |   | 0.6f |   |   |
| max |   | 1f |   |   |
| storeResult |   | float Chooser | Variable |   |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | float Chooser |   |   |
| y |   | float Chooser |   |   |
| z |   | float Chooser |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

