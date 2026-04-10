# Explosion Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Explosion Control |
| GameObject Name | Gas Explosion L |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets |
| Start State | Line Loop |
| FSM PathId | 888 |
| GameObject PathId | 179 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Chooser | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Looper | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Camera | [null] | NamedAssetPPtr:  |
| Hit Effect | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Explode

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "CameraParent" | "CameraParent" | Tag |  |
| store | GameObject Camera | GameObject Camera | Variable |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [explosion_4_wet (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [explosion_4_wet (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 0.85f | 0.85f |  |  |
| pitchMax | 1.1f | 1.1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Death Wave Infected (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] | [Global] [Death Wave Infected (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Hit Effect | GameObject Hit Effect | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 5. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 3f | 3f |  |  |
| y | 3f | 3f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren | true | true |  |  |

### Line Loop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1.6f | 1.6f |  |  |
| y | 1.6f | 1.6f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Looper | int Looper | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Impact Lines (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets27.assets)] | [Global] [Impact Lines (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets27.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Hit Effect | GameObject Hit Effect | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 5. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| color | Color(1, 0.51724136, 0, 1) | Color(1, 0.51724136, 0, 1) | FsmColor |  |
| everyframe | false | false |  |  |

##### 6. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 2f | 2f |  |  |
| max | 3f | 3f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 7. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Chooser | float Chooser |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 8. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0f | 0f |  |  |
| max | 360f | 360f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 9. Rotate

Full Name: HutongGames.PlayMaker.Actions.Rotate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit Effect | OwnerDefault Hit Effect |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f |  |  |
| yAngle | 0f | 0f |  |  |
| zAngle | float Chooser | float Chooser |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 10. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Looper | int Looper |  |  |
| integer2 | 11 | 11 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(LOOP COMPLETE) | Event(LOOP COMPLETE) |  |  |
| everyFrame | false | false |  |  |

### Loop Back

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. GotoPreviousState

Full Name: HutongGames.PlayMaker.Actions.GotoPreviousState
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Explode | FINISHED | destroy | 0 | 0 | 0 |
| Line Loop | FINISHED | Loop Back | 0 | 0 | 0 |
| Line Loop | LOOP COMPLETE | Explode | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LOOP COMPLETE | false |

