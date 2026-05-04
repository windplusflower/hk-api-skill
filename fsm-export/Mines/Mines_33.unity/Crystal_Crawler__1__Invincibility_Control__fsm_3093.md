# Invincibility Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Invincibility Control |
| GameObject Name | Crystal Crawler (1) |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level272 |
| Start State | Init |
| FSM PathId | 3093 |
| GameObject PathId | 441 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| X Scale | 0 | Single: 0 |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| xScale |   | true |   |   |
| positiveEvent |   | TURN LEFT |   |   |
| negativeEvent |   | TURN RIGHT |   |   |
| space | UnityEngine.Space::World | 0 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TURN LEFT | Left | 0 | |
| TURN RIGHT | Right | 0 | |

### Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetInvincible

Full Name: SetInvincible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| Invincible |   | true |   |   |
| InvincibleFromDirection |   | 11 |   |   |

##### 2. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xScale |   | float X Scale | Variable |   |
| yScale |   | 0f | Variable |   |
| zScale |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Scale |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   | TURN RIGHT |   |   |
| greaterThan |   |   |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TURN RIGHT | Right | 0 | |

### Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetInvincible

Full Name: SetInvincible
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| Invincible |   | true |   |   |
| InvincibleFromDirection |   | 10 |   |   |

##### 2. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| xScale |   | float X Scale | Variable |   |
| yScale |   | 0f | Variable |   |
| zScale |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Scale |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0f |   |   |
| equal |   |   |   |   |
| lessThan |   |   |   |   |
| greaterThan |   | TURN LEFT |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TURN LEFT | Left | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| TURN LEFT | false |
| TURN RIGHT | false |

