# ProxyFSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | ProxyFSM |
| GameObject Name | Knight |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 21915 |
| GameObject PathId | 3895 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Faced Nightmare | false | Boolean: false |
| Faced Radiance | false | Boolean: false |
| Faced Zote | false | Boolean: false |
| No Charms | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Item Name |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Acid Armour | [null] | NamedAssetPPtr:  |
| Charm Effects | [null] | NamedAssetPPtr:  |
| Effects | [null] | NamedAssetPPtr:  |
| Inventory | [null] | NamedAssetPPtr:  |
| Msg | [null] | NamedAssetPPtr:  |
| Msg Item | [null] | NamedAssetPPtr:  |
| Msg Text | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| White_Flower_Break | [null] | NamedAssetPPtr:  |
| White_Flower_Break | [null] | NamedAssetPPtr:  |

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 13

#### Actions

_None_

### Damaged

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Charm Effects | EventTarget(GameObject):Charm Effects |  |  |
| sendEvent | "HERO DAMAGED" | "HERO DAMAGED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Charm Effects | OwnerDefault Charm Effects |  |  |
| sendEvent | "HERO DAMAGED" | "HERO DAMAGED" |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "HERO DAMAGED" | "HERO DAMAGED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| sendEvent | "HERO DAMAGED" | "HERO DAMAGED" |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:HUD Canvas | EventTarget(GameObject)[SendToChildren]:HUD Canvas |  |  |
| sendEvent | "HERO DAMAGED" | "HERO DAMAGED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "HERO DAMAGED" | "HERO DAMAGED" |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Inventory | EventTarget(GameObject):Inventory |  |  |
| sendEvent | "HERO DAMAGED" | "HERO DAMAGED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Inventory | OwnerDefault Inventory |  |  |
| sendEvent | "HERO DAMAGED" | "HERO DAMAGED" |  |  |
| everyFrame | false | false |  |  |

##### 9. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "disablePause" | "disablePause" |  |  |
| isTrue | Event(BROADCAST) | Event(BROADCAST) |  |  |
| isFalse | Event() | Event() |  |  |

### Left Ground

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "LEFT GROUND" | "LEFT GROUND" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| sendEvent | "LEFT GROUND" | "LEFT GROUND" |  |  |
| everyFrame | false | false |  |  |

### Focus Completed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "FOCUS COMPLETED" | "FOCUS COMPLETED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| sendEvent | "FOCUS COMPLETED" | "FOCUS COMPLETED" |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:HUD Canvas | EventTarget(GameObject)[SendToChildren]:HUD Canvas |  |  |
| sendEvent | "HERO HEALED" | "HERO HEALED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Charm Effects | EventTarget(GameObject):Charm Effects |  |  |
| sendEvent | "HERO HEALED" | "HERO HEALED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Charm Effects | OwnerDefault Charm Effects |  |  |
| sendEvent | "HERO HEALED" | "HERO HEALED" |  |  |
| everyFrame | false | false |  |  |

### Leaving Scene

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "LEAVING SCENE" | "LEAVING SCENE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| sendEvent | "LEAVING SCENE" | "LEAVING SCENE" |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Charm Effects | EventTarget(GameObject):Charm Effects |  |  |
| sendEvent | "LEAVING SCENE" | "LEAVING SCENE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Charm Effects | OwnerDefault Charm Effects |  |  |
| sendEvent | "LEAVING SCENE" | "LEAVING SCENE" |  |  |
| everyFrame | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Effects | EventTarget(GameObject):Effects |  |  |
| sendEvent | "LEAVING SCENE" | "LEAVING SCENE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Effects | OwnerDefault Effects |  |  |
| sendEvent | "LEAVING SCENE" | "LEAVING SCENE" |  |  |
| everyFrame | false | false |  |  |

##### 7. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Inventory | EventTarget(GameObject):Inventory |  |  |
| sendEvent | "INVENTORY CANCEL" | "INVENTORY CANCEL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 8. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Inventory | OwnerDefault Inventory |  |  |
| sendEvent | "LEAVING SCENE" | "LEAVING SCENE" |  |  |
| everyFrame | false | false |  |  |

### Respawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "HERO RESPAWNED" | "HERO RESPAWNED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "CHARM INDICATOR CHECK" | "CHARM INDICATOR CHECK" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Landed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "HERO LANDED" | "HERO LANDED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| sendEvent | "HERO LANDED" | "HERO LANDED" |  |  |
| everyFrame | false | false |  |  |

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
| childName | "White_Flower_Break" | "White_Flower_Break" |  |  |
| storeResult | GameObject White_Flower_Break | GameObject White_Flower_Break | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Camera | OwnerDefault HUD Camera |  |  |
| childName | "Inventory" | "Inventory" |  |  |
| storeResult | GameObject Inventory | GameObject Inventory | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Charm Effects" | "Charm Effects" |  |  |
| storeResult | GameObject Charm Effects | GameObject Charm Effects | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Effects" | "Effects" |  |  |
| storeResult | GameObject Effects | GameObject Effects | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Effects | OwnerDefault Effects |  |  |
| childName | "Acid Armour" | "Acid Armour" |  |  |
| storeResult | GameObject Acid Armour | GameObject Acid Armour | Variable |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Healed Max

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:HUD Canvas | EventTarget(GameObject)[SendToChildren]:HUD Canvas |  |  |
| sendEvent | "HERO HEALED FULL" | "HERO HEALED FULL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Charm Effects | EventTarget(GameObject):Charm Effects |  |  |
| sendEvent | "HERO HEALED FULL" | "HERO HEALED FULL" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Charm Effects | OwnerDefault Charm Effects |  |  |
| sendEvent | "HERO HEALED FULL" | "HERO HEALED FULL" |  |  |
| everyFrame | false | false |  |  |

### Healed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:HUD Canvas | EventTarget(GameObject)[SendToChildren]:HUD Canvas |  |  |
| sendEvent | "HERO HEALED" | "HERO HEALED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Charm Effects | EventTarget(GameObject):Charm Effects |  |  |
| sendEvent | "HERO HEALED" | "HERO HEALED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault Charm Effects | OwnerDefault Charm Effects |  |  |
| sendEvent | "HERO HEALED" | "HERO HEALED" |  |  |
| everyFrame | false | false |  |  |

### Blocker Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "BLOCKER HIT" | "BLOCKER HIT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Enter Super Dash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "ENTER SUPER DASH" | "ENTER SUPER DASH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### End Dash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "DASH END" | "DASH END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventToGameObjectOptimized

Full Name: HutongGames.PlayMaker.Actions.SendEventToGameObjectOptimized
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| target | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| sendEvent | "DASH END" | "DASH END" |  |  |
| everyFrame | false | false |  |  |

### Flower?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTrueAndFalse

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTrueAndFalse
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| trueBool | "hasXunFlower" | "hasXunFlower" |  |  |
| falseBool | "xunFlowerBroken" | "xunFlowerBroken" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "xunFlowerBroken" | "xunFlowerBroken" |  |  |
| value | true | true |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault White_Flower_Break | OwnerDefault White_Flower_Break |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. IncrementPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.IncrementPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "xunFlowerBrokeTimes" | "xunFlowerBrokeTimes" |  |  |

##### 5. SpawnObjectFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Relic Get Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Relic Get Msg (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint |  |  |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| rotation | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| storeObject | GameObject Msg | GameObject Msg | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg | OwnerDefault Msg |  |  |
| childName | "Text" | "Text" |  |  |
| storeResult | GameObject Msg Text | GameObject Msg Text | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg | OwnerDefault Msg |  |  |
| childName | "Icon" | "Icon" |  |  |
| storeResult | GameObject Msg Item | GameObject Msg Item | Variable |  |

##### 8. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg Item | OwnerDefault Msg Item |  |  |
| sprite | [White_Flower_Half (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [White_Flower_Half (Sprite) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |

##### 9. GetLanguageString

Full Name: HutongGames.PlayMaker.Actions.GetLanguageString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sheetName | "UI" | "UI" |  |  |
| convName | "NOTIFICATION_FLOWER_BREAK" | "NOTIFICATION_FLOWER_BREAK" |  |  |
| storeValue | string Item Name | string Item Name | Variable |  |

##### 10. SetTextMeshProText

Full Name: HutongGames.PlayMaker.Actions.SetTextMeshProText
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Msg Text | OwnerDefault Msg Text |  |  |
| textString | string Item Name | string Item Name |  |  |

##### 11. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::RequireReceiver | 0 |  |  |
| functionCall | SaveGame(???) | SaveGame(???) |  |  |

### Enter Quake

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject)[SendToChildren]:FSM Owner | EventTarget(GameObject)[SendToChildren]:FSM Owner |  |  |
| sendEvent | "ENTER QUAKE" | "ENTER QUAKE" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Broadcast Damaged

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "HERO DAMAGED" | "HERO DAMAGED" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | HeroCtrl-HeroDamaged | Flower? | 0 | 0 | 0 |
| Idle | HeroCtrl-LeftGround | Left Ground | 0 | 0 | 0 |
| Idle | HeroCtrl-FocusCompleted | Focus Completed | 0 | 0 | 0 |
| Idle | HeroCtrl-LeavingScene | Leaving Scene | 0 | 0 | 0 |
| Idle | HeroCtrl-Respawned | Respawn | 0 | 0 | 0 |
| Idle | HeroCtrl-Landed | Landed | 0 | 0 | 0 |
| Idle | HeroCtrl-Healed | Healed | 0 | 0 | 0 |
| Idle | HeroCtrl-MaxHealth | Healed Max | 0 | 0 | 0 |
| Idle | HeroCtrl-TookBlockerHit | Blocker Hit | 0 | 0 | 0 |
| Idle | HeroCtrl-EnterSuperDash | Enter Super Dash | 0 | 0 | 0 |
| Idle | HeroCtrl-ShadowDashEnd |  | 0 | 0 | 0 |
| Idle | HeroCtrl-DashEnd | End Dash | 0 | 0 | 0 |
| Idle | HeroCtrl-EnterQuake | Enter Quake | 0 | 0 | 0 |
| Damaged | FINISHED | Idle | 0 | 0 | 0 |
| Damaged | BROADCAST | Broadcast Damaged | 0 | 0 | 0 |
| Left Ground | FINISHED | Idle | 0 | 0 | 0 |
| Focus Completed | FINISHED | Idle | 0 | 0 | 0 |
| Leaving Scene | FINISHED | Idle | 0 | 0 | 0 |
| Respawn | FINISHED | Idle | 0 | 0 | 0 |
| Landed | FINISHED | Idle | 0 | 0 | 0 |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Healed Max | FINISHED | Idle | 0 | 0 | 0 |
| Healed | FINISHED | Idle | 0 | 0 | 0 |
| Blocker Hit | FINISHED | Damaged | 0 | 0 | 0 |
| Enter Super Dash | FINISHED | Idle | 0 | 0 | 0 |
| End Dash | FINISHED | Idle | 0 | 0 | 0 |
| Flower? | FINISHED | Damaged | 0 | 0 | 0 |
| Enter Quake | FINISHED | Idle | 0 | 0 | 0 |
| Broadcast Damaged | FINISHED | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| BROADCAST | false |
| DASH END | false |
| HERO DAMAGED | true |
| HERO HEALED | false |
| HERO HEALED FULL | false |
| HERO LANDED | false |
| HeroCtrl-DashEnd | false |
| HeroCtrl-EnterQuake | false |
| HeroCtrl-EnterSuperDash | false |
| HeroCtrl-FocusCompleted | false |
| HeroCtrl-Healed | false |
| HeroCtrl-HeroDamaged | false |
| HeroCtrl-Landed | false |
| HeroCtrl-LeavingScene | false |
| HeroCtrl-LeftGround | false |
| HeroCtrl-MaxHealth | false |
| HeroCtrl-Respawned | false |
| HeroCtrl-ShadowDash | false |
| HeroCtrl-ShadowDashEnd | false |
| HeroCtrl-TookBlockerHit | false |

