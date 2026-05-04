# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Grimm Flame UI |
| GameObject Path | _GameCameras/HudCamera/Inventory/Charms/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level1 |
| Start State | Init |
| FSM PathId | 9638 |
| GameObject PathId | 1761 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Flames Collected | 0 | Int32: 0 |
| Grimmchild Level | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| S1 Flame1 | _GameCameras/HudCamera/Inventory/Charms/Grimm Flame UI/Set 1/Flame 1 (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Inventory/Charms/Grimm Flame UI/Set 1/Flame 1 (Hollow Knight/hollow_knight_Data\level1)] |
| S1 Flame2 | _GameCameras/HudCamera/Inventory/Charms/Grimm Flame UI/Set 1/Flame 2 (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Inventory/Charms/Grimm Flame UI/Set 1/Flame 2 (Hollow Knight/hollow_knight_Data\level1)] |
| S1 Flame3 | _GameCameras/HudCamera/Inventory/Charms/Grimm Flame UI/Set 1/Flame 3 (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Inventory/Charms/Grimm Flame UI/Set 1/Flame 3 (Hollow Knight/hollow_knight_Data\level1)] |
| Self | [null] | NamedAssetPPtr: [null] |
| Set 1 | _GameCameras/HudCamera/Inventory/Charms/Grimm Flame UI/Set 1 (Hollow Knight/hollow_knight_Data\level1) | NamedAssetPPtr: [_GameCameras/HudCamera/Inventory/Charms/Grimm Flame UI/Set 1 (Hollow Knight/hollow_knight_Data\level1)] |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "flamesCollected" |   |   |
| storeValue |   | int Flames Collected | Variable |   |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "grimmChildLevel" |   |   |
| storeValue |   | int Grimmchild Level | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Hide | 0 | |

### Hide

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Self | Variable |   |
| activate |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SHOW | Level? | 0 | |

### Level?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Grimmchild Level | Variable |   |
| compareTo |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

##### 2. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(Self):FSM Owner |   |   |
| sendEvent |   | 1 |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| 1 | Set 1 | 0 | |
| 2 |   | 0 | |
| 3 |   | 0 | |
| 4 | Hide | 0 | |
| 5 | Hide | 0 | |

### Set 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Set 1 |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 2. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Flames Collected | Variable |   |
| compareTo |   | FSMViewAvalonia2.FsmArray2 |   |   |
| sendEvent |   | FSMViewAvalonia2.FsmArray2 |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| 1 | S1 F 1 | 0 | |
| 2 | S1 F 2 | 0 | |
| 3 | S1 F 3 | 0 | |
| 0 | None | 0 | |

### S1 F 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame1 |   |   |
| sprite |   | [Grimm_charm_flame_front (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

##### 2. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame2 |   |   |
| sprite |   | [Grimm_charm_flame_backboard (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

##### 3. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame3 |   |   |
| sprite |   | [Grimm_charm_flame_backboard (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |   | 0 | |

### S1 F 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame1 |   |   |
| sprite |   | [Grimm_charm_flame_front (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

##### 2. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame2 |   |   |
| sprite |   | [Grimm_charm_flame_front (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

##### 3. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame3 |   |   |
| sprite |   | [Grimm_charm_flame_backboard (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |   | 0 | |

### S1 F 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame1 |   |   |
| sprite |   | [Grimm_charm_flame_front (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

##### 2. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame2 |   |   |
| sprite |   | [Grimm_charm_flame_front (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

##### 3. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame3 |   |   |
| sprite |   | [Grimm_charm_flame_front (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED |   | 0 | |

### None

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame1 |   |   |
| sprite |   | [Grimm_charm_flame_backboard (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

##### 2. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame2 |   |   |
| sprite |   | [Grimm_charm_flame_backboard (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

##### 3. SetSpriteRendererSprite

Full Name: HutongGames.PlayMaker.Actions.SetSpriteRendererSprite
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault S1 Flame3 |   |   |
| sprite |   | [Grimm_charm_flame_backboard (Sprite) (Hollow Knight/hollow_knight_Data\resources.assets)] |   |   |

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| HIDE | Hide | 0 | |
| INVENTORY CLOSED | Hide | 0 | |

## Events

| Name | Global |
| --- | --- |
| 0 | false |
| 1 | false |
| 2 | false |
| 3 | false |
| 4 | false |
| 5 | false |
| FINISHED | false |
| HIDE | false |
| INVENTORY CLOSED | false |
| SHOW | false |

