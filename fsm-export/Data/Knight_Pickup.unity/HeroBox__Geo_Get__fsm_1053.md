# Geo Get

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Geo Get |
| GameObject Name | HeroBox |
| GameObject Path | Knight/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level4 |
| Start State | Init |
| FSM PathId | 1053 |
| GameObject PathId | 173 |

## Variables

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| World Pos | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Geo Get | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Geo Get |   |   |
| active |   | false |   |   |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "Geo" | Tag |   |
| collideLayer |   | "Particle" | Layer |   |
| sendEvent |   | Event(GEO GET) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| GEO GET | Get 1 | 0 | |

### Get 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetRandomRotation

Full Name: HutongGames.PlayMaker.Actions.SetRandomRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Geo Get |   |   |
| x |   | false |   |   |
| y |   | false |   |   |
| z |   | true |   |   |

##### 2. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |

##### 3. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Geo Get |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 0.85f |   |   |
| pitchMax |   | 1.15f |   |   |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Geo Get |   |   |
| active |   | true |   |   |

##### 5. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Geo Get |   |   |
| frame |   | 0 |   |   |

##### 6. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Geo Get |   |   |
| clipName |   | "Get" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event() |   |   |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Get 2 | 0 | |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Geo Get" |   |   |
| storeResult |   | GameObject Geo Get | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Inert | 0 | |

### Get 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Geo Get |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector3 World Pos | Variable |   |
| x |   | 0f | Variable |   |
| y |   | 0f | Variable |   |
| z |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Inert | 0 | |
| GEO GET | Get 1 | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| GEO GET | false |

