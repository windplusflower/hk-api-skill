# Shift_pos

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Shift_pos |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets10.assets |
| Start State | Init |
| FSM PathId | 530 |
| GameObject PathId |  |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Current Num | 0 | Int32: 0 |
| Item Num | 0 | Int32: 0 |
| Num Diff | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Instant | false | Boolean: false |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Pos Down | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Pos Original | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Pos Up | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |
| Tween Vector | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Half Color | Color(1, 1, 1, 0.528) | UnityColor: Color(1, 1, 1, 0.528) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Enemy List | [null] | NamedAssetPPtr:  |
| Geo Sprite | [null] | NamedAssetPPtr:  |
| Item Sprite | [null] | NamedAssetPPtr:  |
| Item cost | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3 Pos Original | Vector3 Pos Original | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| behaviour | "ShopItemStats" | "ShopItemStats" | Behaviour |  |
| methodName | "GetItemNumber" | "GetItemNumber" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Item Num = 0 | Var Item Num = 0 | Variable | Store Result |

##### 4. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Pos Down | Vector3 Pos Down | Variable |  |
| vector3Value | Vector3 Pos Original | Vector3 Pos Original |  |  |
| everyFrame | false | false |  |  |

##### 5. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Pos Up | Vector3 Pos Up | Variable |  |
| vector3Value | Vector3 Pos Original | Vector3 Pos Original |  |  |
| everyFrame | false | false |  |  |

##### 6. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Pos Down | Vector3 Pos Down | Variable |  |
| addX | 0f | 0f |  |  |
| addY | -0.8f | -0.8f |  |  |
| addZ | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. Vector3AddXYZ

Full Name: HutongGames.PlayMaker.Actions.Vector3AddXYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Pos Up | Vector3 Pos Up | Variable |  |
| addX | 0f | 0f |  |  |
| addY | 0.8f | 0.8f |  |  |
| addZ | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 8. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| storeResult | GameObject Enemy List | GameObject Enemy List | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Geo Sprite" | "Geo Sprite" |  |  |
| storeResult | GameObject Geo Sprite | GameObject Geo Sprite | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Item cost" | "Item cost" |  |  |
| storeResult | GameObject Item cost | GameObject Item cost | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Item Sprite" | "Item Sprite" |  |  |
| storeResult | GameObject Item Sprite | GameObject Item Sprite | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Instant | bool Instant | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Check Num

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetFsmInt

Full Name: HutongGames.PlayMaker.Actions.GetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Enemy List | OwnerDefault Enemy List |  |  |
| fsmName | "Item List Control" | "Item List Control" | FsmName |  |
| variableName | "Current Item" | "Current Item" | FsmInt |  |
| storeValue | int Current Num | int Current Num | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Item Num | int Item Num |  |  |
| integer2 | int Current Num | int Current Num |  |  |
| equal | Event(CURRENT) | Event(CURRENT) |  |  |
| lessThan | Event(UP) | Event(UP) |  |  |
| greaterThan | Event(DOWN) | Event(DOWN) |  |  |
| everyFrame | false | false |  |  |

### Tween

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Tween Vector | Vector3 Tween Vector |  |  |
| time | 0.25f | 0.25f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| easeType | iTween/EaseType::easeOutSine | 13 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| moveToPath | false | false |  | Path |
| lookAhead | 0f | 0f |  |  |
| transforms | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| vectors | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| reverse | false | false |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Current

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Tween Vector | Vector3 Tween Vector | Variable |  |
| vector3Value | Vector3 Pos Original | Vector3 Pos Original |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Instant | bool Instant | Variable |  |
| isTrue | Event(SHIFT INSTANT) | Event(SHIFT INSTANT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Tween Vector | Vector3 Tween Vector | Variable |  |
| vector3Value | Vector3 Pos Up | Vector3 Pos Up |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Instant | bool Instant | Variable |  |
| isTrue | Event(SHIFT INSTANT) | Event(SHIFT INSTANT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetVector3Value

Full Name: HutongGames.PlayMaker.Actions.SetVector3Value
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Tween Vector | Vector3 Tween Vector | Variable |  |
| vector3Value | Vector3 Pos Down | Vector3 Pos Down |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Instant | bool Instant | Variable |  |
| isTrue | Event(SHIFT INSTANT) | Event(SHIFT INSTANT) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Instant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Instant | bool Instant | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Instant Shift

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| vector | Vector3 Tween Vector | Vector3 Tween Vector | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | SHIFT | Check Num | 0 | 0 | 0 |
| Idle | SHIFT INSTANT | Instant | 0 | 0 | 0 |
| Check Num | CURRENT | Current | 0 | 0 | 0 |
| Check Num | UP | Up | 0 | 0 | 0 |
| Check Num | DOWN | Down | 0 | 0 | 0 |
| Tween | FINISHED | Idle | 0 | 0 | 0 |
| Tween | SHIFT | Check Num | 0 | 0 | 0 |
| Tween | SHIFT INSTANT | Instant | 0 | 0 | 0 |
| Current | FINISHED | Tween | 0 | 0 | 0 |
| Current | SHIFT INSTANT | Instant Shift | 0 | 0 | 0 |
| Up | FINISHED | Tween | 0 | 0 | 0 |
| Up | SHIFT INSTANT | Instant Shift | 0 | 0 | 0 |
| Down | FINISHED | Tween | 0 | 0 | 0 |
| Down | SHIFT INSTANT | Instant Shift | 0 | 0 | 0 |
| Instant | FINISHED | Check Num | 0 | 0 | 0 |
| Instant Shift | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CURRENT | false |
| DOWN | false |
| FADE HALF | false |
| FADE NORM | false |
| FADE OUT | false |
| SHIFT | false |
| SHIFT INSTANT | false |
| UP | false |

