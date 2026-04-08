# Shield Hit

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Shield Hit |
| GameObject Name | Shield |
| GameObject Path | Orbit Shield |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 24442 |
| GameObject PathId | 7924 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Collider Layer | 0 | Int32: 0 |
| Damage | 10 | Int32: 10 |
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
| Collider | [null] | NamedAssetPPtr:  |
| Collider Parent | [null] | NamedAssetPPtr:  |
| Enemy | [null] | NamedAssetPPtr:  |
| Enemy Grandparent | [null] | NamedAssetPPtr:  |
| Enemy Parent | [null] | NamedAssetPPtr:  |
| Idle Pt | [null] | NamedAssetPPtr:  |
| Laser Stopper | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Laser Stopper" | "Laser Stopper" |  |  |
| storeResult | GameObject Laser Stopper | GameObject Laser Stopper | Variable |  |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "nailDamage" | "nailDamage" |  |  |
| storeValue | int Damage | int Damage | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Idle Pt" | "Idle Pt" |  |  |
| storeResult | GameObject Idle Pt | GameObject Idle Pt | Variable |  |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Form" | "Form" |  |  |

##### 7. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| pitch | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 8. SetAudioVolume

Full Name: HutongGames.PlayMaker.Actions.SetAudioVolume
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 9. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 10. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Laser Stopper | OwnerDefault Laser Stopper |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | ENTER | ENTER |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

### Send Event

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Collider | EventTarget(GameObject):Collider |  |  |
| sendEvent | "ORBIT SHIELD" | "ORBIT SHIELD" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. DestroyEnemyBullet

Full Name: DestroyEnemyBullet
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Collider | OwnerDefault Collider |  |  |

##### 3. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Collider | OwnerDefault Collider |  |  |
| storeResult | GameObject Collider Parent | GameObject Collider Parent | Variable |  |

##### 4. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider Parent | GameObject Collider Parent | Variable |  |
| isNull | FINISHED | FINISHED |  |  |
| isNotNull |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Collider Parent | EventTarget(GameObject):Collider Parent |  |  |
| sendEvent | "ORBIT SHIELD" | "ORBIT SHIELD" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. DestroyEnemyBullet

Full Name: DestroyEnemyBullet
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Collider Parent | OwnerDefault Collider Parent |  |  |

### Block Effect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "BLOCK EFFECT" | "BLOCK EFFECT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0f | 0f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [SmallImpact (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [SmallImpact (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

### Type

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. GetTag

Full Name: HutongGames.PlayMaker.Actions.GetTag
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| storeResult | string Tag | string Tag | Variable |  |
| everyFrame | false | false |  |  |

##### 2. GetLayer

Full Name: HutongGames.PlayMaker.Actions.GetLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| storeResult | int Collider Layer | int Collider Layer | Variable |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Collider Layer | int Collider Layer |  |  |
| integer2 | 11 | 11 |  |  |
| equal | ENEMY | ENEMY |  |  |
| lessThan |  |  |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Collider Layer | int Collider Layer |  |  |
| integer2 | 17 | 17 |  |  |
| equal | NO EFFECT | NO EFFECT |  |  |
| lessThan |  |  |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 5. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tag | string Tag | Variable |  |
| compareTo | "Nail Attack" | "Nail Attack" |  |  |
| equalEvent | HERO ATTACK | HERO ATTACK |  |  |
| notEqualEvent |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 6. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tag | string Tag | Variable |  |
| compareTo | "Hero Spell" | "Hero Spell" |  |  |
| equalEvent | HERO ATTACK | HERO ATTACK |  |  |
| notEqualEvent |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 7. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | PROJECTILE | PROJECTILE |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [dream_damage (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [dream_damage (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. PlayVibration

Full Name: PlayVibration
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| lowFidelityVibration | Enum(LowFidelityVibrations, 0) | Enum(LowFidelityVibrations, 0) |  |  |
| highFidelityVibration | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [low_hit_nail_impact (TextAsset) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| motors | Enum(VibrationMotors, 3) | Enum(VibrationMotors, 3) |  |  |
| loopTime | 0f | 0f |  |  |
| isLooping | false | false |  |  |
| tag | "" | "" |  |  |
| gamepadVibration | [SmallImpact (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [SmallImpact (Script GamepadVibration) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy | OwnerDefault Enemy |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | flashFocusHeal(???) | flashFocusHeal(???) |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Enemy | EventTarget(GameObject):Enemy |  |  |
| sendEvent | "TOOK DAMAGE" | "TOOK DAMAGE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. GetHP

Full Name: GetHP
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy | OwnerDefault Enemy | Variable |  |
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
| target | OwnerDefault Enemy | OwnerDefault Enemy | Variable |  |
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
| target | OwnerDefault Enemy | OwnerDefault Enemy | Variable |  |
| direction | 0f | 0f |  |  |

### Invincible?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoxCollider2DSize

Full Name: HutongGames.PlayMaker.Actions.SetBoxCollider2DSize
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| width | 0.8f | 0.8f |  |  |
| height | 2.7f | 2.7f |  |  |
| offsetX | -0.07f | -0.07f |  |  |
| offsetY | 0f | 0f |  |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Enemy | GameObject Enemy | Variable |  |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| everyFrame | false | false |  |  |

##### 3. GetTag

Full Name: HutongGames.PlayMaker.Actions.GetTag
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Enemy | GameObject Enemy |  |  |
| storeResult | string Tag | string Tag | Variable |  |
| everyFrame | false | false |  |  |

##### 4. StringCompare

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

##### 5. CheckInvincibility

Full Name: CheckInvincibility
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy | OwnerDefault Enemy | Variable |  |
| storeValue | bool Invincible | bool Invincible |  |  |

##### 6. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Invincible | bool Invincible | Variable |  |
| isTrue | INVINCIBLE | INVINCIBLE |  |  |
| isFalse |  |  |  |  |
| everyFrame | false | false |  |  |

##### 7. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy | OwnerDefault Enemy |  |  |
| storeResult | GameObject Enemy Parent | GameObject Enemy Parent | Variable |  |

##### 8. CheckInvincibility

Full Name: CheckInvincibility
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Enemy Parent | OwnerDefault Enemy Parent | Variable |  |
| storeValue | bool Invincible | bool Invincible |  |  |

##### 9. BoolTest

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

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Enemy Parent | EventTarget(GameObject):Enemy Parent |  |  |
| sendEvent | "TOOK DAMAGE" | "TOOK DAMAGE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Parent | OwnerDefault Enemy Parent |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | flashFocusHeal(???) | flashFocusHeal(???) |  |  |

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

### Break

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Laser Stopper | OwnerDefault Laser Stopper |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Enemy Hit" | "Enemy Hit" |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | END | END |  |  |
| realTime | false | false |  |  |

##### 5. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| pitch | 0.75f | 0.75f |  |  |
| everyFrame | false | false |  |  |

##### 6. SetAudioVolume

Full Name: HutongGames.PlayMaker.Actions.SetAudioVolume
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 0.75f | 0.75f |  |  |
| everyFrame | false | false |  |  |

### Reform

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Reform" | "Reform" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. SetAudioPitch

Full Name: HutongGames.PlayMaker.Actions.SetAudioPitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| pitch | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetAudioVolume

Full Name: HutongGames.PlayMaker.Actions.SetAudioVolume
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [soul_pickup_1 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [soul_pickup_1 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Reset

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Laser Stopper | OwnerDefault Laser Stopper |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

### Disappear

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Disappear" | "Disappear" |  |  |

##### 2. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Pt | OwnerDefault Idle Pt |  |  |

##### 3. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Pt | OwnerDefault Idle Pt |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Disappear" | "Disappear" |  |  |

##### 3. SetBoxCollider2DSize

Full Name: HutongGames.PlayMaker.Actions.SetBoxCollider2DSize
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| width | 0.8f | 0.8f |  |  |
| height | 2.7f | 2.7f |  |  |
| offsetX | -0.07f | -0.07f |  |  |
| offsetY | 0f | 0f |  |  |

### Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle Pt | OwnerDefault Idle Pt |  |  |
| emit | 0 | 0 |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Form" | "Form" |  |  |

### Pulsing

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "Pulse" | "Pulse" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. SetBoxCollider2DSize

Full Name: HutongGames.PlayMaker.Actions.SetBoxCollider2DSize
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| width | 1.9f | 1.9f |  |  |
| height | 2.7f | 2.7f |  |  |
| offsetX | -0.63f | -0.63f |  |  |
| offsetY | 0f | 0f |  |  |

##### 3. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | ENTER | ENTER |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

##### 4. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

### Type 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetTag

Full Name: HutongGames.PlayMaker.Actions.GetTag
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| storeResult | string Tag | string Tag | Variable |  |
| everyFrame | false | false |  |  |

##### 2. GetLayer

Full Name: HutongGames.PlayMaker.Actions.GetLayer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider | GameObject Collider |  |  |
| storeResult | int Collider Layer | int Collider Layer | Variable |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Collider Layer | int Collider Layer |  |  |
| integer2 | 11 | 11 |  |  |
| equal | ENEMY | ENEMY |  |  |
| lessThan |  |  |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 4. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tag | string Tag | Variable |  |
| compareTo | "Nail Attack" | "Nail Attack" |  |  |
| equalEvent | HERO ATTACK | HERO ATTACK |  |  |
| notEqualEvent |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 5. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Tag | string Tag | Variable |  |
| compareTo | "Hero Spell" | "Hero Spell" |  |  |
| equalEvent | HERO ATTACK | HERO ATTACK |  |  |
| notEqualEvent |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 6. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | PROJECTILE | PROJECTILE |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Slash End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 2. SetBoxCollider2DSize

Full Name: HutongGames.PlayMaker.Actions.SetBoxCollider2DSize
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| width | 0.8f | 0.8f |  |  |
| height | 2.7f | 2.7f |  |  |
| offsetX | -0.07f | -0.07f |  |  |
| offsetY | 0f | 0f |  |  |

### Slash Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Pulse" | "Pulse" |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [dreamshield_attack (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [dreamshield_attack (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 0.8f | 0.8f |  |  |
| pitchMax | 1.2f | 1.2f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Pulse Block

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Collider | EventTarget(GameObject):Collider |  |  |
| sendEvent | "ORBIT SHIELD" | "ORBIT SHIELD" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Collider | OwnerDefault Collider |  |  |
| storeResult | GameObject Collider Parent | GameObject Collider Parent | Variable |  |

##### 4. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Collider Parent | GameObject Collider Parent | Variable |  |
| isNull | FINISHED | FINISHED |  |  |
| isNotNull |  |  |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Collider Parent | EventTarget(GameObject):Collider Parent |  |  |
| sendEvent | "ORBIT SHIELD" | "ORBIT SHIELD" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Dreamwielder?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -1f | -1f |  |  |
| y | 1f | 1f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Laser Stopper | OwnerDefault Laser Stopper |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 1f | 1f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_30" | "equippedCharm_30" |  |  |
| isTrue |  |  |  |  |
| isFalse | FINISHED | FINISHED |  |  |

##### 4. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -1.15f | -1.15f |  |  |
| y | 1.15f | 1.15f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Laser Stopper | OwnerDefault Laser Stopper |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1.15f | 1.15f |  |  |
| y | 1.15f | 1.15f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Tink

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [sword_hit_reject (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [sword_hit_reject (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Collider | EventTarget(GameObject):Collider |  |  |
| sendEvent | "ORBIT SHIELD B" | "ORBIT SHIELD B" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Dreamwielder? | 0 | 0 | 0 |
| Idle | ENTER | Type | 0 | 0 | 0 |
| Idle | SLASH | Slash Anim | 0 | 0 | 0 |
| Send Event | FINISHED | Idle | 0 | 0 | 0 |
| Block Effect | FINISHED | Send Event | 0 | 0 | 0 |
| Type | HERO ATTACK | Idle | 0 | 0 | 0 |
| Type | ENEMY | Invincible? | 0 | 0 | 0 |
| Type | PROJECTILE | Block Effect | 0 | 0 | 0 |
| Type | NO EFFECT | Send Event | 0 | 0 | 0 |
| Hit | FINISHED | Parent? | 0 | 0 | 0 |
| Invincible? | INVINCIBLE | Tink | 0 | 0 | 0 |
| Invincible? | FINISHED | Hit | 0 | 0 | 0 |
| Parent? | FINISHED | G Parent? | 0 | 0 | 0 |
| G Parent? | FINISHED | Break | 0 | 0 | 0 |
| Break | END | Reform | 0 | 0 | 0 |
| Reform | FINISHED | Reset | 0 | 0 | 0 |
| Reset | FINISHED | Idle | 0 | 0 | 0 |
| Down | ORBIT SHIELD UP | Up | 0 | 0 | 0 |
| Up | FINISHED | Idle | 0 | 0 | 0 |
| Pulsing | FINISHED | Slash End | 0 | 0 | 0 |
| Pulsing | ENTER | Type 2 | 0 | 0 | 0 |
| Type 2 | HERO ATTACK | Pulsing | 0 | 0 | 0 |
| Type 2 | ENEMY | Invincible? | 0 | 0 | 0 |
| Type 2 | PROJECTILE | Pulse Block | 0 | 0 | 0 |
| Slash End | FINISHED | Idle | 0 | 0 | 0 |
| Slash Anim | FINISHED | Pulsing | 0 | 0 | 0 |
| Pulse Block | FINISHED | Pulsing | 0 | 0 | 0 |
| Dreamwielder? | FINISHED | Idle | 0 | 0 | 0 |
| Tink | FINISHED | Break | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| DISAPPEAR | Disappear | 0 | 0 | 0 |
| ORBIT SHIELD DOWN | Down | 0 | 0 | 0 |
| CHECK COMBO | Init | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CHECK COMBO | false |
| DISAPPEAR | false |
| END | false |
| ENEMY | false |
| ENTER | false |
| HERO ATTACK | false |
| INVINCIBLE | false |
| NO EFFECT | false |
| ORBIT SHIELD DOWN | false |
| ORBIT SHIELD UP | false |
| PROJECTILE | false |
| SLASH | false |

