# Check for Blockers

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Check for Blockers |
| GameObject Name | CameraLockArea |
| GameObject Path |   |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level155 |
| Start State | Check |
| FSM PathId | 7830 |
| GameObject PathId | 786 |

## Variables

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blocker 1 Null | false | Boolean: false |
| Blocker 2 Null | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blocker 1 | [null] | NamedAssetPPtr: [null] |
| Blocker 2 | [null] | NamedAssetPPtr: [null] |

## States

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName |   | "Blocker 1" |   |   |
| withTag |   | "Untagged" | Tag |   |
| store |   | GameObject Blocker 1 | Variable |   |

##### 2. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName |   | "Blocker 2" |   |   |
| withTag |   | "Untagged" | Tag |   |
| store |   | GameObject Blocker 2 | Variable |   |

##### 3. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Blocker 1 | Variable |   |
| isNull |   | Event() |   |   |
| isNotNull |   | Event() |   |   |
| storeResult |   | bool Blocker 1 Null | Variable |   |
| everyFrame |   | true |   |   |

##### 4. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | GameObject Blocker 2 | Variable |   |
| isNull |   | Event() |   |   |
| isNotNull |   | Event() |   |   |
| storeResult |   | bool Blocker 2 Null | Variable |   |
| everyFrame |   | true |   |   |

##### 5. BoolAllTrue

Full Name: HutongGames.PlayMaker.Actions.BoolAllTrue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariables |   | FSMViewAvalonia2.FsmArray2 | Variable |   |
| sendEvent |   | Event(DESTROY) |   |   |
| storeResult |   | false | Variable |   |
| everyFrame |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| DESTROY | Pause | 0 | |

### Destroy

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren |   | false |   |   |

#### Transitions

(none)

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | 1f |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Destroy | 0 | |

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| DESTROY | false |
| FINISHED | false |

