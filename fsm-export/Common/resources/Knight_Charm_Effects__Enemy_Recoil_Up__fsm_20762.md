# Enemy Recoil Up

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Enemy Recoil Up |
| GameObject Name | Charm Effects |
| GameObject Path | Knight |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20762 |
| GameObject PathId | 4312 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alt Slash | [null] | NamedAssetPPtr:  |
| Attacks | [null] | NamedAssetPPtr:  |
| Cyclone Slash | [null] | NamedAssetPPtr:  |
| Down Slash | [null] | NamedAssetPPtr:  |
| Great Slash | [null] | NamedAssetPPtr:  |
| Hit L | [null] | NamedAssetPPtr:  |
| Hit R | [null] | NamedAssetPPtr:  |
| Hits | [null] | NamedAssetPPtr:  |
| Knight | [null] | NamedAssetPPtr:  |
| Slash | [null] | NamedAssetPPtr:  |
| Up Slash | [null] | NamedAssetPPtr:  |

## States

### Check

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
| boolName | "equippedCharm_15" | "equippedCharm_15" |  |  |
| isTrue | Event(EQUIPPED) | Event(EQUIPPED) |  |  |
| isFalse | Event(UNEQUIPPED) | Event(UNEQUIPPED) |  |  |

### Equipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Alt Slash | OwnerDefault Alt Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Down Slash | OwnerDefault Down Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Up Slash | OwnerDefault Up Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Slash | OwnerDefault Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 1.75f | 1.75f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash | OwnerDefault Great Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit L | OwnerDefault Hit L |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 2.5f | 2.5f |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit R | OwnerDefault Hit R |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 2.5f | 2.5f |  |  |
| everyFrame | false | false |  |  |

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Knight | GameObject Knight | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Knight | OwnerDefault Knight |  |  |
| childName | "Attacks" | "Attacks" |  |  |
| storeResult | GameObject Attacks | GameObject Attacks | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "AltSlash" | "AltSlash" |  |  |
| storeResult | GameObject Alt Slash | GameObject Alt Slash | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "DownSlash" | "DownSlash" |  |  |
| storeResult | GameObject Down Slash | GameObject Down Slash | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "UpSlash" | "UpSlash" |  |  |
| storeResult | GameObject Up Slash | GameObject Up Slash | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "Slash" | "Slash" |  |  |
| storeResult | GameObject Slash | GameObject Slash | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "Great Slash" | "Great Slash" |  |  |
| storeResult | GameObject Great Slash | GameObject Great Slash | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Attacks | OwnerDefault Attacks |  |  |
| childName | "Cyclone Slash" | "Cyclone Slash" |  |  |
| storeResult | GameObject Cyclone Slash | GameObject Cyclone Slash | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Cyclone Slash | OwnerDefault Cyclone Slash |  |  |
| childName | "Hits" | "Hits" |  |  |
| storeResult | GameObject Hits | GameObject Hits | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hits | OwnerDefault Hits |  |  |
| childName | "Hit L" | "Hit L" |  |  |
| storeResult | GameObject Hit L | GameObject Hit L | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hits | OwnerDefault Hits |  |  |
| childName | "Hit R" | "Hit R" |  |  |
| storeResult | GameObject Hit R | GameObject Hit R | Variable |  |

### Unequipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Alt Slash | OwnerDefault Alt Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Down Slash | OwnerDefault Down Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Up Slash | OwnerDefault Up Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Slash | OwnerDefault Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Great Slash | OwnerDefault Great Slash |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |

##### 6. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit L | OwnerDefault Hit L |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hit R | OwnerDefault Hit R |  |  |
| fsmName | "damages_enemy" | "damages_enemy" | FsmName |  |
| variableName | "magnitudeMult" | "magnitudeMult" | FsmFloat |  |
| setValue | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Check | EQUIPPED | Equipped | 0 | 0 | 0 |
| Check | UNEQUIPPED | Unequipped | 0 | 0 | 0 |
| Init | FINISHED | Check | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| CHARM EQUIP CHECK | Check | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CHARM EQUIP CHECK | false |
| EQUIPPED | false |
| UNEQUIPPED | false |

