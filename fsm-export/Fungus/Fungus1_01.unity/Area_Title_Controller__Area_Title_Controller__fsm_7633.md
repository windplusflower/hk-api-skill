# Area Title Controller

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Area Title Controller |
| GameObject Name | Area Title Controller |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level128 |
| Start State | Init |
| FSM PathId | 7633 |
| GameObject PathId | 2142 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Unvisited Pause | 2 | Single: 2 |
| Visited Pause | 2 | Single: 2 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area ID | 2 | Int32: 2 |
| Current Area | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Always Visited | false | Boolean: false |
| Display Right | false | Boolean: false |
| Only On Revisit | false | Boolean: false |
| Sub Area | true | Boolean: true |
| Visited Area | false | Boolean: false |
| Wait for Trigger | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area Event | GREENPATH | String: GREENPATH |
| Door Trigger |   | String:  |
| Entry Door |   | String:  |
| Visited Bool | visitedCrossroads | String: visitedCrossroads |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Area Title | [null] | NamedAssetPPtr: [null] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Wait for Trigger | Variable |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(DISPLAY) |   |   |
| everyFrame |   | false |   |   |

##### 2. Trigger2dEvent

Full Name: HutongGames.PlayMaker.Actions.Trigger2dEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| trigger | PlayMakerUnity2d/Trigger2DType::OnTriggerEnter2D | 0 |   |   |
| collideTag |   | "" | Tag |   |
| collideLayer |   | "" | Layer |   |
| sendEvent |   | Event(DISPLAY) |   |   |
| storeCollider |   |   | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DISPLAY |   | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| ABYSS | false |
| ABYSS_DEEP | false |
| ACID_LAKE | false |
| BLUE_LAKE | false |
| CLIFFS | false |
| COLOSSEUM | false |
| CROSSROADS | false |
| DEEPNEST | false |
| DIRTMOUTH | false |
| DISPLAY | false |
| EGGTEMPLE | false |
| FINISHED | false |
| FOG_CANYON | false |
| FUNGUS | false |
| FUNGUS_CORE | false |
| FUNGUS_SHAMAN | false |
| GREENPATH | false |
| HEGEMOL_NEST | false |
| HIVE | false |
| INACTIVE | false |
| KINGSPASS | false |
| KINGS_STATION | false |
| LOVE_TOWER | false |
| MAGE_TOWER | false |
| MANTIS_VILLAGE | false |
| MINES | false |
| NPC CONVO START | false |
| OUTSKIRTS | false |
| QUEENS_STATION | false |
| RESTING_GROUNDS | false |
| ROYAL_GARDENS | false |
| RUINS | false |
| SHAMANTEMPLE | false |
| SPIDER_VILLAGE | false |
| SUB AREA | false |
| UNVISITED | false |
| VISITED | false |
| WATERWAYS | false |
| WHITE_PALACE | false |

