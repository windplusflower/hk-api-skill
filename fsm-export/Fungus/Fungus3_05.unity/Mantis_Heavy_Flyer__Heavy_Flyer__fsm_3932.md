# Heavy Flyer

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Heavy Flyer |
| GameObject Name | Mantis Heavy Flyer |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level201 |
| Start State | Init |
| FSM PathId | 3932 |
| GameObject PathId | 149 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle | 0 | Single: 0 |
| Distance | 0 | Single: 0 |
| Height | 0 | Single: 0 |
| Range Out Timer | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alert Range | false | Boolean: false |
| Out of Range | false | Boolean: false |
| Shoot Range | false | Boolean: false |
| Stay Left | false | Boolean: false |
| Stay Right | false | Boolean: false |
| startAlert | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Map Zone |   | String:  |
| Map Zone |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |
| Shot | [null] | NamedAssetPPtr: [null] |
| Shot Point | Mantis Heavy Flyer/Shot Point (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level201) | NamedAssetPPtr: [Mantis Heavy Flyer/Shot Point (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level201)] |

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

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IdleBuzz

Full Name: HutongGames.PlayMaker.Actions.IdleBuzz
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| waitMin |   | 0.25f |   |   |
| waitMax |   | 0.75f |   |   |
| speedMax |   | 5f |   |   |
| accelerationMax |   | 200f |   |   |
| roamingRange |   | 3f |   |   |

##### 2. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| spriteFacesRight |   | true |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "TurnToFly" |   |   |
| everyFrame |   | true |   |   |
| pauseBetweenTurns |   | true |   |   |
| pauseTime |   | 0.5f |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Alert Range | Variable |   |
| isTrue |   | Event(ALERT) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Range Out Timer | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool startAlert | Variable |   |
| isTrue |   | Event(ALERT) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 6. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| behaviour |   | "GameManager" | Behaviour |   |
| methodName |   | "GetCurrentMapZone" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var Map Zone =  | Variable | Store Result |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| sendEvent |   | string Map Zone |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ALERT | Alert | 0 | |
| COLOSSEUM | Alert | 0 | |

### Alert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 6f |   |   |
| max |   | 8f |   |   |
| storeResult |   | float Distance | Variable |   |

##### 2. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min |   | 4f |   |   |
| max |   | 5.5f |   |   |
| storeResult |   | float Height | Variable |   |

##### 3. DistanceFly

Full Name: HutongGames.PlayMaker.Actions.DistanceFly
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | [Global] GameObject Hero | Variable |   |
| distance |   | float Distance |   |   |
| speedMax |   | 4.5f |   |   |
| acceleration |   | 0.5f |   |   |
| targetsHeight |   | true |   |   |
| height |   | float Height |   |   |

##### 4. DistanceFlyV2

Full Name: HutongGames.PlayMaker.Actions.DistanceFlyV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | [Global] GameObject Hero | Variable |   |
| distance |   | float Distance |   |   |
| speedMax |   | 4.5f |   |   |
| acceleration |   | 0.5f |   |   |
| targetsHeight |   | true |   |   |
| height |   | float Height |   |   |
| stayLeft |   | bool Stay Left |   |   |
| stayRight |   | bool Stay Right |   |   |

##### 5. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | [Global] GameObject Hero | Variable |   |
| spriteFacesRight |   | true |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "TurnToFly" |   |   |
| resetFrame |   | true |   |   |
| everyFrame |   | true |   |   |

##### 6. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 1.75f |   |   |
| timeMax |   | 2.5f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Fly" |   |   |

##### 8. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Out of Range | Variable |   |
| boolValue |   | bool Shoot Range |   |   |
| everyFrame |   | false |   |   |

##### 9. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Out of Range | Variable |   |
| everyFrame |   | true |   |   |

##### 10. FloatAddV2

Full Name: HutongGames.PlayMaker.Actions.FloatAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Range Out Timer | Variable |   |
| add |   | 1f |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | true |   |   |
| fixedUpdate |   | false |   |   |
| activeBool |   | bool Out of Range | Variable |   |

##### 11. SetFloatValueV2

Full Name: HutongGames.PlayMaker.Actions.SetFloatValueV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Range Out Timer | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | true |   |   |
| activeBool |   | bool Shoot Range |   |   |

##### 12. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Range Out Timer |   |   |
| float2 |   | 8f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(UNALERT) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Shoot Antic | 0 | |

### Shoot Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Shoot Range | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(CANCEL) |   |   |
| everyFrame |   | false |   |   |

##### 2. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| deceleration |   | 0.95f |   |   |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Shoot Antic" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 4. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [ruin_flying_sentry_prepare (AudioClip) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets34.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Shoot | 0 | |
| CANCEL | Alert | 0 | |

### Shoot

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [mantis_heavy_flyer_projectile_throw (AudioClip) (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets34.assets)] |   |   |

##### 2. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | [Global] GameObject Hero | Variable |   |
| spriteFacesRight |   | true |   |   |
| playNewAnimation |   | false |   |   |
| newAnimationClip |   | "" |   |   |
| resetFrame |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. DecelerateV2

Full Name: HutongGames.PlayMaker.Actions.DecelerateV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| deceleration |   | 0.95f |   |   |

##### 4. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Shoot" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Shot Mantis (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\sharedassets34.assets)] |   |   |
| spawnPoint |   | [Mantis Heavy Flyer/Shot Point (D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\level201)] |   |   |
| position |   | Vector3(0, 0, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Shot | Variable |   |

##### 6. GetAngleToTarget2D

Full Name: HutongGames.PlayMaker.Actions.GetAngleToTarget2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Shot Point |   |   |
| target |   | [Global] GameObject Hero |   |   |
| offsetX |   | 0f |   |   |
| offsetY |   | 0f |   |   |
| storeAngle |   | float Angle |   |   |
| everyFrame |   | false |   |   |

##### 7. SetVelocityAsAngle

Full Name: HutongGames.PlayMaker.Actions.SetVelocityAsAngle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Shot |   |   |
| angle |   | float Angle |   |   |
| speed |   | 17f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Recover | 0 | |

### Recover

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DistanceFly

Full Name: HutongGames.PlayMaker.Actions.DistanceFly
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | [Global] GameObject Hero | Variable |   |
| distance |   | 8f |   |   |
| speedMax |   | 5.5f |   |   |
| acceleration |   | 0.65f |   |   |
| targetsHeight |   | true |   |   |
| height |   | 5f |   |   |

##### 2. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | [Global] GameObject Hero | Variable |   |
| spriteFacesRight |   | true |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "TurnToFly" |   |   |
| resetFrame |   | true |   |   |
| everyFrame |   | true |   |   |

##### 3. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | 0.5f |   |   |
| timeMax |   | 0.75f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Fly" |   |   |

##### 5. DistanceFlyV2

Full Name: HutongGames.PlayMaker.Actions.DistanceFlyV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | [Global] GameObject Hero | Variable |   |
| distance |   | float Distance |   |   |
| speedMax |   | 4.5f |   |   |
| acceleration |   | 0.5f |   |   |
| targetsHeight |   | true |   |   |
| height |   | float Height |   |   |
| stayLeft |   | bool Stay Left |   |   |
| stayRight |   | bool Stay Right |   |   |

##### 6. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Out of Range | Variable |   |
| boolValue |   | bool Shoot Range |   |   |
| everyFrame |   | false |   |   |

##### 7. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Out of Range | Variable |   |
| everyFrame |   | true |   |   |

##### 8. FloatAddV2

Full Name: HutongGames.PlayMaker.Actions.FloatAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Range Out Timer | Variable |   |
| add |   | 1f |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | true |   |   |
| fixedUpdate |   | false |   |   |
| activeBool |   | bool Out of Range | Variable |   |

##### 9. SetFloatValueV2

Full Name: HutongGames.PlayMaker.Actions.SetFloatValueV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Range Out Timer | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | true |   |   |
| activeBool |   | bool Shoot Range |   |   |

##### 10. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Range Out Timer |   |   |
| float2 |   | 8f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(UNALERT) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Alert | 0 | |

### Shot Position

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DistanceFly

Full Name: HutongGames.PlayMaker.Actions.DistanceFly
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | [Global] GameObject Hero | Variable |   |
| distance |   | 9.5f |   |   |
| speedMax |   | 5.5f |   |   |
| acceleration |   | 0.65f |   |   |
| targetsHeight |   | true |   |   |
| height |   | 5f |   |   |

##### 2. DistanceFlyV2

Full Name: HutongGames.PlayMaker.Actions.DistanceFlyV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | [Global] GameObject Hero | Variable |   |
| distance |   | float Distance |   |   |
| speedMax |   | 4.5f |   |   |
| acceleration |   | 0.5f |   |   |
| targetsHeight |   | true |   |   |
| height |   | float Height |   |   |
| stayLeft |   | bool Stay Left |   |   |
| stayRight |   | bool Stay Right |   |   |

##### 3. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | [Global] GameObject Hero | Variable |   |
| spriteFacesRight |   | true |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "TurnToFly" |   |   |
| resetFrame |   | true |   |   |
| everyFrame |   | true |   |   |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.75f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Shoot Antic | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UNALERT | Idle | 0 | |

## Events

| Name | Global |
| --- | --- |
| ALERT | true |
| CANCEL | false |
| COLOSSEUM | false |
| FINISHED | false |
| UNALERT | false |

