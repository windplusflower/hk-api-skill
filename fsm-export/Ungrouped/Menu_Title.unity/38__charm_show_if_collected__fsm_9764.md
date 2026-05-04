# charm_show_if_collected

## Summary

| Field | Value |
| --- | --- |
| FSM Name | charm_show_if_collected |
| GameObject Name | 38 |
| GameObject Path | _GameCameras/HudCamera/Inventory/Charms/Collected Charms/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Pause |
| FSM PathId | 9764 |
| GameObject PathId | 1776 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| ID | 0 | Int32: 0 |
| Royal Charm State | 0 | Int32: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Name |   | String:  |
| PD Bool Name |   | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Charm Sprite | [null] | NamedAssetPPtr: [null] |
| Glow | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

### Objects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Sprite | [null] | NamedAssetPPtr: [null] |

## States

### Check

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

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Glow" |   |   |
| storeResult |   | GameObject Glow | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Sprite" |   |   |
| storeResult |   | GameObject Charm Sprite | Variable |   |

##### 4. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| storeName |   | string Name | Variable |   |
| everyFrame |   | false |   |   |

##### 5. ConvertStringToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertStringToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable |   | string Name | Variable |   |
| intVariable |   | int ID | Variable |   |
| everyFrame |   | false |   |   |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string PD Bool Name | Variable |   |
| everyFrame |   | false |   |   |

##### 7. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Icons |   |   |
| behaviour |   | "CharmIconList" | Behaviour |   |
| methodName |   | "GetSprite" | Method |   |
| parameters |   | FSMViewAvalonia2.FsmArray2 |   |   |
| storeResult |   | Var Sprite =  | Variable | Store Result |

##### 8. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| sprite |   | object Sprite |   |   |

##### 9. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | string PD Bool Name |   |   |
| isTrue |   | Event(GOT) |   |   |
| isFalse |   | Event(NOT) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| GOT | Glass HP | 0 | |
| NOT | Not | 0 | |

### Got

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self |   |   |
| storeName |   | string Name | Variable |   |
| everyFrame |   | false |   |   |

##### 3. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts |   | FSMViewAvalonia2.FsmArray2 |   |   |
| separator |   | "" |   |   |
| addToEnd |   | true |   |   |
| storeResult |   | string PD Bool Name | Variable |   |
| everyFrame |   | false |   |   |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | string PD Bool Name |   |   |
| isTrue |   | Event(EQUIPPED) |   |   |
| isFalse |   | Event() |   |   |

##### 5. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color(1, 1, 1, 1) |   |   |
| everyFrame |   | false |   |   |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Glow |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| fsmName |   | "color_fader" | FsmName |   |
| variableName |   | "Up Colour" | FsmColor |   |
| setValue |   | Color(1, 1, 1, 1) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EQUIPPED | Equipped | 0 | |

### Not

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self | Variable |   |
| activate |   | false |   |   |

#### Transitions

(none)

### Equipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Glow |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| materialIndex |   | 0 |   |   |
| material |   | [FsmMaterial not implemented] |   |   |
| namedColor |   | "_Color" | NamedColor |   |
| color |   | Color(0.4705882, 0.4705882, 0.4705882, 1) |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| fsmName |   | "color_fader" | FsmName |   |
| variableName |   | "Up Colour" | FsmColor |   |
| setValue |   | Color(0.4705882, 0.4705882, 0.4705882, 1) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Glass HP

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int ID |   |   |
| integer2 |   | 23 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "brokenCharm_23" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 3. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| sprite |   | [_0002_charm_glass_heal_broken (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Glass Geo | 0 | |

### Glass Geo

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int ID |   |   |
| integer2 |   | 24 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "brokenCharm_24" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 3. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| sprite |   | [_0003_charm_glass_geo_broken (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Glass Attack | 0 | |

### Glass Attack

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int ID |   |   |
| integer2 |   | 25 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "brokenCharm_25" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FINISHED) |   |   |

##### 3. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| sprite |   | [_0002_charm_glass_attack_up_broken (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Royal Charm | 0 | |

### Royal Charm

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int ID |   |   |
| integer2 |   | 36 |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "royalCharmState" |   |   |
| storeValue |   | int Royal Charm State | Variable |   |

##### 3. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Royal Charm State | Variable |   |
| compareTo |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Got | 0 | |
| R QUEEN | R Queen | 0 | |
| R KING | R King | 0 | |
| R FINAL | R Final | 0 | |
| R SHADE | R Shade | 0 | |

### R Queen

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| sprite |   | [charm_white_left (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Got | 0 | |

### R King

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| sprite |   | [charm_white_right (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Got | 0 | |

### R Final

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| sprite |   | [charm_white_full (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Got | 0 | |

### R Shade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Charm Sprite |   |   |
| sprite |   | [charm_black (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Got | 0 | |

### Pause

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
| FINISHED | Check | 0 | |

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| UPDATE | Check | 0 | |
| EQUIP | Equipped | 0 | |

## Events

| Name | Global |
| --- | --- |
| EQUIP | false |
| EQUIPPED | false |
| FINISHED | false |
| GOT | false |
| NOT | false |
| R FINAL | false |
| R KING | false |
| R QUEEN | false |
| R SHADE | false |
| UPDATE | false |

