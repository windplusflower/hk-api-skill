# Soul Orb Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Soul Orb Control |
| GameObject Name | Soul Orb |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 20296 |
| GameObject PathId | 5349 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Liquid Bottom Y | -0.59 | Single: -0.59 |
| Liquid Y | 0 | Single: 0 |
| Liquid Y Per MP | 0.0171 | Single: 0.0171 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Focus MP amount | 0 | Int32: 0 |
| HP | 0 | Int32: 0 |
| MP | 0 | Int32: 0 |
| Max HP | 0 | Int32: 0 |
| Max MP | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Can Focus Anim | false | Boolean: false |
| Focus Prompted | false | Boolean: false |
| Half Burst | false | Boolean: false |
| Has Spell | false | Boolean: false |
| Hero Focusing | false | Boolean: false |
| Orb Filled | false | Boolean: false |
| Setting | false | Boolean: false |

### Vector3s

| Name | Value | Raw/Type |
| --- | --- | --- |
| Tween Vector | Vector3(0, 0, 0) | Vector3: Vector3(0, 0, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Binding Cap | _GameCameras/HudCamera/Hud Canvas/Soul Orb/Binding Cap (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: _GameCameras/HudCamera/Hud Canvas/Soul Orb/Binding Cap (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Binding Cap Full | _GameCameras/HudCamera/Hud Canvas/Soul Orb/Binding Cap Full (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) | NamedAssetPPtr: _GameCameras/HudCamera/Hud Canvas/Soul Orb/Binding Cap Full (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets) |
| Burst Anim | [null] | NamedAssetPPtr:  |
| Can Heal Particles | [null] | NamedAssetPPtr:  |
| Effect | [null] | NamedAssetPPtr:  |
| Eyes | [null] | NamedAssetPPtr:  |
| Fill | [null] | NamedAssetPPtr:  |
| Get Flash | [null] | NamedAssetPPtr:  |
| Hero | [null] | NamedAssetPPtr:  |
| Hero Effects | [null] | NamedAssetPPtr:  |
| Liquid | [null] | NamedAssetPPtr:  |
| Orb Anim | [null] | NamedAssetPPtr:  |
| Orb Full | [null] | NamedAssetPPtr:  |
| Soul Burst | [null] | NamedAssetPPtr:  |
| Vessel Folder | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetHero

Full Name: GetHero
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | GameObject Hero | GameObject Hero | Variable |  |

##### 2. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "ClearMP" | "ClearMP" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Binding Cap | OwnerDefault Binding Cap |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Binding Cap Full | OwnerDefault Binding Cap Full |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| childName | "Effects" | "Effects" |  |  |
| storeResult | GameObject Hero Effects | GameObject Hero Effects | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero Effects | OwnerDefault Hero Effects |  |  |
| childName | "Soul Burst" | "Soul Burst" |  |  |
| storeResult | GameObject Soul Burst | GameObject Soul Burst | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Vessels" | "Vessels" |  |  |
| storeResult | GameObject Vessel Folder | GameObject Vessel Folder | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "SoulOrb_fill" | "SoulOrb_fill" |  |  |
| storeResult | GameObject Fill | GameObject Fill | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "White Flash" | "White Flash" |  |  |
| storeResult | GameObject Get Flash | GameObject Get Flash | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Can Heal Particles" | "Can Heal Particles" |  |  |
| storeResult | GameObject Can Heal Particles | GameObject Can Heal Particles | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Eyes" | "Eyes" |  |  |
| storeResult | GameObject Eyes | GameObject Eyes | Variable |  |

##### 12. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fill | OwnerDefault Fill |  |  |
| childName | "Liquid" | "Liquid" |  |  |
| storeResult | GameObject Liquid | GameObject Liquid | Variable |  |

##### 13. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Orb Anim" | "Orb Anim" |  |  |
| storeResult | GameObject Orb Anim | GameObject Orb Anim | Variable |  |

##### 14. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Orb Full" | "Orb Full" |  |  |
| storeResult | GameObject Orb Full | GameObject Orb Full | Variable |  |

##### 15. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Burst Anim" | "Burst Anim" |  |  |
| storeResult | GameObject Burst Anim | GameObject Burst Anim | Variable |  |

##### 16. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPCharge" | "MPCharge" |  |  |
| storeValue | int MP | int MP | Variable |  |

##### 17. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(MP IS ZERO) | Event(MP IS ZERO) |  |  |
| lessThan | Event(MP IS ZERO) | Event(MP IS ZERO) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 18. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int MP | int MP | Variable |  |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| everyFrame | false | false |  |  |

##### 19. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| multiplyBy | float Liquid Y Per MP | float Liquid Y Per MP |  |  |
| everyFrame | false | false |  |  |

##### 20. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| add | float Liquid Bottom Y | float Liquid Bottom Y |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 21. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Liquid | OwnerDefault Liquid |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Liquid Y | float Liquid Y |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 22. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | 100 | 100 |  |  |
| equal | Event(FULL) | Event(FULL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FULL) | Event(FULL) |  |  |
| everyFrame | false | false |  |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Setting | bool Setting | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### MP Drain

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Vessel Folder | EventTarget(GameObject):Vessel Folder |  |  |
| sendEvent | "MP DRAIN" | "MP DRAIN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Orb Full | OwnerDefault Orb Full |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Binding Cap Full | EventTarget(GameObject):Binding Cap Full |  |  |
| sendEvent | "NOT FULL" | "NOT FULL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Orb Filled | bool Orb Filled | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPCharge" | "MPCharge" |  |  |
| storeValue | int MP | int MP | Variable |  |

##### 6. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(MP IS ZERO) | Event(MP IS ZERO) |  |  |
| lessThan | Event(MP IS ZERO) | Event(MP IS ZERO) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 7. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int MP | int MP | Variable |  |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| everyFrame | false | false |  |  |

##### 8. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| multiplyBy | float Liquid Y Per MP | float Liquid Y Per MP |  |  |
| everyFrame | false | false |  |  |

##### 9. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| add | float Liquid Bottom Y | float Liquid Bottom Y |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 10. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Liquid | OwnerDefault Liquid |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Liquid Y | float Liquid Y |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### MP <= 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Liquid | OwnerDefault Liquid |  |  |
| active | false | false |  |  |

##### 2. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Liquid | OwnerDefault Liquid |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -10f | -10f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### MP Gain

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Liquid | OwnerDefault Liquid |  |  |
| active | true | true |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPCharge" | "MPCharge" |  |  |
| storeValue | int MP | int MP | Variable |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "maxMP" | "maxMP" |  |  |
| storeValue | int Max MP | int Max MP | Variable |  |

##### 4. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int MP | int MP | Variable |  |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| everyFrame | false | false |  |  |

##### 5. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| multiplyBy | float Liquid Y Per MP | float Liquid Y Per MP |  |  |
| everyFrame | false | false |  |  |

##### 6. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| add | float Liquid Bottom Y | float Liquid Bottom Y |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 7. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Liquid | OwnerDefault Liquid |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Liquid Y | float Liquid Y |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 8. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | int Max MP | int Max MP |  |  |
| equal | Event(FULL) | Event(FULL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FULL) | Event(FULL) |  |  |
| everyFrame | false | false |  |  |

##### 9. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | 50 | 50 |  |  |
| equal | Event(HALF FULL) | Event(HALF FULL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(HALF FULL) | Event(HALF FULL) |  |  |
| everyFrame | false | false |  |  |

##### 10. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Half Burst | bool Half Burst | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

### MP Full

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
| boolName | "soulLimited" | "soulLimited" |  |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |

##### 2. GGCheckBoundSoul

Full Name: GGCheckBoundSoul
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boundEvent | Event(GG BINDING) | Event(GG BINDING) |  |  |
| unboundEvent | Event() | Event() |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Orb Filled | bool Orb Filled | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Orb Full | OwnerDefault Orb Full |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Orb Filled | bool Orb Filled | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 6. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "hasSpell" | "hasSpell" |  |  |
| storeValue | bool Has Spell | bool Has Spell | Variable |  |

##### 7. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Setting | bool Setting | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 8. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Burst Anim | OwnerDefault Burst Anim |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Check Can Heal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetFsmBool

Full Name: HutongGames.PlayMaker.Actions.GetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Spell Control" | "Spell Control" | FsmName |  |
| variableName | "Focusing" | "Focusing" | FsmBool |  |
| storeValue | bool Hero Focusing | bool Hero Focusing | Variable |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Hero Focusing | bool Hero Focusing | Variable |  |
| isTrue | Event(CANCEL) | Event(CANCEL) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPCharge" | "MPCharge" |  |  |
| storeValue | int MP | int MP | Variable |  |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "focusMP_amount" | "focusMP_amount" |  |  |
| storeValue | int Focus MP amount | int Focus MP amount | Variable |  |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | int Focus MP amount | int Focus MP amount |  |  |
| equal | Event(CAN HEAL) | Event(CAN HEAL) |  |  |
| lessThan | Event(CANT HEAL) | Event(CANT HEAL) |  |  |
| greaterThan | Event(CAN HEAL) | Event(CAN HEAL) |  |  |
| everyFrame | false | false |  |  |

### Can't Heal

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Can Focus Anim | bool Can Focus Anim | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Liquid | EventTarget(GameObject):Liquid |  |  |
| sendEvent | "CANT HEAL" | "CANT HEAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### MP Lose

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Liquid | OwnerDefault Liquid |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Shrink" | "Shrink" |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Orb Full | OwnerDefault Orb Full |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Binding Cap Full | EventTarget(GameObject):Binding Cap Full |  |  |
| sendEvent | "NOT FULL" | "NOT FULL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Orb Filled | bool Orb Filled | Variable |  |
| boolValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. Tk2dPlayFrame

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayFrame
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Liquid | OwnerDefault Liquid |  |  |
| frame | 0 | 0 |  |  |

##### 6. ConvertIntToFloat

Full Name: HutongGames.PlayMaker.Actions.ConvertIntToFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int MP | int MP | Variable |  |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| everyFrame | false | false |  |  |

##### 7. FloatMultiply

Full Name: HutongGames.PlayMaker.Actions.FloatMultiply
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| multiplyBy | float Liquid Y Per MP | float Liquid Y Per MP |  |  |
| everyFrame | false | false |  |  |

##### 8. FloatAdd

Full Name: HutongGames.PlayMaker.Actions.FloatAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Liquid Y | float Liquid Y | Variable |  |
| add | float Liquid Bottom Y | float Liquid Bottom Y |  |  |
| everyFrame | false | false |  |  |
| perSecond | false | false |  |  |

##### 9. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Liquid | OwnerDefault Liquid |  |  |
| vector | Vector3 Tween Vector | Vector3 Tween Vector | Variable |  |
| x | 0f | 0f | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |

##### 10. SetVector3XYZ

Full Name: HutongGames.PlayMaker.Actions.SetVector3XYZ
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| vector3Variable | Vector3 Tween Vector | Vector3 Tween Vector | Variable |  |
| vector3Value | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | float Liquid Y | float Liquid Y |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 11. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Liquid | OwnerDefault Liquid |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3 Tween Vector | Vector3 Tween Vector |  |  |
| time | 0.5f | 0.5f |  |  |
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
| moveToPath | true | true |  | Path |
| lookAhead | 0f | 0f |  |  |
| transforms | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| vectors | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| reverse | false | false |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

### Check MP

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPCharge" | "MPCharge" |  |  |
| storeValue | int MP | int MP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(MP IS ZERO) | Event(MP IS ZERO) |  |  |
| lessThan | Event(MP IS ZERO) | Event(MP IS ZERO) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Check Eyes

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | 50 | 50 |  |  |
| equal | Event(OVER) | Event(OVER) |  |  |
| lessThan | Event(UNDER) | Event(UNDER) |  |  |
| greaterThan | Event(OVER) | Event(OVER) |  |  |
| everyFrame | false | false |  |  |

### Over

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Eyes | EventTarget(GameObject):Eyes |  |  |
| sendEvent | "OVER" | "OVER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Under

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Eyes | EventTarget(GameObject):Eyes |  |  |
| sendEvent | "UNDER" | "UNDER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Under 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Eyes | EventTarget(GameObject):Eyes |  |  |
| sendEvent | "UNDER" | "UNDER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Check Eyes 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPCharge" | "MPCharge" |  |  |
| storeValue | int MP | int MP | Variable |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Vessel Folder | EventTarget(GameObject):Vessel Folder |  |  |
| sendEvent | "MP DRAIN" | "MP DRAIN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | 50 | 50 |  |  |
| equal | Event(OVER) | Event(OVER) |  |  |
| lessThan | Event(UNDER) | Event(UNDER) |  |  |
| greaterThan | Event(OVER) | Event(OVER) |  |  |
| everyFrame | false | false |  |  |

### Over 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Eyes | EventTarget(GameObject):Eyes |  |  |
| sendEvent | "OVER" | "OVER" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Start Full

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GGCheckBoundSoul

Full Name: GGCheckBoundSoul
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boundEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| unboundEvent | Event() | Event() |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Orb Full | OwnerDefault Orb Full |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Check Focus Prompt

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "promptFocus" | "promptFocus" |  |  |
| storeValue | bool Focus Prompted | bool Focus Prompted | Variable |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Focus Prompted | bool Focus Prompted | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "seenFocusTablet" | "seenFocusTablet" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "health" | "health" |  |  |
| storeValue | int HP | int HP | Variable |  |

##### 5. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "maxHealth" | "maxHealth" |  |  |
| storeValue | int Max HP | int Max HP | Variable |  |

##### 6. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | int Max HP | int Max HP |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 7. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int HP | int HP |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(FINISHED) | Event(FINISHED) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 8. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPCharge" | "MPCharge" |  |  |
| storeValue | int MP | int MP | Variable |  |

##### 9. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | 33 | 33 |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 10. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "promptFocus" | "promptFocus" |  |  |
| value | true | true |  |  |

##### 11. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "REMINDER FOCUS" | "REMINDER FOCUS" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Already Can Heal?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | int Focus MP amount | int Focus MP amount |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(CANT HEAL) | Event(CANT HEAL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Can Focus Anim | bool Can Focus Anim | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Orb Flash?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Setting | bool Setting | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPCharge" | "MPCharge" |  |  |
| storeValue | int MP | int MP | Variable |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "maxMP" | "maxMP" |  |  |
| storeValue | int Max MP | int Max MP | Variable |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int MP | int MP |  |  |
| integer2 | int Max MP | int Max MP |  |  |
| equal | Event(FULL) | Event(FULL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FULL) | Event(FULL) |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Get Flash | EventTarget(GameObject):Get Flash |  |  |
| sendEvent | "FLASH" | "FLASH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Setting | bool Setting | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

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

### Can Heal 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Liquid | EventTarget(GameObject):Liquid |  |  |
| sendEvent | "CAN HEAL" | "CAN HEAL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Can Focus Anim | bool Can Focus Anim | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Setting | bool Setting | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Can Heal Particles | OwnerDefault Can Heal Particles |  |  |
| emit | 0 | 0 |  |  |

##### 5. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Hero | GameObject Hero |  |  |
| audioClip | [focus_ready (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [focus_ready (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Soul Burst | OwnerDefault Soul Burst |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. SetScale

Full Name: HutongGames.PlayMaker.Actions.SetScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Effect | OwnerDefault Effect |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 2f | 2f |  |  |
| y | 2f | 2f |  |  |
| z | 0f | 0f |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

##### 8. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | flashFocusGet(???) | flashFocusGet(???) |  |  |

##### 9. SetParent

Full Name: HutongGames.PlayMaker.Actions.SetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Effect | OwnerDefault Effect |  |  |
| parent | GameObject Hero | GameObject Hero |  |  |
| resetLocalPosition | false | false |  |  |
| resetLocalRotation | false | false |  |  |

##### 10. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "CAN HEAL EFFECT" | "CAN HEAL EFFECT" |  |  |

##### 11. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Can Focus Anim | bool Can Focus Anim | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Binding?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GGCheckBoundSoul

Full Name: GGCheckBoundSoul
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boundEvent | Event(GG BINDING) | Event(GG BINDING) |  |  |
| unboundEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Bound

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Binding Cap | OwnerDefault Binding Cap |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Orb Full | OwnerDefault Orb Full |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Not Bound

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Binding Cap | OwnerDefault Binding Cap |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Binding Cap Full | OwnerDefault Binding Cap Full |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Bound Full

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Binding Cap Full | OwnerDefault Binding Cap Full |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Set?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Setting | bool Setting | Variable |  |
| isTrue | Event(TRUE) | Event(TRUE) |  |  |
| isFalse | Event(FALSE) | Event(FALSE) |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Already Can Heal? | 0 | 0 | 0 |
| Init | MP IS ZERO | MP &lt;= 1 | 0 | 0 | 0 |
| Init | FULL | Start Full | 0 | 0 | 0 |
| Idle | MP DRAIN | MP Drain | 0 | 0 | 0 |
| Idle | MP GAIN | Orb Flash? | 0 | 0 | 0 |
| Idle | MP LOSE | Binding? | 0 | 0 | 0 |
| Idle | MP GAIN SPA | MP Gain | 0 | 0 | 0 |
| Idle | MP SET | Set | 0 | 0 | 0 |
| MP Drain | FINISHED | Check Can Heal | 0 | 0 | 0 |
| MP Drain | MP IS ZERO | MP &lt;= 1 | 0 | 0 | 0 |
| MP &lt;= 1 | FINISHED | Check Can Heal | 0 | 0 | 0 |
| MP Gain | FINISHED | Check Can Heal | 0 | 0 | 0 |
| MP Gain | FULL | MP Full | 0 | 0 | 0 |
| MP Gain | HALF FULL |  | 0 | 0 | 0 |
| MP Full | FINISHED | Check Can Heal | 0 | 0 | 0 |
| MP Full | GG BINDING | Bound Full | 0 | 0 | 0 |
| Check Can Heal | CANCEL | Idle | 0 | 0 | 0 |
| Check Can Heal | CAN HEAL | Can Heal 2 | 0 | 0 | 0 |
| Check Can Heal | CANT HEAL | Can't Heal | 0 | 0 | 0 |
| Can't Heal | FINISHED | Check Eyes | 0 | 0 | 0 |
| MP Lose | FINISHED | Check MP | 0 | 0 | 0 |
| MP Lose | MP LOSE | Check Eyes 2 | 0 | 0 | 0 |
| Check MP | MP IS ZERO | MP &lt;= 1 | 0 | 0 | 0 |
| Check MP | FINISHED | Check Can Heal | 0 | 0 | 0 |
| Check Eyes | OVER | Over | 0 | 0 | 0 |
| Check Eyes | UNDER | Under | 0 | 0 | 0 |
| Over | FINISHED | Idle | 0 | 0 | 0 |
| Under | FINISHED | Idle | 0 | 0 | 0 |
| Under 2 | FINISHED | MP Lose | 0 | 0 | 0 |
| Check Eyes 2 | OVER | Over 2 | 0 | 0 | 0 |
| Check Eyes 2 | UNDER | Under 2 | 0 | 0 | 0 |
| Over 2 | FINISHED | MP Lose | 0 | 0 | 0 |
| Start Full | FINISHED | Already Can Heal? | 0 | 0 | 0 |
| Check Focus Prompt | FINISHED | MP Gain | 0 | 0 | 0 |
| Already Can Heal? | CANT HEAL | Check Can Heal | 0 | 0 | 0 |
| Already Can Heal? | FINISHED | Check Can Heal | 0 | 0 | 0 |
| Orb Flash? | FULL | Check Focus Prompt | 0 | 0 | 0 |
| Orb Flash? | FINISHED | Check Focus Prompt | 0 | 0 | 0 |
| Set | FINISHED | Binding? | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |
| Can Heal 2 | FINISHED | Check Eyes | 0 | 0 | 0 |
| Binding? | FINISHED | Not Bound | 0 | 0 | 0 |
| Binding? | GG BINDING | Bound | 0 | 0 | 0 |
| Bound | FINISHED | Set? | 0 | 0 | 0 |
| Not Bound | FINISHED | Set? | 0 | 0 | 0 |
| Bound Full | FINISHED | Check Can Heal | 0 | 0 | 0 |
| Set? | TRUE | Orb Flash? | 0 | 0 | 0 |
| Set? | FALSE | Check Eyes 2 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CAN HEAL | false |
| CANCEL | false |
| CANT HEAL | false |
| DONE | false |
| FALSE | false |
| FULL | false |
| GG BINDING | false |
| HALF FULL | false |
| MP DRAIN | false |
| MP GAIN | false |
| MP GAIN SPA | false |
| MP IS ZERO | false |
| MP LOSE | false |
| MP SET | false |
| MP TO ZERO | false |
| OVER | false |
| TRUE | false |
| UNDER | false |

