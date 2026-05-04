# damages_enemy

## Summary

| Field | Value |
| --- | --- |
| FSM Name | damages_enemy |
| GameObject Name | Cave Spikes |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level270 |
| Start State | Idle |
| FSM PathId | 6597 |
| GameObject PathId | 281 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Move Angle | 0 | Single: 0 |
| Multiplier | 1 | Single: 1 |
| direction | 90 | Single: 90 |
| magnitudeMult | 1 | Single: 1 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Special Type | 0 | Int32: 0 |
| attackType | 1 | Int32: 1 |
| damageDealt | 50 | Int32: 50 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Ignore Invuln | true | Boolean: true |
| circleDirection | false | Boolean: false |
| moveDirection | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Collider | [null] | NamedAssetPPtr: [null] |
| Parent | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| sendEvent |   | Event(HIT) |   |   |
| storeCollider |   | GameObject Collider | Variable |   |
| storeForce |   | 0f | Variable |   |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(HIT) |   |   |
| storeCollider |   | GameObject Collider | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIT | Send Event | 0 | |

### Send Event

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int damageDealt |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(FINISHED) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Collider |   |   |
| sendEvent |   | "TAKE DAMAGE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. TakeDamage

Full Name: HutongGames.PlayMaker.Actions.TakeDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | GameObject Collider |   |   |
| AttackType |   | 1 |   |   |
| CircleDirection |   | false |   |   |
| DamageDealt |   | int damageDealt |   |   |
| Direction |   | float direction |   |   |
| IgnoreInvulnerable |   | bool Ignore Invuln |   |   |
| MagnitudeMultiplier |   | float magnitudeMult |   |   |
| MoveAngle |   | float Move Angle |   |   |
| MoveDirection |   | bool moveDirection |   |   |
| Multiplier |   | float Multiplier |   |   |
| SpecialType |   | int Special Type |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Parent | 0 | |

### Parent

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Collider |   |   |
| storeResult |   | GameObject Parent | Variable |   |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Parent | Variable |   |
| isNull |   | Event(FINISHED) |   |   |
| isNotNull |   | Event() |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Parent |   |   |
| sendEvent |   | "TAKE DAMAGE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| HIT | true |
| MOVE DIRECTION | false |

