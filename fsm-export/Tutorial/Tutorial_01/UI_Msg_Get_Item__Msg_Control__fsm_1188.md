# Msg Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Msg Control |
| GameObject Name | UI Msg Get Item |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets |
| Start State | Init |
| FSM PathId | 1188 |
| GameObject PathId | 491 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Game Text |  | String:  |
| Item |  | String:  |
| Language |  | String:  |
| To Scene | Room_Town_Stag_Station | String: Room_Town_Stag_Station |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Audio Player | [null] | NamedAssetPPtr:  |
| BG | UI Msg Get Item/BG (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: UI Msg Get Item/BG (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Button | UI Msg Get Item/Button (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: UI Msg Get Item/Button (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Fleur | UI Msg Get Item/Fleur (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: UI Msg Get Item/Fleur (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Icon | UI Msg Get Item/Icon (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: UI Msg Get Item/Icon (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Item Name | UI Msg Get Item/Item Name (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: UI Msg Get Item/Item Name (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Item Name Prefix | UI Msg Get Item/Item Name Prefix (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: UI Msg Get Item/Item Name Prefix (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Msg 1 | UI Msg Get Item/Msg 1 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: UI Msg Get Item/Msg 1 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Msg 2 | UI Msg Get Item/Msg 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: UI Msg Get Item/Msg 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Press | UI Msg Get Item/Press (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: UI Msg Get Item/Press (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |
| Self | [null] | NamedAssetPPtr:  |
| Stop | UI Msg Get Item/Stop (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) | NamedAssetPPtr: UI Msg Get Item/Stop (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets) |

## States

### Detect

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetButtonDown

Full Name: HutongGames.PlayMaker.Actions.GetButtonDown
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| buttonName | "Jump" | "Jump" |  |  |
| sendEvent | Event(PRESS) | Event(PRESS) |  |  |
| storeResult | false | false | Variable |  |

##### 2. GetButtonDown

Full Name: HutongGames.PlayMaker.Actions.GetButtonDown
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| buttonName | "Attack" | "Attack" |  |  |
| sendEvent | Event(PRESS) | Event(PRESS) |  |  |
| storeResult | false | false | Variable |  |

##### 3. GetButtonDown

Full Name: HutongGames.PlayMaker.Actions.GetButtonDown
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| buttonName | "Pause" | "Pause" |  |  |
| sendEvent | Event(PRESS) | Event(PRESS) |  |  |
| storeResult | false | false | Variable |  |

##### 4. ListenForCast

Full Name: HutongGames.PlayMaker.Actions.ListenForCast
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(PRESS) | Event(PRESS) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |
| activeBool | false | false |  |  |
| stateEntryOnly | false | false |  |  |

##### 5. ListenForJump

Full Name: HutongGames.PlayMaker.Actions.ListenForJump
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(PRESS) | Event(PRESS) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

##### 6. ListenForAttack

Full Name: HutongGames.PlayMaker.Actions.ListenForAttack
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| wasPressed | Event(PRESS) | Event(PRESS) |  |  |
| wasReleased | Event() | Event() |  |  |
| isPressed | Event() | Event() |  |  |
| isNotPressed | Event() | Event() |  |  |

### Done

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "GET ITEM MSG END" | "GET ITEM MSG END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren | false | false |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 24

#### Actions

##### 1. StringSwitch

Full Name: HutongGames.PlayMaker.Actions.StringSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Item | string Item | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Set Dash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Dash Cloak") | StoryRecord_acquired("Dash Cloak") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("DASH") | SetActionString("DASH") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_DASH" | "INV_NAME_DASH" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO1" | "GET_ITEM_INTRO1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_PRESS" | "BUTTON_DESC_PRESS" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DASH_1" | "GET_DASH_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DASH_2" | "GET_DASH_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Top Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):BG | EventTarget(GameObject):BG |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | SaveGame(???) | SaveGame(???) |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | GameObject Audio Player | GameObject Audio Player |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [spell_information_screen (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [spell_information_screen (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0.75f | 0.75f |  |  |
| storePlayer |  |  |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Icon | EventTarget(GameObject):Icon |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Item Name | EventTarget(GameObject):Item Name |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Item Name Prefix | EventTarget(GameObject):Item Name Prefix |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.5f | 2.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 8. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fleur | OwnerDefault Fleur |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 9. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RefreshButtonIcon(???) | RefreshButtonIcon(???) |  |  |

### Bot Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Press | EventTarget(GameObject):Press |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Msg 1 | EventTarget(GameObject):Msg 1 |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Msg 2 | EventTarget(GameObject):Msg 2 |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Button | EventTarget(GameObject):Button |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3f | 3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Stop Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stop | OwnerDefault Stop |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player UI (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [button (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [button (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 0.8f | 0.8f |  |  |
| pitchMax | 0.8f | 0.8f |  |  |
| volume | 0.3f | 0.3f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Set Fireball

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Fireball Lv1") | StoryRecord_acquired("Fireball Lv1") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("CAST") | SetActionString("CAST") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_FIREBALL1" | "INV_NAME_SPELL_FIREBALL1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_FIREBALL_1" | "GET_FIREBALL_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_FIREBALL_2" | "GET_FIREBALL_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Walljump

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Walljump") | StoryRecord_acquired("Walljump") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("JUMP") | SetActionString("JUMP") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_WALLJUMP" | "INV_NAME_WALLJUMP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO1" | "GET_ITEM_INTRO1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_PRESS" | "BUTTON_DESC_PRESS" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_WALLJUMP_1" | "GET_WALLJUMP_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_WALLJUMP_2" | "GET_WALLJUMP_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Journal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Journal") | StoryRecord_acquired("Journal") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("INVENTORY") | SetActionString("INVENTORY") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_JOURNAL" | "INV_NAME_JOURNAL" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO1" | "GET_ITEM_INTRO1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_PRESS" | "BUTTON_DESC_PRESS" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_JOURNAL_1" | "GET_JOURNAL_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_JOURNAL_2" | "GET_JOURNAL_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Fireball 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Fireball Lv2") | StoryRecord_acquired("Fireball Lv2") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("CAST") | SetActionString("CAST") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_FIREBALL2" | "INV_NAME_SPELL_FIREBALL2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_FIREBALL2_1" | "GET_FIREBALL2_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_FIREBALL2_2" | "GET_FIREBALL2_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Super Dash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Superdash") | StoryRecord_acquired("Superdash") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("SUPER_DASH") | SetActionString("SUPER_DASH") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SUPERDASH" | "INV_NAME_SUPERDASH" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_HOLD" | "BUTTON_DESC_HOLD" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_SUPERDASH_1" | "GET_SUPERDASH_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_SUPERDASH_2" | "GET_SUPERDASH_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### SetQuake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Quake Lv1") | StoryRecord_acquired("Quake Lv1") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("CAST") | SetActionString("CAST") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_QUAKE1" | "INV_NAME_SPELL_QUAKE1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_QUAKE_1" | "GET_QUAKE_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_QUAKE_2" | "GET_QUAKE_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set NA Cyclone

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Cyclone Slash") | StoryRecord_acquired("Cyclone Slash") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("ATTACK") | SetActionString("ATTACK") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_ART_CYCLONE" | "INV_NAME_ART_CYCLONE" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO3" | "GET_ITEM_INTRO3" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_HOLD" | "BUTTON_DESC_HOLD" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_CYCLONE_1" | "GET_CYCLONE_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_CYCLONE_2" | "GET_CYCLONE_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set NA G Slash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Great Slash") | StoryRecord_acquired("Great Slash") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("ATTACK") | SetActionString("ATTACK") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_ART_DASH" | "INV_NAME_ART_DASH" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO3" | "GET_ITEM_INTRO3" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_HOLD" | "BUTTON_DESC_HOLD" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_GSLASH_1" | "GET_GSLASH_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_GSLASH_2" | "GET_GSLASH_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### SetScream

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Scream Lv1") | StoryRecord_acquired("Scream Lv1") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("CAST") | SetActionString("CAST") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_SCREAM1" | "INV_NAME_SPELL_SCREAM1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_SCREAM_1" | "GET_SCREAM_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_SCREAM_2" | "GET_SCREAM_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Pure Seed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Isma's Tear") | StoryRecord_acquired("Isma's Tear") |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_ACIDARMOUR" | "INV_NAME_ACIDARMOUR" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 6. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO6" | "GET_ITEM_INTRO6" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 7. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | "" | "" |  |  |

##### 10. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ACIDARMOUR_1" | "GET_ACIDARMOUR_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 12. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ACIDARMOUR_2" | "GET_ACIDARMOUR_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 13. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 14. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 15. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 16. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stop | OwnerDefault Stop |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

### Set D Jump

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Double Jump") | StoryRecord_acquired("Double Jump") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("JUMP") | SetActionString("JUMP") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_DOUBLEJUMP" | "INV_NAME_DOUBLEJUMP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_PRESS" | "BUTTON_DESC_PRESS" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DOUBLEJUMP_1" | "GET_DOUBLEJUMP_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DOUBLEJUMP_2" | "GET_DOUBLEJUMP_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Kings Brand

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("King's Brand") | StoryRecord_acquired("King's Brand") |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_KINGSBRAND" | "INV_NAME_KINGSBRAND" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 6. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO4" | "GET_ITEM_INTRO4" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 7. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_NONE" | "BUTTON_DESC_NONE" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 10. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_KINGSBRAND_1" | "GET_KINGSBRAND_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 12. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_KINGSBRAND_2" | "GET_KINGSBRAND_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 13. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 14. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 15. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 16. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stop | OwnerDefault Stop |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

### SetScream 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Scream Lv2") | StoryRecord_acquired("Scream Lv2") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("CAST") | SetActionString("CAST") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_SCREAM2" | "INV_NAME_SPELL_SCREAM2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_SCREAM2_1" | "GET_SCREAM2_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_SCREAM2_2" | "GET_SCREAM2_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Shadow Dash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Shadow Cloak") | StoryRecord_acquired("Shadow Cloak") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("DASH") | SetActionString("DASH") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SHADOWDASH" | "INV_NAME_SHADOWDASH" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO7" | "GET_ITEM_INTRO7" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_PRESS" | "BUTTON_DESC_PRESS" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_SHADOWDASH_1" | "GET_SHADOWDASH_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_SHADOWDASH_2" | "GET_SHADOWDASH_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Quake 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Quake Lv2") | StoryRecord_acquired("Quake Lv2") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("CAST") | SetActionString("CAST") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_QUAKE2" | "INV_NAME_SPELL_QUAKE2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_QUAKE2_1" | "GET_QUAKE2_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_QUAKE2_2" | "GET_QUAKE2_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Hunter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ApplyMusicCue

Full Name: HutongGames.PlayMaker.Actions.ApplyMusicCue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| musicCue | [None (Script MusicCue) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [None (Script MusicCue) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| delayTime | 0f | 0f |  |  |
| transitionTime | 0f | 0f |  |  |

##### 2. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Normal (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | 2f | 2f |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Hunter's Mark") | StoryRecord_acquired("Hunter's Mark") |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "NAME_HUNTERMARK" | "NAME_HUNTERMARK" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 7. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO1" | "GET_ITEM_INTRO1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 10. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_NONE" | "BUTTON_DESC_NONE" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 12. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_HUNTERMARK_1" | "GET_HUNTERMARK_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 13. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 14. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_HUNTERMARK_2" | "GET_HUNTERMARK_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 15. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 16. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 17. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 18. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stop | OwnerDefault Stop |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

### Set NA D Slash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Dash Slash") | StoryRecord_acquired("Dash Slash") |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("ATTACK") | SetActionString("ATTACK") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_ART_UPPER" | "INV_NAME_ART_UPPER" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 4. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO3" | "GET_ITEM_INTRO3" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_HOLD" | "BUTTON_DESC_HOLD" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DSLASH_1" | "GET_DSLASH_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DSLASH_2" | "GET_DSLASH_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### All Nail Art Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| stringVariables | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trueEvent | Event() | Event() |  |  |
| falseEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasAllNailArts" | "hasAllNailArts" |  |  |
| value | true | true |  |  |

### Set D Nail

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("DREAM_NAIL") | SetActionString("DREAM_NAIL") |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_DREAMNAIL" | "INV_NAME_DREAMNAIL" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO1" | "GET_ITEM_INTRO1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 6. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_HOLD" | "BUTTON_DESC_HOLD" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 7. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DASH_1" | "GET_DASH_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 10. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DASH_2" | "GET_DASH_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 12. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault BG | OwnerDefault BG |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 13. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 14. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fleur | OwnerDefault Fleur |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 15. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 16. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stop | OwnerDefault Stop |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 17. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 18. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 19. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 20. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

##### 21. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| color | Color(0, 0, 0, 1) | Color(0, 0, 0, 1) |  |  |
| everyFrame | false | false |  |  |

### Set DN Upgrade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Upgraded Dreamnail") | StoryRecord_acquired("Upgraded Dreamnail") |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("DREAM_NAIL") | SetActionString("DREAM_NAIL") |  |  |

##### 5. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_DREAMNAIL_B" | "INV_NAME_DREAMNAIL_B" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 6. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 7. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO5" | "GET_ITEM_INTRO5" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 8. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_HOLD" | "BUTTON_DESC_HOLD" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 11. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DREAMNAILUPGRADE_1" | "GET_DREAMNAILUPGRADE_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 13. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DREAMNAILUPGRADE_2" | "GET_DREAMNAILUPGRADE_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 14. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Grub Map

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
| sendEvent | "GET GRUB MAP" | "GET GRUB MAP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Grub Map") | StoryRecord_acquired("Grub Map") |  |  |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasPin" | "hasPin" |  |  |
| value | true | true |  |  |

##### 4. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.75f | 0.75f |  |  |
| y | 0.75f | 0.75f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("QUICK_MAP") | SetActionString("QUICK_MAP") |  |  |

##### 6. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "COLLECTOR_MAP" | "COLLECTOR_MAP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 7. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO1" | "GET_ITEM_INTRO1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 10. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_HOLD" | "BUTTON_DESC_HOLD" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 12. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_MAP_2" | "GET_MAP_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 13. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 14. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_COLLECTOR_MAP" | "GET_COLLECTOR_MAP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 15. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Blessing

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("Salubra's Blessing") | StoryRecord_acquired("Salubra's Blessing") |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "NAME_BLESSING" | "NAME_BLESSING" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 6. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO8" | "GET_ITEM_INTRO8" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 7. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_NONE" | "BUTTON_DESC_NONE" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 10. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_BLESSING_1" | "GET_BLESSING_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 12. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_BLESSING_2" | "GET_BLESSING_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 13. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Audio Player Actor

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Audio Player | GameObject Audio Player | Variable |  |
| gameObject | [Global] [Audio Player NoDestroy (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player NoDestroy (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| everyFrame | false | false |  |  |

### Audio Player Music

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Audio Player | GameObject Audio Player | Variable |  |
| gameObject | [Global] [Audio Player Music (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Audio Player Music (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| everyFrame | false | false |  |  |

### Set Dreamgate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("DREAM_NAIL") | SetActionString("DREAM_NAIL") |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_DREAMGATE" | "INV_NAME_DREAMGATE" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 3. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO3" | "GET_ITEM_INTRO3" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 6. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_HOLD" | "BUTTON_DESC_HOLD" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 7. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DREAMGATE_1" | "GET_DREAMGATE_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 10. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_DREAMGATE_2" | "GET_DREAMGATE_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Fireball JA

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetCurrentLanguageAsString

Full Name: HutongGames.PlayMaker.Actions.GetCurrentLanguageAsString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Language | string Language | Variable |  |

##### 2. StringCompare

Full Name: HutongGames.PlayMaker.Actions.StringCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Language | string Language | Variable |  |
| compareTo | "JA" | "JA" |  |  |
| equalEvent | Event() | Event() |  |  |
| notEqualEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | -0.1f | -0.1f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Set Godfinder

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_acquired("God Finder") | StoryRecord_acquired("God Finder") |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "CP3" | "CP3" |  |  |
| convName | "INV_NAME_GODFINDER" | "INV_NAME_GODFINDER" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 5. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name | OwnerDefault Item Name |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 6. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ITEM_INTRO5" | "GET_ITEM_INTRO5" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 7. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Item Name Prefix | OwnerDefault Item Name Prefix |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "BUTTON_DESC_NONE" | "BUTTON_DESC_NONE" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 10. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "CP3" | "CP3" |  |  |
| convName | "GET_GODFINDER_1" | "GET_GODFINDER_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 12. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "CP3" | "CP3" |  |  |
| convName | "GET_GODFINDER_2" | "GET_GODFINDER_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 13. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 14. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 15. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 16. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stop | OwnerDefault Stop |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 1.5f | 1.5f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Detect | PRESS | Down | 0 | 0 | 0 |
| Init | DASH | Set Dash | 0 | 0 | 0 |
| Init | FIREBALL | Fireball JA | 0 | 0 | 0 |
| Init | WALLJUMP | Set Walljump | 0 | 0 | 0 |
| Init | JOURNAL | Set Journal | 0 | 0 | 0 |
| Init | FIREBALL 2 | Set Fireball 2 | 0 | 0 | 0 |
| Init | S DASH | Set Super Dash | 0 | 0 | 0 |
| Init | QUAKE | SetQuake | 0 | 0 | 0 |
| Init | NA CYCLONE | Set NA Cyclone | 0 | 0 | 0 |
| Init | NA GSLASH | Set NA G Slash | 0 | 0 | 0 |
| Init | SCREAM | SetScream | 0 | 0 | 0 |
| Init | PURE SEED | Pure Seed | 0 | 0 | 0 |
| Init | D JUMP | Set D Jump | 0 | 0 | 0 |
| Init | KINGS BRAND | Set Kings Brand | 0 | 0 | 0 |
| Init | SCREAM 2 | SetScream 2 | 0 | 0 | 0 |
| Init | SHADOW DASH | Set Shadow Dash | 0 | 0 | 0 |
| Init | QUAKE 2 | Set Quake 2 | 0 | 0 | 0 |
| Init | HUNTER | Set Hunter | 0 | 0 | 0 |
| Init | NA DASH | Set NA D Slash | 0 | 0 | 0 |
| Init | D NAIL | Set D Nail | 0 | 0 | 0 |
| Init | DN UPGRADE | Set DN Upgrade | 0 | 0 | 0 |
| Init | GRUB MAP | Set Grub Map | 0 | 0 | 0 |
| Init | BLESSING | Set Blessing | 0 | 0 | 0 |
| Init | DREAM GATE | Set Dreamgate | 0 | 0 | 0 |
| Init | GODFINDER | Set Godfinder | 0 | 0 | 0 |
| Set Dash | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Top Up | FINISHED | Bot Up | 0 | 0 | 0 |
| Bot Up | FINISHED | Stop Up | 0 | 0 | 0 |
| Stop Up | FINISHED | Detect | 0 | 0 | 0 |
| Down | FINISHED | Done | 0 | 0 | 0 |
| Set Fireball | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set Walljump | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set Journal | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set Fireball 2 | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set Super Dash | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| SetQuake | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set NA Cyclone | FINISHED | All Nail Art Check | 0 | 0 | 0 |
| Set NA G Slash | FINISHED | All Nail Art Check | 0 | 0 | 0 |
| SetScream | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Pure Seed | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set D Jump | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set Kings Brand | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| SetScream 2 | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set Shadow Dash | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set Quake 2 | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set Hunter | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set NA D Slash | FINISHED | All Nail Art Check | 0 | 0 | 0 |
| All Nail Art Check | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set D Nail | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set DN Upgrade | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set Grub Map | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Set Blessing | FINISHED | Audio Player Music | 0 | 0 | 0 |
| Audio Player Actor | FINISHED | Top Up | 0 | 0 | 0 |
| Audio Player Music | FINISHED | Top Up | 0 | 0 | 0 |
| Set Dreamgate | FINISHED | Audio Player Actor | 0 | 0 | 0 |
| Fireball JA | FINISHED | Set Fireball | 0 | 0 | 0 |
| Set Godfinder | FINISHED | Audio Player Actor | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BLESSING | false |
| D JUMP | false |
| D NAIL | false |
| DASH | false |
| DN UPGRADE | false |
| DREAM GATE | false |
| FIREBALL | false |
| FIREBALL 2 | false |
| GODFINDER | false |
| GRUB MAP | false |
| HUNTER | false |
| JOURNAL | false |
| KINGS BRAND | false |
| NA CYCLONE | false |
| NA DASH | false |
| NA GSLASH | false |
| PRESS | false |
| PURE SEED | false |
| QUAKE | false |
| QUAKE 2 | false |
| S DASH | false |
| SCREAM | false |
| SCREAM 2 | false |
| SHADOW DASH | false |
| WALLJUMP | false |

