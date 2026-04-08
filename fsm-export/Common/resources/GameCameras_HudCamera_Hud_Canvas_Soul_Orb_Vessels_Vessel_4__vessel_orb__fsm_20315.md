# vessel_orb

## Summary

| Field | Value |
| --- | --- |
| FSM Name | vessel_orb |
| GameObject Name | Vessel 4 |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Setup |
| FSM PathId | 20315 |
| GameObject PathId | 4966 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Load Anim Pause | 2.6 | Single: 2.6 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| 3Quarter Amount | 0 | Int32: 0 |
| Empty Amount | 99 | Int32: 99 |
| Full Amount | 132 | Int32: 132 |
| Half Amount | 0 | Int32: 0 |
| Quarter Amount | 0 | Int32: 0 |
| Reserve MP | 0 | Int32: 0 |
| Reserve MP Max | 0 | Int32: 0 |

### Bools

| Name | Value | Raw/Type |
| --- | --- | --- |
| Initialised | false | Boolean: false |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Binding Cap | [null] | NamedAssetPPtr:  |
| Flash | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Binding Cap | OwnerDefault Binding Cap |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| childName | "Flash" | "Flash" |  |  |
| storeResult | GameObject Flash | GameObject Flash | Variable |  |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPReserveMax" | "MPReserveMax" |  |  |
| storeValue | int Reserve MP Max | int Reserve MP Max | Variable |  |

##### 5. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Quarter Amount | int Quarter Amount | Variable |  |
| intValue | int Empty Amount | int Empty Amount |  |  |
| everyFrame | false | false |  |  |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Half Amount | int Half Amount | Variable |  |
| intValue | int Empty Amount | int Empty Amount |  |  |
| everyFrame | false | false |  |  |

##### 7. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int 3Quarter Amount | int 3Quarter Amount | Variable |  |
| intValue | int Empty Amount | int Empty Amount |  |  |
| everyFrame | false | false |  |  |

##### 8. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Quarter Amount | int Quarter Amount | Variable |  |
| add | 8 | 8 |  |  |
| everyFrame | false | false |  |  |

##### 9. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Half Amount | int Half Amount | Variable |  |
| add | 16 | 16 |  |  |
| everyFrame | false | false |  |  |

##### 10. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int 3Quarter Amount | int 3Quarter Amount | Variable |  |
| add | 24 | 24 |  |  |
| everyFrame | false | false |  |  |

##### 11. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| fsmName | "vessel_size" | "vessel_size" | FsmName |  |
| variableName | "Empty Amount" | "Empty Amount" | FsmInt |  |
| setValue | int Empty Amount | int Empty Amount |  |  |
| everyFrame | false | false |  |  |

##### 12. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Self | OwnerDefault Self |  |  |
| fsmName | "vessel_size" | "vessel_size" | FsmName |  |
| variableName | "Full Amount" | "Full Amount" | FsmInt |  |
| setValue | int Full Amount | int Full Amount |  |  |
| everyFrame | false | false |  |  |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: vessel_size]:Self | EventTarget(GameObjectFSM)[SendToFSM: vessel_size]:Self |  |  |
| sendEvent | "START" | "START" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 14. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP Max | int Reserve MP Max |  |  |
| integer2 | int Full Amount | int Full Amount |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(NOT OBTAINED) | Event(NOT OBTAINED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Not Obtained

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

### Down Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: vessel_size]:Self | EventTarget(GameObjectFSM)[SendToFSM: vessel_size]:Self |  |  |
| sendEvent | "SIZE CHECK" | "SIZE CHECK" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPReserve" | "MPReserve" |  |  |
| storeValue | int Reserve MP | int Reserve MP | Variable |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP | int Reserve MP |  |  |
| integer2 | int Full Amount | int Full Amount |  |  |
| equal | Event(FULL) | Event(FULL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FULL) | Event(FULL) |  |  |
| everyFrame | false | false |  |  |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP | int Reserve MP |  |  |
| integer2 | int 3Quarter Amount | int 3Quarter Amount |  |  |
| equal | Event(3QUARTER) | Event(3QUARTER) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(3QUARTER) | Event(3QUARTER) |  |  |
| everyFrame | false | false |  |  |

##### 6. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP | int Reserve MP |  |  |
| integer2 | int Half Amount | int Half Amount |  |  |
| equal | Event(HALF) | Event(HALF) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(HALF) | Event(HALF) |  |  |
| everyFrame | false | false |  |  |

##### 7. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP | int Reserve MP |  |  |
| integer2 | int Quarter Amount | int Quarter Amount |  |  |
| equal | Event(QUARTER) | Event(QUARTER) |  |  |
| lessThan | Event(EMPTY) | Event(EMPTY) |  |  |
| greaterThan | Event(QUARTER) | Event(QUARTER) |  |  |
| everyFrame | false | false |  |  |

### Down To Empty

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationV2

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_DownToEmpty" | "V_DownToEmpty" |  |  |
| doNotResetCurrentClip | true | true |  |  |

### Up Check

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 5

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: vessel_size]:Self | EventTarget(GameObjectFSM)[SendToFSM: vessel_size]:Self |  |  |
| sendEvent | "SIZE CHECK" | "SIZE CHECK" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPReserve" | "MPReserve" |  |  |
| storeValue | int Reserve MP | int Reserve MP | Variable |  |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP | int Reserve MP |  |  |
| integer2 | int Full Amount | int Full Amount |  |  |
| equal | Event(FULL) | Event(FULL) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FULL) | Event(FULL) |  |  |
| everyFrame | false | false |  |  |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP | int Reserve MP |  |  |
| integer2 | int 3Quarter Amount | int 3Quarter Amount |  |  |
| equal | Event(3QUARTER) | Event(3QUARTER) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(3QUARTER) | Event(3QUARTER) |  |  |
| everyFrame | false | false |  |  |

##### 6. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP | int Reserve MP |  |  |
| integer2 | int Half Amount | int Half Amount |  |  |
| equal | Event(HALF) | Event(HALF) |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(HALF) | Event(HALF) |  |  |
| everyFrame | false | false |  |  |

##### 7. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP | int Reserve MP |  |  |
| integer2 | int Quarter Amount | int Quarter Amount |  |  |
| equal | Event(QUARTER) | Event(QUARTER) |  |  |
| lessThan | Event(EMPTY) | Event(EMPTY) |  |  |
| greaterThan | Event(QUARTER) | Event(QUARTER) |  |  |
| everyFrame | false | false |  |  |

### Up To Quarter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationV2

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_UpToQuarter" | "V_UpToQuarter" |  |  |
| doNotResetCurrentClip | true | true |  |  |

### Down To Quarter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationV2

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_DownToQuarter" | "V_DownToQuarter" |  |  |
| doNotResetCurrentClip | true | true |  |  |

### Down To Half

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationV2

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_DownToHalf" | "V_DownToHalf" |  |  |
| doNotResetCurrentClip | true | true |  |  |

### Up To Half

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationV2

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_UpToHalf" | "V_UpToHalf" |  |  |
| doNotResetCurrentClip | true | true |  |  |

### Down To 3Quarter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationV2

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_DownTo3Quarter" | "V_DownTo3Quarter" |  |  |
| doNotResetCurrentClip | true | true |  |  |

### Up To 3Quarter

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationV2

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_UpTo3Quarter" | "V_UpTo3Quarter" |  |  |
| doNotResetCurrentClip | true | true |  |  |

### Down To Full

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. Tk2dPlayAnimationV2

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_Full" | "V_Full" |  |  |
| doNotResetCurrentClip | true | true |  |  |

### Up To Full

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationV2

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_UpToFull" | "V_UpToFull" |  |  |
| doNotResetCurrentClip | true | true |  |  |

### Flash?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPReserve" | "MPReserve" |  |  |
| storeValue | int Reserve MP | int Reserve MP | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP | int Reserve MP |  |  |
| integer2 | int Empty Amount | int Empty Amount |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP | int Reserve MP |  |  |
| integer2 | int Full Amount | int Full Amount |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event() | Event() |  |  |
| greaterThan | Event(FINISHED) | Event(FINISHED) |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):Flash | EventTarget(GameObject):Flash |  |  |
| sendEvent | "FLASH" | "FLASH" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Appear?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "MPReserveMax" | "MPReserveMax" |  |  |
| storeValue | int Reserve MP Max | int Reserve MP Max | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP Max | int Reserve MP Max |  |  |
| integer2 | int Full Amount | int Full Amount |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

##### 4. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "V_New" | "V_New" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Load Anim?

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. PlayerDataBoolTest

Full Name: HutongGames.PlayMaker.Actions.PlayerDataBoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| boolName | "isFirstGame" | "isFirstGame" |  |  |
| isTrue | Event() | Event() |  |  |
| isFalse | Event(FULL) | Event(FULL) |  |  |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Initialised | bool Initialised | Variable |  |
| isTrue | Event(FULL) | Event(FULL) |  |  |
| isFalse | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable | bool Initialised | bool Initialised | Variable |  |
| boolValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Load Anim Pause | float Load Anim Pause |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Load Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| clipName | "V_New" | "V_New" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| active | true | true |  |  |

### Init Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_Empty" | "V_Empty" |  |  |

### Empty

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. Tk2dPlayAnimationV2

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationV2
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| animLibName | "" | "" |  |  |
| clipName | "V_Empty" | "V_Empty" |  |  |
| doNotResetCurrentClip | true | true |  |  |

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

### Bound

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Reserve MP Max | int Reserve MP Max |  |  |
| integer2 | int Full Amount | int Full Amount |  |  |
| equal | Event() | Event() |  |  |
| lessThan | Event(NOT OBTAINED) | Event(NOT OBTAINED) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Setup

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
| childName | "Binding" | "Binding" |  |  |
| storeResult | GameObject Binding Cap | GameObject Binding Cap | Variable |  |

### Obtained

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Binding Cap | OwnerDefault Binding Cap |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Not obtained

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

_None_

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | NOT OBTAINED | Not Obtained | 0 | 0 | 0 |
| Init | FINISHED | Load Anim? | 0 | 0 | 0 |
| Init | NEW SOUL ORB | Pause | 0 | 0 | 0 |
| Not Obtained | NEW SOUL ORB | Pause | 0 | 0 | 0 |
| Not Obtained | LEVEL LOADED | Pause | 0 | 0 | 0 |
| Down Check | EMPTY | Down To Empty | 0 | 0 | 0 |
| Down Check | QUARTER | Down To Quarter | 0 | 0 | 0 |
| Down Check | HALF | Down To Half | 0 | 0 | 0 |
| Down Check | 3QUARTER | Down To 3Quarter | 0 | 0 | 0 |
| Down Check | FULL | Down To Full | 0 | 0 | 0 |
| Down To Empty | MP RESERVE UP | Flash? | 0 | 0 | 0 |
| Down To Empty | MP RESERVE DOWN | Down Check | 0 | 0 | 0 |
| Down To Empty | MP RESERVE ZERO | Init Anim | 0 | 0 | 0 |
| Up Check | EMPTY | Empty | 0 | 0 | 0 |
| Up Check | QUARTER | Up To Quarter | 0 | 0 | 0 |
| Up Check | HALF | Up To Half | 0 | 0 | 0 |
| Up Check | 3QUARTER | Up To 3Quarter | 0 | 0 | 0 |
| Up Check | FULL | Up To Full | 0 | 0 | 0 |
| Up To Quarter | MP RESERVE DOWN | Down Check | 0 | 0 | 0 |
| Up To Quarter | MP RESERVE UP | Flash? | 0 | 0 | 0 |
| Up To Quarter | MP RESERVE ZERO | Init Anim | 0 | 0 | 0 |
| Down To Quarter | MP RESERVE DOWN | Down Check | 0 | 0 | 0 |
| Down To Quarter | MP RESERVE UP | Flash? | 0 | 0 | 0 |
| Down To Quarter | MP RESERVE ZERO | Init Anim | 0 | 0 | 0 |
| Down To Half | MP RESERVE DOWN | Down Check | 0 | 0 | 0 |
| Down To Half | MP RESERVE UP | Flash? | 0 | 0 | 0 |
| Down To Half | MP RESERVE ZERO | Init Anim | 0 | 0 | 0 |
| Up To Half | MP RESERVE DOWN | Down Check | 0 | 0 | 0 |
| Up To Half | MP RESERVE UP | Flash? | 0 | 0 | 0 |
| Up To Half | MP RESERVE ZERO | Init Anim | 0 | 0 | 0 |
| Down To 3Quarter | MP RESERVE DOWN | Down Check | 0 | 0 | 0 |
| Down To 3Quarter | MP RESERVE UP | Flash? | 0 | 0 | 0 |
| Down To 3Quarter | MP RESERVE ZERO | Init Anim | 0 | 0 | 0 |
| Up To 3Quarter | MP RESERVE DOWN | Down Check | 0 | 0 | 0 |
| Up To 3Quarter | MP RESERVE UP | Flash? | 0 | 0 | 0 |
| Up To 3Quarter | MP RESERVE ZERO | Init Anim | 0 | 0 | 0 |
| Down To Full | MP RESERVE DOWN | Down Check | 0 | 0 | 0 |
| Down To Full | MP RESERVE ZERO | Init Anim | 0 | 0 | 0 |
| Up To Full | MP RESERVE DOWN | Down Check | 0 | 0 | 0 |
| Up To Full | MP RESERVE UP | Flash? | 0 | 0 | 0 |
| Up To Full | MP RESERVE ZERO | Init Anim | 0 | 0 | 0 |
| Flash? | FINISHED | Up Check | 0 | 0 | 0 |
| Appear? | CANCEL | Not Obtained | 0 | 0 | 0 |
| Appear? | FINISHED | Empty | 0 | 0 | 0 |
| Load Anim? | FULL | Init Anim | 0 | 0 | 0 |
| Load Anim? | FINISHED | Load Anim | 0 | 0 | 0 |
| Load Anim | FINISHED | Empty | 0 | 0 | 0 |
| Init Anim | FINISHED | Down Check | 0 | 0 | 0 |
| Empty | MP RESERVE UP | Up Check | 0 | 0 | 0 |
| Empty | MP RESERVE DOWN | Down Check | 0 | 0 | 0 |
| Empty | MP RESERVE ZERO | Init Anim | 0 | 0 | 0 |
| Pause | FINISHED | Appear? | 0 | 0 | 0 |
| Bound | NOT OBTAINED | Not obtained | 0 | 0 | 0 |
| Bound | FINISHED | Obtained | 0 | 0 | 0 |
| Setup | FINISHED | Init | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| BIND VESSEL ORB | Bound | 0 | 0 | 0 |
| UNBIND VESSEL ORB | Init | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| LEVEL LOADED | false |
| 3QUARTER | false |
| BIND VESSEL ORB | true |
| CANCEL | false |
| EMPTY | false |
| FULL | false |
| HALF | false |
| MP RESERVE DOWN | false |
| MP RESERVE UP | false |
| MP RESERVE ZERO | false |
| NEW SOUL ORB | false |
| NOT OBTAINED | false |
| QUARTER | false |
| UNBIND VESSEL ORB | true |
| UPDATE VESSELS | false |

