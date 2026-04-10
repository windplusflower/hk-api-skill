# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets82.assets |
| Start State | Init |
| FSM PathId | 56 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero X Speed | 0 | Single: 0 |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Sprite Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Active | [null] | NamedAssetPPtr:  |
| Pt Rocks | [null] | NamedAssetPPtr:  |
| Sprite | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Active" | "Active" |  |  |
| storeResult | GameObject Active | GameObject Active | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Rocks" | "Pt Rocks" |  |  |
| storeResult | GameObject Pt Rocks | GameObject Pt Rocks | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Active | OwnerDefault Active |  |  |
| childName | "Sprite" | "Sprite" |  |  |
| storeResult | GameObject Sprite | GameObject Sprite | Variable |  |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sprite | OwnerDefault Sprite |  |  |
| vector | Vector3 Sprite Pos | Vector3 Sprite Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sprite | OwnerDefault Sprite |  |  |
| vector | Vector3 Sprite Pos | Vector3 Sprite Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |  |  |
| collideTag | "Player" | "Player" | Tag |  |
| sendEvent | Event(HERO ON) | Event(HERO ON) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 3. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Rocks | OwnerDefault Pt Rocks |  |  |
| emission | false | false |  |  |

### Shaking

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sprite | OwnerDefault Sprite |  |  |
| vector | Vector3 Sprite Pos | Vector3 Sprite Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionExit2D | 2 |  |  |
| collideTag | "Player" | "Player" | Tag |  |
| sendEvent | Event(HERO OFF) | Event(HERO OFF) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 3. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Hero X Speed | float Hero X Speed | Variable |  |
| y | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X Speed | float Hero X Speed |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0.01f | 0.01f |  |  |
| equal | Event(STILL) | Event(STILL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 5. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sprite | OwnerDefault Sprite |  |  |
| x | 0.025f | 0.025f |  |  |
| y | 0.025f | 0.025f |  |  |
| z | 0f | 0f |  |  |
| allowMovement | false | false |  |  |

##### 6. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Rocks | OwnerDefault Pt Rocks |  |  |
| emission | true | true |  |  |

##### 7. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 0.65f | 0.65f |  |  |
| oneShotClip | [] | [] |  |  |

### Shaking Cooldown

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sprite | OwnerDefault Sprite |  |  |
| vector | Vector3 Sprite Pos | Vector3 Sprite Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionExit2D | 2 |  |  |
| collideTag | "Player" | "Player" | Tag |  |
| sendEvent | Event(HERO OFF) | Event(HERO OFF) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 3. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Hero X Speed | float Hero X Speed | Variable |  |
| y | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X Speed | float Hero X Speed |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0.01f | 0.01f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(MOVING) | Event(MOVING) |  |  |
| greaterThan | Event(MOVING) | Event(MOVING) |  |  |
| everyFrame | true | true |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.35f | 0.35f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

##### 6. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sprite | OwnerDefault Sprite |  |  |
| x | 0.025f | 0.025f |  |  |
| y | 0.025f | 0.025f |  |  |
| z | 0f | 0f |  |  |
| allowMovement | false | false |  |  |

### Still

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Sprite | OwnerDefault Sprite |  |  |
| vector | Vector3 Sprite Pos | Vector3 Sprite Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionExit2D | 2 |  |  |
| collideTag | "Player" | "Player" | Tag |  |
| sendEvent | Event(HERO OFF) | Event(HERO OFF) |  |  |
| storeCollider |  |  | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 3. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Hero X Speed | float Hero X Speed | Variable |  |
| y | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X Speed | float Hero X Speed |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 0.01f | 0.01f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(MOVING) | Event(MOVING) |  |  |
| greaterThan | Event(MOVING) | Event(MOVING) |  |  |
| everyFrame | true | true |  |  |

##### 5. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

##### 6. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Rocks | OwnerDefault Pt Rocks |  |  |
| emission | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | HERO ON | Shaking | 0 | 0 | 0 |
| Shaking | HERO OFF | Idle | 0 | 0 | 0 |
| Shaking | STILL | Shaking Cooldown | 0 | 0 | 0 |
| Shaking Cooldown | HERO OFF | Idle | 0 | 0 | 0 |
| Shaking Cooldown | MOVING | Shaking | 0 | 0 | 0 |
| Shaking Cooldown | WAIT | Still | 0 | 0 | 0 |
| Still | HERO OFF | Idle | 0 | 0 | 0 |
| Still | MOVING | Shaking | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| HERO OFF | false |
| HERO ON | false |
| MOVING | false |
| STILL | false |
| WAIT | true |

