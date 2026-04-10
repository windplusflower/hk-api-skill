# Initial Scene

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Initial Scene |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets |
| Start State | Init |
| FSM PathId | 266 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Hero Y | 0 | Single: 0 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Flames Collected | 0 | Int32: 0 |
| Flames Required | 0 | Int32: 0 |
| Grimmchild Level | 0 | Int32: 0 |
| Something Cost | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Activated | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Item Name |  | String:  |
| Item Name |  | String:  |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Absorb Pos | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Absorb Effects | [null] | NamedAssetPPtr:  |
| Area Title | [null] | NamedAssetPPtr:  |
| Area Title2 | [null] | NamedAssetPPtr:  |
| Boss | [null] | NamedAssetPPtr:  |
| CamLock Battle | [null] | NamedAssetPPtr:  |
| CamLock Normal | [null] | NamedAssetPPtr:  |
| Dark_room | [null] | NamedAssetPPtr:  |
| Get Flame | Flamebearer Spawn/Get Flame (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) | NamedAssetPPtr: Flamebearer Spawn/Get Flame (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) |
| Get Flash | Flamebearer Spawn/Get Flash (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) | NamedAssetPPtr: Flamebearer Spawn/Get Flash (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) |
| Grimm Hand | [null] | NamedAssetPPtr:  |
| Grimm NPC | Grimm Scene/Grimm NPC (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) | NamedAssetPPtr: Grimm Scene/Grimm NPC (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) |
| Grimm_teleport_effect | [null] | NamedAssetPPtr:  |
| Grimm_teleport_effect2 | Grimm Scene/Grimm_teleport_effect2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) | NamedAssetPPtr: Grimm Scene/Grimm_teleport_effect2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) |
| Grimmchild | [null] | NamedAssetPPtr:  |
| Light Up Flash | [null] | NamedAssetPPtr:  |
| Loop Absorbed | [null] | NamedAssetPPtr:  |
| Loop Drumroll | [null] | NamedAssetPPtr:  |
| Loop Rumble | [null] | NamedAssetPPtr:  |
| Msg | [null] | NamedAssetPPtr:  |
| Msg | [null] | NamedAssetPPtr:  |
| Msg Icon | [null] | NamedAssetPPtr:  |
| Msg Text | [null] | NamedAssetPPtr:  |
| Parent | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Spotlight | Grimm Scene/Spotlight (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) | NamedAssetPPtr: Grimm Scene/Spotlight (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets) |
| Spotlight Appear | [null] | NamedAssetPPtr:  |
| Voice Player | [null] | NamedAssetPPtr:  |
| wide_smoke_back | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitForBossLoad

Full Name: WaitForBossLoad
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | FINISHED | FINISHED |  |  |

##### 3. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "flamesCollected" | "flamesCollected" |  |  |
| storeValue | int Flames Collected | int Flames Collected | Variable |  |

##### 5. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "flamesRequired" | "flamesRequired" |  |  |
| storeValue | int Flames Required | int Flames Required | Variable |  |

##### 6. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "grimmChildLevel" | "grimmChildLevel" |  |  |
| storeValue | int Grimmchild Level | int Grimmchild Level | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Grimm NPC" | "Grimm NPC" |  |  |
| storeResult | [Grimm Scene/Grimm NPC (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm Scene/Grimm NPC (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Spotlight" | "Spotlight" |  |  |
| storeResult | [Grimm Scene/Spotlight (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm Scene/Spotlight (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Grimm_teleport_effect" | "Grimm_teleport_effect" |  |  |
| storeResult | GameObject Grimm_teleport_effect | GameObject Grimm_teleport_effect | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Grimm_teleport_effect2" | "Grimm_teleport_effect2" |  |  |
| storeResult | [Grimm Scene/Grimm_teleport_effect2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm Scene/Grimm_teleport_effect2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Grimm Hand" | "Grimm Hand" |  |  |
| storeResult | GameObject Grimm Hand | GameObject Grimm Hand | Variable |  |

##### 12. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Get Flash" | "Get Flash" |  |  |
| storeResult | [Flamebearer Spawn/Get Flash (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Flamebearer Spawn/Get Flash (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | Variable |  |

##### 13. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Get Flame" | "Get Flame" |  |  |
| storeResult | [Flamebearer Spawn/Get Flame (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Flamebearer Spawn/Get Flame (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | Variable |  |

##### 14. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Dark_room" | "Dark_room" |  |  |
| storeResult | GameObject Dark_room | GameObject Dark_room | Variable |  |

##### 15. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Loop Rumble" | "Loop Rumble" |  |  |
| storeResult | GameObject Loop Rumble | GameObject Loop Rumble | Variable |  |

##### 16. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Loop Drumroll" | "Loop Drumroll" |  |  |
| storeResult | GameObject Loop Drumroll | GameObject Loop Drumroll | Variable |  |

##### 17. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Loop Absorbed" | "Loop Absorbed" |  |  |
| storeResult | GameObject Loop Absorbed | GameObject Loop Absorbed | Variable |  |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "killedGrimm" | "killedGrimm" |  |  |
| isTrue | FINISHED | FINISHED |  |  |
| isFalse |  |  |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "metGrimm" | "metGrimm" |  |  |
| isTrue |  |  |  |  |
| isFalse | UNMET | UNMET |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "equippedCharm_40" | "equippedCharm_40" |  |  |
| isTrue |  |  |  |  |
| isFalse | FINISHED | FINISHED |  |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Flames Collected | int Flames Collected |  |  |
| integer2 | int Flames Required | int Flames Required |  |  |
| equal |  |  |  |  |
| lessThan | FINISHED | FINISHED |  |  |
| greaterThan | FINISHED | FINISHED |  |  |
| everyFrame | false | false |  |  |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Grimmchild Level | int Grimmchild Level |  |  |
| integer2 | 1 | 1 |  |  |
| equal | FIRST UPGRADE | FIRST UPGRADE |  |  |
| lessThan |  |  |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

##### 6. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Grimmchild Level | int Grimmchild Level |  |  |
| integer2 | 2 | 2 |  |  |
| equal | FIRST BATTLE | FIRST BATTLE |  |  |
| lessThan |  |  |  |  |
| greaterThan |  |  |  |  |
| everyFrame | false | false |  |  |

### Meet Ready

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

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
| storeCollider |  |  | Variable |  |

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "Spotlight Appear" | "Spotlight Appear" |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| store | GameObject Spotlight Appear | GameObject Spotlight Appear | Variable |  |

### Take Control

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
| sendEvent | "ACCORDION END" | "ACCORDION END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hero | EventTarget(GameObject):Hero |  |  |
| sendEvent | "FSM CANCEL" | "FSM CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Canvas | EventTarget(GameObject):HUD Canvas |  |  |
| sendEvent | "OUT" | "OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControl(???) | RelinquishControl(???) |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StartAnimationControl(???) | StartAnimationControl(???) |  |  |

##### 6. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

##### 7. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Hero Y | float Hero Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 9. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero Y | float Hero Y |  |  |
| float2 | 6.64f | 6.64f |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan | LAND | LAND |  |  |
| greaterThan |  |  |  |  |
| everyFrame | true | true |  |  |

##### 10. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | AffectedByGravity(true) | AffectedByGravity(true) |  |  |

##### 11. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "isInvincible" | "isInvincible" |  |  |
| value | true | true |  |  |

### Appear Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.5f | 1.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

### Spotlights Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.5f | 2.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Spotlight | EventTarget(GameObject)[SendToChildren]:Spotlight |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Grimm Appear

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 5f | 5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault CameraParent | OwnerDefault CameraParent |  |  |
| fsmName | "CameraShake" | "CameraShake" | FsmName |  |
| variableName | "RumblingSmall" | "RumblingSmall" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Spotlight | EventTarget(GameObject)[SendToChildren]:Spotlight |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookUp" | "LookUp" |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm_teleport_effect | OwnerDefault Grimm_teleport_effect |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "TeleToIdle" | "TeleToIdle" |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX UP" | "BOX UP" |  |  |
| delay | 4.7f | 4.7f |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Drumroll | OwnerDefault Loop Drumroll |  |  |

##### 11. AudioStop

Full Name: HutongGames.PlayMaker.Actions.AudioStop
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Rumble | OwnerDefault Loop Rumble |  |  |

### Meet 1

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

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueText | OwnerDefault DialogueText |  |  |
| fsmName | "Dialogue Page Control" | "Dialogue Page Control" | FsmName |  |
| variableName | "Use Stop" | "Use Stop" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "metBrum" | "metBrum" |  |  |
| value | true | true |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_talk_02 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_talk_02 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Meet 2

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

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueText | OwnerDefault DialogueText |  |  |
| fsmName | "Dialogue Page Control" | "Dialogue Page Control" | FsmName |  |
| variableName | "Use Stop" | "Use Stop" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookBack" | "LookBack" |  |  |

##### 4. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Area Title2 | GameObject Area Title2 | Variable |  |
| gameObject | [Global] GameObject AreaTitle | [Global] GameObject AreaTitle |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "NPC Title" | "NPC Title" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "Display Right" | "Display Right" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 8. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "Area Event" | "Area Event" | FsmString |  |
| setValue | "GRIMM" | "GRIMM" |  |  |
| everyFrame | false | false |  |  |

### End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RegainControl(???) | RegainControl(???) |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "isInvincible" | "isInvincible" |  |  |
| value | false | false |  |  |

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StartAnimationControl(???) | StartAnimationControl(???) |  |  |

##### 4. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | false | false |  |  |

##### 5. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "metGrimm" | "metGrimm" |  |  |
| value | true | true |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "ACCORDION START" | "ACCORDION START" |  |  |
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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookUpEnd" | "LookUpEnd" |  |  |

### Absent

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Accept

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

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_talk_03 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_talk_03 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Box Up 3

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Bow" | "Bow" |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [hornet_jump (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hornet_jump (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Get Charm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "gotCharm_40" | "gotCharm_40" |  |  |
| value | true | true |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasCharm" | "hasCharm" |  |  |
| value | true | true |  |  |

##### 3. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Item Get Effect (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets7.assets)] | [Global] [Item Get Effect (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets7.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| position | Vector3(0, -0.76, -1) | Vector3(0, -0.76, -1) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject |  |  | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 4. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Charm Get Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [Global] [Charm Get Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Msg | GameObject Msg | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg | OwnerDefault Msg |  |  |
| fsmName | "Charm Msg" | "Charm Msg" | FsmName |  |
| variableName | "ID" | "ID" | FsmInt |  |
| setValue | 40 | 40 |  |  |
| everyFrame | false | false |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 7. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [shiny_item_pickup (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [shiny_item_pickup (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 0.9f | 0.9f |  |  |
| pitchMax | 0.9f | 0.9f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Box Up 4

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

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "TALK START" | "TALK START" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Bow Return" | "Bow Return" |  |  |

### Ritual Complete

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

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_talk_05 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_talk_05 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Spotlight Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 4.5f | 4.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Spotlight Appear | OwnerDefault Spotlight Appear |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Spotlight Appear | GameObject Spotlight Appear | Variable |  |
| activate | true | true |  |  |

##### 5. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Roar Lock" | "Roar Lock" |  |  |

##### 6. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Drumroll | OwnerDefault Loop Drumroll |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

##### 7. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Rumble | OwnerDefault Loop Rumble |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

##### 8. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault CameraParent | OwnerDefault CameraParent |  |  |
| fsmName | "CameraShake" | "CameraShake" | FsmName |  |
| variableName | "RumblingSmall" | "RumblingSmall" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Tele Out Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| clipName | "Tele Out" | "Tele Out" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent | FINISHED | FINISHED |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [grimm_teleport_out (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [grimm_teleport_out (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Tele Poof

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm_teleport_effect2 | OwnerDefault Grimm_teleport_effect2 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Spotlight | EventTarget(GameObject)[SendToChildren]:Spotlight |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| active | false | false |  |  |

### 1st Ready

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

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
| storeCollider |  |  | Variable |  |

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "Spotlight Appear" | "Spotlight Appear" |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| store | GameObject Spotlight Appear | GameObject Spotlight Appear | Variable |  |

### Take Control 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hero | EventTarget(GameObject):Hero |  |  |
| sendEvent | "FSM CANCEL" | "FSM CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "ACCORDION END" | "ACCORDION END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "Grimmchild" | "Grimmchild" | Tag |  |
| store | GameObject Grimmchild | GameObject Grimmchild | Variable |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Canvas | EventTarget(GameObject):HUD Canvas |  |  |
| sendEvent | "OUT" | "OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControl(???) | RelinquishControl(???) |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StartAnimationControl(???) | StartAnimationControl(???) |  |  |

##### 7. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

##### 8. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Hero Y | float Hero Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 10. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero Y | float Hero Y |  |  |
| float2 | 6.64f | 6.64f |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan | LAND | LAND |  |  |
| greaterThan |  |  |  |  |
| everyFrame | true | true |  |  |

##### 11. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | AffectedByGravity(true) | AffectedByGravity(true) |  |  |

##### 12. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "isInvincible" | "isInvincible" |  |  |
| value | true | true |  |  |

### Appear Pause 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.25f | 1.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

### Grimm Appear 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3f | 3f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Spotlight | EventTarget(GameObject)[SendToChildren]:Spotlight |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookUp" | "LookUp" |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm_teleport_effect | OwnerDefault Grimm_teleport_effect |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "TeleToIdle" | "TeleToIdle" |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX UP" | "BOX UP" |  |  |
| delay | 2.7f | 2.7f |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Levelup 1

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

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Area Title2 | GameObject Area Title2 | Variable |  |
| gameObject | [Global] GameObject AreaTitle | [Global] GameObject AreaTitle |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "NPC Title" | "NPC Title" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "Display Right" | "Display Right" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "Area Event" | "Area Event" | FsmString |  |
| setValue | "GRIMM" | "GRIMM" |  |  |
| everyFrame | false | false |  |  |

##### 7. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_talk_02 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_talk_02 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Levelup 2

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

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookBack" | "LookBack" |  |  |

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
| sendEvent | "BOX DOWN NO HUD" | "BOX DOWN NO HUD" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.3f | 0.3f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Hand Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hand Out" | "Hand Out" |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.75f | 1.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Click

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hand Click" | "Hand Click" |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_click (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_click (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Level Up To 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

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

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [nightmare_lantern_flame_burst (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [nightmare_lantern_flame_burst (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 4. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flash | OwnerDefault Get Flash |  |  |
| parent | GameObject Grimmchild | GameObject Grimmchild |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flash | OwnerDefault Get Flash |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. SetPositionToObject

Full Name: HutongGames.PlayMaker.Actions.SetPositionToObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flash | OwnerDefault Get Flash |  |  |
| targetObject | GameObject Grimmchild | GameObject Grimmchild |  |  |
| xOffset | 0f | 0f |  |  |
| yOffset | 0f | 0f |  |  |
| zOffset | 0f | 0f |  |  |

##### 7. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flash | OwnerDefault Get Flash |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 8. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | "grimmChildLevel" | "grimmChildLevel" |  |  |
| value | 2 | 2 |  |  |

##### 9. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | "flamesCollected" | "flamesCollected" |  |  |
| value | 0 | 0 |  |  |

##### 10. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | "flamesRequired" | "flamesRequired" |  |  |
| value | 3 | 3 |  |  |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Grimmchild | EventTarget(GameObject):Grimmchild |  |  |
| sendEvent | "LEVEL UP" | "LEVEL UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 12. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
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

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flame | OwnerDefault Get Flame |  |  |
| fsmName | "Follow Grimmchild" | "Follow Grimmchild" | FsmName |  |
| variableName | "Grimmchild" | "Grimmchild" | FsmGameObject |  |
| setValue | GameObject Grimmchild | GameObject Grimmchild |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Flame | OwnerDefault Get Flame |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

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
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [nightmare_lantern_powering_up (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [nightmare_lantern_powering_up (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Box Up 5

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hand In" | "Hand In" |  |  |

### Levelup 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault DialogueText | OwnerDefault DialogueText |  |  |
| behaviour | "DialogueBox" | "DialogueBox" | Behaviour |  |
| methodName | "StartConversation" | "StartConversation" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_talk_06 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_talk_06 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Battle Ready

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
| boolName | "killedGrimm" | "killedGrimm" |  |  |
| isTrue | KILLED | KILLED |  |  |
| isFalse |  |  |  |  |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |  |  |
| collideTag | "" | "" | Tag |  |
| collideLayer | "" | "" | Layer |  |
| sendEvent | ENTER | ENTER |  |  |
| storeCollider |  |  | Variable |  |

##### 3. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "Spotlight Appear" | "Spotlight Appear" |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| store | GameObject Spotlight Appear | GameObject Spotlight Appear | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "CamLock Battle" | "CamLock Battle" |  |  |
| storeResult | GameObject CamLock Battle | GameObject CamLock Battle | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "CamLock Normal" | "CamLock Normal" |  |  |
| storeResult | GameObject CamLock Normal | GameObject CamLock Normal | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "wide_smoke_back" | "wide_smoke_back" |  |  |
| storeResult | GameObject wide_smoke_back | GameObject wide_smoke_back | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Absorb Effects" | "Absorb Effects" |  |  |
| storeResult | GameObject Absorb Effects | GameObject Absorb Effects | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Light Up Flash" | "Light Up Flash" |  |  |
| storeResult | GameObject Light Up Flash | GameObject Light Up Flash | Variable |  |

##### 9. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Parent | GameObject Parent | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Parent | OwnerDefault Parent |  |  |
| childName | "Grimm Boss" | "Grimm Boss" |  |  |
| storeResult | GameObject Boss | GameObject Boss | Variable |  |

##### 11. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "Grimm Boss" | "Grimm Boss" |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| store | GameObject Boss | GameObject Boss | Variable |  |

##### 12. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Boss | OwnerDefault Boss |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 13. PreSpawnCorpse

Full Name: PreSpawnCorpse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Boss | OwnerDefault Boss | Variable |  |

##### 14. SetBoxCollider2DSize

Full Name: HutongGames.PlayMaker.Actions.SetBoxCollider2DSize
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject1 | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| width | 0f | 0f |  |  |
| height | 0f | 0f |  |  |
| offsetX | 2f | 2f |  |  |
| offsetY | 0f | 0f |  |  |

### Take Control 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hero | EventTarget(GameObject):Hero |  |  |
| sendEvent | "FSM CANCEL" | "FSM CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "ACCORDION END" | "ACCORDION END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "Grimmchild" | "Grimmchild" | Tag |  |
| store | GameObject Grimmchild | GameObject Grimmchild | Variable |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Canvas | EventTarget(GameObject):HUD Canvas |  |  |
| sendEvent | "OUT" | "OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RelinquishControl(???) | RelinquishControl(???) |  |  |

##### 6. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StartAnimationControl(???) | StartAnimationControl(???) |  |  |

##### 7. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "isInvincible" | "isInvincible" |  |  |
| value | true | true |  |  |

##### 8. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

##### 9. SetVelocity2d

Full Name: HutongGames.PlayMaker.Actions.SetVelocity2d
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector2(0, 0) | Vector2(0, 0) |  |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f | Variable |  |
| y | float Hero Y | float Hero Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | true | true |  |  |

##### 11. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero Y | float Hero Y |  |  |
| float2 | 6.64f | 6.64f |  |  |
| tolerance | 0f | 0f |  |  |
| equal |  |  |  |  |
| lessThan | LAND | LAND |  |  |
| greaterThan |  |  |  |  |
| everyFrame | true | true |  |  |

##### 12. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | AffectedByGravity(true) | AffectedByGravity(true) |  |  |

### Appear Pause 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.25f | 1.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

### Grimm Appear 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3f | 3f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Spotlight | EventTarget(GameObject)[SendToChildren]:Spotlight |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookUp" | "LookUp" |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm_teleport_effect | OwnerDefault Grimm_teleport_effect |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "TeleToIdle" | "TeleToIdle" |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX UP" | "BOX UP" |  |  |
| delay | 2.7f | 2.7f |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Battle Convo 1

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

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_talk_05 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_talk_05 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Battle Convo 2

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

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookBack" | "LookBack" |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "BG CLOSE" | "BG CLOSE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_talk_03 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_talk_03 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Box Down 4

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
| sendEvent | "BOX DOWN NO HUD" | "BOX DOWN NO HUD" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.25f | 2.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookBack" | "LookBack" |  |  |

##### 4. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Absorbed | OwnerDefault Loop Absorbed |  |  |
| startVolume | 1f | 1f |  |  |
| endVolume | 0f | 0f |  |  |
| time | 1f | 1f |  |  |

### Lights Up

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
| sendEvent | "LIGHTS UP" | "LIGHTS UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Spotlight | EventTarget(GameObject)[SendToChildren]:Spotlight |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Dark_room | EventTarget(GameObject)[SendToChildren]:Dark_room |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault CamLock Battle | OwnerDefault CamLock Battle |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Light Up Flash | OwnerDefault Light Up Flash |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault wide_smoke_back | OwnerDefault wide_smoke_back |  |  |
| emit | 0 | 0 |  |  |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Parent | EventTarget(GameObject)[SendToChildren]:Parent |  |  |
| sendEvent | "BG CLOSE" | "BG CLOSE" |  |  |
| delay | 0.9f | 0.9f |  |  |
| everyFrame | false | false |  |  |

##### 10. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [flamebearer_dash_dash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_dash_dash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Battle Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "foughtGrimm" | "foughtGrimm" |  |  |
| value | true | true |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "isInvincible" | "isInvincible" |  |  |
| value | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Canvas | EventTarget(GameObject):HUD Canvas |  |  |
| sendEvent | "IN" | "IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | RegainControl(???) | RegainControl(???) |  |  |

##### 5. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StartAnimationControl(???) | StartAnimationControl(???) |  |  |

##### 6. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | false | false |  |  |

##### 7. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "metGrimm" | "metGrimm" |  |  |
| value | true | true |  |  |

##### 8. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Area Title2 | GameObject Area Title2 | Variable |  |
| gameObject | [Global] GameObject AreaTitle | [Global] GameObject AreaTitle |  |  |
| everyFrame | false | false |  |  |

##### 9. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 10. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "Display Right" | "Display Right" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "Visited" | "Visited" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 12. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Area Title2 | OwnerDefault Area Title2 |  |  |
| fsmName | "" | "" | FsmName |  |
| variableName | "Area Event" | "Area Event" | FsmString |  |
| setValue | "GRIMM" | "GRIMM" |  |  |
| everyFrame | false | false |  |  |

##### 13. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Boss | OwnerDefault Boss |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 14. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Box Up 6

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hand In" | "Hand In" |  |  |

### Battle Convo 3

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

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_talk_06 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_talk_06 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Box Down 5

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookUpEnd" | "LookUpEnd" |  |  |

### Absorb Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| vector | Vector3 Absorb Pos | Vector3 Absorb Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmVector3

Full Name: HutongGames.PlayMaker.Actions.SetFsmVector3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimmchild | OwnerDefault Grimmchild |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Absorb Pos" | "Absorb Pos" | FsmVector3 |  |
| setValue | Vector3 Absorb Pos | Vector3 Absorb Pos |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Absorb Start" | "Absorb Start" |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [grimm_cape_open_for_cast (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [grimm_cape_open_for_cast (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Box Down 6

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
| sendEvent | "BOX DOWN NO HUD" | "BOX DOWN NO HUD" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Call Child

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
| sendEvent | "ABSORB" | "ABSORB" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [hornet_jump (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hornet_jump (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Absorb End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| clipName | "Absorb" | "Absorb" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent |  |  |  |  |

##### 2. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Absorb Effects | GameObject Absorb Effects | Variable |  |
| activate | true | true |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [flamebearer_fire_spiral_cast (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_fire_spiral_cast (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 6. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [ghost_dialogue_death_explode (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [ghost_dialogue_death_explode (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 7. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Absorbed | OwnerDefault Loop Absorbed |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

### Box Up 7

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookBack" | "LookBack" |  |  |

### Look Back

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Absorb End" | "Absorb End" |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Hand Out 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hand Out" | "Hand Out" |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Click 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hand Click" | "Hand Click" |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_click (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_click (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Refight?

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
| boolName | "foughtGrimm" | "foughtGrimm" |  |  |
| isTrue | REFIGHT | REFIGHT |  |  |
| isFalse |  |  |  |  |

### Appear Pause 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StopAnimationControl(???) | StopAnimationControl(???) |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

### Grimm Appear 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3f | 3f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Idle" | "Idle" |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Spotlight | EventTarget(GameObject)[SendToChildren]:Spotlight |  |  |
| sendEvent | "UP" | "UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookUp" | "LookUp" |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm_teleport_effect | OwnerDefault Grimm_teleport_effect |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "TeleToIdle" | "TeleToIdle" |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):DialogueManager | EventTarget(GameObject):DialogueManager |  |  |
| sendEvent | "BOX UP" | "BOX UP" |  |  |
| delay | 2.7f | 2.7f |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Lights Up 2

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
| sendEvent | "LIGHTS UP" | "LIGHTS UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Spotlight | EventTarget(GameObject)[SendToChildren]:Spotlight |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Dark_room | EventTarget(GameObject)[SendToChildren]:Dark_room |  |  |
| sendEvent | "DOWN" | "DOWN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault CamLock Battle | OwnerDefault CamLock Battle |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Light Up Flash | OwnerDefault Light Up Flash |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [flamebearer_dash_dash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_dash_dash (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 7. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 8. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault wide_smoke_back | OwnerDefault wide_smoke_back |  |  |
| emit | 0 | 0 |  |  |

##### 9. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:Parent | EventTarget(GameObject)[SendToChildren]:Parent |  |  |
| sendEvent | "BG CLOSE" | "BG CLOSE" |  |  |
| delay | 0.9f | 0.9f |  |  |
| everyFrame | false | false |  |  |

### Box Up 8

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hand In" | "Hand In" |  |  |

### Battle Convo 6

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

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Box Down 8

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| animLibName | "" | "" |  |  |
| clipName | "LookUpEnd" | "LookUpEnd" |  |  |

### Absorb Start 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| vector | Vector3 Absorb Pos | Vector3 Absorb Pos | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmVector3

Full Name: HutongGames.PlayMaker.Actions.SetFsmVector3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimmchild | OwnerDefault Grimmchild |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Absorb Pos" | "Absorb Pos" | FsmVector3 |  |
| setValue | Vector3 Absorb Pos | Vector3 Absorb Pos |  |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Absorb Start" | "Absorb Start" |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [grimm_cape_open_for_cast (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [grimm_cape_open_for_cast (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Box Down 9

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
| sendEvent | "BOX DOWN NO HUD" | "BOX DOWN NO HUD" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Call Child 2

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
| sendEvent | "ABSORB" | "ABSORB" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [hornet_jump (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [hornet_jump (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Absorb End 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| clipName | "Absorb" | "Absorb" |  |  |
| animationTriggerEvent |  |  |  |  |
| animationCompleteEvent |  |  |  |  |

##### 2. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Absorb Effects | GameObject Absorb Effects | Variable |  |
| activate | true | true |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.5f | 1.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [flamebearer_fire_spiral_cast (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [flamebearer_fire_spiral_cast (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 6. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [ghost_dialogue_death_explode (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [ghost_dialogue_death_explode (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 7. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Absorbed | OwnerDefault Loop Absorbed |  |  |
| volume | 1f | 1f |  |  |
| oneShotClip | [] | [] |  |  |

### Look Back 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm NPC | OwnerDefault Grimm NPC |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Absorb End" | "Absorb End" |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. FadeAudio

Full Name: HutongGames.PlayMaker.Actions.FadeAudio
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Loop Absorbed | OwnerDefault Loop Absorbed |  |  |
| startVolume | 1f | 1f |  |  |
| endVolume | 0f | 0f |  |  |
| time | 0.5f | 0.5f |  |  |

### Hand Out 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hand Out" | "Hand Out" |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.75f | 0.75f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Click 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Grimm Hand | OwnerDefault Grimm Hand |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Hand Click" | "Hand Click" |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [Grimm_click (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] | [Grimm_click (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets391.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Already Killed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Tele SFX

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
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [grimm_explode_into_bats (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [grimm_explode_into_bats (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Sting

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor 2D (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [accordion_sting_02 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets236.assets)] | [accordion_sting_02 (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets236.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 5.25f | 5.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Tele SFX 2

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
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [grimm_explode_into_bats (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [grimm_explode_into_bats (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Tele SFX 3

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
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [grimm_explode_into_bats (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [grimm_explode_into_bats (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Tele SFX 4

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
| spawnPoint | [Global] GameObject Hero | [Global] GameObject Hero |  |  |
| audioClip | [grimm_explode_into_bats (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] | [grimm_explode_into_bats (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets6.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Check | 0 | 0 | 0 |
| Check | FINISHED | Absent | 0 | 0 | 0 |
| Check | UNMET | Meet Ready | 0 | 0 | 0 |
| Check | FIRST UPGRADE | 1st Ready | 0 | 0 | 0 |
| Check | FIRST BATTLE | Battle Ready | 0 | 0 | 0 |
| Meet Ready | ENTER | Take Control | 0 | 0 | 0 |
| Take Control | LAND | Appear Pause | 0 | 0 | 0 |
| Appear Pause | FINISHED | Spotlight Anim | 0 | 0 | 0 |
| Spotlights Up | FINISHED | Grimm Appear | 0 | 0 | 0 |
| Grimm Appear | FINISHED | Meet 1 | 0 | 0 | 0 |
| Meet 1 | CONVO_FINISH | Meet 2 | 0 | 0 | 0 |
| Meet 2 | CONVO_FINISH | Box Up 3 | 0 | 0 | 0 |
| Box Down | FINISHED | Tele Out Anim | 0 | 0 | 0 |
| Accept | CONVO_FINISH | Box Down 3 | 0 | 0 | 0 |
| Box Up 3 | FINISHED | Accept | 0 | 0 | 0 |
| Box Down 3 | FINISHED | Get Charm | 0 | 0 | 0 |
| Get Charm | FINISHED | Box Up 4 | 0 | 0 | 0 |
| Box Up 4 | FINISHED | Ritual Complete | 0 | 0 | 0 |
| Ritual Complete | CONVO_FINISH | Box Down | 0 | 0 | 0 |
| Spotlight Anim | FINISHED | Sting | 0 | 0 | 0 |
| Tele Out Anim | FINISHED | Tele Poof | 0 | 0 | 0 |
| Tele Poof | FINISHED | End | 0 | 0 | 0 |
| 1st Ready | ENTER | Take Control 2 | 0 | 0 | 0 |
| Take Control 2 | LAND | Appear Pause 2 | 0 | 0 | 0 |
| Appear Pause 2 | FINISHED | Tele SFX 2 | 0 | 0 | 0 |
| Grimm Appear 2 | FINISHED | Levelup 1 | 0 | 0 | 0 |
| Levelup 1 | CONVO_FINISH | Levelup 2 | 0 | 0 | 0 |
| Levelup 2 | CONVO_FINISH | Box Down 2 | 0 | 0 | 0 |
| Box Down 2 | FINISHED | Hand Out | 0 | 0 | 0 |
| Hand Out | FINISHED | Click | 0 | 0 | 0 |
| Click | FINISHED | Flame Ring | 0 | 0 | 0 |
| Level Up To 2 | FINISHED | Box Up 5 | 0 | 0 | 0 |
| Flame Ring | FINISHED | Level Up To 2 | 0 | 0 | 0 |
| Box Up 5 | FINISHED | Levelup 3 | 0 | 0 | 0 |
| Levelup 3 | CONVO_FINISH | Box Down | 0 | 0 | 0 |
| Battle Ready | ENTER | Take Control 3 | 0 | 0 | 0 |
| Battle Ready | KILLED | Already Killed | 0 | 0 | 0 |
| Take Control 3 | LAND | Refight? | 0 | 0 | 0 |
| Appear Pause 3 | FINISHED | Tele SFX 3 | 0 | 0 | 0 |
| Grimm Appear 3 | FINISHED | Battle Convo 1 | 0 | 0 | 0 |
| Battle Convo 1 | CONVO_FINISH | Box Down 6 | 0 | 0 | 0 |
| Battle Convo 2 | CONVO_FINISH | Box Down 4 | 0 | 0 | 0 |
| Box Down 4 | FINISHED | Hand Out 2 | 0 | 0 | 0 |
| Lights Up | FINISHED | Box Up 6 | 0 | 0 | 0 |
| Box Up 6 | FINISHED | Battle Convo 3 | 0 | 0 | 0 |
| Battle Convo 3 | CONVO_FINISH | Box Down 5 | 0 | 0 | 0 |
| Box Down 5 | FINISHED | Battle Start | 0 | 0 | 0 |
| Absorb Start | FINISHED | Call Child | 0 | 0 | 0 |
| Box Down 6 | FINISHED | Absorb Start | 0 | 0 | 0 |
| Call Child | ABSORB END | Absorb End | 0 | 0 | 0 |
| Absorb End | FINISHED | Box Up 7 | 0 | 0 | 0 |
| Box Up 7 | FINISHED | Battle Convo 2 | 0 | 0 | 0 |
| Look Back | FINISHED | Hand Out 2 | 0 | 0 | 0 |
| Hand Out 2 | FINISHED | Click 2 | 0 | 0 | 0 |
| Click 2 | FINISHED | Lights Up | 0 | 0 | 0 |
| Refight? | FINISHED | Appear Pause 3 | 0 | 0 | 0 |
| Refight? | REFIGHT | Appear Pause 4 | 0 | 0 | 0 |
| Appear Pause 4 | FINISHED | Tele SFX 4 | 0 | 0 | 0 |
| Grimm Appear 4 | FINISHED | Absorb Start 2 | 0 | 0 | 0 |
| Lights Up 2 | FINISHED | Battle Start | 0 | 0 | 0 |
| Box Up 8 | FINISHED | Battle Convo 6 | 0 | 0 | 0 |
| Battle Convo 6 | CONVO_FINISH | Box Down 8 | 0 | 0 | 0 |
| Box Down 8 | FINISHED | Battle Start | 0 | 0 | 0 |
| Absorb Start 2 | FINISHED | Call Child 2 | 0 | 0 | 0 |
| Box Down 9 | FINISHED | Absorb Start 2 | 0 | 0 | 0 |
| Call Child 2 | ABSORB END | Absorb End 2 | 0 | 0 | 0 |
| Absorb End 2 | FINISHED | Look Back 2 | 0 | 0 | 0 |
| Look Back 2 | FINISHED | Lights Up 2 | 0 | 0 | 0 |
| Hand Out 3 | FINISHED | Click 3 | 0 | 0 | 0 |
| Click 3 | FINISHED | Lights Up 2 | 0 | 0 | 0 |
| Tele SFX | FINISHED | Grimm Appear | 0 | 0 | 0 |
| Sting | FINISHED | Tele SFX | 0 | 0 | 0 |
| Tele SFX 2 | FINISHED | Grimm Appear 2 | 0 | 0 | 0 |
| Tele SFX 3 | FINISHED | Grimm Appear 3 | 0 | 0 | 0 |
| Tele SFX 4 | FINISHED | Grimm Appear 4 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ABSENT | false |
| ABSORB END | false |
| CONVO_FINISH | false |
| ENTER | false |
| FIRST BATTLE | false |
| FIRST UPGRADE | false |
| INACTIVE | false |
| KILLED | false |
| LAND | false |
| MET | false |
| NO | false |
| REFIGHT | false |
| UNMET | false |
| YES | false |

