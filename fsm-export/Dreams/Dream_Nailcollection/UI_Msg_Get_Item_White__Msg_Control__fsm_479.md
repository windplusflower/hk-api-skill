# Msg Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Msg Control |
| GameObject Name | UI Msg Get Item White |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets |
| Start State | Init |
| FSM PathId | 479 |
| GameObject PathId | 414 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Game Text |  | String:  |
| Item |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| BG | UI Msg Get Item White/BG (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) | NamedAssetPPtr: UI Msg Get Item White/BG (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) |
| Button | UI Msg Get Item White/Button (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) | NamedAssetPPtr: UI Msg Get Item White/Button (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) |
| Fleur | UI Msg Get Item White/Fleur (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) | NamedAssetPPtr: UI Msg Get Item White/Fleur (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) |
| Icon | UI Msg Get Item White/Icon (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) | NamedAssetPPtr: UI Msg Get Item White/Icon (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) |
| Item Name | UI Msg Get Item White/Item Name (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) | NamedAssetPPtr: UI Msg Get Item White/Item Name (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) |
| Item Name Prefix | UI Msg Get Item White/Item Name Prefix (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) | NamedAssetPPtr: UI Msg Get Item White/Item Name Prefix (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) |
| Msg 1 | UI Msg Get Item White/Msg 1 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) | NamedAssetPPtr: UI Msg Get Item White/Msg 1 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) |
| Msg 2 | UI Msg Get Item White/Msg 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) | NamedAssetPPtr: UI Msg Get Item White/Msg 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) |
| Press | UI Msg Get Item White/Press (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) | NamedAssetPPtr: UI Msg Get Item White/Press (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) |
| Self | [null] | NamedAssetPPtr:  |
| Stop | UI Msg Get Item White/Stop (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) | NamedAssetPPtr: UI Msg Get Item White/Stop (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets394.assets) |

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
Local Transitions: 19

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [Dash_Prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets132.assets)] | [Dash_Prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets132.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_DASH" | "INV_NAME_DASH" |  |  |
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
| convName | "BUTTON_DESC_PRESS" | "BUTTON_DESC_PRESS" |  |  |
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

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Icon | EventTarget(GameObject):Icon |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
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
| eventTarget | EventTarget(GameObject):Item Name | EventTarget(GameObject):Item Name |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Item Name Prefix | EventTarget(GameObject):Item Name Prefix |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.5f | 2.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 7. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fleur | OwnerDefault Fleur |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 8. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [Fireball_prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets76.assets)] | [Fireball_prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets76.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_FIREBALL1" | "INV_NAME_SPELL_FIREBALL1" |  |  |
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
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
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
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
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
| convName | "GET_FIREBALL_1" | "GET_FIREBALL_1" |  |  |
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
| convName | "GET_FIREBALL_2" | "GET_FIREBALL_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [Wall_Jump_Prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Wall_Jump_Prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_WALLJUMP" | "INV_NAME_WALLJUMP" |  |  |
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
| convName | "BUTTON_DESC_WALLJUMP" | "BUTTON_DESC_WALLJUMP" |  |  |
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
| convName | "GET_WALLJUMP_1" | "GET_WALLJUMP_1" |  |  |
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
| convName | "GET_WALLJUMP_2" | "GET_WALLJUMP_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [Journal_Prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets137.assets)] | [Journal_Prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets137.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_JOURNAL" | "INV_NAME_JOURNAL" |  |  |
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
| convName | "BUTTON_DESC_PRESS" | "BUTTON_DESC_PRESS" |  |  |
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
| convName | "GET_JOURNAL_1" | "GET_JOURNAL_1" |  |  |
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
| convName | "GET_JOURNAL_2" | "GET_JOURNAL_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0010_shadow_fireball (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets109.assets)] | [_0010_shadow_fireball (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets109.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_FIREBALL2" | "INV_NAME_SPELL_FIREBALL2" |  |  |
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
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
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
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
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
| convName | "GET_FIREBALL2_1" | "GET_FIREBALL2_1" |  |  |
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
| convName | "GET_FIREBALL2_2" | "GET_FIREBALL2_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [superdash_prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets270.assets)] | [superdash_prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets270.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SUPERDASH" | "INV_NAME_SUPERDASH" |  |  |
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
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
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
| convName | "GET_SUPERDASH_1" | "GET_SUPERDASH_1" |  |  |
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
| convName | "GET_SUPERDASH_2" | "GET_SUPERDASH_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0003_quake_spell (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets101.assets)] | [_0003_quake_spell (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets101.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_QUAKE1" | "INV_NAME_SPELL_QUAKE1" |  |  |
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
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
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
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
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
| convName | "GET_QUAKE_1" | "GET_QUAKE_1" |  |  |
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
| convName | "GET_QUAKE_2" | "GET_QUAKE_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0001_charge_cyclone (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets13.assets)] | [_0001_charge_cyclone (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets13.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_ART_CYCLONE" | "INV_NAME_ART_CYCLONE" |  |  |
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
| convName | "GET_CYCLONE_1" | "GET_CYCLONE_1" |  |  |
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
| convName | "GET_CYCLONE_2" | "GET_CYCLONE_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0002_charge_slash (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets14.assets)] | [_0002_charge_slash (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets14.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_ART_DASH" | "INV_NAME_ART_DASH" |  |  |
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
| convName | "GET_GSLASH_1" | "GET_GSLASH_1" |  |  |
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
| convName | "GET_GSLASH_2" | "GET_GSLASH_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0006_scream_spell (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets27.assets)] | [_0006_scream_spell (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets27.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_SCREAM1" | "INV_NAME_SPELL_SCREAM1" |  |  |
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
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
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
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
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
| convName | "GET_SCREAM_1" | "GET_SCREAM_1" |  |  |
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
| convName | "GET_SCREAM_2" | "GET_SCREAM_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0004_acid_armour (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets362.assets)] | [_0004_acid_armour (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets362.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_ACIDARMOUR" | "INV_NAME_ACIDARMOUR" |  |  |
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
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
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
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 7. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Press | OwnerDefault Press |  |  |
| textString | "" | "" |  |  |

##### 8. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_SCREAM_1" | "GET_SCREAM_1" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 9. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 1 | OwnerDefault Msg 1 |  |  |
| textString | "" | "" |  |  |

##### 10. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "Prompts" | "Prompts" |  |  |
| convName | "GET_ACIDARMOUR" | "GET_ACIDARMOUR" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set D Jump

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0009_emperors_wings (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets345.assets)] | [_0009_emperors_wings (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets345.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_DOUBLEJUMP" | "INV_NAME_DOUBLEJUMP" |  |  |
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
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
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
| convName | "BUTTON_DESC_PRESS" | "BUTTON_DESC_PRESS" |  |  |
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
| convName | "GET_DOUBLEJUMP_1" | "GET_DOUBLEJUMP_1" |  |  |
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
| convName | "GET_DOUBLEJUMP_2" | "GET_DOUBLEJUMP_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [kings_brand_prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets326.assets)] | [kings_brand_prompt (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets326.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_KINGSBRAND" | "INV_NAME_KINGSBRAND" |  |  |
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
| convName | "GET_ITEM_INTRO4" | "GET_ITEM_INTRO4" |  |  |
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
| convName | "BUTTON_DESC_NONE" | "BUTTON_DESC_NONE" |  |  |
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
| convName | "GET_KINGSBRAND_1" | "GET_KINGSBRAND_1" |  |  |
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
| convName | "GET_KINGSBRAND_2" | "GET_KINGSBRAND_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### SetScream 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0007_shadow_scream (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets338.assets)] | [_0007_shadow_scream (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets338.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_SCREAM2" | "INV_NAME_SPELL_SCREAM2" |  |  |
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
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
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
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
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
| convName | "GET_SCREAM2_1" | "GET_SCREAM2_1" |  |  |
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
| convName | "GET_SCREAM2_2" | "GET_SCREAM2_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0000_shadow-dash (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets337.assets)] | [_0000_shadow-dash (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets337.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SHADOWDASH" | "INV_NAME_SHADOWDASH" |  |  |
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
| convName | "GET_ITEM_INTRO5" | "GET_ITEM_INTRO5" |  |  |
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
| convName | "BUTTON_DESC_PRESS" | "BUTTON_DESC_PRESS" |  |  |
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
| convName | "GET_SHADOWDASH_1" | "GET_SHADOWDASH_1" |  |  |
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
| convName | "GET_SHADOWDASH_2" | "GET_SHADOWDASH_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0005_shadow_quake (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets274.assets)] | [_0005_shadow_quake (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets274.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_SPELL_QUAKE2" | "INV_NAME_SPELL_QUAKE2" |  |  |
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
| convName | "GET_ITEM_INTRO2" | "GET_ITEM_INTRO2" |  |  |
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
| convName | "BUTTON_DESC_TAP" | "BUTTON_DESC_TAP" |  |  |
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
| convName | "GET_QUAKE2_1" | "GET_QUAKE2_1" |  |  |
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
| convName | "GET_QUAKE2_2" | "GET_QUAKE2_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set Quake 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0005_shadow_quake (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets274.assets)] | [_0005_shadow_quake (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets274.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "NAME_HUNTERMARK" | "NAME_HUNTERMARK" |  |  |
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
| convName | "BUTTON_DESC_NONE" | "BUTTON_DESC_NONE" |  |  |
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
| convName | "GET_HUNTERMARK_1" | "GET_HUNTERMARK_1" |  |  |
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
| convName | "GET_HUNTERMARK_2" | "GET_HUNTERMARK_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

### Set NA D Slash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [charge_dash_slash (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets15.assets)] | [charge_dash_slash (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets15.assets)] |  |  |

##### 2. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_ART_UPPER" | "INV_NAME_ART_UPPER" |  |  |
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
| convName | "GET_DSLASH_1" | "GET_DSLASH_1" |  |  |
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
| convName | "GET_DSLASH_2" | "GET_DSLASH_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 11. SetTextMeshProText

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

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Icon | OwnerDefault Icon |  |  |
| sprite | [_0008_dream_nail (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets242.assets)] | [_0008_dream_nail (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets242.assets)] |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Button | OwnerDefault Button |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | SetActionString("DREAM_NAIL") | SetActionString("DREAM_NAIL") |  |  |

##### 3. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "INV_NAME_DREAMNAIL_A" | "INV_NAME_DREAMNAIL_A" |  |  |
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
| convName | "GET_DREAMNAIL_1" | "GET_DREAMNAIL_1" |  |  |
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
| convName | "GET_DREAMNAIL_2" | "GET_DREAMNAIL_2" |  |  |
| storeValue | string Game Text | string Game Text | Variable |  |

##### 12. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg 2 | OwnerDefault Msg 2 |  |  |
| textString | string Game Text | string Game Text |  |  |

##### 13. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault BG | OwnerDefault BG |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Detect | PRESS | Down | 0 | 0 | 0 |
| Init | DASH | Set Dash | 0 | 0 | 0 |
| Init | FIREBALL | Set Fireball | 0 | 0 | 0 |
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
| Init | HUNTER | Set Quake 3 | 0 | 0 | 0 |
| Init | NA DASH | Set NA D Slash | 0 | 0 | 0 |
| Init | D NAIL | Set D Nail | 0 | 0 | 0 |
| Set Dash | FINISHED | Top Up | 0 | 0 | 0 |
| Top Up | FINISHED | Bot Up | 0 | 0 | 0 |
| Bot Up | FINISHED | Stop Up | 0 | 0 | 0 |
| Stop Up | FINISHED | Detect | 0 | 0 | 0 |
| Down | FINISHED | Done | 0 | 0 | 0 |
| Set Fireball | FINISHED | Top Up | 0 | 0 | 0 |
| Set Walljump | FINISHED | Top Up | 0 | 0 | 0 |
| Set Journal | FINISHED | Top Up | 0 | 0 | 0 |
| Set Fireball 2 | FINISHED | Top Up | 0 | 0 | 0 |
| Set Super Dash | FINISHED | Top Up | 0 | 0 | 0 |
| SetQuake | FINISHED | Top Up | 0 | 0 | 0 |
| Set NA Cyclone | FINISHED | All Nail Art Check | 0 | 0 | 0 |
| Set NA G Slash | FINISHED | All Nail Art Check | 0 | 0 | 0 |
| SetScream | FINISHED | Top Up | 0 | 0 | 0 |
| Pure Seed | FINISHED | Top Up | 0 | 0 | 0 |
| Set D Jump | FINISHED | Top Up | 0 | 0 | 0 |
| Set Kings Brand | FINISHED | Top Up | 0 | 0 | 0 |
| SetScream 2 | FINISHED | Top Up | 0 | 0 | 0 |
| Set Shadow Dash | FINISHED | Top Up | 0 | 0 | 0 |
| Set Quake 2 | FINISHED | Top Up | 0 | 0 | 0 |
| Set Quake 3 | FINISHED | Top Up | 0 | 0 | 0 |
| Set NA D Slash | FINISHED | All Nail Art Check | 0 | 0 | 0 |
| All Nail Art Check | FINISHED | Top Up | 0 | 0 | 0 |
| Set D Nail | FINISHED | All Nail Art Check | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| D JUMP | false |
| D NAIL | false |
| DASH | false |
| FIREBALL | false |
| FIREBALL 2 | false |
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

