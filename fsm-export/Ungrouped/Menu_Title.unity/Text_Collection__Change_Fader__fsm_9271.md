# Change Fader

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Change Fader |
| GameObject Name | Text Collection |
| GameObject Path | _GameCameras/HudCamera/Inventory/Charms/Collected Charms/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9271 |
| GameObject PathId | 1402 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Down Time | 0.150000006 | Single: 0.150000006 |
| Up Delay | 0 | Single: 0 |
| Up Time | 0.150000006 | Single: 0.150000006 |

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Down Colour | Color(1, 1, 1, 0) | UnityColor: Color(1, 1, 1, 0) |
| New Colour | Color(0, 0, 0, 1) | UnityColor: Color(0, 0, 0, 1) |
| Prev Colour | Color(1, 1, 1, 1) | UnityColor: Color(1, 1, 1, 1) |
| Up Colour | Color(1, 1, 1, 1) | UnityColor: Color(1, 1, 1, 1) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Self | [null] | NamedAssetPPtr: [null] |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color(1, 1, 1, 0) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHANGE UP | Delay | 0 | |
| CHANGE DOWN | Down | 0 | |

### Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.GetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color Prev Colour | Variable |   |
| fail |   | Event() |   |   |

##### 2. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable |   | Color New Colour | Variable |   |
| color |   | Color Prev Colour |   |   |
| everyFrame |   | false |   |   |

##### 3. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue |   | Color Prev Colour |   |   |
| toValue |   | Color Up Colour |   |   |
| colorVariable |   | Color New Colour | Variable |   |
| time |   | float Up Time |   |   |
| speed |   | 0f |   |   |
| delay |   | 0f |   |   |
| easeType |   | 21 |   |   |
| reverse |   | false |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |

##### 4. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color New Colour |   |   |
| everyFrame |   | true |   |   |

##### 5. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| color |   | Color New Colour |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHANGE DOWN | Down | 0 | |

### Down

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.GetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color Prev Colour | Variable |   |
| fail |   | Event() |   |   |

##### 2. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable |   | Color New Colour | Variable |   |
| color |   | Color Prev Colour |   |   |
| everyFrame |   | false |   |   |

##### 3. GetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.GetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color New Colour | Variable |   |
| fail |   | Event() |   |   |

##### 4. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue |   | Color Prev Colour |   |   |
| toValue |   | Color Down Colour |   |   |
| colorVariable |   | Color New Colour | Variable |   |
| time |   | float Down Time |   |   |
| speed |   | 0f |   |   |
| delay |   | 0f |   |   |
| easeType |   | 21 |   |   |
| reverse |   | false |   |   |
| finishEvent |   | Event() |   |   |
| realTime |   | false |   |   |

##### 5. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color New Colour |   |   |
| everyFrame |   | true |   |   |

##### 6. SetTextMeshProColor

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| color |   | Color New Colour |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHANGE UP | Delay | 0 | |

### Delay

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | float Up Delay |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Up | 0 | |
| CHANGE DOWN | Down | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CHANGE DOWN | false |
| CHANGE UP | false |
| FINISHED | false |

