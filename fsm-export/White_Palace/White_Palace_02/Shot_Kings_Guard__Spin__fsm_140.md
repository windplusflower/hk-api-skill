# Spin

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spin |
| GameObject Name | Shot Kings Guard |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets366.assets |
| Start State | Init |
| FSM PathId | 140 |
| GameObject PathId | 37 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle | 0 | Single: 0 |
| Distance | 0 | Single: 0 |
| Fire Angle | 0 | Single: 0 |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spd Vector | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Parent | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Caught

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| sendEvent | "CAUGHT" | "CAUGHT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. RecycleSelf

Full Name: HutongGames.PlayMaker.Actions.RecycleSelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

### Launch

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. FireAtTarget

Full Name: HutongGames.PlayMaker.Actions.FireAtTarget
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| speed | 35f | 35f |  |  |
| position | Vector3(0, -0.5, 0) | Vector3(0, -0.5, 0) |  |  |
| spread | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angle | float Fire Angle | float Fire Angle |  |  |
| speed | 35f | 35f |  |  |
| everyFrame | false | false |  |  |

##### 3. GetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.GetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeAngle | float Angle | float Angle | Variable |  |
| everyFrame | false | false |  |  |

##### 4. FloatInRange

Full Name: HutongGames.PlayMaker.Actions.FloatInRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle |  |  |
| lowerValue | 185f | 185f |  |  |
| upperValue | 270f | 270f |  |  |
| boolVariable | false | false | Variable |  |
| trueEvent | Event(CLAMP BL) | Event(CLAMP BL) |  |  |
| falseEvent | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 5. FloatInRange

Full Name: HutongGames.PlayMaker.Actions.FloatInRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle |  |  |
| lowerValue | 270f | 270f |  |  |
| upperValue | 355f | 355f |  |  |
| boolVariable | false | false | Variable |  |
| trueEvent | Event(CLAMP BR) | Event(CLAMP BR) |  |  |
| falseEvent | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 6. FloatInRange

Full Name: HutongGames.PlayMaker.Actions.FloatInRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle |  |  |
| lowerValue | 90f | 90f |  |  |
| upperValue | 135f | 135f |  |  |
| boolVariable | false | false | Variable |  |
| trueEvent | Event(CLAMP TL) | Event(CLAMP TL) |  |  |
| falseEvent | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 7. FloatInRange

Full Name: HutongGames.PlayMaker.Actions.FloatInRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle |  |  |
| lowerValue | 45f | 45f |  |  |
| upperValue | 90f | 90f |  |  |
| boolVariable | false | false | Variable |  |
| trueEvent | Event(CLAMP TR) | Event(CLAMP TR) |  |  |
| falseEvent | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### In Air

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AddForce2d

Full Name: HutongGames.PlayMaker.Actions.AddForce2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| forceMode | UnityEngine.ForceMode2D::Force | 0 |  |  |
| atPosition | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| vector | Vector2 Spd Vector | Vector2 Spd Vector | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| vector3 | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| everyFrame | true | true |  |  |

##### 2. GetDistance

Full Name: HutongGames.PlayMaker.Actions.GetDistance
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | GameObject Parent | GameObject Parent |  |  |
| storeResult | float Distance | float Distance | Variable |  |
| everyFrame | true | true |  |  |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Distance | float Distance |  |  |
| float2 | 2f | 2f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(RETURN) | Event(RETURN) |  |  |
| lessThan | Event(RETURN) | Event(RETURN) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | Event(RETURN) | Event(RETURN) |  |  |
| realTime | false | false |  |  |

### Clamp BL

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angle | 185f | 185f |  |  |
| speed | 35f | 35f |  |  |
| everyFrame | false | false |  |  |

### Get Vel

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2 Spd Vector | Vector2 Spd Vector | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. Vector2Multiply

Full Name: HutongGames.PlayMaker.Actions.Vector2Multiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable | Vector2 Spd Vector | Vector2 Spd Vector | Variable |  |
| multiplyBy | -7f | -7f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Clamp TL

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angle | 135f | 135f |  |  |
| speed | 35f | 35f |  |  |
| everyFrame | false | false |  |  |

### Clamp TR

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angle | 45f | 45f |  |  |
| speed | 35f | 35f |  |  |
| everyFrame | false | false |  |  |

### Clamp BR

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angle | 355f | 355f |  |  |
| speed | 35f | 35f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Launch | 0 | 0 | 0 |
| Launch | CLAMP BL | Clamp BL | 0 | 0 | 0 |
| Launch | CLAMP TL | Clamp TL | 0 | 0 | 0 |
| Launch | CLAMP TR | Clamp TR | 0 | 0 | 0 |
| Launch | CLAMP BR | Clamp BR | 0 | 0 | 0 |
| Launch | FINISHED | Get Vel | 0 | 0 | 0 |
| In Air | RETURN | Caught | 0 | 0 | 0 |
| Clamp BL | FINISHED | Get Vel | 0 | 0 | 0 |
| Get Vel | FINISHED | In Air | 0 | 0 | 0 |
| Clamp TL | FINISHED | Get Vel | 0 | 0 | 0 |
| Clamp TR | FINISHED | Get Vel | 0 | 0 | 0 |
| Clamp BR | FINISHED | Get Vel | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CLAMP BL | false |
| CLAMP BR | false |
| CLAMP TL | false |
| CLAMP TR | false |
| COLLIDE | false |
| RETURN | false |

