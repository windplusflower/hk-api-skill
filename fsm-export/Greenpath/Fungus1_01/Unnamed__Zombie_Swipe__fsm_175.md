# Zombie Swipe

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Zombie Swipe |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets128.assets |
| Start State | Initialise |
| FSM PathId | 175 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Chooser | 0 | Single: 0 |
| Hero X | 0 | Single: 0 |
| Idle Time | 0 | Single: 0 |
| Lunge Speed | 0 | Single: 0 |
| Lunge Speed Adjust | 0 | Single: 0 |
| Self X | 0 | Single: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Can See Hero | false | Boolean: false |
| In Attack Range | false | Boolean: false |
| Reverse | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Region | [null] | NamedAssetPPtr:  |
| Hero | [null] | NamedAssetPPtr:  |
| Pt Roll | Mossman_Runner/Pt Roll (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets128.assets) | NamedAssetPPtr: Mossman_Runner/Pt Roll (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets128.assets) |
| Self | [null] | NamedAssetPPtr:  |

## States

### Initialise

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetHero

Full Name: GetHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | GameObject Hero | GameObject Hero | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Attack Range" | "Attack Range" |  |  |
| storeResult | GameObject Attack Region | GameObject Attack Region | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pt Roll" | "Pt Roll" |  |  |
| storeResult | [Mossman_Runner/Pt Roll (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets128.assets)] | [Mossman_Runner/Pt Roll (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets128.assets)] | Variable |  |

##### 4. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

### Ready

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CheckCanSeeHero

Full Name: CheckCanSeeHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | bool Can See Hero | bool Can See Hero | Variable |  |
| everyFrame | true | true |  |  |

##### 2. CheckAlertRangeByName

Full Name: CheckAlertRangeByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | bool In Attack Range | bool In Attack Range | Variable |  |
| childName | Attack Range | Attack Range |  |  |
| everyFrame | true | true |  |  |

##### 3. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(ATTACK ALERT) | Event(ATTACK ALERT) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | true | true |  |  |

### Anticipate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RandomFloat

Full Name: HutongGames.PlayMaker.Actions.RandomFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| min | 0.9f | 0.9f |  |  |
| max | 1.1f | 1.1f |  |  |
| storeResult | float Chooser | float Chooser | Variable |  |

##### 2. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| pitch | float Chooser | float Chooser |  |  |
| everyFrame | false | false |  |  |

##### 3. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1.1f | 1.1f |  |  |
| pitchMax | 1.2f | 1.2f |  |  |

##### 4. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Attack Anticipate" | "Attack Anticipate" |  |  |

##### 6. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(WAIT) | Event(WAIT) |  |  |

### Left or Right?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. StopWalker

Full Name: StopWalker
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFloatValue

Full Name: HutongGames.PlayMaker.Actions.SetFloatValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Lunge Speed Adjust | float Lunge Speed Adjust | Variable |  |
| floatValue | float Lunge Speed | float Lunge Speed |  |  |
| everyFrame | false | false |  |  |

##### 3. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Self X | float Self X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 4. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | float Self X | float Self X |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(HERO IS LEFT) | Event(HERO IS LEFT) |  |  |
| lessThan | Event(HERO IS LEFT) | Event(HERO IS LEFT) |  |  |
| greaterThan | Event(HERO IS RIGHT) | Event(HERO IS RIGHT) |  |  |
| everyFrame | false | false |  |  |

### Face Left

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Lunge Speed Adjust | float Lunge Speed Adjust | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. SetWalkerFacing

Full Name: SetWalkerFacing
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| walkRight | false | false |  |  |
| randomStartDir | false | false |  |  |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| everyFrame | false | false |  |  |

### Face Right

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -1f | -1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SetWalkerFacing

Full Name: SetWalkerFacing
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| walkRight | true | true |  |  |
| randomStartDir | false | false |  |  |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| everyFrame | false | false |  |  |

### Lunge

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Attack Lunge" | "Attack Lunge" |  |  |

##### 2. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(WAIT) | Event(WAIT) |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | float Lunge Speed Adjust | float Lunge Speed Adjust |  |  |
| y | 0f | 0f |  |  |
| everyFrame | true | true |  |  |

##### 4. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |

##### 5. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pt Roll | OwnerDefault Pt Roll |  |  |
| emit | 0 | 0 |  |  |

### Cooldown

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Attack Cooldown" | "Attack Cooldown" |  |  |

##### 2. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(WAIT) | Event(WAIT) |  |  |

##### 3. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Idle Time | float Idle Time |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 2. StartWalker

Full Name: StartWalker
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| walkRight | false | false |  |  |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| everyFrame | false | false |  |  |

### R?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Reverse | bool Reverse | Variable |  |
| isTrue | Event(REVERSE) | Event(REVERSE) |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

### R? 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Reverse | bool Reverse | Variable |  |
| isTrue | Event(REVERSE) | Event(REVERSE) |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

### Reverse

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Reverse | bool Reverse | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. FlipScale

Full Name: HutongGames.PlayMaker.Actions.FlipScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| flipHorizontally | true | true |  |  |
| flipVertically | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Reverse Back

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Reverse | bool Reverse | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. FlipScale

Full Name: HutongGames.PlayMaker.Actions.FlipScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| flipHorizontally | true | true |  |  |
| flipVertically | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Initialise | FINISHED | Ready | 0 | 0 | 0 |
| Ready | ATTACK ALERT | Left or Right? | 0 | 0 | 0 |
| Anticipate | WAIT | Reverse Back | 0 | 0 | 0 |
| Left or Right? | HERO IS RIGHT | R? 2 | 0 | 0 | 0 |
| Left or Right? | HERO IS LEFT | R? | 0 | 0 | 0 |
| Face Left | FINISHED | Reverse | 0 | 0 | 0 |
| Face Right | FINISHED | Reverse | 0 | 0 | 0 |
| Lunge | WAIT | Cooldown | 0 | 0 | 0 |
| Cooldown | WAIT | Idle | 0 | 0 | 0 |
| Idle | WAIT | Reset | 0 | 0 | 0 |
| Reset | FINISHED | Ready | 0 | 0 | 0 |
| R? | FINISHED | Face Left | 0 | 0 | 0 |
| R? | REVERSE | Face Right | 0 | 0 | 0 |
| R? 2 | FINISHED | Face Right | 0 | 0 | 0 |
| R? 2 | REVERSE | Face Left | 0 | 0 | 0 |
| Reverse | FINISHED | Anticipate | 0 | 0 | 0 |
| Reverse Back | FINISHED | Lunge | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| RECOIL HORIZONTAL | Reset | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ATTACK ALERT | true |
| HERO IS LEFT | false |
| HERO IS RIGHT | false |
| MOVESTOP | true |
| RECOIL HORIZONTAL | true |
| REVERSE | false |
| WAIT | true |

