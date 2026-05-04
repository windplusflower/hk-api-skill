# UI List Stag

## Summary

| Field | Value |
| --- | --- |
| FSM Name | UI List Stag |
| GameObject Name | UI List Stag |
| GameObject Path | Stag Map/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level107 |
| Start State | Init |
| FSM PathId | 1911 |
| GameObject PathId | 443 |

## Variables

### Arrays

| Name | Value | Raw/Type |
| --- | --- | --- |
| NamesArray | Array NamesArray | FsmArray: Array NamesArray |

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Knight Icon TransY | 0 | Single: 0 |
| Space to move up | 1 | Single: 1 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Initial Item | 0 | Int32: 0 |
| Items | 11 | Int32: 11 |
| Max Items | 0 | Int32: 0 |
| Stag Position | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| City 1 | [null] | NamedAssetPPtr: [null] |
| Crossroads | [null] | NamedAssetPPtr: [null] |
| Deepnest | [null] | NamedAssetPPtr: [null] |
| Dirtmouth | [null] | NamedAssetPPtr: [null] |
| Fungal Wastes | [null] | NamedAssetPPtr: [null] |
| Greenpath | [null] | NamedAssetPPtr: [null] |
| Hidden Station | [null] | NamedAssetPPtr: [null] |
| Kings Station | [null] | NamedAssetPPtr: [null] |
| Knight Icon | [null] | NamedAssetPPtr: [null] |
| Resting Grounds | [null] | NamedAssetPPtr: [null] |
| Royal Gardens | [null] | NamedAssetPPtr: [null] |
| Stag Nest | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "City Storerooms" |   |   |
| storeResult |   | GameObject City 1 | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Crossroads" |   |   |
| storeResult |   | GameObject Crossroads | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Dirtmouth" |   |   |
| storeResult |   | GameObject Dirtmouth | Variable |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Kings Station" |   |   |
| storeResult |   | GameObject Kings Station | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Fungal Wastes" |   |   |
| storeResult |   | GameObject Fungal Wastes | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Greenpath" |   |   |
| storeResult |   | GameObject Greenpath | Variable |   |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Deepnest" |   |   |
| storeResult |   | GameObject Deepnest | Variable |   |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Resting Grounds" |   |   |
| storeResult |   | GameObject Resting Grounds | Variable |   |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Royal Gardens" |   |   |
| storeResult |   | GameObject Royal Gardens | Variable |   |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Hidden Station" |   |   |
| storeResult |   | GameObject Hidden Station | Variable |   |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Stag Nest" |   |   |
| storeResult |   | GameObject Stag Nest | Variable |   |

##### 12. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Knight Icon" |   |   |
| storeResult |   | GameObject Knight Icon | Variable |   |

##### 13. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "stagPosition" |   |   |
| storeValue |   | int Stag Position | Variable |   |

##### 14. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Stag Position | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 15. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Max Items | Variable |   |
| intValue |   | int Items |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Town Initial? | 0 | |

### Crossroads?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "openedCrossroads" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Crossroads |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Greenpath |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Fungal Wastes |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Royal Gardens |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault City 1 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Kings Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Resting Grounds |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 9. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Deepnest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 10. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hidden Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 11. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Greenpath |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Fungal Wastes |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Royal Gardens |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 15. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):City 1 |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 16. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hidden Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 17. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Kings Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 18. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Resting Grounds |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 19. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Deepnest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 20. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Stag Nest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 21. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Items | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Crossroads Initial? | 0 | |

### Greenpath?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "openedGreenpath" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Greenpath |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Fungal Wastes |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Royal Gardens |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault City 1 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Kings Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Resting Grounds |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Deepnest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 9. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hidden Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 10. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Fungal Wastes |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Royal Gardens |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):City 1 |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hidden Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 15. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Kings Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 16. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Resting Grounds |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 17. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Deepnest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 18. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Stag Nest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 19. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Items | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Greenpath Initial? | 0 | |

### Fungus?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "openedFungalWastes" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Fungal Wastes |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Royal Gardens |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault City 1 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Kings Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Resting Grounds |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Deepnest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hidden Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 9. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Royal Gardens |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):City 1 |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hidden Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Kings Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Resting Grounds |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 15. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Deepnest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 16. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Stag Nest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 17. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Items | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fungus Initial? | 0 | |

### Royal G?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "openedRoyalGardens" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Royal Gardens |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault City 1 |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Kings Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Resting Grounds |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Deepnest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hidden Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):City 1 |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hidden Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Kings Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Resting Grounds |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Deepnest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Stag Nest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 15. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Items | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Royal G Initial? | 0 | |

### City?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "openedRuins1" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault City 1 |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Kings Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Resting Grounds |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Deepnest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hidden Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Kings Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hidden Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Resting Grounds |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Deepnest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Stag Nest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 13. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Items | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | City 1 Initial? | 0 | |

### City 2?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "openedRuins2" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Kings Station |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Resting Grounds |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Deepnest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hidden Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Resting Grounds |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hidden Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Deepnest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Stag Nest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 11. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Items | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | City 2 Initial? | 0 | |

### Resting G?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "openedRestingGrounds" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Resting Grounds |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Deepnest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hidden Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Deepnest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hidden Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Stag Nest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 9. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Items | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Resting G Initial? | 0 | |

### Deepnest?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "openedDeepnest" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Deepnest |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hidden Station |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Hidden Station |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Stag Nest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 7. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Items | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Deepnest Initial? | 0 | |

### Stag Nest?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "openedStagNest" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Items | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Stagnest Initial? | 0 | |

### Set Items Amount

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "ui_list" | FsmName |   |
| variableName |   | "Items" | FsmInt |   |
| setValue |   | int Items |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Pause | 0 | |

### Set Initial Item

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "stagPosition" |   |   |
| storeValue |   | int Initial Item | Variable |   |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Initial Item | Variable |   |
| add |   | 1 |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "ui_list" | FsmName |   |
| variableName |   | "Current Item" | FsmInt |   |
| setValue |   | int Initial Item |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "ui_list" | FsmName |   |
| variableName |   | "Initial Item" | FsmInt |   |
| setValue |   | int Initial Item |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "ui_list" | FsmName |   |
| variableName |   | "Cancel Item" | FsmInt |   |
| setValue |   | int Initial Item |   |   |
| everyFrame |   | false |   |   |

##### 6. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Initial Item | Variable |   |
| floatVariable |   | float Knight Icon TransY | Variable |   |
| everyFrame |   | false |   |   |

##### 7. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Knight Icon TransY | Variable |   |
| multiplyBy |   | -1f |   |   |
| everyFrame |   | false |   |   |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable |   | float Knight Icon TransY | Variable |   |
| add |   | 1f |   |   |
| everyFrame |   | false |   |   |
| perSecond |   | false |   |   |

##### 9. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Knight Icon |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Knight Icon TransY |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 10. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Knight Icon |   |   |
| active |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Items Amount | 0 | |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RestoreGameObjectPositions

Full Name: RestoreGameObjectPositions
Enabled: true

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
| FINISHED | Activate | 0 | |

### Activate

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):FSM Owner |   |   |
| sendEvent |   | "UI ACTIVE" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UI SELECTION MADE | State 1 | 0 | |

### Town Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 1 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Dirtmouth |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Crossroads? | 0 | |

### Crossroads Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 2 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Crossroads |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Greenpath? | 0 | |

### Greenpath Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 3 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Greenpath |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Fungus? | 0 | |

### Fungus Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 4 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Fungal Wastes |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Royal G? | 0 | |

### Royal G Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 5 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Royal Gardens |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | City? | 0 | |

### City 1 Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 6 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault City 1 |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | City 2? | 0 | |

### Resting G Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 8 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Resting Grounds |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Deepnest? | 0 | |

### City 2 Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 7 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Kings Station |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Resting G? | 0 | |

### Deepnest Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 9 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Deepnest |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hidden Station? | 0 | |

### Stagnest Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 10 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Set Initial Item | 0 | |

### Hidden Station?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "openedHiddenStation" |   |   |
| isTrue |   | Event(FINISHED) |   |   |
| isFalse |   | Event() |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hidden Station |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Stag Nest |   |   |
| vector |   | Vector3(0, 0, 0) | Variable |   |
| x |   | 0f |   |   |
| y |   | float Space to move up |   |   |
| z |   | 0f |   |   |
| space | UnityEngine.Space::Self | 1 |   |   |
| perSecond |   | false |   |   |
| everyFrame |   | false |   |   |
| lateUpdate |   | false |   |   |
| fixedUpdate |   | false |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Stag Nest |   |   |
| sendEvent |   | "DECREMENT LIST NUMBER" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 5. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Items |   |   |
| integer2 |   | 1 |   |   |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |   |   |
| storeResult |   | int Items | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hidden S Initial? | 0 | |

### Hidden S Initial?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Stag Position |   |   |
| integer2 |   | 11 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hidden Station |   |   |
| fsmName |   | "ui_list_item" | FsmName |   |
| variableName |   | "Item Number" | FsmInt |   |
| storeValue |   | int Initial Item | Variable |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Stag Nest? | 0 | |

### State 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Items | Variable |   |
| intValue |   | int Max Items |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| UI SELECTION MADE | false |

