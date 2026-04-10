# Spin

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spin |
| GameObject Name | Flameball Spinner |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets |
| Start State | Spin |
| FSM PathId | 1262 |
| GameObject PathId | 560 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spin Speed | 360 | Single: 360 |

## States

### Spin

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RandomlyFlipFloat

Full Name: HutongGames.PlayMaker.Actions.RandomlyFlipFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | float Spin Speed | float Spin Speed | Variable |  |

##### 2. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Spin Speed | float Spin Speed |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| perSecond | true | true |  |  |
| everyFrame | true | true |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |  |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| _(none)_ |  |

