# Change if Weaversong equipped

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Change if Weaversong equipped |
| GameObject Name | Dream Dialogue |
| GameObject Path | Happy Spider NPC/ |
| Source Asset | Hollow Knight/hollow_knight_Data/level299 |
| Start State | Init |
| FSM PathId | 7430 |
| GameObject PathId | 2433 |

## Variables

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent |   | FINISHED |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Check | 0 | |

### Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "equippedCharm_39" |   |   |
| isTrue |   | CHANGE |   |   |
| isFalse |   |   |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CHANGE | Set | 0 | |

### Set

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "npc_dream_dialogue" | FsmName |   |
| variableName |   | "Convo Name" | FsmString |   |
| setValue |   | "MIDWIFE_WEAVERSONG_DREAM" |   |   |
| everyFrame |   | false |   |   |

##### 2. SetFsmString

Full Name: HutongGames.PlayMaker.Actions.SetFsmString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| fsmName |   | "npc_dream_dialogue" | FsmName |   |
| variableName |   | "Sheet Name" | FsmString |   |
| setValue |   | "CP2" |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

## Global Transitions

(none)

## Events

| Name | Global |
| --- | --- |
| CHANGE | false |
| FINISHED | false |

