# enemy_dreamnail_reaction

## Summary

| Field | Value |
| --- | --- |
| FSM Name | enemy_dreamnail_reaction |
| GameObject Name | Grub Mimic Top |
| GameObject Path | Grub Mimic Bottle Col |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets33.assets |
| Start State | Init |
| FSM PathId | 956 |
| GameObject PathId | 237 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| X Scale | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Convo Amount | 3 | Int32: 3 |
| MP Charge | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Start Inactive | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Convo Title | GRUB_MIMIC | String: GRUB_MIMIC |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Collider | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Start Inactive | bool Start Inactive | Variable |  |
| isTrue | Event(INACTIVE) | Event(INACTIVE) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "Dream Attack" | "Dream Attack" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | Event(DREAM IMPACT) | Event(DREAM IMPACT) |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

##### 2. Trigger2dEventLayer

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEventLayer
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "Dream Attack" | "Dream Attack" | Tag |  |
| collideLayer | 17 | 17 | Layer |  |
| sendEvent | Event(DREAM IMPACT) | Event(DREAM IMPACT) |  |  |
| storeCollider | GameObject Collider | GameObject Collider | Variable |  |

### Get Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "recoil" | "recoil" | FsmName |  |
| variableName | "Attack Magnitude" | "Attack Magnitude" | FsmFloat |  |
| setValue | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 2. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Dream Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Dream Impact (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | flashDreamImpact(???) | flashDreamImpact(???) |  |  |

##### 4. SendEventByScale

Full Name: HutongGames.PlayMaker.Actions.SendEventByScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| xScale | true | true |  |  |
| positiveEvent | Event(L) | Event(L) |  |  |
| negativeEvent | Event(R) | Event(R) |  |  |
| space | UnityEngine.Space::World | 0 |  |  |

### Recoil L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "recoil" | "recoil" | FsmName |  |
| variableName | "Attack Direction" | "Attack Direction" | FsmFloat |  |
| setValue | 180f | 180f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "RECOIL L" | "RECOIL L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Recoil R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "recoil" | "recoil" | FsmName |  |
| variableName | "Attack Direction" | "Attack Direction" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "RECOIL R" | "RECOIL R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Recoil

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.2f | 0.2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Get Soul

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessageV2

Full Name: HutongGames.PlayMaker.Actions.SendMessageV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessageV2/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | AddMPCharge(MP Charge=int MP Charge) | AddMPCharge(MP Charge=int MP Charge) |  |  |
| everyFrame | false | false |  |  |

### Set SP

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int MP Charge | int MP Charge | Variable |  |
| intValue | 33 | 33 |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_30" | "equippedCharm_30" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int MP Charge | int MP Charge | Variable |  |
| intValue | 66 | 66 |  |  |
| everyFrame | false | false |  |  |

### Send Msg

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Dream Msg | OwnerDefault Enemy Dream Msg |  |  |
| fsmName | "Display" | "Display" | FsmName |  |
| variableName | "Convo Amount" | "Convo Amount" | FsmInt |  |
| setValue | int Convo Amount | int Convo Amount |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy Dream Msg | OwnerDefault Enemy Dream Msg |  |  |
| fsmName | "Display" | "Display" | FsmName |  |
| variableName | "Convo Title" | "Convo Title" | FsmString |  |
| setValue | string Convo Title | string Convo Title |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Enemy Dream Msg | EventTarget(GameObject):Enemy Dream Msg |  |  |
| sendEvent | "DISPLAY ENEMY DREAM" | "DISPLAY ENEMY DREAM" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Init | INACTIVE | Inactive | 0 | 0 | 0 |
| Idle | DREAM IMPACT | Set SP | 0 | 0 | 0 |
| Get Hit | L | Recoil L | 0 | 0 | 0 |
| Get Hit | R | Recoil R | 0 | 0 | 0 |
| Recoil L | FINISHED | Recoil | 0 | 0 | 0 |
| Recoil R | FINISHED | Recoil | 0 | 0 | 0 |
| Recoil | FINISHED | Idle | 0 | 0 | 0 |
| Get Soul | FINISHED | Send Msg | 0 | 0 | 0 |
| Set SP | FINISHED | Get Soul | 0 | 0 | 0 |
| Send Msg | FINISHED | Get Hit | 0 | 0 | 0 |
| Inactive | DREAM REACTION ACTIVE | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| DREAM IMPACT | false |
| DREAM REACTION ACTIVE | false |
| INACTIVE | false |
| L | false |
| LEFT | false |
| R | false |
| RIGHT | false |

