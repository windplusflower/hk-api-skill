# Eyes Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Eyes Control |
| GameObject Name | Eyes |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Soul Orb |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 21633 |
| GameObject PathId | 5238 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| MP | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Has Spell | false | Boolean: false |

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Colour | Color(1, 1, 1, 1) | UnityColor: Color(1, 1, 1, 1) |
| Prev Colour | Color(0, 0, 0, 1) | UnityColor: Color(0, 0, 0, 1) |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasSpell" | "hasSpell" |  |  |
| storeValue | bool Has Spell | bool Has Spell | Variable |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Has Spell | bool Has Spell | Variable |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(OFF) | Event(OFF) |  |  |
| everyFrame | false | false |  |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPCharge" | "MPCharge" |  |  |
| storeValue | int MP | int MP | Variable |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | 50 | 50 |  |  |
| equal | Event(OVER) | Event(OVER) |  |  |
| lessThan | Event(UNDER) | Event(UNDER) |  |  |
| greaterThan | Event(OVER) | Event(OVER) |  |  |
| everyFrame | false | false |  |  |

### Start Under

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| color | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) | FsmColor |  |
| everyframe | false | false |  |  |

##### 3. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 1f | 1f |  |  |
| y | 0.4f | 0.4f |  |  |
| z | 1f | 1f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Under

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.GetMaterialColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color Prev Colour | Color Prev Colour | Variable |  |
| fail | Event() | Event() |  |  |

##### 2. Tk2dSpriteGetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteGetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| color | Color Prev Colour | Color Prev Colour | Variable |  |
| everyframe | false | false |  |  |

##### 3. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue | Color Prev Colour | Color Prev Colour |  |  |
| toValue | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| colorVariable | Color Colour | Color Colour | Variable |  |
| time | 0.2f | 0.2f |  |  |
| speed | 0f | 0f |  |  |
| delay | 0f | 0f |  |  |
| easeType | 13 | 13 |  |  |
| reverse | false | false |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 4. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color Colour | Color Colour |  |  |
| everyFrame | true | true |  |  |

##### 5. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| color | Color Colour | Color Colour | FsmColor |  |
| everyframe | true | true |  |  |

##### 6. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0f | 0f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformScale |  |  |  |  |
| vectorScale | Vector3(1, 0.4, 1) | Vector3(1, 0.4, 1) |  |  |
| time | 0.2f | 0.2f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::easeOutSine | 13 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Start Over

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) | FsmColor |  |
| everyframe | false | false |  |  |

### Over

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.GetMaterialColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color Prev Colour | Color Prev Colour | Variable |  |
| fail | Event() | Event() |  |  |

##### 2. Tk2dSpriteGetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteGetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| color | Color Prev Colour | Color Prev Colour | Variable |  |
| everyframe | false | false |  |  |

##### 3. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue | Color Prev Colour | Color Prev Colour |  |  |
| toValue | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| colorVariable | Color Colour | Color Colour | Variable |  |
| time | 0.8f | 0.8f |  |  |
| speed | 0f | 0f |  |  |
| delay | 0f | 0f |  |  |
| easeType | 21 | 21 |  |  |
| reverse | false | false |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 4. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color Colour | Color Colour |  |  |
| everyFrame | true | true |  |  |

##### 5. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| color | Color Colour | Color Colour | FsmColor |  |
| everyframe | true | true |  |  |

##### 6. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| id | "" | "" |  |  |
| transformScale |  |  |  |  |
| vectorScale | Vector3(1, 1, 1) | Vector3(1, 1, 1) |  |  |
| time | 0.5f | 0.5f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::easeOutSine | 13 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Off

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetSpriteRenderer

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRenderer
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | UNDER | Start Under | 0 | 0 | 0 |
| Init | OVER | Start Over | 0 | 0 | 0 |
| Init | OFF | Off | 0 | 0 | 0 |
| Init | FINISHED | Start Under | 0 | 0 | 0 |
| Start Under | OVER | Over | 0 | 0 | 0 |
| Under | OVER | Over | 0 | 0 | 0 |
| Start Over | UNDER | Under | 0 | 0 | 0 |
| Over | UNDER | Under | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| OFF | false |
| OVER | false |
| UNDER | false |

