# corpse

## Summary

| Field | Value |
| --- | --- |
| FSM Name | corpse |
| GameObject Name | Corpse_Colosseum_Roller_Spawned |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets |
| Start State | Initiate |
| FSM PathId | 776 |
| GameObject PathId | 242 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Scale | 0 | Single: 0 |
| X Scale | 0 | Single: 0 |
| X Speed | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| spellBurn | false | Boolean: false |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Velocity | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Scale Vector | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Colour | Color(0, 0, 0, 1) | UnityColor: Color(0, 0, 0, 1) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |
| Unfurler | [null] | NamedAssetPPtr:  |

## States

### Initiate

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

##### 2. SetProperty

Full Name: HutongGames.PlayMaker.Actions.SetProperty
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| targetProperty | Property {[Corpse Flame (ParticleSystem) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)]}.enableEmission | Property {[Corpse Flame (ParticleSystem) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)]}.enableEmission |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.1f | 0.1f |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |

### In Air

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CheckCollisionSide

Full Name: HutongGames.PlayMaker.Actions.CheckCollisionSide
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| topHit | false | false | Variable |  |
| rightHit | false | false | Variable |  |
| bottomHit | false | false | Variable |  |
| leftHit | false | false | Variable |  |
| topHitEvent | Event() | Event() |  |  |
| rightHitEvent | Event() | Event() |  |  |
| bottomHitEvent | Event(LANDED) | Event(LANDED) |  |  |
| leftHitEvent | Event() | Event() |  |  |
| otherLayer | false | false |  |  |
| otherLayerNumber | 0 | 0 |  |  |
| ignoreTriggers | false | false |  |  |

### Landed

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
| vector | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float X Speed | float X Speed | Variable |  |
| y | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Death Land" | "Death Land" |  |  |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float X Speed | float X Speed |  |  |
| float2 | 0f | 0f |  |  |
| tolerance | 2f | 2f |  |  |
| equal | Event(LANDED) | Event(LANDED) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

### Unfurl

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetScale

Full Name: HutongGames.PlayMaker.Actions.GetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xScale | float X Scale | float X Scale | Variable |  |
| yScale | 0f | 0f | Variable |  |
| zScale | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float X Scale | float X Scale | Variable |  |
| multiplyBy | 0.2f | 0.2f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Scale Vector | Vector3 Scale Vector | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float X Scale | float X Scale |  |  |
| y | 0.2f | 0.2f |  |  |
| z | 0.2f | 0.2f |  |  |
| everyFrame | false | false |  |  |

##### 4. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformScale |  |  |  |  |
| vectorScale | Vector3 Scale Vector | Vector3 Scale Vector |  |  |
| time | 0.2f | 0.2f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::linear | 21 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 5. SetProperty

Full Name: HutongGames.PlayMaker.Actions.SetProperty
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| targetProperty | Property {[Corpse Flame (ParticleSystem) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)]}.enableEmission | Property {[Corpse Flame (ParticleSystem) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)]}.enableEmission |  |  |
| everyFrame | false | false |  |  |

##### 6. SetProperty

Full Name: HutongGames.PlayMaker.Actions.SetProperty
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| targetProperty | Property {[Corpse Steam (ParticleSystem) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)]}.enableEmission | Property {[Corpse Steam (ParticleSystem) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)]}.enableEmission |  |  |
| everyFrame | false | false |  |  |

### Flame Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool spellBurn | bool spellBurn | Variable |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |
| everyFrame | false | false |  |  |

### Start Flame

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| color | Color(0.19607843, 0.19607843, 0.19607843, 1) | Color(0.19607843, 0.19607843, 0.19607843, 1) | FsmColor |  |
| everyframe | false | false |  |  |

##### 2. SetProperty

Full Name: HutongGames.PlayMaker.Actions.SetProperty
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| targetProperty | Property {[Corpse Flame (ParticleSystem) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)]}.enableEmission | Property {[Corpse Flame (ParticleSystem) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)]}.enableEmission |  |  |
| everyFrame | false | false |  |  |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Death Puff Mini (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] | [Global] [Death Puff Mini (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 2. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren | true | true |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Initiate | FINISHED | Flame Check | 0 | 0 | 0 |
| In Air | LANDED | Landed | 0 | 0 | 0 |
| Landed | LANDED | Unfurl | 0 | 0 | 0 |
| Unfurl | FINISHED | Destroy | 0 | 0 | 0 |
| Flame Check | TRUE | Start Flame | 0 | 0 | 0 |
| Flame Check | FALSE | In Air | 0 | 0 | 0 |
| Start Flame | FINISHED | In Air | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LANDED | false |
| TRUE | false |
| FALSE | false |

