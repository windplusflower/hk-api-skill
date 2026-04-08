# Uumuu Event

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Uumuu Event |
| GameObject Name | Gas Explosion Uumuu |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets156.assets |
| Start State | Idle |
| FSM PathId | 439 |
| GameObject PathId | 40 |

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
| magnitudeMult | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Layer | 0 | Int32: 0 |
| Special Type | 0 | Int32: 0 |
| attackType | 0 | Int32: 0 |
| damageDealt | 0 | Int32: 0 |

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
| sendEvent | HIT | HIT |  |  |
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
| sendEvent | HIT | HIT |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

##### 3. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "Enemies" | "Enemies" | Layer |  |
| sendEvent | HIT | HIT |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

### Send Event

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Collider | EventTarget(GameObject):Collider |  |  |
| sendEvent | "EXPLODE" | "EXPLODE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int damageDealt | int damageDealt |  |  |
| integer2 | 0 | 0 |  |  |
| equal | CANCEL | CANCEL |  |  |
| lessThan | CANCEL | CANCEL |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 3. GetLayer

Full Name: HutongGames.PlayMaker.Actions.GetLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| storeResult | int Layer | int Layer | Variable |  |
| everyFrame | false | false |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Layer | int Layer |  |  |
| integer2 | 20 | 20 |  |  |
| equal | CANCEL | CANCEL |  |  |
| lessThan |  |  |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Layer | int Layer |  |  |
| integer2 | 9 | 9 |  |  |
| equal | CANCEL | CANCEL |  |  |
| lessThan |  |  |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 6. CheckSendEventLimit

Full Name: CheckSendEventLimit
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| target | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| trueEvent |  |  |  |  |
| falseEvent | FINISHED | FINISHED |  |  |

##### 7. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| storeName | string Name | string Name | Variable |  |
| everyFrame | false | false |  |  |

##### 8. CompareNames

Full Name: HutongGames.PlayMaker.Actions.CompareNames
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| name | string Name | string Name |  |  |
| strings | Array Ignore Names | Array Ignore Names |  |  |
| target | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| trueEvent | CANCEL | CANCEL |  |  |
| falseEvent |  |  |  |  |

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
| isNull | FINISHED | FINISHED |  |  |
| isNotNull |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. CheckSendEventLimit

Full Name: CheckSendEventLimit
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Parent | GameObject Parent |  |  |
| target | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| trueEvent |  |  |  |  |
| falseEvent | FINISHED | FINISHED |  |  |

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
| trueEvent | FINISHED | FINISHED |  |  |
| falseEvent |  |  |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| sendEvent | "EXPLODE" | "EXPLODE" |  |  |
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
| isNull | FINISHED | FINISHED |  |  |
| isNotNull |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. CheckSendEventLimit

Full Name: CheckSendEventLimit
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject G Parent | GameObject G Parent |  |  |
| target | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| trueEvent |  |  |  |  |
| falseEvent | FINISHED | FINISHED |  |  |

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
| trueEvent | FINISHED | FINISHED |  |  |
| falseEvent |  |  |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):G Parent | EventTarget(GameObject):G Parent |  |  |
| sendEvent | "EXPLODE" | "EXPLODE" |  |  |
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
| HIT | true |
| FINISHED | false |
| CANCEL | false |

