# Attack Choices

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Attack Choices |
| GameObject Name | Absolute Radiance |
| GameObject Path | Boss Control |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/level459.assets |
| Start State | Init |
| FSM PathId | 3677 |
| GameObject PathId | 834 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Arena | 1 | Int32: 1 |
| Ct Beam Sweep L | 0 | Int32: 0 |
| Ct Beam Sweep R | 0 | Int32: 0 |
| Ct Eye Beam | 0 | Int32: 0 |
| Ct Nail Fan | 0 | Int32: 0 |
| Ct Nail L Sweep | 0 | Int32: 0 |
| Ct Nail R Sweep | 0 | Int32: 0 |
| Ct Nail Top Sweep | 0 | Int32: 0 |
| Ct Orbs | 0 | Int32: 0 |
| Ms Beam Sweep L | 0 | Int32: 0 |
| Ms Beam Sweep R | 0 | Int32: 0 |
| Ms Eye Beam | 0 | Int32: 0 |
| Ms Nail Fan | 0 | Int32: 0 |
| Ms Nail L Sweep | 0 | Int32: 0 |
| Ms Nail R Sweep | 0 | Int32: 0 |
| Ms Nail Top Sweep | 0 | Int32: 0 |
| Ms Orbs | 0 | Int32: 0 |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### A1 Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.2f | 0.2f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### A1 Choice

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 8

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | "ORBS" | "ORBS" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendRandomEventV3

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trackingInts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| eventMax | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trackingIntsMissed | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| missedMax | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |

### Nail Top Sweep

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB TOP" | "COMB TOP" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB TOP" | "COMB TOP" |  |  |
| delay | 0.75f | 0.75f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB TOP" | "COMB TOP" |  |  |
| delay | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB TOP" | "COMB TOP" |  |  |
| delay | 2.25f | 2.25f |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 4f | 4f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 6. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Last Attack Was Cast" | "Last Attack Was Cast" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Nail L Sweep

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB L" | "COMB L" |  |  |
| delay | 0.5f | 0.5f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB L" | "COMB L" |  |  |
| delay | 1.7f | 1.7f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB L" | "COMB L" |  |  |
| delay | 2.9f | 2.9f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 4.4f | 4.4f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Last Attack Was Cast" | "Last Attack Was Cast" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Nail R Sweep

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB R" | "COMB R" |  |  |
| delay | 0.5f | 0.5f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB R" | "COMB R" |  |  |
| delay | 1.7f | 1.7f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB R" | "COMB R" |  |  |
| delay | 2.9f | 2.9f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 4.4f | 4.4f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Last Attack Was Cast" | "Last Attack Was Cast" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Eye Beam Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Please Cast" | "Please Cast" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Eye Beam

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "EYE BEAMS" | "EYE BEAMS" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Eye Beam Recover

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "CAST END" | "CAST END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Beam Sweep L

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "BEAM SWEEP L" | "BEAM SWEEP L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Last Attack Was Cast" | "Last Attack Was Cast" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Beam Sweep R

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "BEAM SWEEP R" | "BEAM SWEEP R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Last Attack Was Cast" | "Last Attack Was Cast" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Nail Fan Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Please Cast" | "Please Cast" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Nail Fan

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "NAIL FAN" | "NAIL FAN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Nail Fan Recover

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "CAST END" | "CAST END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Orb Wait

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Please Cast" | "Please Cast" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

### Orbs

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "ORBS" | "ORBS" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Orb Recover

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "CAST END" | "CAST END" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### A1 End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Arena | int Arena | Variable |  |
| intValue | 2 | 2 |  |  |
| everyFrame | false | false |  |  |

### Return

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Arena | int Arena |  |  |
| integer2 | 1 | 1 |  |  |
| equal | A1 | A1 |  |  |
| lessThan | A1 | A1 |  |  |
| greaterThan | A2 | A2 |  |  |
| everyFrame | false | false |  |  |

### A2 Choice

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 6

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | "ORBS" | "ORBS" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendRandomEventV3

Full Name: HutongGames.PlayMaker.Actions.SendRandomEventV3
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trackingInts | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| eventMax | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| trackingIntsMissed | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 | Variable |  |
| missedMax | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |

### A2 Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.5f | 0.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Nail Top Sweep 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB TOP2" | "COMB TOP2" |  |  |
| delay | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB TOP2" | "COMB TOP2" |  |  |
| delay | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB TOP2" | "COMB TOP2" |  |  |
| delay | 2.5f | 2.5f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB TOP2" | "COMB TOP2" |  |  |
| delay | 3.5f | 3.5f |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3f | 3f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 6. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Last Attack Was Cast" | "Last Attack Was Cast" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Nail L Sweep 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB L2" | "COMB L2" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB L2" | "COMB L2" |  |  |
| delay | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB L2" | "COMB L2" |  |  |
| delay | 3.5f | 3.5f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB L2" | "COMB L2" |  |  |
| delay | 5f | 5f |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3.5f | 3.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 6. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Last Attack Was Cast" | "Last Attack Was Cast" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Nail R Sweep 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB R2" | "COMB R2" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB R2" | "COMB R2" |  |  |
| delay | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB R2" | "COMB R2" |  |  |
| delay | 3.5f | 3.5f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):FSM Owner | EventTarget(GameObject):FSM Owner |  |  |
| sendEvent | "COMB R2" | "COMB R2" |  |  |
| delay | 5f | 5f |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3.5f | 3.5f |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 6. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Last Attack Was Cast" | "Last Attack Was Cast" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Beam Sweep L 2

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "BEAM SWEEP L2" | "BEAM SWEEP L2" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Last Attack Was Cast" | "Last Attack Was Cast" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### Beam Sweep R 2

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
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "BEAM SWEEP R2" | "BEAM SWEEP R2" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| fsmName | "Control" | "Control" | FsmName |  |
| variableName | "Last Attack Was Cast" | "Last Attack Was Cast" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### L or R Choice

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SendRandomEvent

Full Name: HutongGames.PlayMaker.Actions.SendRandomEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| events | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| delay | 0f | 0f |  |  |

### A2 End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | ARENA 1 START | A1 Pause | 0 | 0 | 0 |
| A1 Pause | FINISHED | A1 Choice | 0 | 0 | 0 |
| A1 Choice | NAIL TOP SWEEP | Nail Top Sweep | 0 | 0 | 0 |
| A1 Choice | NAIL L SWEEP | Nail L Sweep | 0 | 0 | 0 |
| A1 Choice | NAIL R SWEEP | Nail R Sweep | 0 | 0 | 0 |
| A1 Choice | EYE BEAMS | Eye Beam Wait | 0 | 0 | 0 |
| A1 Choice | BEAM SWEEP L | Beam Sweep L | 0 | 0 | 0 |
| A1 Choice | BEAM SWEEP R | Beam Sweep R | 0 | 0 | 0 |
| A1 Choice | NAIL FAN | Nail Fan Wait | 0 | 0 | 0 |
| A1 Choice | ORBS | Orb Wait | 0 | 0 | 0 |
| Nail Top Sweep | FINISHED | Return | 0 | 0 | 0 |
| Nail L Sweep | FINISHED | Return | 0 | 0 | 0 |
| Nail R Sweep | FINISHED | Return | 0 | 0 | 0 |
| Eye Beam Wait | CAST READY | Eye Beam | 0 | 0 | 0 |
| Eye Beam | ATTACK END | Eye Beam Recover | 0 | 0 | 0 |
| Eye Beam Recover | FINISHED | Return | 0 | 0 | 0 |
| Beam Sweep L | FINISHED | Return | 0 | 0 | 0 |
| Beam Sweep R | FINISHED | Return | 0 | 0 | 0 |
| Nail Fan Wait | CAST READY | Nail Fan | 0 | 0 | 0 |
| Nail Fan | ATTACK END | Nail Fan Recover | 0 | 0 | 0 |
| Nail Fan Recover | FINISHED | Return | 0 | 0 | 0 |
| Orb Wait | CAST READY | Orbs | 0 | 0 | 0 |
| Orbs | ATTACK END | Orb Recover | 0 | 0 | 0 |
| Orb Recover | FINISHED | Return | 0 | 0 | 0 |
| A1 End | ARENA 2 START | A2 Pause | 0 | 0 | 0 |
| Return | A1 | A1 Choice | 0 | 0 | 0 |
| Return | A2 | A2 Choice | 0 | 0 | 0 |
| A2 Choice | NAIL LR SWEEP | L or R Choice | 0 | 0 | 0 |
| A2 Choice | EYE BEAMS | Eye Beam Wait | 0 | 0 | 0 |
| A2 Choice | BEAM SWEEP L | Beam Sweep L 2 | 0 | 0 | 0 |
| A2 Choice | BEAM SWEEP R | Beam Sweep R 2 | 0 | 0 | 0 |
| A2 Choice | NAIL FAN | Nail Fan Wait | 0 | 0 | 0 |
| A2 Choice | ORBS | Orb Wait | 0 | 0 | 0 |
| A2 Pause | FINISHED | A2 Choice | 0 | 0 | 0 |
| Nail Top Sweep 2 | FINISHED | Return | 0 | 0 | 0 |
| Nail L Sweep 2 | FINISHED | Return | 0 | 0 | 0 |
| Nail R Sweep 2 | FINISHED | Return | 0 | 0 | 0 |
| Beam Sweep L 2 | FINISHED | Return | 0 | 0 | 0 |
| Beam Sweep R 2 | FINISHED | Return | 0 | 0 | 0 |
| L or R Choice | NAIL R SWEEP | Nail R Sweep 2 | 0 | 0 | 0 |
| L or R Choice | NAIL L SWEEP | Nail L Sweep 2 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| ARENA 1 END | A1 End | 0 | 0 | 0 |
| ARENA 2 END | A2 End | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| A1 | false |
| A2 | false |
| ARENA 1 END | false |
| ARENA 1 START | false |
| ARENA 2 END | false |
| ARENA 2 START | false |
| ATTACK END | false |
| BEAM SWEEP L | false |
| BEAM SWEEP R | false |
| CAST READY | false |
| EYE BEAMS | false |
| NAIL FAN | false |
| NAIL L SWEEP | false |
| NAIL LR SWEEP | false |
| NAIL R SWEEP | false |
| NAIL TL SWEEP | false |
| NAIL TOP SWEEP | false |
| NAIL TR SWEEP | false |
| ORBS | false |

