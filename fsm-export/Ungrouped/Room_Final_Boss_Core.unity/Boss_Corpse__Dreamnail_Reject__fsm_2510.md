# Dreamnail Reject

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Dreamnail Reject |
| GameObject Name | Boss Corpse |
| GameObject Path | Boss Control/Hollow Knight Boss/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level409 |
| Start State | Init |
| FSM PathId | 2510 |
| GameObject PathId | 134 |

## Variables

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Tag |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Attack Pt | Dream Dialogue/Active Pt (Hollow Knight/hollow_knight_Data\sharedassets6.assets) | NamedAssetPPtr: [Dream Dialogue/Active Pt (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] |
| Collider | [null] | NamedAssetPPtr: [null] |
| Dream Impact | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Attack Pt" |   |   |
| storeResult |   | [Dream Dialogue/Active Pt (Hollow Knight/hollow_knight_Data\sharedassets6.assets)] | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dream Impact" |   |   |
| storeResult |   | GameObject Dream Impact | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "Dream Attack" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(DREAM HIT) |   |   |
| storeCollider |   | GameObject Collider | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DREAM HIT | Tink | 0 | |

### Tink

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetTag

Full Name: HutongGames.PlayMaker.Actions.GetTag
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Collider |   |   |
| storeResult |   | string Tag | Variable |   |
| everyFrame |   | false |   |   |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer |   | [Global] [Audio Player Actor (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| spawnPoint |   | GameObject Self |   |   |
| audioClip |   | [sword_hit_reject (AudioClip) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |
| pitchMin |   | 1f |   |   |
| pitchMax |   | 1f |   |   |
| volume |   | 1f |   |   |
| delay |   | 0f |   |   |
| storePlayer |   |   |   |   |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | flashArmoured(???) |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):CameraParent |   |   |
| sendEvent |   | "AverageShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| sendEvent |   | "UP INSTANT" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| sendEvent |   | "DOWN" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Attack Pt |   |   |
| emission |   | true |   |   |

##### 8. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dream Impact |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 9. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| xScale |   | true |   |   |
| positiveEvent |   | Event(R) |   |   |
| negativeEvent |   | Event(L) |   |   |
| space | UnityEngine.Space::World | 0 |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| L | Recoil L | 0 | |
| R | Recoil R | 0 | |
| CANCEL | Cancel Pause | 0 | |

### End emission

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetParticleEmission

Full Name: HutongGames.PlayMaker.Actions.SetParticleEmission
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Attack Pt |   |   |
| emission |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | End emission | 0 | |

### Recoil L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | RecoilLeft(???) |   |   |

##### 2. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | -1.5f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |

### Recoil R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |   |   |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |   |   |
| functionCall |   | RecoilRight(???) |   |   |

##### 2. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hero |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 1.5f |   |   |
| y |   | 0f |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |

### Cancel Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Idle | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CANCEL | false |
| CONVO CANCEL | false |
| CONVO_FINISH | false |
| DREAM HIT | false |
| FINISHED | false |
| L | false |
| R | false |
| TAKE DAMAGE | false |

