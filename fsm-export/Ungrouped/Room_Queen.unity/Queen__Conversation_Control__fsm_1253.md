# Conversation Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Conversation Control |
| GameObject Name | Queen |
| GameObject Path |   |
| Source Asset | Hollow Knight/hollow_knight_Data/level348 |
| Start State | Init |
| FSM PathId | 1253 |
| GameObject PathId | 318 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Royal Charm State | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Awake | false | Boolean: false |
| Defeated Nightmare Grimm | false | Boolean: false |
| Destroyed Nightmare Lantern | false | Boolean: false |
| Equipped Grimm | false | Boolean: false |
| Grimm Convo 1 | false | Boolean: false |
| Grimm Convo 2 | false | Boolean: false |
| Spoken | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area Title | [null] | NamedAssetPPtr: [null] |
| Pt Summon | Queen/Pt Summon (Hollow Knight/hollow_knight_Data\level348) | NamedAssetPPtr: [Queen/Pt Summon (Hollow Knight/hollow_knight_Data\level348)] |
| Self | [null] | NamedAssetPPtr: [null] |
| Voice Player | [null] | NamedAssetPPtr: [null] |
| White Flash | Queen/White Flash (Hollow Knight/hollow_knight_Data\level348) | NamedAssetPPtr: [Queen/White Flash (Hollow Knight/hollow_knight_Data\level348)] |
| White Wave | Queen/White Wave (Hollow Knight/hollow_knight_Data\level348) | NamedAssetPPtr: [Queen/White Wave (Hollow Knight/hollow_knight_Data\level348)] |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CONVO START | Hero Look | 0 | |
| GET ITEM MSG END | Collider On | 0 | |

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

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

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

### Hero Look

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
| clipName |   | "LookUp" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | NPC Anim | 0 | |

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
| setValue |   | "QUEEN" |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Convo Choice | 0 | |

### Meet

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "metQueen" |   |   |
| value |   | true |   |   |

##### 3. CallMethodProper

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
| CONVO_FINISH | Box Down 2 | 0 | |

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

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Box Down | 0 | |

### Talk Finish

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Spoken | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEventByName

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

### NPC Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Awake | Variable |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Awake | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "Wake" |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| sendEvent |   | "AWAKE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Box Up | 0 | |

### Convo Choice

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 12

#### Actions

##### 1. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "killedNightmareGrimm" |   |   |
| storeValue |   | bool Defeated Nightmare Grimm | Variable |   |

##### 2. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "destroyedNightmareLantern" |   |   |
| storeValue |   | bool Destroyed Nightmare Lantern | Variable |   |

##### 3. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "queenConvo_grimm1" |   |   |
| storeValue |   | bool Grimm Convo 1 | Variable |   |

##### 4. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "queenConvo_grimm2" |   |   |
| storeValue |   | bool Grimm Convo 2 | Variable |   |

##### 5. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "equippedCharm_40" |   |   |
| storeValue |   | bool Equipped Grimm | Variable |   |

##### 6. SetAudioVolume

Full Name: HutongGames.PlayMaker.Actions.SetAudioVolume
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Voice Player |   |   |
| volume |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "metQueen" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(MEET) |   |   |

##### 8. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| trueBool |   | "equippedCharm_40" |   |   |
| falseBool |   | "queenConvo_grimm1" |   |   |
| isTrue |   | Event(GRIMM 1) |   |   |
| isFalse |   | Event() |   |   |

##### 9. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| boolStates |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trueEvent |   | Event(GRIMM 1) |   |   |
| falseEvent |   | Event() |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 10. BoolTestMulti

Full Name: HutongGames.PlayMaker.Actions.BoolTestMulti
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| boolStates |   | FSMViewAvalonia2.FsmArray2 |   |   |
| trueEvent |   | Event(GRIMM 2) |   |   |
| falseEvent |   | Event() |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | false |   |   |

##### 11. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| trueBool |   | "equippedCharm_10" |   |   |
| falseBool |   | "queenDung1" |   |   |
| isTrue |   | Event(DUNG1) |   |   |
| isFalse |   | Event() |   |   |

##### 12. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| trueBool |   | "equippedCharm_10" |   |   |
| falseBool |   | "queenDung2" |   |   |
| isTrue |   | Event(DUNG2) |   |   |
| isFalse |   | Event() |   |   |

##### 13. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| trueBool |   | "hasKingsBrand" |   |   |
| falseBool |   | "queenHornet" |   |   |
| isTrue |   | Event(HORNET) |   |   |
| isFalse |   | Event() |   |   |

##### 14. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "queenTalk1" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(TALK1) |   |   |

##### 15. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "queenTalk2" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(TALK2) |   |   |

##### 16. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Spoken | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(REMEET) |   |   |
| everyFrame |   | false |   |   |

##### 17. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "royalCharmState" |   |   |
| storeValue |   | int Royal Charm State | Variable |   |

##### 18. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Royal Charm State | Variable |   |
| compareTo |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MEET | Meet | 0 | |
| FINISHED | Repeat | 0 | |
| TALK1 | Talk 1 | 0 | |
| TALK2 | Talk 2 | 0 | |
| HORNET | Hornet | 0 | |
| DUNG1 | Dung 1 | 0 | |
| DUNG2 | Dung 2 | 0 | |
| KINGSOUL | Kingsoul Repeat | 0 | |
| REMEET | Remeet | 0 | |
| SHADECHARM | Shadecharm Repeat | 0 | |
| GRIMM 1 | Grimm 1 | 0 | |
| GRIMM 2 | Grimm 2 | 0 | |

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
| time |   | 0.75f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Summon | 0 | |

### Summon

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Pt Summon |   |   |
| emit |   | 0 |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 3f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 3. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Appear | 0 | |

### Appear

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(BroadcastAll):FSM Owner |   |   |
| sendEvent |   | "CHARM DROP" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetAudioVolume

Full Name: HutongGames.PlayMaker.Actions.SetAudioVolume
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Voice Player |   |   |
| volume |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault White Flash |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault White Wave |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 5. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 6. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Talk Finish | 0 | |

### Collider On

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetCollider

Full Name: HutongGames.PlayMaker.Actions.SetCollider
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Repeat

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

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
| CONVO_FINISH | Flower? | 0 | |

### Talk 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "queenTalk1" |   |   |
| value |   | true |   |   |

##### 3. CallMethodProper

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
| CONVO_FINISH | Flower? | 0 | |

### Talk 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "queenTalk2" |   |   |
| value |   | true |   |   |

##### 3. CallMethodProper

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
| CONVO_FINISH | Flower? | 0 | |

### Hornet

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "queenHornet" |   |   |
| value |   | true |   |   |

##### 3. CallMethodProper

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
| CONVO_FINISH | Flower? | 0 | |

### Dung 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "queenDung1" |   |   |
| value |   | true |   |   |

##### 3. CallMethodProper

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
| CONVO_FINISH | Flower? | 0 | |

### Dung 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "queenDung2" |   |   |
| value |   | true |   |   |

##### 3. CallMethodProper

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
| CONVO_FINISH | Flower? | 0 | |

### Kingsoul Repeat

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

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
| CONVO_FINISH | Flower? | 0 | |

### Shadecharm Repeat

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

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
| CONVO_FINISH | Flower? | 0 | |

### Remeet

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

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
| CONVO_FINISH | Flower? | 0 | |

### Grimm 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "queenConvo_grimm1" |   |   |
| value |   | true |   |   |

##### 3. CallMethodProper

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
| CONVO_FINISH | Flower? | 0 | |

### Grimm 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShot

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClips |   | FSMViewAvalonia2.FsmArray2 |   |   |
| weights |   | FSMViewAvalonia2.FsmArray2 |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   | GameObject Voice Player |   |   |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "queenConvo_grimm2" |   |   |
| value |   | true |   |   |

##### 3. CallMethodProper

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
| CONVO_FINISH | Flower? | 0 | |

### Flower

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName |   | "givenWhiteLadyFlower" |   |   |
| value |   | true |   |   |

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

### Decline Pause 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.3f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):DialogueManager |   |   |
| sendEvent |   | "BOX DOWN YN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Talk Finish | 0 | |

### Box Up YN 2

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
| sendEvent |   | "BOX UP YN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.25f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Send Text 2 | 0 | |

### Send Text 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault DialogueTextYN |   |   |
| fsmName |   | "Dialogue Page Control" | FsmName |   |
| variableName |   | "Toll Cost" | FsmInt |   |
| setValue |   | 0 |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault DialogueTextYN |   |   |
| fsmName |   | "Dialogue Page Control" | FsmName |   |
| variableName |   | "Requester" | FsmGameObject |   |
| setValue |   | GameObject Self |   |   |
| everyFrame |   | false |   |   |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault DialogueTextYN |   |   |
| behaviour |   | "DialogueBox" | Behaviour |   |
| methodName |   | "StartConversation" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var unnamed = 0 | Variable | Store Result |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NO | Decline Pause 2 | 0 | |
| YES | Yes 2 | 0 | |

### Yes 2

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
| sendEvent |   | "BOX DOWN YN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.5f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Box Up 10 | 0 | |

### Box Up 10

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

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Flower | 0 | |

### Box Down 3

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

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.75f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Box Up YN 2 | 0 | |

### Flower?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "hasXunFlower" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(CANCEL) |   |   |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "givenWhiteLadyFlower" |   |   |
| isTrue |   | Event(CANCEL) |   |   |
| isFalse |   | Event() |   |   |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "xunFlowerBroken" |   |   |
| isTrue |   | Event(CANCEL) |   |   |
| isFalse |   | Event() |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CANCEL | Talk Finish | 0 | |
| FINISHED | Box Down 3 | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| RESET CONVO | Idle | 0 | |
| TALK FINISH | Anim End | 0 | |

## Events

| Name | Global |
| --- | --- |
| CANCEL | false |
| CONVO START | false |
| CONVO_FINISH | false |
| DUNG1 | false |
| DUNG2 | false |
| FINISHED | false |
| FLOWER | false |
| GET ITEM MSG END | false |
| GRIMM 1 | false |
| GRIMM 2 | false |
| HORNET | false |
| KINGSOUL | false |
| MEET | false |
| NO | false |
| REMEET | false |
| RESET CONVO | false |
| SHADECHARM | false |
| TALK FINISH | false |
| TALK1 | false |
| TALK2 | false |
| YES | false |

