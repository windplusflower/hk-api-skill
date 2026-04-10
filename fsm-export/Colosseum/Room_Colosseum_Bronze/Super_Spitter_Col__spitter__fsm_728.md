# spitter

## Summary

| Field | Value |
| --- | --- |
| FSM Name | spitter |
| GameObject Name | Super Spitter Col |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets |
| Start State | Idle |
| FSM PathId | 728 |
| GameObject PathId | 228 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle | 0 | Single: 0 |
| AngleToHero | 0 | Single: 0 |
| Distance | 0 | Single: 0 |
| Dribble Spread Max | 0 | Single: 0 |
| Dribble Spread Min | 0 | Single: 0 |
| Fire Timer | 0 | Single: 0 |
| Hero X | 0 | Single: 0 |
| Hero Y | 0 | Single: 0 |
| Range Out Timer | 0 | Single: 0 |
| Raycast X | 0 | Single: 0 |
| Raycast Y | 0 | Single: 0 |
| Self X | 0 | Single: 0 |
| Self Y | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Can See Hero | false | Boolean: false |
| In Alert Range | false | Boolean: false |
| Out Of Range | false | Boolean: false |
| Raycast Hit | false | Boolean: false |
| Unalert Range | false | Boolean: false |
| startAlert | false | Boolean: false |

### Vector2s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Pos 2D | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Raycast Vector | Vector2(0, 0) | Vector2: Vector2(0, 0) |
| Self Pos 2D | Vector2(0, 0) | Vector2: Vector2(0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Shot | [null] | NamedAssetPPtr:  |

### Objects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alert Range | [null] | NamedAssetPPtr:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| pitch | 0.8f | 0.8f |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 3. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| frame | 2 | 2 |  |  |

##### 4. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | false | false |  |  |
| pauseTime | 0f | 0f |  |  |

##### 5. IdleBuzz

Full Name: HutongGames.PlayMaker.Actions.IdleBuzz
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| waitMin | 0.75f | 0.75f |  |  |
| waitMax | 1f | 1f |  |  |
| speedMax | 1.75f | 1.75f |  |  |
| accelerationMax | 15f | 15f |  |  |
| roamingRange | 1f | 1f |  |  |

##### 6. FindAlertRange

Full Name: FindAlertRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| storeResult | object Alert Range | object Alert Range | Variable |  |
| childName | Alert Range New | Alert Range New |  |  |

##### 7. CheckCanSeeHero

Full Name: CheckCanSeeHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | bool Can See Hero | bool Can See Hero | Variable |  |
| everyFrame | true | true |  |  |

##### 8. CheckAlertRange

Full Name: CheckAlertRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| alertRange | object Alert Range | object Alert Range | Variable |  |
| storeResult | bool In Alert Range | bool In Alert Range | Variable |  |
| everyFrame | true | true |  |  |

##### 9. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(ALERT) | Event(ALERT) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | true | true |  |  |

##### 10. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool startAlert | bool startAlert | Variable |  |
| isTrue | Event(ALERT) | Event(ALERT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | true | true |  |  |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | "ALERT" | "ALERT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Distance Fly

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 2. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| frame | 2 | 2 |  |  |

##### 3. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 2.5f | 2.5f |  |  |
| max | 3f | 3f |  |  |
| storeResult | float Fire Timer | float Fire Timer | Variable |  |

##### 4. DistanceFly

Full Name: HutongGames.PlayMaker.Actions.DistanceFly
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | GameObject Hero | GameObject Hero | Variable |  |
| distance | 7f | 7f |  |  |
| speedMax | 5f | 5f |  |  |
| acceleration | 0.1f | 0.1f |  |  |
| targetsHeight | false | false |  |  |
| height | 0f | 0f |  |  |

##### 5. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | GameObject Hero | GameObject Hero | Variable |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | "TurnToFly" | "TurnToFly" |  |  |
| resetFrame | true | true |  |  |
| everyFrame | true | true |  |  |

##### 6. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 1f | 1f |  |  |
| timeMax | 1.5f | 1.5f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Fire Timer | float Fire Timer |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

##### 8. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Out Of Range | bool Out Of Range | Variable |  |
| boolValue | bool Unalert Range | bool Unalert Range |  |  |
| everyFrame | true | true |  |  |

##### 9. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Out Of Range | bool Out Of Range | Variable |  |
| everyFrame | true | true |  |  |

##### 10. FloatAddV2

Full Name: HutongGames.PlayMaker.Actions.FloatAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Range Out Timer | float Range Out Timer | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | true | true |  |  |
| perSecond | true | true |  |  |
| fixedUpdate | false | false |  |  |
| activeBool | bool Out Of Range | bool Out Of Range | Variable |  |

##### 11. SetFloatValueV2

Full Name: HutongGames.PlayMaker.Actions.SetFloatValueV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Range Out Timer | float Range Out Timer | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | true | true |  |  |
| activeBool | bool Unalert Range | bool Unalert Range |  |  |

##### 12. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Range Out Timer | float Range Out Timer |  |  |
| float2 | 8f | 8f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(UNALERT) | Event(UNALERT) |  |  |
| everyFrame | true | true |  |  |

### Fire

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlay

Full Name: HutongGames.PlayMaker.Actions.AudioPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [spitter_spit (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] | [spitter_spit (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] |  |  |
| finishedEvent | Event() | Event() |  |  |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spitter Shot R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] | [Global] [Spitter Shot R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Shot | GameObject Shot | Variable |  |

##### 3. FireAtTarget

Full Name: HutongGames.PlayMaker.Actions.FireAtTarget
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shot | OwnerDefault Shot |  |  |
| target | GameObject Hero | GameObject Hero |  |  |
| speed | 15f | 15f |  |  |
| position | Vector3(0, -0.5, 0) | Vector3(0, -0.5, 0) |  |  |
| spread | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(WAIT) | Event(WAIT) |  |  |

##### 5. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Attack" | "Attack" |  |  |

##### 6. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | GameObject Hero | GameObject Hero | Variable |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| resetFrame | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. GetAngleToTarget2D

Full Name: HutongGames.PlayMaker.Actions.GetAngleToTarget2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| target | GameObject Hero | GameObject Hero |  |  |
| offsetX | 0f | 0f |  |  |
| offsetY | -0.5f | -0.5f |  |  |
| storeAngle | float Angle | float Angle |  |  |
| everyFrame | false | false |  |  |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle | Variable |  |
| add | -35f | -35f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 9. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spitter Shot R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] | [Global] [Spitter Shot R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Shot | GameObject Shot | Variable |  |

##### 10. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shot | OwnerDefault Shot |  |  |
| angle | float Angle | float Angle |  |  |
| speed | 15f | 15f |  |  |
| everyFrame | false | false |  |  |

##### 11. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Angle | float Angle | Variable |  |
| add | 70f | 70f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 12. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spitter Shot R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] | [Global] [Spitter Shot R (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets32.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Shot | GameObject Shot | Variable |  |

##### 13. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shot | OwnerDefault Shot |  |  |
| angle | float Angle | float Angle |  |  |
| speed | 15f | 15f |  |  |
| everyFrame | false | false |  |  |

### Alert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| pitch | 1.2f | 1.2f |  |  |
| everyFrame | false | false |  |  |

##### 2. GetHero

Full Name: GetHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | GameObject Hero | GameObject Hero | Variable |  |

##### 3. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool startAlert | bool startAlert | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Fire Anticipate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DistanceFly

Full Name: HutongGames.PlayMaker.Actions.DistanceFly
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | GameObject Hero | GameObject Hero | Variable |  |
| distance | 9f | 9f |  |  |
| speedMax | 2f | 2f |  |  |
| acceleration | 0.1f | 0.1f |  |  |
| targetsHeight | false | false |  |  |
| height | 0f | 0f |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Attack Antic" | "Attack Antic" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(WAIT) | Event(WAIT) |  |  |

### Raycast

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | float Hero Y | float Hero Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Self X | float Self X | Variable |  |
| y | float Self Y | float Self Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 3. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable | Vector2 Hero Pos 2D | Vector2 Hero Pos 2D | Variable |  |
| vector2Value | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Hero X | float Hero X |  |  |
| y | float Hero Y | float Hero Y |  |  |
| everyFrame | false | false |  |  |

##### 4. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable | Vector2 Self Pos 2D | Vector2 Self Pos 2D | Variable |  |
| vector2Value | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Self X | float Self X |  |  |
| y | float Self Y | float Self Y |  |  |
| everyFrame | false | false |  |  |

##### 5. DistanceBetweenPoints2D

Full Name: HutongGames.PlayMaker.Actions.DistanceBetweenPoints2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| distanceResult | float Distance | float Distance | Variable |  |
| point1 | Vector2 Self Pos 2D | Vector2 Self Pos 2D |  |  |
| point2 | Vector2 Hero Pos 2D | Vector2 Hero Pos 2D |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Raycast X | float Raycast X | Variable |  |
| floatValue | float Hero X | float Hero X |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Raycast Y | float Raycast Y | Variable |  |
| floatValue | float Hero Y | float Hero Y |  |  |
| everyFrame | false | false |  |  |

##### 8. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Raycast X | float Raycast X | Variable |  |
| subtract | float Self X | float Self X |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 9. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Raycast Y | float Raycast Y | Variable |  |
| subtract | float Self Y | float Self Y |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 10. SetVector2XY

Full Name: HutongGames.PlayMaker.Actions.SetVector2XY
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector2Variable | Vector2 Raycast Vector | Vector2 Raycast Vector | Variable |  |
| vector2Value | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| x | float Raycast X | float Raycast X |  |  |
| y | float Raycast Y | float Raycast Y |  |  |
| everyFrame | false | false |  |  |

##### 11. RayCast2d

Full Name: HutongGames.PlayMaker.Actions.RayCast2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromGameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  | Setup |
| fromPosition | Vector2(0, 0) | Vector2(0, 0) |  |  |
| direction | Vector2 Raycast Vector | Vector2 Raycast Vector |  |  |
| space | UnityEngine.Space::World | 0 |  |  |
| distance | float Distance | float Distance |  |  |
| minDepth | 0 | 0 |  |  |
| maxDepth | 0 | 0 |  |  |
| hitEvent | Event() | Event() | Variable | Result |
| storeDidHit | bool Raycast Hit | bool Raycast Hit | Variable |  |
| storeHitObject |  |  | Variable |  |
| storeHitPoint | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitNormal | Vector2(0, 0) | Vector2(0, 0) | Variable |  |
| storeHitDistance | 0f | 0f | Variable |  |
| storeHitFraction | 0f | 0f | Variable |  |
| repeatInterval | 1 | 1 |  | Filter |
| layerMask | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Layer |  |
| invertMask | false | false |  |  |
| debugColor | Color(1, 0.92156863, 0.015686275, 1) | Color(1, 0.92156863, 0.015686275, 1) |  | Debug |
| debug | true | true |  |  |

##### 12. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(WAIT) | Event(WAIT) |  |  |

### Raycast Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Raycast Hit | bool Raycast Hit | Variable |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |
| everyFrame | false | false |  |  |

### Fire Dribble

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetRotation

Full Name: HutongGames.PlayMaker.Actions.GetRotation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shot | OwnerDefault Shot |  |  |
| quaternion | Quaternion(0, 0, 0, 0) | Quaternion(0, 0, 0, 0) | Variable |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| xAngle | 0f | 0f | Variable |  |
| yAngle | 0f | 0f | Variable |  |
| zAngle | float AngleToHero | float AngleToHero | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Dribble Spread Min | float Dribble Spread Min | Variable |  |
| floatValue | float AngleToHero | float AngleToHero |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Dribble Spread Max | float Dribble Spread Max | Variable |  |
| floatValue | float AngleToHero | float AngleToHero |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Dribble Spread Max | float Dribble Spread Max | Variable |  |
| add | 25f | 25f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 5. FloatSubtract

Full Name: HutongGames.PlayMaker.Actions.FloatSubtract
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Dribble Spread Min | float Dribble Spread Min | Variable |  |
| subtract | 25f | 25f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 6. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Spatter Orange (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 3 | 3 |  |  |
| spawnMax | 5 | 5 |  |  |
| speedMin | 10f | 10f |  |  |
| speedMax | 20f | 20f |  |  |
| angleMin | float Dribble Spread Min | float Dribble Spread Min |  |  |
| angleMax | float Dribble Spread Max | float Dribble Spread Max |  |  |
| originVariationX | 0f | 0f |  |  |
| originVariationY | 0f | 0f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 7. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(WAIT) | Event(WAIT) |  |  |

### Fly Back

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.4f | 0.4f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. DistanceFly

Full Name: HutongGames.PlayMaker.Actions.DistanceFly
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| target | GameObject Hero | GameObject Hero | Variable |  |
| distance | 8.25f | 8.25f |  |  |
| speedMax | 6f | 6f |  |  |
| acceleration | 0.25f | 0.25f |  |  |
| targetsHeight | false | false |  |  |
| height | 0f | 0f |  |  |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Range Out Timer | float Range Out Timer | Variable |  |
| floatValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | ALERT | Alert | 0 | 0 | 0 |
| Idle | FINISHED | Alert | 0 | 0 | 0 |
| Distance Fly | WAIT | Raycast | 0 | 0 | 0 |
| Distance Fly | TOOK DAMAGE | Raycast | 0 | 0 | 0 |
| Fire | WAIT | Fire Dribble | 0 | 0 | 0 |
| Alert | FINISHED | Distance Fly | 0 | 0 | 0 |
| Fire Anticipate | WAIT | Fire | 0 | 0 | 0 |
| Raycast | WAIT | Raycast Check | 0 | 0 | 0 |
| Raycast Check | TRUE | Distance Fly | 0 | 0 | 0 |
| Raycast Check | FALSE | Fly Back | 0 | 0 | 0 |
| Fire Dribble | WAIT | Distance Fly | 0 | 0 | 0 |
| Fly Back | FINISHED | Fire Anticipate | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ALERT | true |
| FALSE | false |
| TOOK DAMAGE | false |
| TRUE | false |
| UNALERT | false |
| WAIT | true |

