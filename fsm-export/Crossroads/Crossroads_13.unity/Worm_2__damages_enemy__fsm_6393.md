# damages_enemy

## Summary

| Field | Value |
| --- | --- |
| FSM Name | damages_enemy |
| GameObject Name | Worm 2 |
| GameObject Path | _Enemies/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level52 |
| Start State | Idle |
| FSM PathId | 6393 |
| GameObject PathId | 437 |

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
| direction | 90 | Single: 90 |
| magnitudeMult | 2 | Single: 2 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Layer | 0 | Int32: 0 |
| Special Type | 0 | Int32: 0 |
| attackType | 1 | Int32: 1 |
| damageDealt | 50 | Int32: 50 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Ignore Invuln | false | Boolean: false |
| circleDirection | false | Boolean: false |
| moveDirection | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Name |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Collider | [null] | NamedAssetPPtr: [null] |
| G Parent | [null] | NamedAssetPPtr: [null] |
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

##### 3. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "Enemies" | Layer |   |
| sendEvent |   | Event(HIT) |   |   |
| storeCollider |   | GameObject Collider | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIT | Send Event | 0 | |

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
| integer1 |   | int damageDealt |   |   |
| integer2 |   | 0 |   |   |
| equal |   | Event(CANCEL) |   |   |
| lessThan |   | Event(CANCEL) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. GetLayer

Full Name: HutongGames.PlayMaker.Actions.GetLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Collider |   |   |
| storeResult |   | int Layer | Variable |   |
| everyFrame |   | false |   |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Layer |   |   |
| integer2 |   | 20 |   |   |
| equal |   | Event(CANCEL) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Layer |   |   |
| integer2 |   | 9 |   |   |
| equal |   | Event(CANCEL) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 5. CheckSendEventLimit

Full Name: CheckSendEventLimit
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Collider |   |   |
| target |   | EventTarget(Self):FSM Owner |   |   |
| trueEvent |   | Event() |   |   |
| falseEvent |   | Event(FINISHED) |   |   |

##### 6. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Collider |   |   |
| storeName |   | string Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. CompareNames

Full Name: HutongGames.PlayMaker.Actions.CompareNames
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| name |   | string Name |   |   |
| strings |   | Array Ignore Names |   |   |
| target |   | EventTarget(Self):FSM Owner |   |   |
| trueEvent |   | Event(CANCEL) |   |   |
| falseEvent |   | Event() |   |   |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Collider |   |   |
| sendEvent |   | "TAKE DAMAGE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 9. TakeDamage

Full Name: HutongGames.PlayMaker.Actions.TakeDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | GameObject Collider |   |   |
| AttackType |   | int attackType |   |   |
| CircleDirection |   | bool circleDirection |   |   |
| DamageDealt |   | int damageDealt |   |   |
| Direction |   | float direction |   |   |
| IgnoreInvulnerable |   | bool Ignore Invuln |   |   |
| MagnitudeMultiplier |   | float magnitudeMult |   |   |
| MoveAngle |   | float Move Angle |   |   |
| MoveDirection |   | bool moveDirection |   |   |
| Multiplier |   | float Multiplier |   |   |
| SpecialType |   | int Special Type |   |   |

##### 10. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| sendEvent |   | Event(FINISHED) |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Parent | 0 | |
| CANCEL | Idle | 0 | |

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

##### 3. CheckSendEventLimit

Full Name: CheckSendEventLimit
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Parent |   |   |
| target |   | EventTarget(Self):FSM Owner |   |   |
| trueEvent |   | Event() |   |   |
| falseEvent |   | Event(FINISHED) |   |   |

##### 4. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Parent |   |   |
| storeName |   | string Name | Variable |   |
| everyFrame |   | false |   |   |

##### 5. CompareNames

Full Name: HutongGames.PlayMaker.Actions.CompareNames
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| name |   | string Name |   |   |
| strings |   | Array Ignore Names |   |   |
| target |   | EventTarget(Self):FSM Owner |   |   |
| trueEvent |   | Event(FINISHED) |   |   |
| falseEvent |   | Event() |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Parent |   |   |
| sendEvent |   | "TAKE DAMAGE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. TakeDamage

Full Name: HutongGames.PlayMaker.Actions.TakeDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | GameObject Parent |   |   |
| AttackType |   | int attackType |   |   |
| CircleDirection |   | bool circleDirection |   |   |
| DamageDealt |   | int damageDealt |   |   |
| Direction |   | float direction |   |   |
| IgnoreInvulnerable |   | bool Ignore Invuln |   |   |
| MagnitudeMultiplier |   | float magnitudeMult |   |   |
| MoveAngle |   | float Move Angle |   |   |
| MoveDirection |   | bool moveDirection |   |   |
| Multiplier |   | float Multiplier |   |   |
| SpecialType |   | int Special Type |   |   |

##### 8. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| sendEvent |   | Event(FINISHED) |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Grandparent | 0 | |

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
| gameObject |   | OwnerDefault Parent |   |   |
| storeResult |   | GameObject G Parent | Variable |   |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject G Parent | Variable |   |
| isNull |   | Event(FINISHED) |   |   |
| isNotNull |   | Event() |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 3. CheckSendEventLimit

Full Name: CheckSendEventLimit
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject G Parent |   |   |
| target |   | EventTarget(Self):FSM Owner |   |   |
| trueEvent |   | Event() |   |   |
| falseEvent |   | Event(FINISHED) |   |   |

##### 4. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject G Parent |   |   |
| storeName |   | string Name | Variable |   |
| everyFrame |   | false |   |   |

##### 5. CompareNames

Full Name: HutongGames.PlayMaker.Actions.CompareNames
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| name |   | string Name |   |   |
| strings |   | Array Ignore Names |   |   |
| target |   | EventTarget(Self):FSM Owner |   |   |
| trueEvent |   | Event(FINISHED) |   |   |
| falseEvent |   | Event() |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):G Parent |   |   |
| sendEvent |   | "TAKE DAMAGE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. TakeDamage

Full Name: HutongGames.PlayMaker.Actions.TakeDamage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| Target |   | GameObject G Parent |   |   |
| AttackType |   | int attackType |   |   |
| CircleDirection |   | bool circleDirection |   |   |
| DamageDealt |   | int damageDealt |   |   |
| Direction |   | float direction |   |   |
| IgnoreInvulnerable |   | bool Ignore Invuln |   |   |
| MagnitudeMultiplier |   | float magnitudeMult |   |   |
| MoveAngle |   | float Move Angle |   |   |
| MoveDirection |   | bool moveDirection |   |   |
| Multiplier |   | float Multiplier |   |   |
| SpecialType |   | int Special Type |   |   |

##### 8. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| sendEvent |   | Event(FINISHED) |   |   |
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
| CANCEL | false |
| FINISHED | false |
| HIT | true |
| MOVE DIRECTION | false |

