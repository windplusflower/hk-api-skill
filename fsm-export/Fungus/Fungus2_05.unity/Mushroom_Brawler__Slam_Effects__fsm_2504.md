# Slam Effects

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Slam Effects |
| GameObject Name | Mushroom Brawler |
| GameObject Path | Battle Scene v2/Completed/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level169 |
| Start State | Init |
| FSM PathId | 2504 |
| GameObject PathId | 551 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Sprite ID | 0 | Int32: 0 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Cap Hit | Battle Scene v2/Completed/Mushroom Brawler/Smash Hits (Hollow Knight/hollow_knight_Data\level169) | NamedAssetPPtr: [Battle Scene v2/Completed/Mushroom Brawler/Smash Hits (Hollow Knight/hollow_knight_Data\level169)] |
| Slam Effect | Battle Scene v2/Completed/Mushroom Brawler/Slam Effect (Hollow Knight/hollow_knight_Data\level169) | NamedAssetPPtr: [Battle Scene v2/Completed/Mushroom Brawler/Slam Effect (Hollow Knight/hollow_knight_Data\level169)] |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

(none)

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dSpriteGetId

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteGetId
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Cap Hit |   |   |
| spriteID |   | int Sprite ID | FsmInt |   |
| everyframe |   | true |   |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Sprite ID |   |   |
| integer2 |   | 36 |   |   |
| equal |   | Event(SMASH) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| SMASH | Smash | 0 | |

### Smash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. AudioPlaySimple

Full Name: HutongGames.PlayMaker.Actions.AudioPlaySimple
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| volume |   | 1f |   |   |
| oneShotClip |   | [mushroom_brawler_head_bang (AudioClip) (Hollow Knight/hollow_knight_Data\sharedassets169.assets)] |   |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Slam Effect |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 0.1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:CameraParent |   |   |
| sendEvent |   | "EnemyKillShake" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| SMASH | false |

