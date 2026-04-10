# Open Stag

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Open Stag |
| GameObject Name | Menus |
| GameObject Path | _GameCameras/HudCamera |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 23034 |
| GameObject PathId | 5131 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Menu | [null] | NamedAssetPPtr:  |
| Requester | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Open

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Menu | OwnerDefault Menu |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Stag Map (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Stag Map (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0.03, 0.03, 35.35) | Vector3(0.03, 0.03, 35.35) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Menu | GameObject Menu | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Menu | OwnerDefault Menu |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Menu | OwnerDefault Menu |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0.3f | 0.3f |  |  |
| y | 0.3f | 0.3f |  |  |
| z | 35.35f | 35.35f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 5. SetFsmGameObject

Full Name: HutongGames.PlayMaker.Actions.SetFsmGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Menu | OwnerDefault Menu |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Requester" | "Requester" | FsmGameObject |  |
| setValue | GameObject Requester | GameObject Requester |  |  |
| everyFrame | false | false |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Stag Map" | "Stag Map" |  |  |
| storeResult | GameObject Menu | GameObject Menu | Variable |  |

##### 2. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

### Spawn Stag Map

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CreateObject

Full Name: HutongGames.PlayMaker.Actions.CreateObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Stag Map (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Stag Map (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0.03, 0.03, 35.35) | Vector3(0.03, 0.03, 35.35) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Menu | GameObject Menu | Variable |  |
| networkInstantiate | false | false |  |  |
| networkGroup | 0 | 0 |  |  |

##### 2. SetTransformParent

Full Name: HutongGames.PlayMaker.Actions.SetTransformParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Menu | OwnerDefault Menu |  |  |
| parent | GameObject Self | GameObject Self |  |  |
| worldPositionStays | true | true |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Menu | OwnerDefault Menu |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Inert

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Destroy Map

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Menu | GameObject Menu |  |  |
| delay | 0f | 0f |  |  |
| detachChildren | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | OPEN STAG MENU | Open | 0 | 0 | 0 |
| Open | FINISHED | Idle | 0 | 0 | 0 |
| Init | FINISHED | Inert | 0 | 0 | 0 |
| Spawn Stag Map | FINISHED | Idle | 0 | 0 | 0 |
| Destroy Map | FINISHED | Inert | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| SPAWN | Spawn Stag Map | 0 | 0 | 0 |
| DESPAWN | Destroy Map | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| DESPAWN | true |
| OPEN STAG MENU | false |
| SPAWN | true |

