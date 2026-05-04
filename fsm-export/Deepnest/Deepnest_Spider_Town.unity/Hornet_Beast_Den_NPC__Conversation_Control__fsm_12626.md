# Conversation Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Conversation Control |
| GameObject Name | Hornet Beast Den NPC |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level304 |
| Start State | Init |
| FSM PathId | 12626 |
| GameObject PathId | 1966 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Guardians Defeated | 0 | Int32: 0 |
| Royal Charm State | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Spoken | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Anim End |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area Title | [null] | NamedAssetPPtr: [null] |
| Audio Player | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CONVO START | Hero Anim | 0 | |

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

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Defeated in Outskirts? | 0 | |

### End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| sendEvent |   | "CONVO END" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| sendEvent |   | "RESET CONVO" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

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
| eventTarget |   | EventTarget(GameObject):DialogueManager |   |   |
| sendEvent |   | "BOX DOWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "NPC TITLE DOWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.3f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | End | 0 | |

### Box Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):DialogueManager |   |   |
| sendEvent |   | "BOX UP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.3f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable |   | GameObject Area Title | Variable |   |
| gameObject |   | [Global] GameObject AreaTitle |   |   |
| everyFrame |   | false |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Area Title |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Area Title |   |   |
| fsmName |   | "" | FsmName |   |
| variableName |   | "NPC Title" | FsmBool |   |
| setValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Area Title |   |   |
| fsmName |   | "" | FsmName |   |
| variableName |   | "Area Event" | FsmString |   |
| setValue |   | "HORNET" |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Choice | 0 | |

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
| gameObject |   | OwnerDefault Hero |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "LookUpToIdle" |   |   |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | string Anim End |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Box Down | 0 | |

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
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| sendEvent |   | "TALK FINISH" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Hero Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "LookUp" |   |   |

##### 2. CheckTargetDirection

Full Name: HutongGames.PlayMaker.Actions.CheckTargetDirection
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| target |   | [Global] GameObject Hero |   |   |
| aboveEvent |   | Event() |   |   |
| belowEvent |   | Event() |   |   |
| rightEvent |   | Event(R) |   |   |
| leftEvent |   | Event(L) |   |   |
| aboveBool |   | false | Variable |   |
| belowBool |   | false | Variable |   |
| rightBool |   | false | Variable |   |
| leftBool |   | false | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| L | L | 0 | |
| R | R | 0 | |

### Greet

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [Hornet_Dialogue_Generic_05 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets19.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Audio Player |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "hornetDenEncounter" |   |   |
| value |   | true |   |   |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Spoken | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault DialogueText |   |   |
| behaviour |   | "DialogueBox" | Behaviour |   |
| methodName |   | "StartConversation" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CONVO_FINISH | Talk Finish | 0 | |

### Choice

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetAudioVolume

Full Name: HutongGames.PlayMaker.Actions.SetAudioVolume
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Audio Player |   |   |
| volume |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Spoken | Variable |   |
| isTrue |   | Event(REPEAT) |   |   |
| isFalse |   | Event(GREET) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| GREET | Greet | 0 | |
| REPEAT | Repeat | 0 | |

### Repeat

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [Hornet_Dialogue_Generic_03 (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets19.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Audio Player |   |   |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault DialogueText |   |   |
| behaviour |   | "DialogueBox" | Behaviour |   |
| methodName |   | "StartConversation" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CONVO_FINISH | Talk Finish | 0 | |

### L

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
| clipName |   | "Den Talk L" |   |   |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable |   | string Anim End | Variable |   |
| stringValue |   | "Den End L" | TextArea |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Box Up | 0 | |

### R

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
| clipName |   | "Den Talk R" |   |   |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable |   | string Anim End | Variable |   |
| stringValue |   | "Den End R" | TextArea |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Box Up | 0 | |

### Defeated in Outskirts?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| trueBool |   | "hegemolDefeated" |   |   |
| falseBool |   | "hornetOutskirtsDefeated" |   |   |
| isTrue |   | Event(ABSENT) |   |   |
| isFalse |   | Event() |   |   |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hornetOutskirtsDefeated" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(ABSENT) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| ABSENT | Never Meet | 0 | |
| FINISHED | Idle | 0 | |

### Never Meet

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "hornetDenEncounter" |   |   |
| value |   | true |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| activate |   | false |   |   |
| recursive |   | true |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RESET CONVO | Idle | 0 | |
| TALK FINISH | Anim End | 0 | |

## Events

| Name | Global |
| --- | --- |
| ABSENT | false |
| CONVO START | false |
| CONVO_FINISH | false |
| FINISHED | false |
| GREET | false |
| HORNET ACTIVE | false |
| INACTIVE | false |
| L | false |
| R | false |
| REPEAT | false |
| RESET CONVO | false |
| TALK FINISH | false |
| UNOPENED | false |

