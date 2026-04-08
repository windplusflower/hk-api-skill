# Final Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Final Control |
| GameObject Name | Radiant Orb |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets407.assets |
| Start State | Idle |
| FSM PathId | 288 |
| GameObject PathId | 77 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Max X | 79.79 | Single: 79.79 |
| Max Y | 165.78 | Single: 165.78 |
| Min X | 45.97 | Single: 45.97 |
| Min Y | 149.96 | Single: 149.96 |
| X Pos | 0 | Single: 0 |
| Y Pos | 0 | Single: 0 |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Pos | float X Pos | Variable |  |
| y | float Y Pos | float Y Pos | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float X Pos | float X Pos |  |  |
| float2 | float Min X | float Min X |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan | END | END |  |  |
| greaterThan |  |  |  |  |
| everyFrame | true | true |  |  |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float X Pos | float X Pos |  |  |
| float2 | float Max X | float Max X |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan |  |  |  |  |
| greaterThan | END | END |  |  |
| everyFrame | true | true |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Y Pos | float Y Pos |  |  |
| float2 | float Min Y | float Min Y |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan | END | END |  |  |
| greaterThan |  |  |  |  |
| everyFrame | true | true |  |  |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Y Pos | float Y Pos |  |  |
| float2 | float Max Y | float Max Y |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan |  |  |  |  |
| greaterThan | END | END |  |  |
| everyFrame | true | true |  |  |

### Recycle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | FINAL | Check | 0 | 0 | 0 |
| Check | END | Recycle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| END | false |
| FINAL | false |

