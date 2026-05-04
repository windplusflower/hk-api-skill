# Crystal Flyer

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Crystal Flyer |
| GameObject Name | Crystal Flyer |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level254 |
| Start State | Init |
| FSM PathId | 2079 |
| GameObject PathId | 282 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Angle | 0 | Single: 0 |
| Angle Max | 330 | Single: 330 |
| Angle Min | 210 | Single: 210 |
| Unalert Timer | 0 | Single: 0 |
| Wait Max | 2.5 | Single: 2.5 |
| Wait Min | 1.5 | Single: 1.5 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alert Range | false | Boolean: false |
| First Attack | false | Boolean: false |
| Not In Range | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |
| Shot | [null] | NamedAssetPPtr: [null] |

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

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Wait Min | Variable |   |
| floatValue |   | 1f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Wait Max | Variable |   |
| floatValue |   | 1.5f |   |   |
| everyFrame |   | false |   |   |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool First Attack | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

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
| clipName |   | "Fly" |   |   |

##### 2. IdleBuzz

Full Name: HutongGames.PlayMaker.Actions.IdleBuzz
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| waitMin |   | 0.75f |   |   |
| waitMax |   | 1f |   |   |
| speedMax |   | 1.75f |   |   |
| accelerationMax |   | 15f |   |   |
| roamingRange |   | 1f |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Alert Range | Variable |   |
| isTrue |   | Event(ALERT) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | true |   |   |

##### 4. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| spriteFacesRight |   | false |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "Turn To Fly" |   |   |
| everyFrame |   | true |   |   |
| pauseBetweenTurns |   | true |   |   |
| pauseTime |   | 0.5f |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ALERT | Alert | 0 | |

### Alert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. DistanceFly

Full Name: HutongGames.PlayMaker.Actions.DistanceFly
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | [Global] GameObject Hero | Variable |   |
| distance |   | 5.5f |   |   |
| speedMax |   | 5f |   |   |
| acceleration |   | 0.045f |   |   |
| targetsHeight |   | true |   |   |
| height |   | 5.5f |   |   |

##### 2. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA |   | GameObject Self |   |   |
| objectB |   | [Global] GameObject Hero | Variable |   |
| spriteFacesRight |   | false |   |   |
| playNewAnimation |   | true |   |   |
| newAnimationClip |   | "Turn To Fly" |   |   |
| resetFrame |   | false |   |   |
| everyFrame |   | true |   |   |

##### 3. DistanceFly

Full Name: HutongGames.PlayMaker.Actions.DistanceFly
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | [Global] GameObject Hero | Variable |   |
| distance |   | 6f |   |   |
| speedMax |   | 3.5f |   |   |
| acceleration |   | 0.1f |   |   |
| targetsHeight |   | true |   |   |
| height |   | 5.5f |   |   |

##### 4. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin |   | float Wait Min |   |   |
| timeMax |   | float Wait Max |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 5. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Fly" |   |   |

##### 6. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Not In Range | Variable |   |
| boolValue |   | bool Alert Range |   |   |
| everyFrame |   | true |   |   |

##### 7. BoolFlipEveryFrame

Full Name: HutongGames.PlayMaker.Actions.BoolFlipEveryFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Not In Range | Variable |   |
| everyFrame |   | true |   |   |

##### 8. FloatAddV2

Full Name: HutongGames.PlayMaker.Actions.FloatAddV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Unalert Timer | Variable |   |
| add |   | 1f |   |   |
| everyFrame |   | true |   |   |
| perSecond |   | true |   |   |
| fixedUpdate |   | false |   |   |
| activeBool |   | bool Not In Range | Variable |   |

##### 9. SetFloatValueV2

Full Name: HutongGames.PlayMaker.Actions.SetFloatValueV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Unalert Timer | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | true |   |   |
| activeBool |   | bool Alert Range |   |   |

##### 10. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 |   | float Unalert Timer |   |   |
| float2 |   | 8f |   |   |
| tolerance |   | 0f |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(UNALERT) |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Angle Check | 0 | |
| UNALERT | Idle | 0 | |

### Antic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Attack" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 2. DistanceFly

Full Name: HutongGames.PlayMaker.Actions.DistanceFly
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner | Variable |   |
| target |   | [Global] GameObject Hero | Variable |   |
| distance |   | 6f |   |   |
| speedMax |   | 3.5f |   |   |
| acceleration |   | 0.05f |   |   |
| targetsHeight |   | true |   |   |
| height |   | 5.2f |   |   |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool First Attack | Variable |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Wait Min | Variable |   |
| floatValue |   | 1.5f |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Wait Max | Variable |   |
| floatValue |   | 2.5f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fire | 0 | |

### Fire

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
| oneShotClip |   | [crystal_flyer_shoot (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets251.assets)] |   |   |

##### 2. GetAngleToTarget2D

Full Name: HutongGames.PlayMaker.Actions.GetAngleToTarget2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | [Global] GameObject Hero |   |   |
| offsetX |   | 0f |   |   |
| offsetY |   | 0f |   |   |
| storeAngle |   | float Angle |   |   |
| everyFrame |   | false |   |   |

##### 3. FloatClamp

Full Name: HutongGames.PlayMaker.Actions.FloatClamp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle | Variable |   |
| minValue |   | float Angle Min |   |   |
| maxValue |   | float Angle Max |   |   |
| everyFrame |   | false |   |   |

##### 4. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | [Global] [Crystal Shot (Hollow Knight/hollow_knight_Data\sharedassets251.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| position |   | Vector3(0, -0.5, 0) |   |   |
| rotation |   | Vector3(0, 0, 0) |   |   |
| storeObject |   | GameObject Shot | Variable |   |

##### 5. FireAtTarget

Full Name: HutongGames.PlayMaker.Actions.FireAtTarget
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Shot |   |   |
| target |   | [Global] GameObject Hero |   |   |
| speed |   | 20f |   |   |
| position |   | Vector3(0, -0.5, 0) |   |   |
| spread |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "Attack Recover" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 7. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool First Attack | Variable |   |
| boolValue |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Alert | 0 | |

### Angle Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetAngleToTarget2D

Full Name: HutongGames.PlayMaker.Actions.GetAngleToTarget2D
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | [Global] GameObject Hero |   |   |
| offsetX |   | 0f |   |   |
| offsetY |   | 0f |   |   |
| storeAngle |   | float Angle |   |   |
| everyFrame |   | false |   |   |

##### 2. FloatInRange

Full Name: HutongGames.PlayMaker.Actions.FloatInRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Angle |   |   |
| lowerValue |   | float Angle Min |   |   |
| upperValue |   | float Angle Max |   |   |
| boolVariable |   | false | Variable |   |
| trueEvent |   | Event(ATTACK) |   |   |
| falseEvent |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Wait Min | Variable |   |
| floatValue |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Wait Min | Variable |   |
| floatValue |   | 0.5f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Alert | 0 | |
| ATTACK | Antic | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ALERT | true |
| ATTACK | false |
| CANCEL | false |
| FINISHED | false |
| UNALERT | false |

