# Attack

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Attack |
| GameObject Name | Enemy Damager |
| GameObject Path | Weaverling |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 24765 |
| GameObject PathId | 7429 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Damage | 3 | Int32: 3 |
| Enemy HP | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Invincible | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Tag |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Enemy | [null] | NamedAssetPPtr:  |
| Enemy Grandparent | [null] | NamedAssetPPtr:  |
| Enemy Parent | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |
| Self | Weaverling (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: Weaverling (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 0.5f | 0.5f |  |  |
| timeMax | 1f | 1f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerStay2D | 1 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "Enemies" | "Enemies" | Layer |  |
| sendEvent | ATTACK | ATTACK |  |  |
| storeCollider | GameObject Enemy | GameObject Enemy | Variable |  |

### Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy | OwnerDefault Enemy |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | flashFocusHeal(???) | flashFocusHeal(???) |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Weaverling (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Weaverling (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| audioClip | [enemy_damage_over_time (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [enemy_damage_over_time (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Enemy | EventTarget(GameObject):Enemy |  |  |
| sendEvent | "TOOK DAMAGE" | "TOOK DAMAGE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy | OwnerDefault Enemy | Variable |  |
| storeValue | int Enemy HP | int Enemy HP | Variable |  |

##### 5. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Enemy HP | int Enemy HP |  |  |
| integer2 | int Damage | int Damage |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Enemy HP | int Enemy HP | Variable |  |
| everyFrame | false | false |  |  |

##### 6. SetHP

Full Name: SetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy | OwnerDefault Enemy | Variable |  |
| hp | int Enemy HP | int Enemy HP |  |  |

##### 7. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Enemy HP | int Enemy HP |  |  |
| integer2 | 0 | 0 |  |  |
| equal |  |  |  |  |
| lessThan |  |  |  |  |
| greaterThan | FINISHED | FINISHED |  |  |
| everyFrame | false | false |  |  |

##### 8. InstaDeath

Full Name: InstaDeath
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy | OwnerDefault Enemy | Variable |  |
| direction | 0f | 0f |  |  |

##### 9. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [weaverling_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [weaverling_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0f | 0f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [] | [] |  |  |

### Invincible?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetTag

Full Name: HutongGames.PlayMaker.Actions.GetTag
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Enemy | GameObject Enemy |  |  |
| storeResult | string Tag | string Tag | Variable |  |
| everyFrame | false | false |  |  |

##### 2. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tag | string Tag | Variable |  |
| compareTo | "Spell Vulnerable" | "Spell Vulnerable" |  |  |
| equalEvent | FINISHED | FINISHED |  |  |
| notEqualEvent |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. CheckInvincibility

Full Name: CheckInvincibility
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy | OwnerDefault Enemy | Variable |  |
| storeValue | bool Invincible | bool Invincible |  |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Invincible | bool Invincible | Variable |  |
| isTrue | INVINCIBLE | INVINCIBLE |  |  |
| isFalse |  |  |  |  |
| everyFrame | false | false |  |  |

### Parent?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy | OwnerDefault Enemy |  |  |
| storeResult | GameObject Enemy Parent | GameObject Enemy Parent | Variable |  |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Enemy Parent | GameObject Enemy Parent | Variable |  |
| isNull | FINISHED | FINISHED |  |  |
| isNotNull |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Parent | OwnerDefault Enemy Parent |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | flashFocusHeal(???) | flashFocusHeal(???) |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Enemy Parent | EventTarget(GameObject):Enemy Parent |  |  |
| sendEvent | "TOOK DAMAGE" | "TOOK DAMAGE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy Parent | OwnerDefault Enemy Parent | Variable |  |
| storeValue | int Enemy HP | int Enemy HP | Variable |  |

##### 6. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Enemy HP | int Enemy HP |  |  |
| integer2 | int Damage | int Damage |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Enemy HP | int Enemy HP | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetHP

Full Name: SetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy Parent | OwnerDefault Enemy Parent | Variable |  |
| hp | int Enemy HP | int Enemy HP |  |  |

##### 8. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Enemy HP | int Enemy HP |  |  |
| integer2 | 0 | 0 |  |  |
| equal |  |  |  |  |
| lessThan |  |  |  |  |
| greaterThan | FINISHED | FINISHED |  |  |
| everyFrame | false | false |  |  |

##### 9. InstaDeath

Full Name: InstaDeath
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy Parent | OwnerDefault Enemy Parent | Variable |  |
| direction | 0f | 0f |  |  |

### G Parent?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Parent | OwnerDefault Enemy Parent |  |  |
| storeResult | GameObject Enemy Grandparent | GameObject Enemy Grandparent | Variable |  |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Enemy Grandparent | GameObject Enemy Grandparent | Variable |  |
| isNull | FINISHED | FINISHED |  |  |
| isNotNull |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Grandparent | OwnerDefault Enemy Grandparent |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | flashFocusHeal(???) | flashFocusHeal(???) |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Enemy Grandparent | EventTarget(GameObject):Enemy Grandparent |  |  |
| sendEvent | "TOOK DAMAGE" | "TOOK DAMAGE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy Grandparent | OwnerDefault Enemy Grandparent | Variable |  |
| storeValue | int Enemy HP | int Enemy HP | Variable |  |

##### 6. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Enemy HP | int Enemy HP |  |  |
| integer2 | int Damage | int Damage |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Enemy HP | int Enemy HP | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SetHP

Full Name: SetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy Grandparent | OwnerDefault Enemy Grandparent | Variable |  |
| hp | int Enemy HP | int Enemy HP |  |  |

##### 8. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Enemy HP | int Enemy HP |  |  |
| integer2 | 0 | 0 |  |  |
| equal |  |  |  |  |
| lessThan |  |  |  |  |
| greaterThan | FINISHED | FINISHED |  |  |
| everyFrame | false | false |  |  |

##### 9. InstaDeath

Full Name: InstaDeath
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy Grandparent | OwnerDefault Enemy Grandparent | Variable |  |
| direction | 0f | 0f |  |  |

### Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| active | false | false |  |  |

##### 3. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Attack" | "Attack" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Parent | EventTarget(GameObject):Parent |  |  |
| sendEvent | "ATTACK" | "ATTACK" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. AudioPlayRandom

Full Name: HutongGames.PlayMaker.Actions.AudioPlayRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Parent | GameObject Parent |  |  |
| audioClips | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |

### Anim Complete

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| active | true | true |  |  |

### Disappear

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| active | true | true |  |  |

### Grubsong

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_3" | "equippedCharm_3" |  |  |
| isTrue |  |  |  |  |
| isFalse | FINISHED | FINISHED |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "AddMPCharge" | "AddMPCharge" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Wait | 0 | 0 | 0 |
| Wait | FINISHED | Detect | 0 | 0 | 0 |
| Detect | ATTACK | Invincible? | 0 | 0 | 0 |
| Hit | FINISHED | Parent? | 0 | 0 | 0 |
| Invincible? | INVINCIBLE | Anim | 0 | 0 | 0 |
| Invincible? | FINISHED | Grubsong | 0 | 0 | 0 |
| Parent? | FINISHED | G Parent? | 0 | 0 | 0 |
| G Parent? | FINISHED | Anim | 0 | 0 | 0 |
| Anim | FINISHED | Anim Complete | 0 | 0 | 0 |
| Anim Complete | FINISHED | Wait | 0 | 0 | 0 |
| Grubsong | FINISHED | Hit | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| DISAPPEAR | Disappear | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ATTACK | false |
| INVINCIBLE | false |
| DISAPPEAR | false |

