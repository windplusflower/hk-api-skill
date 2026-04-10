# move_stagmap_marker

## Summary

| Field | Value |
| --- | --- |
| FSM Name | move_stagmap_marker |
| GameObject Name | Crossroads |
| GameObject Path | Stag Map/UI List Stag |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 21043 |
| GameObject PathId | 6669 |

## Variables

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Marker Pos | Vector3(0.84, 1.876, -1) | Vector3: Vector3(0.84, 1.876, -1) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Marker | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "StagMapMarker" | "StagMapMarker" | Tag |  |
| store | GameObject Marker | GameObject Marker | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Move

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Marker | OwnerDefault Marker |  |  |
| vector | Vector3 Marker Pos | Vector3 Marker Pos | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Marker | EventTarget(GameObject):Marker |  |  |
| sendEvent | "MARKER UP" | "MARKER UP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Have Map Marker?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Marker | GameObject Marker | Variable |  |
| isNull | Event() | Event() |  |  |
| isNotNull | Event(FINISHED) | Event(FINISHED) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "StagMapMarker" | "StagMapMarker" | Tag |  |
| store | GameObject Marker | GameObject Marker | Variable |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | SELECTED | Have Map Marker? | 0 | 0 | 0 |
| Move | FINISHED | Idle | 0 | 0 | 0 |
| Have Map Marker? | FINISHED | Move | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| SELECTED | Have Map Marker? | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SELECTED | false |

