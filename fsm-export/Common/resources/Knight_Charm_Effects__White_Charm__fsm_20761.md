# White Charm

## Summary

| Field | Value |
| --- | --- |
| FSM Name | White Charm |
| GameObject Name | Charm Effects |
| GameObject Path | Knight |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 20761 |
| GameObject PathId | 4312 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Royal Charm State | 0 | Int32: 0 |

## States

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
| boolName | "equippedCharm_36" | "equippedCharm_36" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(INACTIVE) | Event(INACTIVE) |  |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "royalCharmState" | "royalCharmState" |  |  |
| storeValue | int Royal Charm State | int Royal Charm State | Variable |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Royal Charm State | int Royal Charm State |  |  |
| integer2 | 3 | 3 |  |  |
| equal | Event(ACTIVE) | Event(ACTIVE) |  |  |
| lessThan | Event(INACTIVE) | Event(INACTIVE) |  |  |
| greaterThan | Event(INACTIVE) | Event(INACTIVE) |  |  |
| everyFrame | false | false |  |  |

### Inactive

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### SOUL Check

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
| boolName | "disablePause" | "disablePause" |  |  |
| isTrue | Event(CANCEL) | Event(CANCEL) |  |  |
| isFalse | Event(SOUL UP) | Event(SOUL UP) |  |  |

### Soul UP

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessageV2

Full Name: HutongGames.PlayMaker.Actions.SendMessageV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessageV2/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | AddMPCharge(4) | AddMPCharge(4) |  |  |
| everyFrame | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Pause | FINISHED | Check | 0 | 0 | 0 |
| Check | ACTIVE | Wait | 0 | 0 | 0 |
| Check | INACTIVE | Inactive | 0 | 0 | 0 |
| Wait | FINISHED | SOUL Check | 0 | 0 | 0 |
| SOUL Check | CANCEL | Wait | 0 | 0 | 0 |
| SOUL Check | SOUL UP | Soul UP | 0 | 0 | 0 |
| Soul UP | FINISHED | Wait | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| CHARM INDICATOR CHECK | Check | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ACTIVE | false |
| CANCEL | false |
| CHARM INDICATOR CHECK | false |
| INACTIVE | false |
| SOUL UP | false |

