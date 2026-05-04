# vessel_orb

## Summary

| Field | Value |
| --- | --- |
| FSM Name | vessel_orb |
| GameObject Name | Vessel 2 |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Soul Orb/Vessels/ |
| Source Asset | D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data/level1 |
| Start State | Setup |
| FSM PathId | 9065 |
| GameObject PathId | 1148 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Load Anim Pause | 2.20000005 | Single: 2.20000005 |

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| 3Quarter Amount | 0 | Int32: 0 |
| Empty Amount | 33 | Int32: 33 |
| Full Amount | 66 | Int32: 66 |
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
| Binding Cap | [null] | NamedAssetPPtr: [null] |
| Flash | [null] | NamedAssetPPtr: [null] |
| Self | [null] | NamedAssetPPtr: [null] |

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
| storeGameObject |   | GameObject Self | Variable |   |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Binding Cap |   |   |
| activate |   | false |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| childName |   | "Flash" |   |   |
| storeResult |   | GameObject Flash | Variable |   |

##### 4. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "MPReserveMax" |   |   |
| storeValue |   | int Reserve MP Max | Variable |   |

##### 5. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Quarter Amount | Variable |   |
| intValue |   | int Empty Amount |   |   |
| everyFrame |   | false |   |   |

##### 6. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Half Amount | Variable |   |
| intValue |   | int Empty Amount |   |   |
| everyFrame |   | false |   |   |

##### 7. SetIntValue

Full Name: HutongGames.PlayMaker.Actions.SetIntValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int 3Quarter Amount | Variable |   |
| intValue |   | int Empty Amount |   |   |
| everyFrame |   | false |   |   |

##### 8. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Quarter Amount | Variable |   |
| add |   | 8 |   |   |
| everyFrame |   | false |   |   |

##### 9. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int Half Amount | Variable |   |
| add |   | 16 |   |   |
| everyFrame |   | false |   |   |

##### 10. IntAdd

Full Name: HutongGames.PlayMaker.Actions.IntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable |   | int 3Quarter Amount | Variable |   |
| add |   | 24 |   |   |
| everyFrame |   | false |   |   |

##### 11. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| fsmName |   | "vessel_size" | FsmName |   |
| variableName |   | "Empty Amount" | FsmInt |   |
| setValue |   | int Empty Amount |   |   |
| everyFrame |   | false |   |   |

##### 12. SetFsmInt

Full Name: HutongGames.PlayMaker.Actions.SetFsmInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault Self |   |   |
| fsmName |   | "vessel_size" | FsmName |   |
| variableName |   | "Full Amount" | FsmInt |   |
| setValue |   | int Full Amount |   |   |
| everyFrame |   | false |   |   |

##### 13. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: vessel_size]:Self |   |   |
| sendEvent |   | "START" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 14. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP Max |   |   |
| integer2 |   | int Full Amount |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(NOT OBTAINED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NOT OBTAINED | Not Obtained | 0 | |
| FINISHED | Load Anim? | 0 | |
| NEW SOUL ORB | Pause | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NEW SOUL ORB | Pause | 0 | |
| LEVEL LOADED | Pause | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: vessel_size]:Self |   |   |
| sendEvent |   | "SIZE CHECK" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "MPReserve" |   |   |
| storeValue |   | int Reserve MP | Variable |   |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP |   |   |
| integer2 |   | int Full Amount |   |   |
| equal |   | Event(FULL) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(FULL) |   |   |
| everyFrame |   | false |   |   |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP |   |   |
| integer2 |   | int 3Quarter Amount |   |   |
| equal |   | Event(3QUARTER) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(3QUARTER) |   |   |
| everyFrame |   | false |   |   |

##### 6. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP |   |   |
| integer2 |   | int Half Amount |   |   |
| equal |   | Event(HALF) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(HALF) |   |   |
| everyFrame |   | false |   |   |

##### 7. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP |   |   |
| integer2 |   | int Quarter Amount |   |   |
| equal |   | Event(QUARTER) |   |   |
| lessThan |   | Event(EMPTY) |   |   |
| greaterThan |   | Event(QUARTER) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EMPTY | Down To Empty | 0 | |
| QUARTER | Down To Quarter | 0 | |
| HALF | Down To Half | 0 | |
| 3QUARTER | Down To 3Quarter | 0 | |
| FULL | Down To Full | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_DownToEmpty" |   |   |
| doNotResetCurrentClip |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP RESERVE UP | Flash? | 0 | |
| MP RESERVE DOWN | Down Check | 0 | |
| MP RESERVE ZERO | Init Anim | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObjectFSM)[SendToFSM: vessel_size]:Self |   |   |
| sendEvent |   | "SIZE CHECK" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

##### 3. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "MPReserve" |   |   |
| storeValue |   | int Reserve MP | Variable |   |

##### 4. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP |   |   |
| integer2 |   | int Full Amount |   |   |
| equal |   | Event(FULL) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(FULL) |   |   |
| everyFrame |   | false |   |   |

##### 5. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP |   |   |
| integer2 |   | int 3Quarter Amount |   |   |
| equal |   | Event(3QUARTER) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(3QUARTER) |   |   |
| everyFrame |   | false |   |   |

##### 6. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP |   |   |
| integer2 |   | int Half Amount |   |   |
| equal |   | Event(HALF) |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(HALF) |   |   |
| everyFrame |   | false |   |   |

##### 7. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP |   |   |
| integer2 |   | int Quarter Amount |   |   |
| equal |   | Event(QUARTER) |   |   |
| lessThan |   | Event(EMPTY) |   |   |
| greaterThan |   | Event(QUARTER) |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| EMPTY | Empty | 0 | |
| QUARTER | Up To Quarter | 0 | |
| HALF | Up To Half | 0 | |
| 3QUARTER | Up To 3Quarter | 0 | |
| FULL | Up To Full | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_UpToQuarter" |   |   |
| doNotResetCurrentClip |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP RESERVE DOWN | Down Check | 0 | |
| MP RESERVE UP | Flash? | 0 | |
| MP RESERVE ZERO | Init Anim | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_DownToQuarter" |   |   |
| doNotResetCurrentClip |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP RESERVE DOWN | Down Check | 0 | |
| MP RESERVE UP | Flash? | 0 | |
| MP RESERVE ZERO | Init Anim | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_DownToHalf" |   |   |
| doNotResetCurrentClip |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP RESERVE DOWN | Down Check | 0 | |
| MP RESERVE UP | Flash? | 0 | |
| MP RESERVE ZERO | Init Anim | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_UpToHalf" |   |   |
| doNotResetCurrentClip |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP RESERVE DOWN | Down Check | 0 | |
| MP RESERVE UP | Flash? | 0 | |
| MP RESERVE ZERO | Init Anim | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_DownTo3Quarter" |   |   |
| doNotResetCurrentClip |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP RESERVE DOWN | Down Check | 0 | |
| MP RESERVE UP | Flash? | 0 | |
| MP RESERVE ZERO | Init Anim | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_UpTo3Quarter" |   |   |
| doNotResetCurrentClip |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP RESERVE DOWN | Down Check | 0 | |
| MP RESERVE UP | Flash? | 0 | |
| MP RESERVE ZERO | Init Anim | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_Full" |   |   |
| doNotResetCurrentClip |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP RESERVE DOWN | Down Check | 0 | |
| MP RESERVE ZERO | Init Anim | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_UpToFull" |   |   |
| doNotResetCurrentClip |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP RESERVE DOWN | Down Check | 0 | |
| MP RESERVE UP | Flash? | 0 | |
| MP RESERVE ZERO | Init Anim | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "MPReserve" |   |   |
| storeValue |   | int Reserve MP | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP |   |   |
| integer2 |   | int Empty Amount |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(FINISHED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP |   |   |
| integer2 |   | int Full Amount |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event() |   |   |
| greaterThan |   | Event(FINISHED) |   |   |
| everyFrame |   | false |   |   |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget |   | EventTarget(GameObject):Flash |   |   |
| sendEvent |   | "FLASH" |   |   |
| delay |   | 0f |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Up Check | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| intName |   | "MPReserveMax" |   |   |
| storeValue |   | int Reserve MP Max | Variable |   |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 |   | int Reserve MP Max |   |   |
| integer2 |   | int Full Amount |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(CANCEL) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

##### 4. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "V_New" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| CANCEL | Not Obtained | 0 | |
| FINISHED | Empty | 0 | |

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
| gameObject |   | OwnerDefault GameManager |   |   |
| boolName |   | "isFirstGame" |   |   |
| isTrue |   | Event() |   |   |
| isFalse |   | Event(FULL) |   |   |

##### 2. BoolTest

Full Name: HutongGames.PlayMaker.Actions.BoolTest
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Initialised | Variable |   |
| isTrue |   | Event(FULL) |   |   |
| isFalse |   | Event() |   |   |
| everyFrame |   | false |   |   |

##### 3. SetBoolValue

Full Name: HutongGames.PlayMaker.Actions.SetBoolValue
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolVariable |   | bool Initialised | Variable |   |
| boolValue |   | true |   |   |
| everyFrame |   | false |   |   |

##### 4. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | false |   |   |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time |   | float Load Anim Pause |   |   |
| finishEvent |   | Event(FINISHED) |   |   |
| realTime |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FULL | Init Anim | 0 | |
| FINISHED | Load Anim | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| clipName |   | "V_New" |   |   |
| animationTriggerEvent |   | Event() |   |   |
| animationCompleteEvent |   | Event(FINISHED) |   |   |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject |   | OwnerDefault FSM Owner |   |   |
| active |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Empty | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_Empty" |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Down Check | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| animLibName |   | "" |   |   |
| clipName |   | "V_Empty" |   |   |
| doNotResetCurrentClip |   | true |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| MP RESERVE UP | Up Check | 0 | |
| MP RESERVE DOWN | Down Check | 0 | |
| MP RESERVE ZERO | Init Anim | 0 | |

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
| sendEvent |   | Event(FINISHED) |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Appear? | 0 | |

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
| integer1 |   | int Reserve MP Max |   |   |
| integer2 |   | int Full Amount |   |   |
| equal |   | Event() |   |   |
| lessThan |   | Event(NOT OBTAINED) |   |   |
| greaterThan |   | Event() |   |   |
| everyFrame |   | false |   |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| NOT OBTAINED | Not obtained | 0 | |
| FINISHED | Obtained | 0 | |

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
| gameObject |   | OwnerDefault FSM Owner |   |   |
| childName |   | "Binding" |   |   |
| storeResult |   | GameObject Binding Cap | Variable |   |

#### Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| FINISHED | Init | 0 | |

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
| gameObject |   | OwnerDefault Binding Cap |   |   |
| activate |   | true |   |   |
| recursive |   | false |   |   |
| resetOnExit |   | false |   |   |
| everyFrame |   | false |   |   |

#### Transitions

(none)

### Not obtained

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

(none)

#### Transitions

(none)

## Global Transitions

| Event | To State | Color Index | |
| --- | --- | --- | --- |
| BIND VESSEL ORB | Bound | 0 | |
| UNBIND VESSEL ORB | Init | 0 | |

## Events

| Name | Global |
| --- | --- |
| 3QUARTER | false |
| BIND VESSEL ORB | true |
| CANCEL | false |
| EMPTY | false |
| FINISHED | false |
| FULL | false |
| HALF | false |
| LEVEL LOADED | false |
| MP RESERVE DOWN | false |
| MP RESERVE UP | false |
| MP RESERVE ZERO | false |
| NEW SOUL ORB | false |
| NOT OBTAINED | false |
| QUARTER | false |
| UNBIND VESSEL ORB | true |
| UPDATE VESSELS | false |

