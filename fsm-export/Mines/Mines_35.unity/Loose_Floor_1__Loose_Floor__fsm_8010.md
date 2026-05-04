# Loose Floor

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Loose Floor |
| GameObject Name | Loose Floor 1 |
| GameObject Path | _Scenery/mine_1_quake_floor/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level274 |
| Start State | Init |
| FSM PathId | 8010 |
| GameObject PathId | 353 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Speed | 0 | Single: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Bot 1 | [null] | NamedAssetPPtr: [null] |
| Bot 2 | [null] | NamedAssetPPtr: [null] |
| Bot 3 | [null] | NamedAssetPPtr: [null] |
| Churn Rocks | [null] | NamedAssetPPtr: [null] |
| Dust B | [null] | NamedAssetPPtr: [null] |
| Dust F | [null] | NamedAssetPPtr: [null] |
| Effect Centre | [null] | NamedAssetPPtr: [null] |
| Hero | [null] | NamedAssetPPtr: [null] |
| Parent | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| fsmName |   | "Play Sound" | FsmName |   |
| variableName |   | "Floor 2" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionStay2D | 1 |   |   |
| collideTag |   | "Player" | Tag |   |
| sendEvent |   | Event(ENTER) |   |   |
| storeCollider |   | GameObject Hero | Variable |   |
| storeForce |   | 0f | Variable |   |

##### 4. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionEnter2D | 0 |   |   |
| collideTag |   | "Player" | Tag |   |
| sendEvent |   | Event(ENTER) |   |   |
| storeCollider |   | GameObject Hero | Variable |   |
| storeForce |   | 0f | Variable |   |

##### 5. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust B |   |   |
| emission |   | false |   |   |

##### 6. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust F |   |   |
| emission |   | false |   |   |

##### 7. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Churn Rocks |   |   |
| emission |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ENTER | Still | 0 | |

### Still

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| fsmName |   | "Play Sound" | FsmName |   |
| variableName |   | "Floor 2" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionExit2D | 2 |   |   |
| collideTag |   | "Player" | Tag |   |
| sendEvent |   | Event(EXIT) |   |   |
| storeCollider |   |   | Variable |   |
| storeForce |   | 0f | Variable |   |

##### 4. GetSpeed2d

Full Name: HutongGames.PlayMaker.Actions.GetSpeed2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| storeResult |   | float Hero Speed | Variable |   |
| everyFrame |   | true |   |   |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Hero Speed |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0.1f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(MOVING) |   |   |
| greaterThan |   | Event(MOVING) |   |   |
| everyFrame |   | true |   |   |

##### 6. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust B |   |   |
| emission |   | false |   |   |

##### 7. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust F |   |   |
| emission |   | false |   |   |

##### 8. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Churn Rocks |   |   |
| emission |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EXIT | Idle | 0 | |
| MOVING | Moving | 0 | |

### Moving

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Shake" |   |   |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| fsmName |   | "Play Sound" | FsmName |   |
| variableName |   | "Floor 2" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 3. Collision2dEvent

Full Name: HutongGames.PlayMaker.Actions.Collision2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| collision | HutongGames.PlayMaker.Collision2DType::OnCollisionExit2D | 2 |   |   |
| collideTag |   | "Player" | Tag |   |
| sendEvent |   | Event(EXIT) |   |   |
| storeCollider |   |   | Variable |   |
| storeForce |   | 0f | Variable |   |

##### 4. GetSpeed2d

Full Name: HutongGames.PlayMaker.Actions.GetSpeed2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| storeResult |   | float Hero Speed | Variable |   |
| everyFrame |   | true |   |   |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Hero Speed |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0.1f |   |   |
| equal |   | Event(STILL) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 6. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bot 1 |   |   |
| x |   | 0.03f |   |   |
| y |   | 0.03f |   |   |
| z |   | 0f |   |   |
| allowMovement |   | false |   |   |

##### 7. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bot 2 |   |   |
| x |   | 0.03f |   |   |
| y |   | 0.03f |   |   |
| z |   | 0f |   |   |
| allowMovement |   | false |   |   |

##### 8. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bot 3 |   |   |
| x |   | 0.03f |   |   |
| y |   | 0.03f |   |   |
| z |   | 0f |   |   |
| allowMovement |   | false |   |   |

##### 9. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust B |   |   |
| emission |   | true |   |   |

##### 10. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust F |   |   |
| emission |   | true |   |   |

##### 11. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Churn Rocks |   |   |
| emission |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EXIT | Moving Cooldown | 0 | |
| STILL | Moving Cooldown | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dust B" |   |   |
| storeResult |   | GameObject Dust B | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dust F" |   |   |
| storeResult |   | GameObject Dust F | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Churn Rocks" |   |   |
| storeResult |   | GameObject Churn Rocks | Variable |   |

##### 4. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Parent | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| childName |   | "Effect Centre" |   |   |
| storeResult |   | GameObject Effect Centre | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| childName |   | "Bot 1" |   |   |
| storeResult |   | GameObject Bot 1 | Variable |   |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| childName |   | "Bot 2" |   |   |
| storeResult |   | GameObject Bot 2 | Variable |   |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| childName |   | "Bot 3" |   |   |
| storeResult |   | GameObject Bot 3 | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Break

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Parent |   |   |
| fsmName |   | "Play Sound" | FsmName |   |
| variableName |   | "Floor 2" | FsmBool |   |
| setValue |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Idle" |   |   |

##### 3. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust B |   |   |
| emission |   | false |   |   |

##### 4. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dust F |   |   |
| emission |   | false |   |   |

#### Transitions

(none)

### Moving Cooldown

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.4f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 2. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bot 3 |   |   |
| x |   | 0.03f |   |   |
| y |   | 0.03f |   |   |
| z |   | 0f |   |   |
| allowMovement |   | false |   |   |

##### 3. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bot 2 |   |   |
| x |   | 0.03f |   |   |
| y |   | 0.03f |   |   |
| z |   | 0f |   |   |
| allowMovement |   | false |   |   |

##### 4. ObjectJitter

Full Name: HutongGames.PlayMaker.Actions.ObjectJitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Bot 1 |   |   |
| x |   | 0.03f |   |   |
| y |   | 0.03f |   |   |
| z |   | 0f |   |   |
| allowMovement |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BREAK 1 | Break | 0 | |

## Events

| Name | Global |
| --- | --- |
| BREAK 1 | false |
| ENTER | false |
| EXIT | false |
| FINISHED | false |
| MOVING | false |
| STILL | false |

