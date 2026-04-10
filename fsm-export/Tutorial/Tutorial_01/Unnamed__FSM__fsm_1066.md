# FSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | FSM |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets |
| Start State | Initiate |
| FSM PathId | 1066 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attention Span | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Can See Hero | false | Boolean: false |
| In Alert Range | false | Boolean: false |
| Start Alert | false | Boolean: false |
| Startles | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |

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

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 2. IdleBuzz

Full Name: HutongGames.PlayMaker.Actions.IdleBuzz
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| waitMin | 0.75f | 0.75f |  |  |
| waitMax | 1f | 1f |  |  |
| speedMax | 1.75f | 1.75f |  |  |
| accelerationMax | 15f | 15f |  |  |
| roamingRange | 1f | 1f |  |  |

##### 3. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | "TurnToIdle" | "TurnToIdle" |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | true | true |  |  |
| pauseTime | 0.5f | 0.5f |  |  |

##### 4. CheckCanSeeHero

Full Name: CheckCanSeeHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | bool Can See Hero | bool Can See Hero | Variable |  |
| everyFrame | true | true |  |  |

##### 5. CheckAlertRange

Full Name: CheckAlertRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| alertRange | object Alert Range | object Alert Range | Variable |  |
| storeResult | bool In Alert Range | bool In Alert Range | Variable |  |
| everyFrame | true | true |  |  |

##### 6. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(ALERT) | Event(ALERT) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | true | true |  |  |

### Startle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1.2f | 1.2f |  |  |
| pitchMax | 1.4f | 1.4f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Startle" | "Startle" |  |  |

##### 4. FaceObject

Full Name: HutongGames.PlayMaker.Actions.FaceObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectA | GameObject Self | GameObject Self |  |  |
| objectB | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | false | false |  |  |
| newAnimationClip | "" | "" |  |  |
| resetFrame | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(ANIM END) | Event(ANIM END) |  |  |

### Startles?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Startles | bool Startles | Variable |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |
| everyFrame | false | false |  |  |

### Chase - In Sight

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | "TurnToFly" | "TurnToFly" |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | true | true |  |  |
| pauseTime | 0.5f | 0.5f |  |  |

##### 2. ChaseObject

Full Name: HutongGames.PlayMaker.Actions.ChaseObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self | Variable |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| speedMax | 5f | 5f |  |  |
| acceleration | 0.045f | 0.045f |  |  |
| targetSpread | 0f | 0f |  |  |
| spreadResetTimeMin | 0f | 0f |  |  |
| spreadResetTimeMax | 0f | 0f |  |  |

##### 3. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(WAIT) | Event(WAIT) |  |  |

### Initiate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. FindAlertRange

Full Name: FindAlertRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner | Variable |  |
| storeResult | object Alert Range | object Alert Range | Variable |  |
| childName | Alert Range New | Alert Range New |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Start Alert | bool Start Alert | Variable |  |
| isTrue | Event(ALERT) | Event(ALERT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Chase - Out of Sight

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. ChaseObject

Full Name: HutongGames.PlayMaker.Actions.ChaseObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self | Variable |  |
| target | [Global] GameObject Hero | [Global] GameObject Hero | Variable |  |
| speedMax | 5f | 5f |  |  |
| acceleration | 0.045f | 0.045f |  |  |
| targetSpread | 0f | 0f |  |  |
| spreadResetTimeMin | 0f | 0f |  |  |
| spreadResetTimeMax | 0f | 0f |  |  |

##### 2. FaceDirection

Full Name: HutongGames.PlayMaker.Actions.FaceDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| spriteFacesRight | false | false |  |  |
| playNewAnimation | true | true |  |  |
| newAnimationClip | "TurnToFly" | "TurnToFly" |  |  |
| everyFrame | true | true |  |  |
| pauseBetweenTurns | true | true |  |  |
| pauseTime | 0.5f | 0.5f |  |  |

##### 3. CheckCanSeeHero

Full Name: CheckCanSeeHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | bool Can See Hero | bool Can See Hero | Variable |  |
| everyFrame | true | true |  |  |

##### 4. CheckAlertRange

Full Name: CheckAlertRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| alertRange | object Alert Range | object Alert Range | Variable |  |
| storeResult | bool In Alert Range | bool In Alert Range | Variable |  |
| everyFrame | true | true |  |  |

##### 5. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(ALERT) | Event(ALERT) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | true | true |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Attention Span | float Attention Span |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### Stop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| pitch | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 3. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| frame | 3 | 3 |  |  |

##### 4. Decelerate

Full Name: HutongGames.PlayMaker.Actions.Decelerate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| deceleration | 0.12f | 0.12f |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### Chase Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| pitch | 1.25f | 1.25f |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Chase" | "Chase" |  |  |

##### 3. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| frame | 3 | 3 |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0f | 0f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | ALERT | Startles? | 0 | 0 | 0 |
| Idle | TOOK DAMAGE | Startles? | 0 | 0 | 0 |
| Startle | ANIM END | Chase Start | 0 | 0 | 0 |
| Startles? | TRUE | Startle | 0 | 0 | 0 |
| Startles? | FALSE | Chase Start | 0 | 0 | 0 |
| Chase - In Sight | WAIT | Chase - Out of Sight | 0 | 0 | 0 |
| Initiate | FINISHED | Idle | 0 | 0 | 0 |
| Initiate | ALERT | Chase Start | 0 | 0 | 0 |
| Chase - Out of Sight | ALERT | Chase - In Sight | 0 | 0 | 0 |
| Chase - Out of Sight | WAIT | Stop | 0 | 0 | 0 |
| Stop | WAIT | Idle | 0 | 0 | 0 |
| Chase Start | WAIT | Chase - In Sight | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ALERT | true |
| ANIM END | false |
| FALSE | false |
| HERO IS LEFT | false |
| HERO IS RIGHT | false |
| TOOK DAMAGE | false |
| TRUE | false |
| WAIT | true |

