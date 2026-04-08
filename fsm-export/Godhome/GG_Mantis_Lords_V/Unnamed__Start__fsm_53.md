# Start

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Start |
| GameObject Name | Unnamed |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets486.assets |
| Start State | Init |
| FSM PathId | 53 |
| GameObject PathId |  |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Centre X | 29.97 | Single: 29.97 |
| Hero X | 0 | Single: 0 |
| Hero Y | 0 | Single: 0 |
| Pincer Max X | 33.85 | Single: 33.85 |
| Pincer Min X | 26.74 | Single: 26.74 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Ct D Dash | 0 | Int32: 0 |
| Ct Dash Stab | 0 | Int32: 0 |
| Ct Double Stab | 0 | Int32: 0 |
| Ct Pincer | 0 | Int32: 0 |
| Ct Stab Dash | 0 | Int32: 0 |
| Ct Throw 1 | 0 | Int32: 0 |
| Ct Throw 2 | 0 | Int32: 0 |
| Mantises Active | 0 | Int32: 0 |
| Ms D Dash | 0 | Int32: 0 |
| Ms Dash Stab | 0 | Int32: 0 |
| Ms Double Stab | 0 | Int32: 0 |
| Ms Pincer | 0 | Int32: 0 |
| Ms Stab Dash | 0 | Int32: 0 |
| Ms Throw 1 | 0 | Int32: 0 |
| Ms Throw 2 | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Rand Bool | false | Boolean: false |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Event |  | String:  |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Mantis 1 | [null] | NamedAssetPPtr:  |
| Mantis 2 | [null] | NamedAssetPPtr:  |
| Mantis 3 | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Sub 1 | [null] | NamedAssetPPtr:  |
| Sub 2 | [null] | NamedAssetPPtr:  |
| Sub 3 | [null] | NamedAssetPPtr:  |

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
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Mantis Lord S1" | "Mantis Lord S1" |  |  |
| storeResult | GameObject Mantis 1 | GameObject Mantis 1 | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Mantis Lord S2" | "Mantis Lord S2" |  |  |
| storeResult | GameObject Mantis 2 | GameObject Mantis 2 | Variable |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Mantis Lord S3" | "Mantis Lord S3" |  |  |
| storeResult | GameObject Mantis 3 | GameObject Mantis 3 | Variable |  |

### Start

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateAllChildren

Full Name: HutongGames.PlayMaker.Actions.ActivateAllChildren
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Self | GameObject Self | Variable |  |
| activate | true | true |  |  |

### Choose Move Triple

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 8

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | float Hero Y | float Hero Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero Y | float Hero Y |  |  |
| float2 | 19f | 19f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(HIGH THROW) | Event(HIGH THROW) |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | 20.16f | 20.16f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(HIGH THROW) | Event(HIGH THROW) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | 39.87f | 39.87f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(HIGH THROW) | Event(HIGH THROW) |  |  |
| everyFrame | false | false |  |  |

##### 5. SendRandomEventV3

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

### Pincer Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatInRange

Full Name: HutongGames.PlayMaker.Actions.FloatInRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Hero X | float Hero X |  |  |
| lowerValue | float Pincer Min X | float Pincer Min X |  |  |
| upperValue | float Pincer Max X | float Pincer Max X |  |  |
| boolVariable | bool Rand Bool | bool Rand Bool | Variable |  |
| trueEvent | Event(PINCER) | Event(PINCER) |  |  |
| falseEvent | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Set Subs

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 1 | GameObject Sub 1 | Variable |  |
| gameObject | GameObject Mantis 1 | GameObject Mantis 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 2 | GameObject Sub 2 | Variable |  |
| gameObject | GameObject Mantis 2 | GameObject Mantis 2 |  |  |
| everyFrame | false | false |  |  |

##### 3. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 3 | GameObject Sub 3 | Variable |  |
| gameObject | GameObject Mantis 3 | GameObject Mantis 3 |  |  |
| everyFrame | false | false |  |  |

##### 4. RandomBool

Full Name: HutongGames.PlayMaker.Actions.RandomBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | bool Rand Bool | bool Rand Bool | Variable |  |

##### 5. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Rand Bool | bool Rand Bool | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 6. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 1 | GameObject Sub 1 | Variable |  |
| gameObject | GameObject Mantis 2 | GameObject Mantis 2 |  |  |
| everyFrame | false | false |  |  |

##### 7. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 2 | GameObject Sub 2 | Variable |  |
| gameObject | GameObject Mantis 3 | GameObject Mantis 3 |  |  |
| everyFrame | false | false |  |  |

##### 8. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 3 | GameObject Sub 3 | Variable |  |
| gameObject | GameObject Mantis 1 | GameObject Mantis 1 |  |  |
| everyFrame | false | false |  |  |

##### 9. RandomBool

Full Name: HutongGames.PlayMaker.Actions.RandomBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | bool Rand Bool | bool Rand Bool | Variable |  |

##### 10. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Rand Bool | bool Rand Bool | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 11. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 1 | GameObject Sub 1 | Variable |  |
| gameObject | GameObject Mantis 3 | GameObject Mantis 3 |  |  |
| everyFrame | false | false |  |  |

##### 12. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 2 | GameObject Sub 2 | Variable |  |
| gameObject | GameObject Mantis 1 | GameObject Mantis 1 |  |  |
| everyFrame | false | false |  |  |

##### 13. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 3 | GameObject Sub 3 | Variable |  |
| gameObject | GameObject Mantis 2 | GameObject Mantis 2 |  |  |
| everyFrame | false | false |  |  |

### Do Pincer

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 1 | EventTarget(GameObject):Mantis 1 |  |  |
| sendEvent | "DASH R" | "DASH R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 2 | EventTarget(GameObject):Mantis 2 |  |  |
| sendEvent | "DASH L" | "DASH L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 3 | EventTarget(GameObject):Mantis 3 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

### D Dash Dir

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | float Centre X | float Centre X |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(LEFT) | Event(LEFT) |  |  |
| lessThan | Event(LEFT) | Event(LEFT) |  |  |
| greaterThan | Event(RIGHT) | Event(RIGHT) |  |  |
| everyFrame | false | false |  |  |

### D Dash R

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 1 | EventTarget(GameObject):Mantis 1 |  |  |
| sendEvent | "DASH R" | "DASH R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### D Dash L

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 1 | EventTarget(GameObject):Mantis 1 |  |  |
| sendEvent | "DASH L" | "DASH L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Stab Dash

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 1 | EventTarget(GameObject):Mantis 1 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 2 | EventTarget(GameObject):Mantis 2 |  |  |
| sendEvent | "DASH" | "DASH" |  |  |
| delay | 0.8f | 0.8f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 3 | EventTarget(GameObject):Mantis 3 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 1.2f | 1.2f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.2f | 2.2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Init Pause

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
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Dash Stab

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 1 | EventTarget(GameObject):Mantis 1 |  |  |
| sendEvent | "DASH" | "DASH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 2 | EventTarget(GameObject):Mantis 2 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 3 | EventTarget(GameObject):Mantis 3 |  |  |
| sendEvent | "DASH" | "DASH" |  |  |
| delay | 2f | 2f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3f | 3f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Triple Stab

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 1 | EventTarget(GameObject):Mantis 1 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 2 | EventTarget(GameObject):Mantis 2 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 0.7f | 0.7f |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 3 | EventTarget(GameObject):Mantis 3 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 1.4f | 1.4f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.4f | 2.4f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### D Dash L 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | float Pincer Max X | float Pincer Max X |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 2 | EventTarget(GameObject):Mantis 2 |  |  |
| sendEvent | "DASH L" | "DASH L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 3 | EventTarget(GameObject):Mantis 3 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.9f | 1.9f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### D Dash R 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | float Pincer Min X | float Pincer Min X |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 2 | EventTarget(GameObject):Mantis 2 |  |  |
| sendEvent | "DASH R" | "DASH R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.9f | 1.9f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 3 | EventTarget(GameObject):Mantis 3 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

### D Throw Narrow

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 1 | EventTarget(GameObject):Mantis 1 |  |  |
| sendEvent | "NARROW THROW L" | "NARROW THROW L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SelectRandomString

Full Name: HutongGames.PlayMaker.Actions.SelectRandomString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| strings | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeString | string Event | string Event | Variable |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 2 | EventTarget(GameObject):Mantis 2 |  |  |
| sendEvent | string Event | string Event |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.5f | 2.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 3 | EventTarget(GameObject):Mantis 3 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |

### D Throw Wide

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 1 | EventTarget(GameObject):Mantis 1 |  |  |
| sendEvent | "WIDE THROW L" | "WIDE THROW L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SelectRandomString

Full Name: HutongGames.PlayMaker.Actions.SelectRandomString
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| strings | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| weights | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeString | string Event | string Event | Variable |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 2 | EventTarget(GameObject):Mantis 2 |  |  |
| sendEvent | string Event | string Event |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.5f | 2.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 3 | EventTarget(GameObject):Mantis 3 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |

### Single Mantis

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Mantis 1 | OwnerDefault Mantis 1 |  |  |
| fsmName | "Mantis Lord" | "Mantis Lord" | FsmName |  |
| variableName | "Sub" | "Sub" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Mantis 2 | OwnerDefault Mantis 2 |  |  |
| fsmName | "Mantis Lord" | "Mantis Lord" | FsmName |  |
| variableName | "Sub" | "Sub" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Mantis 3 | OwnerDefault Mantis 3 |  |  |
| fsmName | "Mantis Lord" | "Mantis Lord" | FsmName |  |
| variableName | "Sub" | "Sub" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

### High Throw

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 1 | EventTarget(GameObject):Sub 1 |  |  |
| sendEvent | "HIGH THROW" | "HIGH THROW" |  |  |
| delay | 0.5f | 0.5f |  |  |
| everyFrame | false | false |  |  |

### Pincer Cancel

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

##### 2. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Ct Pincer | int Ct Pincer | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Ms Pincer | int Ms Pincer | Variable |  |
| intValue | 999 | 999 |  |  |
| everyFrame | false | false |  |  |

### Check 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Mantises Active | int Mantises Active | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Mantis 1 | GameObject Mantis 1 | Variable |  |
| isNull | Event(NULL) | Event(NULL) |  |  |
| isNotNull | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 3. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Mantises Active | int Mantises Active | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Check 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Mantis 2 | GameObject Mantis 2 | Variable |  |
| isNull | Event(NULL) | Event(NULL) |  |  |
| isNotNull | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Mantises Active | int Mantises Active | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Check 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Mantis 3 | GameObject Mantis 3 | Variable |  |
| isNull | Event(NULL) | Event(NULL) |  |  |
| isNotNull | Event() | Event() |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 2. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Mantises Active | int Mantises Active | Variable |  |
| add | 1 | 1 |  |  |
| everyFrame | false | false |  |  |

### Amount

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Mantises Active | int Mantises Active |  |  |
| integer2 | 1 | 1 |  |  |
| equal | Event(SINGLE) | Event(SINGLE) |  |  |
| lessThan | Event(SINGLE) | Event(SINGLE) |  |  |
| greaterThan | Event(DOUBLE) | Event(DOUBLE) |  |  |
| everyFrame | false | false |  |  |

### Choose Move Double

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 8

#### Actions

##### 1. SendEvent

Full Name: HutongGames.PlayMaker.Actions.SendEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(Self):FSM Owner | EventTarget(Self):FSM Owner |  |  |
| sendEvent | Event(D THROW NARROW) | Event(D THROW NARROW) |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | float Hero Y | float Hero Y | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 3. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero Y | float Hero Y |  |  |
| float2 | 19f | 19f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(HIGH THROW) | Event(HIGH THROW) |  |  |
| everyFrame | false | false |  |  |

##### 4. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | 20.16f | 20.16f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(HIGH THROW) | Event(HIGH THROW) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 5. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | 39.87f | 39.87f |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(HIGH THROW) | Event(HIGH THROW) |  |  |
| everyFrame | false | false |  |  |

##### 6. SendRandomEventV3

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

### Pincer Check 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatInRange

Full Name: HutongGames.PlayMaker.Actions.FloatInRange
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| floatVariable | float Hero X | float Hero X |  |  |
| lowerValue | float Pincer Min X | float Pincer Min X |  |  |
| upperValue | float Pincer Max X | float Pincer Max X |  |  |
| boolVariable | bool Rand Bool | bool Rand Bool | Variable |  |
| trueEvent | Event(PINCER) | Event(PINCER) |  |  |
| falseEvent | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Ct Pincer | int Ct Pincer | Variable |  |
| intValue | 0 | 0 |  |  |
| everyFrame | false | false |  |  |

##### 4. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Ms Pincer | int Ms Pincer | Variable |  |
| intValue | 999 | 999 |  |  |
| everyFrame | false | false |  |  |

### Set Subs 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 1 | GameObject Sub 1 | Variable |  |
| gameObject | GameObject Mantis 1 | GameObject Mantis 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 2 | GameObject Sub 2 | Variable |  |
| gameObject | GameObject Mantis 2 | GameObject Mantis 2 |  |  |
| everyFrame | false | false |  |  |

##### 3. RandomBool

Full Name: HutongGames.PlayMaker.Actions.RandomBool
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeResult | bool Rand Bool | bool Rand Bool | Variable |  |

##### 4. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Rand Bool | bool Rand Bool | Variable |  |
| isTrue | Event(FINISHED) | Event(FINISHED) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 5. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 1 | GameObject Sub 1 | Variable |  |
| gameObject | GameObject Mantis 2 | GameObject Mantis 2 |  |  |
| everyFrame | false | false |  |  |

##### 6. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 2 | GameObject Sub 2 | Variable |  |
| gameObject | GameObject Mantis 1 | GameObject Mantis 1 |  |  |
| everyFrame | false | false |  |  |

### Do Pincer 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 1 | EventTarget(GameObject):Sub 1 |  |  |
| sendEvent | "DASH R" | "DASH R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 2 | EventTarget(GameObject):Sub 2 |  |  |
| sendEvent | "DASH L" | "DASH L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2f | 2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### D Dash Dir 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | float Centre X | float Centre X |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event(LEFT) | Event(LEFT) |  |  |
| lessThan | Event(LEFT) | Event(LEFT) |  |  |
| greaterThan | Event(RIGHT) | Event(RIGHT) |  |  |
| everyFrame | false | false |  |  |

### D Dash R 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 1 | EventTarget(GameObject):Sub 1 |  |  |
| sendEvent | "DASH R" | "DASH R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 2 | EventTarget(GameObject):Mantis 2 |  |  |
| sendEvent | "DASH R" | "DASH R" |  |  |
| delay | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.5f | 1.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### D Dash L 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 1 | EventTarget(GameObject):Sub 1 |  |  |
| sendEvent | "DASH L" | "DASH L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Mantis 2 | EventTarget(GameObject):Mantis 2 |  |  |
| sendEvent | "DASH L" | "DASH L" |  |  |
| delay | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 3.25f | 3.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.5f | 1.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Stab Dash 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 1 | EventTarget(GameObject):Sub 1 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 2 | EventTarget(GameObject):Sub 2 |  |  |
| sendEvent | "DASH" | "DASH" |  |  |
| delay | 0.8f | 0.8f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.75f | 2.75f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Dash Stab 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 1 | EventTarget(GameObject):Sub 1 |  |  |
| sendEvent | "DASH" | "DASH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 2 | EventTarget(GameObject):Sub 2 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 1.5f | 1.5f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.75f | 2.75f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Double Stab

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 1 | EventTarget(GameObject):Sub 1 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 2 | EventTarget(GameObject):Sub 2 |  |  |
| sendEvent | "DSTAB" | "DSTAB" |  |  |
| delay | 0.75f | 0.75f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.2f | 2.2f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### D Dash L 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | float Pincer Max X | float Pincer Max X |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(CANCEL) | Event(CANCEL) |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 2 | EventTarget(GameObject):Sub 2 |  |  |
| sendEvent | "DASH L" | "DASH L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.25f | 2.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### D Dash R 4

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPosition

Full Name: HutongGames.PlayMaker.Actions.GetPosition
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | float Hero X | float Hero X | Variable |  |
| y | 0f | 0f | Variable |  |
| z | 0f | 0f | Variable |  |
| space | UnityEngine.Space::World | 0 |  |  |
| everyFrame | false | false |  |  |

##### 2. FloatCompare

Full Name: HutongGames.PlayMaker.Actions.FloatCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| float1 | float Hero X | float Hero X |  |  |
| float2 | float Pincer Min X | float Pincer Min X |  |  |
| tolerance | 0f | 0f |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 2 | EventTarget(GameObject):Sub 2 |  |  |
| sendEvent | "DASH R" | "DASH R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.25f | 2.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### D Throw Narrow 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 1 | EventTarget(GameObject):Sub 1 |  |  |
| sendEvent | "NARROW THROW L" | "NARROW THROW L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 2 | EventTarget(GameObject):Sub 2 |  |  |
| sendEvent | "NARROW THROW R" | "NARROW THROW R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.5f | 2.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### D Throw Wide 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 1 | EventTarget(GameObject):Sub 1 |  |  |
| sendEvent | "WIDE THROW L" | "WIDE THROW L" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 2 | EventTarget(GameObject):Sub 2 |  |  |
| sendEvent | "WIDE THROW R" | "WIDE THROW R" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 2.5f | 2.5f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### High Throw 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Sub 1 | EventTarget(GameObject):Sub 1 |  |  |
| sendEvent | "HIGH THROW" | "HIGH THROW" |  |  |
| delay | 0.5f | 0.5f |  |  |
| everyFrame | false | false |  |  |

### Reset Sub

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 1 | GameObject Sub 1 | Variable |  |
| gameObject | GameObject Mantis 1 | GameObject Mantis 1 |  |  |
| everyFrame | false | false |  |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 2 | GameObject Sub 2 | Variable |  |
| gameObject | GameObject Mantis 2 | GameObject Mantis 2 |  |  |
| everyFrame | false | false |  |  |

##### 3. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Sub 1 | GameObject Sub 1 | Variable |  |
| isNull | Event() | Event() |  |  |
| isNotNull | Event(NULL) | Event(NULL) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 4. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 1 | GameObject Sub 1 | Variable |  |
| gameObject | GameObject Mantis 3 | GameObject Mantis 3 |  |  |
| everyFrame | false | false |  |  |

### Reset Sub 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GameObjectIsNull

Full Name: HutongGames.PlayMaker.Actions.GameObjectIsNull
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Sub 2 | GameObject Sub 2 | Variable |  |
| isNull | Event() | Event() |  |  |
| isNotNull | Event(NULL) | Event(NULL) |  |  |
| storeResult | false | false | Variable |  |
| everyFrame | false | false |  |  |

##### 2. SetGameObject

Full Name: HutongGames.PlayMaker.Actions.SetGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| variable | GameObject Sub 2 | GameObject Sub 2 | Variable |  |
| gameObject | GameObject Mantis 3 | GameObject Mantis 3 |  |  |
| everyFrame | false | false |  |  |

### Pause Frame

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

### State 1

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

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | MLORD START SUB | Start | 0 | 0 | 0 |
| Start | FINISHED | Init Pause | 0 | 0 | 0 |
| Choose Move Triple | DOUBLE DASH | D Dash Dir | 0 | 0 | 0 |
| Choose Move Triple | PINCER | Pincer Check | 0 | 0 | 0 |
| Choose Move Triple | STAB DASH | Stab Dash | 0 | 0 | 0 |
| Choose Move Triple | DASH STAB | Dash Stab | 0 | 0 | 0 |
| Choose Move Triple | DOUBLE STAB | Triple Stab | 0 | 0 | 0 |
| Choose Move Triple | D THROW NARROW | D Throw Narrow | 0 | 0 | 0 |
| Choose Move Triple | D THROW WIDE | D Throw Wide | 0 | 0 | 0 |
| Choose Move Triple | HIGH THROW | High Throw | 0 | 0 | 0 |
| Pincer Check | FINISHED | Pincer Cancel | 0 | 0 | 0 |
| Pincer Check | PINCER | Do Pincer | 0 | 0 | 0 |
| Set Subs | FINISHED | Choose Move Triple | 0 | 0 | 0 |
| Do Pincer | FINISHED | Set Subs | 0 | 0 | 0 |
| D Dash Dir | LEFT | D Dash L | 0 | 0 | 0 |
| D Dash Dir | RIGHT | D Dash R | 0 | 0 | 0 |
| D Dash R | FINISHED | D Dash R 2 | 0 | 0 | 0 |
| D Dash L | FINISHED | D Dash L 2 | 0 | 0 | 0 |
| Stab Dash | FINISHED | Set Subs | 0 | 0 | 0 |
| Init Pause | FINISHED | Set Subs | 0 | 0 | 0 |
| Dash Stab | FINISHED | Set Subs | 0 | 0 | 0 |
| Triple Stab | FINISHED | Choose Move Triple | 0 | 0 | 0 |
| D Dash L 2 | FINISHED | Set Subs | 0 | 0 | 0 |
| D Dash L 2 | CANCEL | D Dash R 2 | 0 | 0 | 0 |
| D Dash R 2 | FINISHED | Set Subs | 0 | 0 | 0 |
| D Dash R 2 | CANCEL | D Dash L 2 | 0 | 0 | 0 |
| D Throw Narrow | FINISHED | Choose Move Triple | 0 | 0 | 0 |
| D Throw Wide | FINISHED | Choose Move Triple | 0 | 0 | 0 |
| High Throw | FINISHED | Set Subs | 0 | 0 | 0 |
| Pincer Cancel | FINISHED | Set Subs | 0 | 0 | 0 |
| Check 1 | FINISHED | Check 2 | 0 | 0 | 0 |
| Check 1 | NULL | Check 2 | 0 | 0 | 0 |
| Check 2 | FINISHED | Check 3 | 0 | 0 | 0 |
| Check 2 | NULL | Check 3 | 0 | 0 | 0 |
| Check 3 | FINISHED | Amount | 0 | 0 | 0 |
| Check 3 | NULL | Amount | 0 | 0 | 0 |
| Amount | SINGLE | Single Mantis | 0 | 0 | 0 |
| Amount | DOUBLE | Reset Sub | 0 | 0 | 0 |
| Choose Move Double | DOUBLE DASH | D Dash Dir 2 | 0 | 0 | 0 |
| Choose Move Double | PINCER | Pincer Check 2 | 0 | 0 | 0 |
| Choose Move Double | STAB DASH | Stab Dash 2 | 0 | 0 | 0 |
| Choose Move Double | DASH STAB | Dash Stab 2 | 0 | 0 | 0 |
| Choose Move Double | DOUBLE STAB | Double Stab | 0 | 0 | 0 |
| Choose Move Double | D THROW NARROW | D Throw Narrow 2 | 0 | 0 | 0 |
| Choose Move Double | D THROW WIDE | D Throw Wide 2 | 0 | 0 | 0 |
| Choose Move Double | HIGH THROW | High Throw 2 | 0 | 0 | 0 |
| Pincer Check 2 | FINISHED | Set Subs 2 | 0 | 0 | 0 |
| Pincer Check 2 | PINCER | Do Pincer 2 | 0 | 0 | 0 |
| Set Subs 2 | FINISHED | Choose Move Double | 0 | 0 | 0 |
| Do Pincer 2 | FINISHED | Set Subs 2 | 0 | 0 | 0 |
| D Dash Dir 2 | LEFT | D Dash L 3 | 0 | 0 | 0 |
| D Dash Dir 2 | RIGHT | D Dash R 3 | 0 | 0 | 0 |
| D Dash R 3 | FINISHED | D Dash R 4 | 0 | 0 | 0 |
| D Dash L 3 | FINISHED | D Dash L 4 | 0 | 0 | 0 |
| Stab Dash 2 | FINISHED | Set Subs 2 | 0 | 0 | 0 |
| Dash Stab 2 | FINISHED | Set Subs 2 | 0 | 0 | 0 |
| Double Stab | FINISHED | Choose Move Double | 0 | 0 | 0 |
| D Dash L 4 | FINISHED | Set Subs 2 | 0 | 0 | 0 |
| D Dash L 4 | CANCEL | D Dash R 4 | 0 | 0 | 0 |
| D Dash R 4 | FINISHED | Set Subs 2 | 0 | 0 | 0 |
| D Dash R 4 | CANCEL | D Dash L 4 | 0 | 0 | 0 |
| D Throw Narrow 2 | FINISHED | Choose Move Double | 0 | 0 | 0 |
| D Throw Wide 2 | FINISHED | Choose Move Double | 0 | 0 | 0 |
| High Throw 2 | FINISHED | Set Subs 2 | 0 | 0 | 0 |
| Reset Sub | FINISHED | Reset Sub 2 | 0 | 0 | 0 |
| Reset Sub | NULL | Reset Sub 2 | 0 | 0 | 0 |
| Reset Sub 2 | FINISHED | Choose Move Double | 0 | 0 | 0 |
| Reset Sub 2 | NULL | Choose Move Double | 0 | 0 | 0 |
| Pause Frame | FINISHED | State 1 | 0 | 0 | 0 |
| State 1 | FINISHED | Check 1 | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| KILLED | Pause Frame | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| CANCEL | false |
| D THROW NARROW | false |
| D THROW WIDE | false |
| DASH STAB | false |
| DOUBLE | false |
| DOUBLE DASH | false |
| DOUBLE STAB | false |
| HIGH THROW | false |
| KILLED | false |
| LEFT | false |
| MLORD START SUB | false |
| NULL | false |
| PINCER | false |
| RIGHT | false |
| SINGLE | false |
| STAB DASH | false |
| TRIPLE | false |

