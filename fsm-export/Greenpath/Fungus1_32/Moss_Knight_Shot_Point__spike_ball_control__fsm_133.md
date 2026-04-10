# spike ball control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | spike ball control |
| GameObject Name | Shot Point |
| GameObject Path | Moss Knight |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets159.assets |
| Start State | Init |
| FSM PathId | 133 |
| GameObject PathId | 37 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle | 0 | Single: 0 |
| Angle Max | 0 | Single: 0 |
| Angle Min | 0 | Single: 0 |
| Direction | 0 | Single: 0 |
| Speed | 0 | Single: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bit1 | [null] | NamedAssetPPtr:  |
| Bit2 | [null] | NamedAssetPPtr:  |
| Bit3 | [null] | NamedAssetPPtr:  |
| Death Spore | [null] | NamedAssetPPtr:  |
| Grass | [null] | NamedAssetPPtr:  |
| Nail Object | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | 8 | 8 | Layer |  |
| sendEvent | Event(TERRAIN) | Event(TERRAIN) |  |  |
| storeCollider |  |  | Variable |  |

##### 2. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "Hero Spell" | "Hero Spell" | Tag |  |
| collideLayer | 17 | 17 | Layer |  |
| sendEvent | Event(TERRAIN) | Event(TERRAIN) |  |  |
| storeCollider |  |  | Variable |  |

##### 3. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "Nail Attack" | "Nail Attack" | Tag |  |
| collideLayer | 17 | 17 | Layer |  |
| sendEvent | Event(NAIL) | Event(NAIL) |  |  |
| storeCollider | GameObject Nail Object | GameObject Nail Object | Variable |  |

### Break

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grass | OwnerDefault Grass |  |  |

##### 2. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Death Spore | OwnerDefault Death Spore |  |  |
| emit | 0 | 0 |  |  |

##### 3. GetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.GetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeAngle | float Angle | float Angle | Variable |  |
| everyFrame | false | false |  |  |

##### 4. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Min | float Angle Min | Variable |  |
| floatValue | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle Max | float Angle Max | Variable |  |
| floatValue | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 7. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Angle Min | float Angle Min |  |  |
| float2 | 45f | 45f |  |  |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Subtract | 1 |  |  |
| storeResult | float Angle Min | float Angle Min | Variable |  |
| everyFrame | false | false |  |  |

##### 8. FloatOperator

Full Name: HutongGames.PlayMaker.Actions.FloatOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Angle Max | float Angle Max |  |  |
| float2 | 45f | 45f |  |  |
| operation | HutongGames.PlayMaker.Actions.FloatOperator/Operation::Add | 0 |  |  |
| storeResult | float Angle Max | float Angle Max | Variable |  |
| everyFrame | false | false |  |  |

##### 9. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Strike Nail (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Strike Nail (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 10. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bit1 | OwnerDefault Bit1 |  |  |
| activate | true | true |  |  |
| recursive | true | true |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 11. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bit2 | OwnerDefault Bit2 |  |  |
| activate | true | true |  |  |
| recursive | true | true |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 12. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bit3 | OwnerDefault Bit3 |  |  |
| activate | true | true |  |  |
| recursive | true | true |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 13. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 10f | 10f |  |  |
| max | 15f | 15f |  |  |
| storeResult | float Speed | float Speed | Variable |  |

##### 14. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | float Angle Min | float Angle Min |  |  |
| max | float Angle Max | float Angle Max |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 15. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bit1 | OwnerDefault Bit1 |  |  |
| angle | float Angle | float Angle |  |  |
| speed | float Speed | float Speed |  |  |
| everyFrame | false | false |  |  |

##### 16. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 10f | 10f |  |  |
| max | 15f | 15f |  |  |
| storeResult | float Speed | float Speed | Variable |  |

##### 17. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | float Angle Min | float Angle Min |  |  |
| max | float Angle Max | float Angle Max |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 18. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bit2 | OwnerDefault Bit2 |  |  |
| angle | float Angle | float Angle |  |  |
| speed | float Speed | float Speed |  |  |
| everyFrame | false | false |  |  |

##### 19. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 10f | 10f |  |  |
| max | 15f | 15f |  |  |
| storeResult | float Speed | float Speed | Variable |  |

##### 20. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | float Angle Min | float Angle Min |  |  |
| max | float Angle Max | float Angle Max |  |  |
| storeResult | float Angle | float Angle | Variable |  |

##### 21. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Bit3 | OwnerDefault Bit3 |  |  |
| angle | float Angle | float Angle |  |  |
| speed | float Speed | float Speed |  |  |
| everyFrame | false | false |  |  |

##### 22. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren | true | true |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.5f | 0.5f |  |  |
| y | 0.5f | 0.5f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformScale |  |  |  |  |
| vectorScale | Vector3(1, 1, 1) | Vector3(1, 1, 1) |  |  |
| time | 0.1f | 0.1f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::linear | 21 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. AddTorque2d

Full Name: HutongGames.PlayMaker.Actions.AddTorque2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| forceMode | UnityEngine.ForceMode2D::Force | 0 |  |  |
| torque | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "damageDealt" | "damageDealt" | FsmInt |  |
| setValue | 5 | 5 |  |  |
| everyFrame | false | false |  |  |

### Spin Choose

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendRandomEvent

Full Name: HutongGames.PlayMaker.Actions.SendRandomEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| delay | 0f | 0f |  |  |

### Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AddTorque2d

Full Name: HutongGames.PlayMaker.Actions.AddTorque2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| forceMode | UnityEngine.ForceMode2D::Force | 0 |  |  |
| torque | -400f | -400f |  |  |
| everyFrame | false | false |  |  |

### Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AddTorque2d

Full Name: HutongGames.PlayMaker.Actions.AddTorque2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| forceMode | UnityEngine.ForceMode2D::Force | 0 |  |  |
| torque | 400f | 400f |  |  |
| everyFrame | false | false |  |  |

### Nail Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.GetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Nail Object | OwnerDefault Nail Object |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "direction" | "direction" | FsmFloat |  |
| storeValue | float Direction | float Direction | Variable |  |
| everyFrame | false | false |  |  |

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Strike Nail (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Strike Nail (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 3. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| angle | float Direction | float Direction |  |  |
| speed | 22f | 22f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.15f | 0.15f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | TERRAIN | Break | 0 | 0 | 0 |
| Idle | NAIL | Nail Hit | 0 | 0 | 0 |
| Init | FINISHED | Spin Choose | 0 | 0 | 0 |
| Activate | FINISHED | Idle | 0 | 0 | 0 |
| Spin Choose | LEFT | Left | 0 | 0 | 0 |
| Spin Choose | RIGHT | Right | 0 | 0 | 0 |
| Left | FINISHED | Activate | 0 | 0 | 0 |
| Right | FINISHED | Activate | 0 | 0 | 0 |
| Nail Hit | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEFT | false |
| NAIL | false |
| RIGHT | false |
| TERRAIN | false |

