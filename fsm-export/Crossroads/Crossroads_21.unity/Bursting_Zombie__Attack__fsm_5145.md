# Attack

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Attack |
| GameObject Name | Bursting Zombie |
| GameObject Path | infected_event/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level58 |
| Start State | Init |
| FSM PathId | 5145 |
| GameObject PathId | 864 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Speed | 15 | Single: 15 |
| X Speed | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alert Range | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Chareg Audio | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

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
| childName |   | "Charge Audio" |   |   |
| storeResult |   | GameObject Chareg Audio | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Alert Range | Variable |   |
| isTrue |   | Event(ATTACK) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "HeroBox" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(EXPLODE) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ATTACK | Antic | 0 | |
| EXPLODE | Explode | 0 | |

### Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | 0f |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. StopWalker

Full Name: StopWalker
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner |   |   |
| everyFrame |   | false |   |   |

##### 3. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | [Global] GameObject Hero | Variable |   |
| spriteFacesRight |   | false |   |   |
| playNewAnimation |   | false |   |   |
| newAnimationClip |   | "" |   |   |
| resetFrame |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Attack Antic" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 5. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "HeroBox" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(EXPLODE) |   |   |
| storeCollider |   |   | Variable |   |

##### 6. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Start Run | 0 | |
| EXPLODE | Explode | 0 | |

### Start Run

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
| clipName |   | "Run" |   |   |

##### 2. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| xScale |   | true |   |   |
| positiveEvent |   | Event(L) |   |   |
| negativeEvent |   | Event(R) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| L | L | 0 | |
| R | R | 0 | |

### L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Speed | Variable |   |
| multiplyBy |   | -1f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float Speed |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Running | 0 | |

### R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) |   |   |
| x |   | float Speed |   |   |
| y |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Running | 0 | |

### Running

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event(EXPLODE) |   |   |
| bottomHitEvent |   | Event() |   |   |
| leftHitEvent |   | Event(EXPLODE) |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [] |   |   |

##### 3. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Chareg Audio |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [exploding_zombie_charge (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets33.assets)] |   |   |

##### 4. CheckCollisionSideEnter

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSideEnter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit |   | false | Variable |   |
| rightHit |   | false | Variable |   |
| bottomHit |   | false | Variable |   |
| leftHit |   | false | Variable |   |
| topHitEvent |   | Event() |   |   |
| rightHitEvent |   | Event(EXPLODE) |   |   |
| bottomHitEvent |   | Event() |   |   |
| leftHitEvent |   | Event(EXPLODE) |   |   |
| otherLayer |   | false |   |   |
| otherLayerNumber |   | 0 |   |   |
| ignoreTriggers |   | false |   |   |

##### 5. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "HeroBox" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(EXPLODE) |   |   |
| storeCollider |   |   | Variable |   |

##### 6. GetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.GetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| vector |   | Vector2(0, 0) | Variable |   |
| x |   | float X Speed | Variable |   |
| y |   | 0f | Variable |   |
| space | UnityEngine.Space::World | 0 |   |   |
| everyFrame |   | true |   |   |

##### 7. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float X Speed |   |   |
| float2 |   | 0f |   |   |
| tolerance |   | 0.1f |   |   |
| equal |   | Event(EXPLODE) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EXPLODE | Explode | 0 | |

### Explode

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Spatter Orange (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| spawnMin |   | 20 |   |   |
| spawnMax |   | 20 |   |   |
| speedMin |   | 15f |   |   |
| speedMax |   | 20f |   |   |
| angleMin |   | 10f |   |   |
| angleMax |   | 170f |   |   |
| originVariationX |   | 0f |   |   |
| originVariationY |   | 0f |   |   |
| FSM |   | "" |   |   |
| FSMEvent |   | "" |   |   |

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Gas Explosion L (Hollow Knight/hollow_knight_Data\sharedassets33.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   |   | Variable |   |
| networkInstantiate |   | false |   |   |
| networkGroup |   | 0 |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. InstaDeath

Full Name: InstaDeath
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target |   | OwnerDefault FSM Owner | Variable |   |
| direction |   | float Speed |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| TOOK DAMAGE | Explode | 0 | |

## Events

| Name | Global |
| --- | --- |
| ATTACK | false |
| EXPLODE | false |
| FINISHED | false |
| L | false |
| R | false |
| TOOK DAMAGE | false |

