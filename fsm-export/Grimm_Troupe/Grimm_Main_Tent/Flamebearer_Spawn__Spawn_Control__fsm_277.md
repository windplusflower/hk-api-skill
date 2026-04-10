# Spawn Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Spawn Control |
| GameObject Name | Flamebearer Spawn |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets |
| Start State | Pause |
| FSM PathId | 277 |
| GameObject PathId | 97 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Charm Level | 0 | Int32: 0 |
| Flames Collected | 0 | Int32: 0 |
| Flames Required | 0 | Int32: 0 |
| Level | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activated | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Item Name |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Active Effects | Flamebearer Spawn/Active Effects (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) | NamedAssetPPtr: Flamebearer Spawn/Active Effects (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) |
| Flamebearer | [null] | NamedAssetPPtr:  |
| Get Flame | Flamebearer Spawn/Get Flame (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) | NamedAssetPPtr: Flamebearer Spawn/Get Flame (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) |
| Get Flash | Flamebearer Spawn/Get Flash (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) | NamedAssetPPtr: Flamebearer Spawn/Get Flash (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) |
| Grimmchild | [null] | NamedAssetPPtr:  |
| Grimmkin Obj | [null] | NamedAssetPPtr:  |
| Msg | [null] | NamedAssetPPtr:  |
| Msg Icon | [null] | NamedAssetPPtr:  |
| Msg Text | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Spawn Point Med | Flamebearer Spawn/Spawn Point Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) | NamedAssetPPtr: Flamebearer Spawn/Spawn Point Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) |
| Spawn Point Small | Flamebearer Spawn/Spawn Point Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) | NamedAssetPPtr: Flamebearer Spawn/Spawn Point Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) |

## States

### Pause

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

##### 2. WaitForFinishedEnteringScene

Full Name: WaitForFinishedEnteringScene
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

##### 3. WaitForHeroInPosition

Full Name: WaitForHeroInPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |
| skipIfAlreadyPositioned | false | false |  |  |

### State

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 7

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Activated | bool Activated | Variable |  |
| isTrue | KILLED | KILLED |  |  |
| isFalse |  |  |  |  |
| everyFrame | false | false |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "flamesCollected" | "flamesCollected" |  |  |
| storeValue | int Flames Collected | int Flames Collected | Variable |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "flamesRequired" | "flamesRequired" |  |  |
| storeValue | int Flames Required | int Flames Required | Variable |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Flames Collected | int Flames Collected |  |  |
| integer2 | int Flames Required | int Flames Required |  |  |
| equal | FINISHED | FINISHED |  |  |
| lessThan |  |  |  |  |
| greaterThan | FINISHED | FINISHED |  |  |
| everyFrame | false | false |  |  |

##### 5. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_40" | "equippedCharm_40" |  |  |
| isTrue |  |  |  |  |
| isFalse | NOT EQUIPPED | NOT EQUIPPED |  |  |

##### 6. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "grimmChildLevel" | "grimmChildLevel" |  |  |
| storeValue | int Charm Level | int Charm Level | Variable |  |

##### 7. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Charm Level | int Charm Level |  |  |
| integer2 | int Level | int Level |  |  |
| equal |  |  |  |  |
| lessThan | KILLED | KILLED |  |  |
| greaterThan | KILLED | KILLED |  |  |
| everyFrame | false | false |  |  |

##### 8. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Charm Level | int Charm Level | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Do Nothing

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Level 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Grimmkin Obj | GameObject Grimmkin Obj |  |  |
| spawnPoint | [Flamebearer Spawn/Spawn Point Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Flamebearer Spawn/Spawn Point Small (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| position | Vector3(0, 1, 0) | Vector3(0, 1, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flamebearer | GameObject Flamebearer | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

### Ready

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "GRIMMKIN SPAWN" | "GRIMMKIN SPAWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Start Fight

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "Grimmchild" | "Grimmchild" | Tag |  |
| store | GameObject Grimmchild | GameObject Grimmchild | Variable |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Active Effects | OwnerDefault Active Effects |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flamebearer | EventTarget(GameObject):Flamebearer |  |  |
| sendEvent | "START" | "START" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | [Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 1f | 1f |  |  |

### Get Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Flame Ring

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flame | OwnerDefault Get Flame |  |  |
| parent | GameObject Grimmchild | GameObject Grimmchild |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 2. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flame | OwnerDefault Get Flame |  |  |
| fsmName | "Follow Grimmchild" | "Follow Grimmchild" | FsmName |  |
| variableName | "Grimmchild" | "Grimmchild" | FsmGameObject |  |
| setValue | GameObject Grimmchild | GameObject Grimmchild |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flame | OwnerDefault Get Flame |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 5. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flame | OwnerDefault Get Flame |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 6. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flame | OwnerDefault Get Flame |  |  |
| emit | 0 | 0 |  |  |

##### 7. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Grimmchild | GameObject Grimmchild |  |  |
| audioClip | [nightmare_lantern_powering_up (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [nightmare_lantern_powering_up (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Get

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimmchild | OwnerDefault Grimmchild |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | FlashGrimmflame(???) | FlashGrimmflame(???) |  |  |

##### 2. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flash | OwnerDefault Get Flash |  |  |
| parent | GameObject Grimmchild | GameObject Grimmchild |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flash | OwnerDefault Get Flash |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetPositionToObject

Full Name: HutongGames.PlayMaker.Actions.SetPositionToObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flash | OwnerDefault Get Flash |  |  |
| targetObject | GameObject Grimmchild | GameObject Grimmchild |  |  |
| xOffset | 0f | 0f |  |  |
| yOffset | 0f | 0f |  |  |
| zOffset | 0f | 0f |  |  |

##### 5. IncrementPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.IncrementPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "flamesCollected" | "flamesCollected" |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | AddToFlameList(???) | AddToFlameList(???) |  |  |

##### 7. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Activated | bool Activated | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 8. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Relic Get Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Relic Get Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Msg | GameObject Msg | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg | OwnerDefault Msg |  |  |
| childName | "Text" | "Text" |  |  |
| storeResult | GameObject Msg Text | GameObject Msg Text | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg | OwnerDefault Msg |  |  |
| childName | "Icon" | "Icon" |  |  |
| storeResult | GameObject Msg Icon | GameObject Msg Icon | Variable |  |

##### 11. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg Icon | OwnerDefault Msg Icon |  |  |
| sprite | [charm_grimmkin_01_upgrade (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [charm_grimmkin_01_upgrade (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

##### 12. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "FLAME_COLLECTED" | "FLAME_COLLECTED" |  |  |
| storeValue | string Item Name | string Item Name | Variable |  |

##### 13. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg Text | OwnerDefault Msg Text |  |  |
| textString | string Item Name | string Item Name |  |  |

##### 14. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Grimmchild | GameObject Grimmchild |  |  |
| audioClip | [nightmare_lantern_flame_burst (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [nightmare_lantern_flame_burst (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 0.75f | 0.75f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 15. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| behaviour | "GameManager" | "GameManager" | Behaviour |  |
| methodName | "SaveLevelState" | "SaveLevelState" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Level 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Grimmkin Obj | GameObject Grimmkin Obj |  |  |
| spawnPoint | [Flamebearer Spawn/Spawn Point Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Flamebearer Spawn/Spawn Point Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| position | Vector3(0, 1, 0) | Vector3(0, 1, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flamebearer | GameObject Flamebearer | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

### Level 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Grimmkin Obj | GameObject Grimmkin Obj |  |  |
| spawnPoint | [Flamebearer Spawn/Spawn Point Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Flamebearer Spawn/Spawn Point Med (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| position | Vector3(0, 2, 0) | Vector3(0, 2, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Flamebearer | GameObject Flamebearer | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

### Extra Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Pause | FINISHED | Extra Wait | 0 | 0 | 0 |
| State | NOT EQUIPPED | Do Nothing | 0 | 0 | 0 |
| State | LEVEL 1 | Level 1 | 0 | 0 | 0 |
| State | LEVEL 2 | Level 2 | 0 | 0 | 0 |
| State | LEVEL 3 | Level 3 | 0 | 0 | 0 |
| State | LEVEL 4 | Do Nothing | 0 | 0 | 0 |
| State | FINISHED | Do Nothing | 0 | 0 | 0 |
| State | KILLED | Do Nothing | 0 | 0 | 0 |
| Level 1 | FINISHED | Ready | 0 | 0 | 0 |
| Ready | ALERT | Start Fight | 0 | 0 | 0 |
| Start Fight | FLAMEBEARER KILLED | Get Pause | 0 | 0 | 0 |
| Get Pause | FINISHED | Flame Ring | 0 | 0 | 0 |
| Flame Ring | FINISHED | Get | 0 | 0 | 0 |
| Level 2 | FINISHED | Ready | 0 | 0 | 0 |
| Level 3 | FINISHED | Ready | 0 | 0 | 0 |
| Extra Wait | FINISHED | State | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ALERT | true |
| FLAMEBEARER KILLED | false |
| KILLED | false |
| LEVEL 1 | false |
| LEVEL 2 | false |
| LEVEL 3 | false |
| LEVEL 4 | false |
| NOT EQUIPPED | false |

