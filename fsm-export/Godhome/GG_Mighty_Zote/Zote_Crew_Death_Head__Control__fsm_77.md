# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Head |
| GameObject Path | Zote Crew Death |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets481.assets |
| Start State | State 3 |
| FSM PathId | 77 |
| GameObject PathId | 17 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Max | 0 | Single: 0 |
| Min | 0 | Single: 0 |

## States

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. FlingObject

Full Name: HutongGames.PlayMaker.Actions.FlingObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| flungObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| speedMin | 20f | 20f |  |  |
| speedMax | 25f | 25f |  |  |
| angleMin | float Min | float Min |  |  |
| angleMax | float Max | float Max |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.6f | 1.6f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 4. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### State 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### State 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. CheckTargetDirection

Full Name: HutongGames.PlayMaker.Actions.CheckTargetDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| aboveEvent |  |  |  |  |
| belowEvent |  |  |  |  |
| rightEvent | R | R |  |  |
| leftEvent | L | L |  |  |
| aboveBool | false | false | Variable |  |
| belowBool | false | false | Variable |  |
| rightBool | false | false | Variable |  |
| leftBool | false | false | Variable |  |
| everyFrame | false | false |  |  |

### R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Min | float Min | Variable |  |
| floatValue | 100f | 100f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Max | float Max | Variable |  |
| floatValue | 130f | 130f |  |  |
| everyFrame | false | false |  |  |

### L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Min | float Min | Variable |  |
| floatValue | 50f | 50f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Max | float Max | Variable |  |
| floatValue | 80f | 80f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| State 1 | FINISHED | State 2 | 0 | 0 | 0 |
| State 3 | L | L | 0 | 0 | 0 |
| State 3 | R | R | 0 | 0 | 0 |
| R | FINISHED | State 1 | 0 | 0 | 0 |
| L | FINISHED | State 1 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| L | false |
| R | false |

