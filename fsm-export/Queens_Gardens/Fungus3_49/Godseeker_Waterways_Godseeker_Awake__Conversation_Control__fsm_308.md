# Conversation Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Conversation Control |
| GameObject Name | Godseeker Awake |
| GameObject Path | Godseeker Waterways |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets225.assets |
| Start State | Init |
| FSM PathId | 308 |
| GameObject PathId | 123 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Flower Repeat | false | Boolean: false |
| Spoken | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| First Talk |  | String:  |
| Repeat | GODSEEKER_WATERWAYS_AWAKE_REPEAT | String: GODSEEKER_WATERWAYS_AWAKE_REPEAT |
| Spoken PD Bool |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

### End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

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
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "CONVO END" | "CONVO END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | "RESET CONVO" | "RESET CONVO" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Box Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX DOWN" | "BOX DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "NPC TITLE DOWN" | "NPC TITLE DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.3f | 0.3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Box Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault AreaTitle | OwnerDefault AreaTitle |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault AreaTitle | OwnerDefault AreaTitle |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "NPC Title" | "NPC Title" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault AreaTitle | OwnerDefault AreaTitle |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "Area Event" | "Area Event" | FsmString |  |
| setValue | "GODSEEKER" | "GODSEEKER" |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX UP" | "BOX UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "godseekerSpokenAwake" | "godseekerSpokenAwake" |  |  |
| value | true | true |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.3f | 0.3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 7. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| startVolume | 0f | 0f |  |  |
| endVolume | 1f | 1f |  |  |
| time | 0.3f | 0.3f |  |  |

### Anim End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookUpToIdle" | "LookUpToIdle" |  |  |

### Talk Finish

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | "TALK FINISH" | "TALK FINISH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Hero Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookUp" | "LookUp" |  |  |

### Greet

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Spoken | bool Spoken | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string Spoken PD Bool | string Spoken PD Bool |  |  |
| value | true | true |  |  |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueText | OwnerDefault DialogueText |  |  |
| behaviour | "DialogueBox" | "DialogueBox" | Behaviour |  |
| methodName | "StartConversation" | "StartConversation" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

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

### Awake 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string First Talk | string First Talk | Variable |  |
| stringValue | "GODSEEKER_WATERWAYS_AWAKE_1" | "GODSEEKER_WATERWAYS_AWAKE_1" | TextArea |  |
| everyFrame | false | false |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Repeat = "GODSEEKER_WATERWAYS_AWAKE_REPEAT" | string Repeat = "GODSEEKER_WATERWAYS_AWAKE_REPEAT" | Variable |  |
| stringValue | "GODSEEKER_WATERWAYS_AWAKE_REPEAT" | "GODSEEKER_WATERWAYS_AWAKE_REPEAT" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Spoken PD Bool | string Spoken PD Bool | Variable |  |
| stringValue | "godseekerWaterwaysSpoken1" | "godseekerWaterwaysSpoken1" | TextArea |  |
| everyFrame | false | false |  |  |

### Awake 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string First Talk | string First Talk | Variable |  |
| stringValue | "GODSEEKER_WATERWAYS_AWAKE_2" | "GODSEEKER_WATERWAYS_AWAKE_2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Repeat = "GODSEEKER_WATERWAYS_AWAKE_REPEAT" | string Repeat = "GODSEEKER_WATERWAYS_AWAKE_REPEAT" | Variable |  |
| stringValue | "GODSEEKER_WATERWAYS_AWAKE_REPEAT" | "GODSEEKER_WATERWAYS_AWAKE_REPEAT" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Spoken PD Bool | string Spoken PD Bool | Variable |  |
| stringValue | "godseekerWaterwaysSpoken2" | "godseekerWaterwaysSpoken2" | TextArea |  |
| everyFrame | false | false |  |  |

### Awake 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string First Talk | string First Talk | Variable |  |
| stringValue | "GODSEEKER_WATERWAYS_AWAKE_3" | "GODSEEKER_WATERWAYS_AWAKE_3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Repeat = "GODSEEKER_WATERWAYS_AWAKE_REPEAT" | string Repeat = "GODSEEKER_WATERWAYS_AWAKE_REPEAT" | Variable |  |
| stringValue | "GODSEEKER_WATERWAYS_AWAKE_3_REPEAT" | "GODSEEKER_WATERWAYS_AWAKE_3_REPEAT" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Spoken PD Bool | string Spoken PD Bool | Variable |  |
| stringValue | "godseekerWaterwaysSpoken3" | "godseekerWaterwaysSpoken3" | TextArea |  |
| everyFrame | false | false |  |  |

### Repeat?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Spoken | bool Spoken | Variable |  |
| isTrue | Event(REPEAT) | Event(REPEAT) |  |  |
| isFalse | Event(GREET) | Event(GREET) |  |  |
| everyFrame | false | false |  |  |

### Repeat

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueText | OwnerDefault DialogueText |  |  |
| behaviour | "DialogueBox" | "DialogueBox" | Behaviour |  |
| methodName | "StartConversation" | "StartConversation" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [GS_waterway_07 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets225.assets)] | [GS_waterway_07 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets225.assets)] |  |  |

### Godfinder?

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
| boolName | "hasGodfinder" | "hasGodfinder" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |

### No Godfinder

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueText | OwnerDefault DialogueText |  |  |
| behaviour | "DialogueBox" | "DialogueBox" | Behaviour |  |
| methodName | "StartConversation" | "StartConversation" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [GS_waterway_05 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets225.assets)] | [GS_waterway_05 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets225.assets)] |  |  |

### Box Up YN

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX UP YN" | "BOX UP YN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Send Text

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueTextYN | OwnerDefault DialogueTextYN |  |  |
| fsmName | "Dialogue Page Control" | "Dialogue Page Control" | FsmName |  |
| variableName | "Toll Cost" | "Toll Cost" | FsmInt |  |
| setValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueTextYN | OwnerDefault DialogueTextYN |  |  |
| fsmName | "Dialogue Page Control" | "Dialogue Page Control" | FsmName |  |
| variableName | "Requester" | "Requester" | FsmGameObject |  |
| setValue | GameObject Self | GameObject Self |  |  |
| everyFrame | false | false |  |  |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueTextYN | OwnerDefault DialogueTextYN |  |  |
| behaviour | "DialogueBox" | "DialogueBox" | Behaviour |  |
| methodName | "StartConversation" | "StartConversation" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

### Yes

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX DOWN YN" | "BOX DOWN YN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Decline Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.3f | 0.3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX DOWN YN" | "BOX DOWN YN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Flower Repeat

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueText | OwnerDefault DialogueText |  |  |
| behaviour | "DialogueBox" | "DialogueBox" | Behaviour |  |
| methodName | "StartConversation" | "StartConversation" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 2. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [GS_waterway_07 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets225.assets)] | [GS_waterway_07 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets225.assets)] |  |  |

### Flower Greet

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "givenGodseekerFlower" | "givenGodseekerFlower" |  |  |
| value | true | true |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasXunFlower" | "hasXunFlower" |  |  |
| value | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Flower Repeat | bool Flower Repeat | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Godseeker Waterways/Godseeker Awake/Flower | OwnerDefault Godseeker Waterways/Godseeker Awake/Flower |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Godseeker Waterways/Godseeker Awake/Flower Appear | OwnerDefault Godseeker Waterways/Godseeker Awake/Flower Appear |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueText | OwnerDefault DialogueText |  |  |
| behaviour | "DialogueBox" | "DialogueBox" | Behaviour |  |
| methodName | "StartConversation" | "StartConversation" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 7. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [GS_waterway_04 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets225.assets)] | [GS_waterway_04 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets225.assets)] |  |  |

### Box Down 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX DOWN" | "BOX DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.3f | 0.3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Box Up 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX UP" | "BOX UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.3f | 0.3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Flower Repeat?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |

##### 2. SetAudioVolume

Full Name: HutongGames.PlayMaker.Actions.SetAudioVolume
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| volume | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Flower Repeat | bool Flower Repeat | Variable |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |
| everyFrame | false | false |  |  |

### Get Spoken

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | string Spoken PD Bool | string Spoken PD Bool |  |  |
| storeValue | bool Spoken | bool Spoken | Variable |  |

### Flower?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| trueBool | "hasXunFlower" | "hasXunFlower" |  |  |
| falseBool | "givenEmilitiaFlower" | "givenEmilitiaFlower" |  |  |
| isTrue | Event(FLOWER) | Event(FLOWER) |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "hasXunFlower" | "hasXunFlower" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(CANCEL) | Event(CANCEL) |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "givenGodseekerFlower" | "givenGodseekerFlower" |  |  |
| isTrue | Event(CANCEL) | Event(CANCEL) |  |  |
| isFalse | Event() | Event() |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "xunFlowerBroken" | "xunFlowerBroken" |  |  |
| isTrue | Event(CANCEL) | Event(CANCEL) |  |  |
| isFalse | Event() | Event() |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | CONVO START | Hero Anim | 0 | 0 | 0 |
| Init | AWAKE 1 | Awake 1 | 0 | 0 | 0 |
| Init | AWAKE 2 | Awake 2 | 0 | 0 | 0 |
| Init | AWAKE 3 | Awake 3 | 0 | 0 | 0 |
| Box Down | FINISHED | End | 0 | 0 | 0 |
| Box Up | FINISHED | Flower Repeat? | 0 | 0 | 0 |
| Anim End | FINISHED | Box Down | 0 | 0 | 0 |
| Hero Anim | FINISHED | Box Up | 0 | 0 | 0 |
| Greet | CONVO_FINISH | Talk Finish | 0 | 0 | 0 |
| Awake 1 | FINISHED | Get Spoken | 0 | 0 | 0 |
| Awake 2 | FINISHED | Get Spoken | 0 | 0 | 0 |
| Awake 3 | FINISHED | Get Spoken | 0 | 0 | 0 |
| Repeat? | GREET | Greet | 0 | 0 | 0 |
| Repeat? | REPEAT | Repeat | 0 | 0 | 0 |
| Repeat | CONVO_FINISH | Flower? | 0 | 0 | 0 |
| Godfinder? | FALSE | No Godfinder | 0 | 0 | 0 |
| Godfinder? | FINISHED | Repeat? | 0 | 0 | 0 |
| No Godfinder | CONVO_FINISH | Talk Finish | 0 | 0 | 0 |
| Box Up YN | FINISHED | Send Text | 0 | 0 | 0 |
| Send Text | NO | Decline Pause | 0 | 0 | 0 |
| Send Text | YES | Yes | 0 | 0 | 0 |
| Yes | FINISHED | Box Up 3 | 0 | 0 | 0 |
| Decline Pause | FINISHED | Talk Finish | 0 | 0 | 0 |
| Flower Repeat | CONVO_FINISH | Talk Finish | 0 | 0 | 0 |
| Flower Greet | CONVO_FINISH | Talk Finish | 0 | 0 | 0 |
| Box Down 2 | FINISHED | Box Up YN | 0 | 0 | 0 |
| Box Up 3 | FINISHED | Flower Greet | 0 | 0 | 0 |
| Flower Repeat? | FALSE | Godfinder? | 0 | 0 | 0 |
| Flower Repeat? | TRUE | Flower Repeat | 0 | 0 | 0 |
| Get Spoken | FINISHED | Idle | 0 | 0 | 0 |
| Flower? | CANCEL | Talk Finish | 0 | 0 | 0 |
| Flower? | FINISHED | Box Down 2 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| RESET CONVO | Idle | 0 | 0 | 0 |
| TALK FINISH | Anim End | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| AWAKE 1 | false |
| AWAKE 2 | false |
| AWAKE 3 | false |
| CONVO START | false |
| CONVO_FINISH | false |
| FALSE | false |
| GREET | false |
| REPEAT | false |
| RESET CONVO | false |
| TALK FINISH | false |
| TRUE | false |
| NO | false |
| YES | false |
| CANCEL | false |

