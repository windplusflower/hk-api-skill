# charm_show_if_collected

## Summary

| Field | Value |
| --- | --- |
| FSM Name | charm_show_if_collected |
| GameObject Name | 11 |
| GameObject Path | _GameCameras/HudCamera/Inventory/Charms/Collected Charms |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 20345 |
| GameObject PathId | 5732 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| ID | 0 | Int32: 0 |
| Royal Charm State | 0 | Int32: 0 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Name |  | String:  |
| PD Bool Name |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Charm Sprite | [null] | NamedAssetPPtr:  |
| Glow | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

### Objects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Sprite | [null] | NamedAssetPPtr:  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Glow" | "Glow" |  |  |
| storeResult | GameObject Glow | GameObject Glow | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Sprite" | "Sprite" |  |  |
| storeResult | GameObject Charm Sprite | GameObject Charm Sprite | Variable |  |

##### 4. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self |  |  |
| storeName | string Name | string Name | Variable |  |
| everyFrame | false | false |  |  |

##### 5. ConvertStringToInt

Full Name: HutongGames.PlayMaker.Actions.ConvertStringToInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Name | string Name | Variable |  |
| intVariable | int ID | int ID | Variable |  |
| everyFrame | false | false |  |  |

##### 6. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PD Bool Name | string PD Bool Name | Variable |  |
| everyFrame | false | false |  |  |

##### 7. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Icons | OwnerDefault Charm Icons |  |  |
| behaviour | "CharmIconList" | "CharmIconList" | Behaviour |  |
| methodName | "GetSprite" | "GetSprite" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var Sprite =  | Var Sprite =  | Variable | Store Result |

##### 8. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| sprite | object Sprite | object Sprite |  |  |

##### 9. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | string PD Bool Name | string PD Bool Name |  |  |
| isTrue | Event(GOT) | Event(GOT) |  |  |
| isFalse | Event(NOT) | Event(NOT) |  |  |

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
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. GetName

Full Name: HutongGames.PlayMaker.Actions.GetName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self |  |  |
| storeName | string Name | string Name | Variable |  |
| everyFrame | false | false |  |  |

##### 3. BuildString

Full Name: HutongGames.PlayMaker.Actions.BuildString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringParts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| separator | "" | "" |  |  |
| addToEnd | true | true |  |  |
| storeResult | string PD Bool Name | string PD Bool Name | Variable |  |
| everyFrame | false | false |  |  |

##### 4. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | string PD Bool Name | string PD Bool Name |  |  |
| isTrue | Event(EQUIPPED) | Event(EQUIPPED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 5. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Glow | OwnerDefault Glow |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| fsmName | "color_fader" | "color_fader" | FsmName |  |
| variableName | "Up Colour" | "Up Colour" | FsmColor |  |
| setValue | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

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
| gameObject | GameObject Self | GameObject Self | Variable |  |
| activate | false | false |  |  |

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
| gameObject | OwnerDefault Glow | OwnerDefault Glow |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetMaterialColor

Full Name: HutongGames.PlayMaker.Actions.SetMaterialColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| materialIndex | 0 | 0 |  |  |
| material | [FsmMaterial not implemented] | [FsmMaterial not implemented] |  |  |
| namedColor | "_Color" | "_Color" | NamedColor |  |
| color | Color(0.4705882, 0.4705882, 0.4705882, 1) | Color(0.4705882, 0.4705882, 0.4705882, 1) |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmColor

Full Name: HutongGames.PlayMaker.Actions.SetFsmColor
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| fsmName | "color_fader" | "color_fader" | FsmName |  |
| variableName | "Up Colour" | "Up Colour" | FsmColor |  |
| setValue | Color(0.4705882, 0.4705882, 0.4705882, 1) | Color(0.4705882, 0.4705882, 0.4705882, 1) |  |  |
| everyFrame | false | false |  |  |

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
| integer1 | int ID | int ID |  |  |
| integer2 | 23 | 23 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "brokenCharm_23" | "brokenCharm_23" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| sprite | [_0002_charm_glass_heal_broken (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [_0002_charm_glass_heal_broken (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

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
| integer1 | int ID | int ID |  |  |
| integer2 | 24 | 24 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "brokenCharm_24" | "brokenCharm_24" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| sprite | [_0003_charm_glass_geo_broken (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [_0003_charm_glass_geo_broken (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

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
| integer1 | int ID | int ID |  |  |
| integer2 | 25 | 25 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "brokenCharm_25" | "brokenCharm_25" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| sprite | [_0002_charm_glass_attack_up_broken (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [_0002_charm_glass_attack_up_broken (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

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
| integer1 | int ID | int ID |  |  |
| integer2 | 36 | 36 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "royalCharmState" | "royalCharmState" |  |  |
| storeValue | int Royal Charm State | int Royal Charm State | Variable |  |

##### 3. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Royal Charm State | int Royal Charm State | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

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
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| sprite | [charm_white_left (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [charm_white_left (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

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
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| sprite | [charm_white_right (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [charm_white_right (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

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
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| sprite | [charm_white_full (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [charm_white_full (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

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
| gameObject | OwnerDefault Charm Sprite | OwnerDefault Charm Sprite |  |  |
| sprite | [charm_black (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [charm_black (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

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
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Check | GOT | Glass HP | 0 | 0 | 0 |
| Check | NOT | Not | 0 | 0 | 0 |
| Got | EQUIPPED | Equipped | 0 | 0 | 0 |
| Glass HP | FINISHED | Glass Geo | 0 | 0 | 0 |
| Glass Geo | FINISHED | Glass Attack | 0 | 0 | 0 |
| Glass Attack | FINISHED | Royal Charm | 0 | 0 | 0 |
| Royal Charm | FINISHED | Got | 0 | 0 | 0 |
| Royal Charm | R QUEEN | R Queen | 0 | 0 | 0 |
| Royal Charm | R KING | R King | 0 | 0 | 0 |
| Royal Charm | R FINAL | R Final | 0 | 0 | 0 |
| Royal Charm | R SHADE | R Shade | 0 | 0 | 0 |
| R Queen | FINISHED | Got | 0 | 0 | 0 |
| R King | FINISHED | Got | 0 | 0 | 0 |
| R Final | FINISHED | Got | 0 | 0 | 0 |
| R Shade | FINISHED | Got | 0 | 0 | 0 |
| Pause | FINISHED | Check | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| UPDATE | Check | 0 | 0 | 0 |
| EQUIP | Equipped | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| EQUIP | false |
| EQUIPPED | false |
| GOT | false |
| NOT | false |
| R FINAL | false |
| R KING | false |
| R QUEEN | false |
| R SHADE | false |
| UPDATE | false |

