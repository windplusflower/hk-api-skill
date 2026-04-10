# UI List Stag

## Summary

| Field | Value |
| --- | --- |
| FSM Name | UI List Stag |
| GameObject Name | UI List Stag |
| GameObject Path | Stag Map |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 21573 |
| GameObject PathId | 5347 |

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
| City 1 | [null] | NamedAssetPPtr:  |
| Crossroads | [null] | NamedAssetPPtr:  |
| Deepnest | [null] | NamedAssetPPtr:  |
| Dirtmouth | [null] | NamedAssetPPtr:  |
| Fungal Wastes | [null] | NamedAssetPPtr:  |
| Greenpath | [null] | NamedAssetPPtr:  |
| Hidden Station | [null] | NamedAssetPPtr:  |
| Kings Station | [null] | NamedAssetPPtr:  |
| Knight Icon | [null] | NamedAssetPPtr:  |
| Resting Grounds | [null] | NamedAssetPPtr:  |
| Royal Gardens | [null] | NamedAssetPPtr:  |
| Stag Nest | [null] | NamedAssetPPtr:  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "City Storerooms" | "City Storerooms" |  |  |
| storeResult | GameObject City 1 | GameObject City 1 | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Crossroads" | "Crossroads" |  |  |
| storeResult | GameObject Crossroads | GameObject Crossroads | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Dirtmouth" | "Dirtmouth" |  |  |
| storeResult | GameObject Dirtmouth | GameObject Dirtmouth | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Kings Station" | "Kings Station" |  |  |
| storeResult | GameObject Kings Station | GameObject Kings Station | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Fungal Wastes" | "Fungal Wastes" |  |  |
| storeResult | GameObject Fungal Wastes | GameObject Fungal Wastes | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Greenpath" | "Greenpath" |  |  |
| storeResult | GameObject Greenpath | GameObject Greenpath | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Deepnest" | "Deepnest" |  |  |
| storeResult | GameObject Deepnest | GameObject Deepnest | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Resting Grounds" | "Resting Grounds" |  |  |
| storeResult | GameObject Resting Grounds | GameObject Resting Grounds | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Royal Gardens" | "Royal Gardens" |  |  |
| storeResult | GameObject Royal Gardens | GameObject Royal Gardens | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Hidden Station" | "Hidden Station" |  |  |
| storeResult | GameObject Hidden Station | GameObject Hidden Station | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Stag Nest" | "Stag Nest" |  |  |
| storeResult | GameObject Stag Nest | GameObject Stag Nest | Variable |  |

##### 12. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Knight Icon" | "Knight Icon" |  |  |
| storeResult | GameObject Knight Icon | GameObject Knight Icon | Variable |  |

##### 13. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "stagPosition" | "stagPosition" |  |  |
| storeValue | int Stag Position | int Stag Position | Variable |  |

##### 14. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Stag Position | int Stag Position | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 15. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Max Items | int Max Items | Variable |  |
| intValue | int Items | int Items |  |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "openedCrossroads" | "openedCrossroads" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Crossroads | OwnerDefault Crossroads |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Greenpath | OwnerDefault Greenpath |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fungal Wastes | OwnerDefault Fungal Wastes |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Royal Gardens | OwnerDefault Royal Gardens |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault City 1 | OwnerDefault City 1 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Kings Station | OwnerDefault Kings Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Resting Grounds | OwnerDefault Resting Grounds |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 9. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deepnest | OwnerDefault Deepnest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 10. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hidden Station | OwnerDefault Hidden Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 11. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Greenpath | EventTarget(GameObject):Greenpath |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Fungal Wastes | EventTarget(GameObject):Fungal Wastes |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Royal Gardens | EventTarget(GameObject):Royal Gardens |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 15. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):City 1 | EventTarget(GameObject):City 1 |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 16. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hidden Station | EventTarget(GameObject):Hidden Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 17. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Kings Station | EventTarget(GameObject):Kings Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 18. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Resting Grounds | EventTarget(GameObject):Resting Grounds |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 19. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Deepnest | EventTarget(GameObject):Deepnest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 20. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Stag Nest | EventTarget(GameObject):Stag Nest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 21. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Items | int Items | Variable |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "openedGreenpath" | "openedGreenpath" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Greenpath | OwnerDefault Greenpath |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fungal Wastes | OwnerDefault Fungal Wastes |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Royal Gardens | OwnerDefault Royal Gardens |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault City 1 | OwnerDefault City 1 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Kings Station | OwnerDefault Kings Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Resting Grounds | OwnerDefault Resting Grounds |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deepnest | OwnerDefault Deepnest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 9. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hidden Station | OwnerDefault Hidden Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 10. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Fungal Wastes | EventTarget(GameObject):Fungal Wastes |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Royal Gardens | EventTarget(GameObject):Royal Gardens |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):City 1 | EventTarget(GameObject):City 1 |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hidden Station | EventTarget(GameObject):Hidden Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 15. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Kings Station | EventTarget(GameObject):Kings Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 16. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Resting Grounds | EventTarget(GameObject):Resting Grounds |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 17. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Deepnest | EventTarget(GameObject):Deepnest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 18. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Stag Nest | EventTarget(GameObject):Stag Nest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 19. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Items | int Items | Variable |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "openedFungalWastes" | "openedFungalWastes" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fungal Wastes | OwnerDefault Fungal Wastes |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Royal Gardens | OwnerDefault Royal Gardens |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault City 1 | OwnerDefault City 1 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Kings Station | OwnerDefault Kings Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Resting Grounds | OwnerDefault Resting Grounds |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deepnest | OwnerDefault Deepnest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hidden Station | OwnerDefault Hidden Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 9. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Royal Gardens | EventTarget(GameObject):Royal Gardens |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):City 1 | EventTarget(GameObject):City 1 |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hidden Station | EventTarget(GameObject):Hidden Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Kings Station | EventTarget(GameObject):Kings Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Resting Grounds | EventTarget(GameObject):Resting Grounds |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 15. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Deepnest | EventTarget(GameObject):Deepnest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 16. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Stag Nest | EventTarget(GameObject):Stag Nest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 17. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Items | int Items | Variable |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "openedRoyalGardens" | "openedRoyalGardens" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Royal Gardens | OwnerDefault Royal Gardens |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault City 1 | OwnerDefault City 1 |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Kings Station | OwnerDefault Kings Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Resting Grounds | OwnerDefault Resting Grounds |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deepnest | OwnerDefault Deepnest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hidden Station | OwnerDefault Hidden Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 8. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):City 1 | EventTarget(GameObject):City 1 |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hidden Station | EventTarget(GameObject):Hidden Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Kings Station | EventTarget(GameObject):Kings Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Resting Grounds | EventTarget(GameObject):Resting Grounds |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Deepnest | EventTarget(GameObject):Deepnest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 14. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Stag Nest | EventTarget(GameObject):Stag Nest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 15. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Items | int Items | Variable |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "openedRuins1" | "openedRuins1" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault City 1 | OwnerDefault City 1 |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Kings Station | OwnerDefault Kings Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Resting Grounds | OwnerDefault Resting Grounds |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deepnest | OwnerDefault Deepnest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hidden Station | OwnerDefault Hidden Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 7. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Kings Station | EventTarget(GameObject):Kings Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hidden Station | EventTarget(GameObject):Hidden Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Resting Grounds | EventTarget(GameObject):Resting Grounds |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Deepnest | EventTarget(GameObject):Deepnest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 12. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Stag Nest | EventTarget(GameObject):Stag Nest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 13. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Items | int Items | Variable |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "openedRuins2" | "openedRuins2" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Kings Station | OwnerDefault Kings Station |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Resting Grounds | OwnerDefault Resting Grounds |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deepnest | OwnerDefault Deepnest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hidden Station | OwnerDefault Hidden Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 6. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Resting Grounds | EventTarget(GameObject):Resting Grounds |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hidden Station | EventTarget(GameObject):Hidden Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Deepnest | EventTarget(GameObject):Deepnest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 10. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Stag Nest | EventTarget(GameObject):Stag Nest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 11. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Items | int Items | Variable |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "openedRestingGrounds" | "openedRestingGrounds" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Resting Grounds | OwnerDefault Resting Grounds |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deepnest | OwnerDefault Deepnest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hidden Station | OwnerDefault Hidden Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Deepnest | EventTarget(GameObject):Deepnest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hidden Station | EventTarget(GameObject):Hidden Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Stag Nest | EventTarget(GameObject):Stag Nest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 9. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Items | int Items | Variable |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "openedDeepnest" | "openedDeepnest" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deepnest | OwnerDefault Deepnest |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hidden Station | OwnerDefault Hidden Station |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 4. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Hidden Station | EventTarget(GameObject):Hidden Station |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Stag Nest | EventTarget(GameObject):Stag Nest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Items | int Items | Variable |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "openedStagNest" | "openedStagNest" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Items | int Items | Variable |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Items" | "Items" | FsmInt |  |
| setValue | int Items | int Items |  |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "stagPosition" | "stagPosition" |  |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Initial Item | int Initial Item | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Current Item" | "Current Item" | FsmInt |  |
| setValue | int Initial Item | int Initial Item |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Initial Item" | "Initial Item" | FsmInt |  |
| setValue | int Initial Item | int Initial Item |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "ui_list" | "ui_list" | FsmName |  |
| variableName | "Cancel Item" | "Cancel Item" | FsmInt |  |
| setValue | int Initial Item | int Initial Item |  |  |
| everyFrame | false | false |  |  |

##### 6. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Initial Item | int Initial Item | Variable |  |
| floatVariable | float Knight Icon TransY | float Knight Icon TransY | Variable |  |
| everyFrame | false | false |  |  |

##### 7. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Knight Icon TransY | float Knight Icon TransY | Variable |  |
| multiplyBy | -1f | -1f |  |  |
| everyFrame | false | false |  |  |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Knight Icon TransY | float Knight Icon TransY | Variable |  |
| add | 1f | 1f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 9. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Knight Icon | OwnerDefault Knight Icon |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Knight Icon TransY | float Knight Icon TransY |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 10. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Knight Icon | OwnerDefault Knight Icon |  |  |
| active | true | true |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. RestoreGameObjectPositions

Full Name: RestoreGameObjectPositions
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

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
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "UI ACTIVE" | "UI ACTIVE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Dirtmouth | OwnerDefault Dirtmouth |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 2 | 2 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Crossroads | OwnerDefault Crossroads |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 3 | 3 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Greenpath | OwnerDefault Greenpath |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 4 | 4 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fungal Wastes | OwnerDefault Fungal Wastes |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 5 | 5 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Royal Gardens | OwnerDefault Royal Gardens |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 6 | 6 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault City 1 | OwnerDefault City 1 |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 8 | 8 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Resting Grounds | OwnerDefault Resting Grounds |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 7 | 7 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Kings Station | OwnerDefault Kings Station |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 9 | 9 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Deepnest | OwnerDefault Deepnest |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 10 | 10 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "openedHiddenStation" | "openedHiddenStation" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hidden Station | OwnerDefault Hidden Station |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. Translate

Full Name: HutongGames.PlayMaker.Actions.Translate
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Stag Nest | OwnerDefault Stag Nest |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Space to move up | float Space to move up |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| perSecond | false | false |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |
| fixedUpdate | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Stag Nest | EventTarget(GameObject):Stag Nest |  |  |
| sendEvent | "DECREMENT LIST NUMBER" | "DECREMENT LIST NUMBER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. IntOperator

Full Name: HutongGames.PlayMaker.Actions.IntOperator
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Items | int Items |  |  |
| integer2 | 1 | 1 |  |  |
| operation | HutongGames.PlayMaker.Actions.IntOperator/Operation::Subtract | 1 |  |  |
| storeResult | int Items | int Items | Variable |  |
| everyFrame | false | false |  |  |

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
| integer1 | int Stag Position | int Stag Position |  |  |
| integer2 | 11 | 11 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hidden Station | OwnerDefault Hidden Station |  |  |
| fsmName | "ui_list_item" | "ui_list_item" | FsmName |  |
| variableName | "Item Number" | "Item Number" | FsmInt |  |
| storeValue | int Initial Item | int Initial Item | Variable |  |
| everyFrame | false | false |  |  |

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
| intVariable | int Items | int Items | Variable |  |
| intValue | int Max Items | int Max Items |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Town Initial? | 0 | 0 | 0 |
| Crossroads? | FINISHED | Crossroads Initial? | 0 | 0 | 0 |
| Greenpath? | FINISHED | Greenpath Initial? | 0 | 0 | 0 |
| Fungus? | FINISHED | Fungus Initial? | 0 | 0 | 0 |
| Royal G? | FINISHED | Royal G Initial? | 0 | 0 | 0 |
| City? | FINISHED | City 1 Initial? | 0 | 0 | 0 |
| City 2? | FINISHED | City 2 Initial? | 0 | 0 | 0 |
| Resting G? | FINISHED | Resting G Initial? | 0 | 0 | 0 |
| Deepnest? | FINISHED | Deepnest Initial? | 0 | 0 | 0 |
| Stag Nest? | FINISHED | Stagnest Initial? | 0 | 0 | 0 |
| Set Items Amount | FINISHED | Pause | 0 | 0 | 0 |
| Set Initial Item | FINISHED | Set Items Amount | 0 | 0 | 0 |
| Pause | FINISHED | Activate | 0 | 0 | 0 |
| Activate | UI SELECTION MADE | State 1 | 0 | 0 | 0 |
| Town Initial? | FINISHED | Crossroads? | 0 | 0 | 0 |
| Crossroads Initial? | FINISHED | Greenpath? | 0 | 0 | 0 |
| Greenpath Initial? | FINISHED | Fungus? | 0 | 0 | 0 |
| Fungus Initial? | FINISHED | Royal G? | 0 | 0 | 0 |
| Royal G Initial? | FINISHED | City? | 0 | 0 | 0 |
| City 1 Initial? | FINISHED | City 2? | 0 | 0 | 0 |
| Resting G Initial? | FINISHED | Deepnest? | 0 | 0 | 0 |
| City 2 Initial? | FINISHED | Resting G? | 0 | 0 | 0 |
| Deepnest Initial? | FINISHED | Hidden Station? | 0 | 0 | 0 |
| Stagnest Initial? | FINISHED | Set Initial Item | 0 | 0 | 0 |
| Hidden Station? | FINISHED | Hidden S Initial? | 0 | 0 | 0 |
| Hidden S Initial? | FINISHED | Stag Nest? | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| UI SELECTION MADE | false |

