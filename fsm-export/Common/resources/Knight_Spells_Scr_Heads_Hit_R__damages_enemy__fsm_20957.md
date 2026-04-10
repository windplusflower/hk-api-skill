# damages_enemy

## Summary

| Field | Value |
| --- | --- |
| FSM Name | damages_enemy |
| GameObject Name | Hit R |
| GameObject Path | Knight/Spells/Scr Heads |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Idle |
| FSM PathId | 20957 |
| GameObject PathId | 6352 |

## Variables

### Arrays

| Name | Value | Raw/Type |
| --- | --- | --- |
| Ignore Names | Array Ignore Names | FsmArray: Array Ignore Names |

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Move Angle | 0 | Single: 0 |
| Multiplier | 1 | Single: 1 |
| direction | 0 | Single: 0 |
| magnitudeMult | 1.5 | Single: 1.5 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Layer | 0 | Int32: 0 |
| Special Type | 0 | Int32: 0 |
| attackType | 2 | Int32: 2 |
| damageDealt | 15 | Int32: 15 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Ignore Invuln | false | Boolean: false |
| circleDirection | false | Boolean: false |
| moveDirection | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Name |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Collider | [null] | NamedAssetPPtr:  |
| G Parent | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |

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
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| sendEvent | Event(HIT) | Event(HIT) |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |
| storeForce | 0f | 0f | Variable |  |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(HIT) | Event(HIT) |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

##### 3. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "Enemies" | "Enemies" | Layer |  |
| sendEvent | Event(HIT) | Event(HIT) |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

### Send Event

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int damageDealt | int damageDealt |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. GetLayer

Full Name: HutongGames.PlayMaker.Actions.GetLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| storeResult | int Layer | int Layer | Variable |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Layer | int Layer |  |  |
| integer2 | 20 | 20 |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Layer | int Layer |  |  |
| integer2 | 9 | 9 |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 5. CheckSendEventLimit

Full Name: CheckSendEventLimit
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| target | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 6. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| storeName | string Name | string Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. CompareNames

Full Name: HutongGames.PlayMaker.Actions.CompareNames
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| name | string Name | string Name |  |  |
| strings | Array Ignore Names | Array Ignore Names |  |  |
| target | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| trueEvent | Event(CANCEL) | Event(CANCEL) |  |  |
| falseEvent | Event() | Event() |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Collider | EventTarget(GameObject):Collider |  |  |
| sendEvent | "TAKE DAMAGE" | "TAKE DAMAGE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. TakeDamage

Full Name: HutongGames.PlayMaker.Actions.TakeDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | GameObject Collider | GameObject Collider |  |  |
| AttackType | int attackType | int attackType |  |  |
| CircleDirection | bool circleDirection | bool circleDirection |  |  |
| DamageDealt | int damageDealt | int damageDealt |  |  |
| Direction | float direction | float direction |  |  |
| IgnoreInvulnerable | bool Ignore Invuln | bool Ignore Invuln |  |  |
| MagnitudeMultiplier | float magnitudeMult | float magnitudeMult |  |  |
| MoveAngle | float Move Angle | float Move Angle |  |  |
| MoveDirection | bool moveDirection | bool moveDirection |  |  |
| Multiplier | float Multiplier | float Multiplier |  |  |
| SpecialType | int Special Type | int Special Type |  |  |

##### 10. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault Collider | OwnerDefault Collider |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Parent | GameObject Parent | Variable |  |
| isNull | Event(FINISHED) | Event(FINISHED) |  |  |
| isNotNull | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. CheckSendEventLimit

Full Name: CheckSendEventLimit
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Parent | GameObject Parent |  |  |
| target | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Parent | GameObject Parent |  |  |
| storeName | string Name | string Name | Variable |  |
| everyFrame | false | false |  |  |

##### 5. CompareNames

Full Name: HutongGames.PlayMaker.Actions.CompareNames
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| name | string Name | string Name |  |  |
| strings | Array Ignore Names | Array Ignore Names |  |  |
| target | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| trueEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| falseEvent | Event() | Event() |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| sendEvent | "TAKE DAMAGE" | "TAKE DAMAGE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. TakeDamage

Full Name: HutongGames.PlayMaker.Actions.TakeDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | GameObject Parent | GameObject Parent |  |  |
| AttackType | int attackType | int attackType |  |  |
| CircleDirection | bool circleDirection | bool circleDirection |  |  |
| DamageDealt | int damageDealt | int damageDealt |  |  |
| Direction | float direction | float direction |  |  |
| IgnoreInvulnerable | bool Ignore Invuln | bool Ignore Invuln |  |  |
| MagnitudeMultiplier | float magnitudeMult | float magnitudeMult |  |  |
| MoveAngle | float Move Angle | float Move Angle |  |  |
| MoveDirection | bool moveDirection | bool moveDirection |  |  |
| Multiplier | float Multiplier | float Multiplier |  |  |
| SpecialType | int Special Type | int Special Type |  |  |

##### 8. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Grandparent

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| storeResult | GameObject G Parent | GameObject G Parent | Variable |  |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject G Parent | GameObject G Parent | Variable |  |
| isNull | Event(FINISHED) | Event(FINISHED) |  |  |
| isNotNull | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. CheckSendEventLimit

Full Name: CheckSendEventLimit
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject G Parent | GameObject G Parent |  |  |
| target | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject G Parent | GameObject G Parent |  |  |
| storeName | string Name | string Name | Variable |  |
| everyFrame | false | false |  |  |

##### 5. CompareNames

Full Name: HutongGames.PlayMaker.Actions.CompareNames
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| name | string Name | string Name |  |  |
| strings | Array Ignore Names | Array Ignore Names |  |  |
| target | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| trueEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| falseEvent | Event() | Event() |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):G Parent | EventTarget(GameObject):G Parent |  |  |
| sendEvent | "TAKE DAMAGE" | "TAKE DAMAGE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. TakeDamage

Full Name: HutongGames.PlayMaker.Actions.TakeDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target | GameObject G Parent | GameObject G Parent |  |  |
| AttackType | int attackType | int attackType |  |  |
| CircleDirection | bool circleDirection | bool circleDirection |  |  |
| DamageDealt | int damageDealt | int damageDealt |  |  |
| Direction | float direction | float direction |  |  |
| IgnoreInvulnerable | bool Ignore Invuln | bool Ignore Invuln |  |  |
| MagnitudeMultiplier | float magnitudeMult | float magnitudeMult |  |  |
| MoveAngle | float Move Angle | float Move Angle |  |  |
| MoveDirection | bool moveDirection | bool moveDirection |  |  |
| Multiplier | float Multiplier | float Multiplier |  |  |
| SpecialType | int Special Type | int Special Type |  |  |

##### 8. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | HIT | Send Event | 0 | 0 | 0 |
| Send Event | FINISHED | Parent | 0 | 0 | 0 |
| Send Event | CANCEL | Idle | 0 | 0 | 0 |
| Parent | FINISHED | Grandparent | 0 | 0 | 0 |
| Grandparent | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CANCEL | false |
| HIT | true |
| MOVE DIRECTION | false |

