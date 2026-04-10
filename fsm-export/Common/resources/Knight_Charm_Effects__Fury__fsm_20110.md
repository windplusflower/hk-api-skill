# Fury

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Fury |
| GameObject Name | Charm Effects |
| GameObject Path | Knight |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init Pause |
| FSM PathId | 20110 |
| GameObject PathId | 4312 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blue Health | 0 | Int32: 0 |
| HP | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Has Blue Health | false | Boolean: false |
| Joni Equipped | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alt Slash | [null] | NamedAssetPPtr:  |
| Attacks | [null] | NamedAssetPPtr:  |
| Cyclone Hit L | [null] | NamedAssetPPtr:  |
| Cyclone Hit R | [null] | NamedAssetPPtr:  |
| Cyclone Slash | [null] | NamedAssetPPtr:  |
| Dash Slash | [null] | NamedAssetPPtr:  |
| Down Slash | [null] | NamedAssetPPtr:  |
| Fury Object | [null] | NamedAssetPPtr:  |
| Fury Vignette | [null] | NamedAssetPPtr:  |
| Great Slash | [null] | NamedAssetPPtr:  |
| Knight | [null] | NamedAssetPPtr:  |
| Rage Burst Effect | [null] | NamedAssetPPtr:  |
| Slash | [null] | NamedAssetPPtr:  |
| Up Slash | [null] | NamedAssetPPtr:  |
| Wall Slash | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Fury" | "Fury" |  |  |
| storeResult | GameObject Fury Object | GameObject Fury Object | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Rage Burst Effect" | "Rage Burst Effect" |  |  |
| storeResult | GameObject Rage Burst Effect | GameObject Rage Burst Effect | Variable |  |

##### 3. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Knight | GameObject Knight | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Knight | OwnerDefault Knight |  |  |
| childName | "Attacks" | "Attacks" |  |  |
| storeResult | GameObject Attacks | GameObject Attacks | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "AltSlash" | "AltSlash" |  |  |
| storeResult | GameObject Alt Slash | GameObject Alt Slash | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "DownSlash" | "DownSlash" |  |  |
| storeResult | GameObject Down Slash | GameObject Down Slash | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "UpSlash" | "UpSlash" |  |  |
| storeResult | GameObject Up Slash | GameObject Up Slash | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "Slash" | "Slash" |  |  |
| storeResult | GameObject Slash | GameObject Slash | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "WallSlash" | "WallSlash" |  |  |
| storeResult | GameObject Wall Slash | GameObject Wall Slash | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "Cyclone Slash" | "Cyclone Slash" |  |  |
| storeResult | GameObject Cyclone Slash | GameObject Cyclone Slash | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "Dash Slash" | "Dash Slash" |  |  |
| storeResult | GameObject Dash Slash | GameObject Dash Slash | Variable |  |

##### 12. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "Great Slash" | "Great Slash" |  |  |
| storeResult | GameObject Great Slash | GameObject Great Slash | Variable |  |

##### 13. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Slash | OwnerDefault Cyclone Slash |  |  |
| childName | "Hits/Hit L" | "Hits/Hit L" |  |  |
| storeResult | GameObject Cyclone Hit L | GameObject Cyclone Hit L | Variable |  |

##### 14. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Slash | OwnerDefault Cyclone Slash |  |  |
| childName | "Hits/Hit R" | "Hits/Hit R" |  |  |
| storeResult | GameObject Cyclone Hit R | GameObject Cyclone Hit R | Variable |  |

##### 15. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Camera | OwnerDefault HUD Camera |  |  |
| childName | "fury_effects_v2" | "fury_effects_v2" |  |  |
| storeResult | GameObject Fury Vignette | GameObject Fury Vignette | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Check HP

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_6" | "equippedCharm_6" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "health" | "health" |  |  |
| storeValue | int HP | int HP | Variable |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "healthBlue" | "healthBlue" |  |  |
| storeValue | int Blue Health | int Blue Health | Variable |  |

##### 4. IntTestToBool

Full Name: HutongGames.PlayMaker.Actions.IntTestToBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| int1 | int Blue Health | int Blue Health |  |  |
| int2 | 0 | 0 |  |  |
| equalBool | false | false | Variable |  |
| lessThanBool | false | false | Variable |  |
| greaterThanBool | bool Has Blue Health | bool Has Blue Health | Variable |  |
| everyFrame | false | false |  |  |

##### 5. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "equippedCharm_27" | "equippedCharm_27" |  |  |
| storeValue | bool Joni Equipped | bool Joni Equipped | Variable |  |

##### 6. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| sendEvent | Event(CANCEL) | Event(CANCEL) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 7. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(FURY) | Event(FURY) |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Knight | GameObject Knight |  |  |
| audioClip | [hero_fury_charm_burst (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hero_fury_charm_burst (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
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
| eventTarget | EventTarget(GameObject):Fury Object | EventTarget(GameObject):Fury Object |  |  |
| sendEvent | "PLAY" | "PLAY" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fury Object | OwnerDefault Fury Object |  |  |
| emit | 0 | 0 |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Alt Slash | OwnerDefault Alt Slash |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetFury(true) | SetFury(true) |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Down Slash | OwnerDefault Down Slash |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetFury(true) | SetFury(true) |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Slash | OwnerDefault Slash |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetFury(true) | SetFury(true) |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Up Slash | OwnerDefault Up Slash |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetFury(true) | SetFury(true) |  |  |

##### 8. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wall Slash | OwnerDefault Wall Slash |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetFury(true) | SetFury(true) |  |  |

##### 9. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Down Slash | OwnerDefault Down Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "Multiplier" | "Multiplier" | FsmFloat |  |
| setValue | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Alt Slash | OwnerDefault Alt Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "Multiplier" | "Multiplier" | FsmFloat |  |
| setValue | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Up Slash | OwnerDefault Up Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "Multiplier" | "Multiplier" | FsmFloat |  |
| setValue | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 12. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Slash | OwnerDefault Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "Multiplier" | "Multiplier" | FsmFloat |  |
| setValue | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 13. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wall Slash | OwnerDefault Wall Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "Multiplier" | "Multiplier" | FsmFloat |  |
| setValue | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 14. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Hit L | OwnerDefault Cyclone Hit L |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 15. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Hit R | OwnerDefault Cyclone Hit R |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 16. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Slash | OwnerDefault Dash Slash |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 17. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash | OwnerDefault Great Slash |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 18. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Slash | OwnerDefault Cyclone Slash |  |  |
| color | Color(1, 0.17647058, 0.17647058, 1) | Color(1, 0.17647058, 0.17647058, 1) | FsmColor |  |
| everyframe | false | false |  |  |

##### 19. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Slash | OwnerDefault Dash Slash |  |  |
| color | Color(1, 0.17647058, 0.17647058, 1) | Color(1, 0.17647058, 0.17647058, 1) | FsmColor |  |
| everyframe | false | false |  |  |

##### 20. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash | OwnerDefault Great Slash |  |  |
| color | Color(1, 0.17647058, 0.17647058, 1) | Color(1, 0.17647058, 0.17647058, 1) | FsmColor |  |
| everyframe | false | false |  |  |

##### 21. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Rage Burst Effect | OwnerDefault Rage Burst Effect |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 22. FadeGroupUp

Full Name: FadeGroupUp
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Fury Vignette | OwnerDefault Fury Vignette | Variable |  |

### Deactivate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Fury Object | EventTarget(GameObject):Fury Object |  |  |
| sendEvent | "STOP" | "STOP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fury Object | OwnerDefault Fury Object |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "FURY END" | "FURY END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Alt Slash | OwnerDefault Alt Slash |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetFury(false) | SetFury(false) |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wall Slash | OwnerDefault Wall Slash |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetFury(false) | SetFury(false) |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Down Slash | OwnerDefault Down Slash |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetFury(false) | SetFury(false) |  |  |

##### 7. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Slash | OwnerDefault Slash |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetFury(false) | SetFury(false) |  |  |

##### 8. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Up Slash | OwnerDefault Up Slash |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetFury(false) | SetFury(false) |  |  |

##### 9. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Down Slash | OwnerDefault Down Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "Multiplier" | "Multiplier" | FsmFloat |  |
| setValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Wall Slash | OwnerDefault Wall Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "Multiplier" | "Multiplier" | FsmFloat |  |
| setValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Alt Slash | OwnerDefault Alt Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "Multiplier" | "Multiplier" | FsmFloat |  |
| setValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 12. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Up Slash | OwnerDefault Up Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "Multiplier" | "Multiplier" | FsmFloat |  |
| setValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 13. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Slash | OwnerDefault Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "Multiplier" | "Multiplier" | FsmFloat |  |
| setValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 14. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Slash | OwnerDefault Dash Slash |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 15. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Hit L | OwnerDefault Cyclone Hit L |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 16. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Hit R | OwnerDefault Cyclone Hit R |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 17. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash | OwnerDefault Great Slash |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 18. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Slash | OwnerDefault Cyclone Slash |  |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) | FsmColor |  |
| everyframe | false | false |  |  |

##### 19. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Slash | OwnerDefault Dash Slash |  |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) | FsmColor |  |
| everyframe | false | false |  |  |

##### 20. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash | OwnerDefault Great Slash |  |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) | FsmColor |  |
| everyframe | false | false |  |  |

##### 21. FadeGroupDown

Full Name: FadeGroupDown
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Fury Vignette | OwnerDefault Fury Vignette | Variable |  |
| fast | false | false |  |  |

### Stay Furied

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Hit L | OwnerDefault Cyclone Hit L |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Hit R | OwnerDefault Cyclone Hit R |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dash Slash | OwnerDefault Dash Slash |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash | OwnerDefault Great Slash |  |  |
| fsmName | "nailart_damage" | "nailart_damage" | FsmName |  |
| variableName | "Fury" | "Fury" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Recheck

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "health" | "health" |  |  |
| storeValue | int HP | int HP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(RETURN) | Event(RETURN) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Joni Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_27" | "equippedCharm_27" |  |  |
| isTrue | Event(CANCEL) | Event(CANCEL) |  |  |
| isFalse | Event(RETURN) | Event(RETURN) |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Init Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### HP Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Get Ref

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Fury Vignette | GameObject Fury Vignette | Variable |  |
| isNull | Event() | Event() |  |  |
| isNotNull | Event(FINISHED) | Event(FINISHED) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Camera | OwnerDefault HUD Camera |  |  |
| childName | "fury_effects_v2" | "fury_effects_v2" |  |  |
| storeResult | GameObject Fury Vignette | GameObject Fury Vignette | Variable |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | HERO DAMAGED | Pause | 0 | 0 | 0 |
| Check HP | FURY | Get Ref | 0 | 0 | 0 |
| Check HP | CANCEL | Idle | 0 | 0 | 0 |
| Activate | HERO DAMAGED | HP Pause | 0 | 0 | 0 |
| Activate | HERO HEALED | Recheck | 0 | 0 | 0 |
| Activate | HERO HEALED FULL | Deactivate | 0 | 0 | 0 |
| Activate | ADD BLUE HEALTH | Joni Check | 0 | 0 | 0 |
| Activate | ALL CHARMS END | Deactivate | 0 | 0 | 0 |
| Activate | FURY REFRESH | Recheck | 0 | 0 | 0 |
| Deactivate | FINISHED | Idle | 0 | 0 | 0 |
| Stay Furied | HERO DAMAGED | HP Pause | 0 | 0 | 0 |
| Stay Furied | HERO HEALED | Recheck | 0 | 0 | 0 |
| Stay Furied | HERO HEALED FULL | Deactivate | 0 | 0 | 0 |
| Stay Furied | ADD BLUE HEALTH | Joni Check | 0 | 0 | 0 |
| Stay Furied | ALL CHARMS END | Deactivate | 0 | 0 | 0 |
| Recheck | FINISHED | Deactivate | 0 | 0 | 0 |
| Recheck | RETURN | Stay Furied | 0 | 0 | 0 |
| Joni Check | CANCEL | Deactivate | 0 | 0 | 0 |
| Joni Check | RETURN | Stay Furied | 0 | 0 | 0 |
| Pause | FINISHED | Check HP | 0 | 0 | 0 |
| Init Pause | FINISHED | Init | 0 | 0 | 0 |
| HP Pause | FINISHED | Recheck | 0 | 0 | 0 |
| Get Ref | FINISHED | Activate | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ADD BLUE HEALTH | false |
| ALL CHARMS END | false |
| CANCEL | false |
| END | false |
| FURY | false |
| FURY REFRESH | false |
| HERO DAMAGED | true |
| HERO HEALED | false |
| HERO HEALED FULL | false |
| REOFF | false |
| RETURN | false |

