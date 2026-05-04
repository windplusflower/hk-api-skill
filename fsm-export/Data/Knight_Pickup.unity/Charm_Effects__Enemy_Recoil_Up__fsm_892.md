# Enemy Recoil Up

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Enemy Recoil Up |
| GameObject Name | Charm Effects |
| GameObject Path | Knight/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level4 |
| Start State | Init |
| FSM PathId | 892 |
| GameObject PathId | 147 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Alt Slash | [null] | NamedAssetPPtr: [null] |
| Attacks | [null] | NamedAssetPPtr: [null] |
| Cyclone Slash | [null] | NamedAssetPPtr: [null] |
| Down Slash | [null] | NamedAssetPPtr: [null] |
| Great Slash | [null] | NamedAssetPPtr: [null] |
| Hit L | [null] | NamedAssetPPtr: [null] |
| Hit R | [null] | NamedAssetPPtr: [null] |
| Hits | [null] | NamedAssetPPtr: [null] |
| Knight | [null] | NamedAssetPPtr: [null] |
| Slash | [null] | NamedAssetPPtr: [null] |
| Up Slash | [null] | NamedAssetPPtr: [null] |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "equippedCharm_15" |   |   |
| isTrue |   | Event(EQUIPPED) |   |   |
| isFalse |   | Event(UNEQUIPPED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EQUIPPED | Equipped | 0 | |
| UNEQUIPPED | Unequipped | 0 | |

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
| gameObject |   | OwnerDefault Alt Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 1.75f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Down Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 1.75f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Up Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 1.75f |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 1.75f |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Great Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 2f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hit L |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 2.5f |   |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hit R |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 2.5f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| storeResult |   | GameObject Knight | Variable |   |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Knight |   |   |
| childName |   | "Attacks" |   |   |
| storeResult |   | GameObject Attacks | Variable |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Attacks |   |   |
| childName |   | "AltSlash" |   |   |
| storeResult |   | GameObject Alt Slash | Variable |   |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Attacks |   |   |
| childName |   | "DownSlash" |   |   |
| storeResult |   | GameObject Down Slash | Variable |   |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Attacks |   |   |
| childName |   | "UpSlash" |   |   |
| storeResult |   | GameObject Up Slash | Variable |   |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Attacks |   |   |
| childName |   | "Slash" |   |   |
| storeResult |   | GameObject Slash | Variable |   |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Attacks |   |   |
| childName |   | "Great Slash" |   |   |
| storeResult |   | GameObject Great Slash | Variable |   |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Attacks |   |   |
| childName |   | "Cyclone Slash" |   |   |
| storeResult |   | GameObject Cyclone Slash | Variable |   |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cyclone Slash |   |   |
| childName |   | "Hits" |   |   |
| storeResult |   | GameObject Hits | Variable |   |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hits |   |   |
| childName |   | "Hit L" |   |   |
| storeResult |   | GameObject Hit L | Variable |   |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hits |   |   |
| childName |   | "Hit R" |   |   |
| storeResult |   | GameObject Hit R | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

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
| gameObject |   | OwnerDefault Alt Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 1f |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Down Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 1f |   |   |
| everyFrame |   | false |   |   |

##### 3. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Up Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 1f |   |   |
| everyFrame |   | false |   |   |

##### 4. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 1f |   |   |
| everyFrame |   | false |   |   |

##### 5. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Great Slash |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 1.5f |   |   |
| everyFrame |   | false |   |   |

##### 6. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hit L |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 2f |   |   |
| everyFrame |   | false |   |   |

##### 7. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Hit R |   |   |
| fsmName |   | "damages_enemy" | FsmName |   |
| variableName |   | "magnitudeMult" | FsmFloat |   |
| setValue |   | 2f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHARM EQUIP CHECK | Check | 0 | |

## Events

| Name | Global |
| --- | --- |
| CHARM EQUIP CHECK | false |
| EQUIPPED | false |
| FINISHED | false |
| UNEQUIPPED | false |

