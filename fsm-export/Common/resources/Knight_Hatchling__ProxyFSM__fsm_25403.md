# ProxyFSM

## Summary

| Field | Value |
| --- | --- |
| FSM Name | ProxyFSM |
| GameObject Name | Knight Hatchling |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Idle |
| FSM PathId | 25403 |
| GameObject PathId | 4816 |

## Variables

## States

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

### Hit Landed

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "KnightHatchling" | "KnightHatchling" | Behaviour |  |
| methodName | "FsmHitLanded" | "FsmHitLanded" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Charms End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "KnightHatchling" | "KnightHatchling" | Behaviour |  |
| methodName | "FsmCharmsEnd" | "FsmCharmsEnd" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Hazard Reload

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "KnightHatchling" | "KnightHatchling" | Behaviour |  |
| methodName | "FsmHazardReload" | "FsmHazardReload" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Bench Rest

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "KnightHatchling" | "KnightHatchling" | Behaviour |  |
| methodName | "FsmBenchRestStart" | "FsmBenchRestStart" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### End Bench

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "KnightHatchling" | "KnightHatchling" | Behaviour |  |
| methodName | "FsmBenchRestEnd" | "FsmBenchRestEnd" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Quick Spawn

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "KnightHatchling" | "KnightHatchling" | Behaviour |  |
| methodName | "FsmQuickSpawn" | "FsmQuickSpawn" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Teleport Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| behaviour | "KnightHatchling" | "KnightHatchling" | Behaviour |  |
| methodName | "FsmDreamGateOut" | "FsmDreamGateOut" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var | Var | Variable | Store Result |

### Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. WaitRandom

Full Name: HutongGames.PlayMaker.Actions.WaitRandom
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| timeMin | 0.5f | 0.5f |  |  |
| timeMax | 1.5f | 1.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Hit Landed | FINISHED | Idle | 0 | 0 | 0 |
| Charms End | FINISHED | Idle | 0 | 0 | 0 |
| Hazard Reload | FINISHED | Idle | 0 | 0 | 0 |
| Bench Rest | FINISHED | Idle | 0 | 0 | 0 |
| End Bench | FINISHED | Idle | 0 | 0 | 0 |
| Quick Spawn | FINISHED | Idle | 0 | 0 | 0 |
| Wait | FINISHED | Teleport Out | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| HIT LANDED | Hit Landed | 0 | 0 | 0 |
| ALL CHARMS END | Charms End | 0 | 0 | 0 |
| HAZARD RELOAD | Hazard Reload | 0 | 0 | 0 |
| K HATCHLING END | Charms End | 0 | 0 | 0 |
| BENCHREST | Bench Rest | 0 | 0 | 0 |
| BENCHREST END | End Bench | 0 | 0 | 0 |
| QUICK SPAWN | Quick Spawn | 0 | 0 | 0 |
| DREAMGATE OUT | Wait | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| ALL CHARMS END | false |
| BENCHREST | false |
| BENCHREST END | false |
| DREAMGATE OUT | false |
| DREAMGATE SPAWN | false |
| HAZARD RELOAD | false |
| HIT LANDED | true |
| K HATCHLING END | false |
| QUICK SPAWN | false |

