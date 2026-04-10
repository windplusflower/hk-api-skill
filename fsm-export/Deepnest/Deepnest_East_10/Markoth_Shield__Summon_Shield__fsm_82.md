# Summon Shield

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Summon Shield |
| GameObject Name | Markoth Shield |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets314.assets |
| Start State | Idle |
| FSM PathId | 82 |
| GameObject PathId | 20 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Shield 2 | Markoth Shield/Shield 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets314.assets) | NamedAssetPPtr: Markoth Shield/Shield 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets314.assets) |

## States

### Idle

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
| childName | "Shield 2" | "Shield 2" |  |  |
| storeResult | [Markoth Shield/Shield 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets314.assets)] | [Markoth Shield/Shield 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets314.assets)] | Variable |  |

### Summon

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shield 2 | OwnerDefault Shield 2 |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shield 2 | OwnerDefault Shield 2 |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3(4.05, 0, 0) | Vector3(4.05, 0, 0) |  |  |
| time | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| easeType | iTween/EaseType::easeOutCubic | 4 |  |  |
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
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Idle | SUMMON SHIELD | Summon | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SUMMON SHIELD | false |

