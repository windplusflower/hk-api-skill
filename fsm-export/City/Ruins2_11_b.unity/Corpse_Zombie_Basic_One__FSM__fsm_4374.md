# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Corpse Zombie Basic One |
| GameObject Path | Break Jar (1)/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level125 |
| Start State | Set Z |
| FSM PathId | 4374 |
| GameObject PathId | 639 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Z Depth | 0.00899999961 | Single: 0.00899999961 |

## States

### Set Z

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
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| z |   | float Z Depth |   |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

##### 2. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: false

#### Transitions

(none)

## Global Transitions

(none)

## Events

(none)

