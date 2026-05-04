# Constrain Y

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Constrain Y |
| GameObject Name | Grimm Boss |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level392 |
| Start State | Check |
| FSM PathId | 561 |
| GameObject PathId | 46 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self Y | 0 | Single: 0 |

## States

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f | Variable |   |
| y |   | float Self Y | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Self Y |   |   |
| float2 |   | 6.3f |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   | CONSTRAIN |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CONSTRAIN | Constrain | 0 | |

### Constrain

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Self Y | Variable |   |
| floatValue |   | 6.3f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | 6.4f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CONSTRAIN | false |
| FINISHED | false |

