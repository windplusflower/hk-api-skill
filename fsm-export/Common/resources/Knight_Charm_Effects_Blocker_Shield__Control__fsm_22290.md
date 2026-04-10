# Control

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Control |
| GameObject Name | Blocker Shield |
| GameObject Path | Knight/Charm Effects |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Pause |
| FSM PathId | 22290 |
| GameObject PathId | 4452 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blocks | 0 | Int32: 0 |
| Decrement | -1 | Int32: -1 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Charm Effects | [null] | NamedAssetPPtr:  |
| Crack | [null] | NamedAssetPPtr:  |
| Knight | [null] | NamedAssetPPtr:  |
| Pusher | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |
| Shell Anim | [null] | NamedAssetPPtr:  |

## States

### Init

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
| childName | "Shell Anim" | "Shell Anim" |  |  |
| storeResult | GameObject Shell Anim | GameObject Shell Anim | Variable |  |

##### 2. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Pusher" | "Pusher" |  |  |
| storeResult | GameObject Pusher | GameObject Pusher | Variable |  |

##### 3. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Hit Crack" | "Hit Crack" |  |  |
| storeResult | GameObject Crack | GameObject Crack | Variable |  |

##### 4. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| storeResult | GameObject Charm Effects | GameObject Charm Effects | Variable |  |

##### 5. GetParent

Full Name: HutongGames.PlayMaker.Actions.GetParent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Charm Effects | OwnerDefault Charm Effects |  |  |
| storeResult | GameObject Knight | GameObject Knight | Variable |  |

##### 6. GetOwner

Full Name: HutongGames.PlayMaker.Actions.GetOwner
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| storeGameObject | GameObject Self | GameObject Self | Variable |  |

### Unequipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blocker HUD | OwnerDefault Blocker HUD |  |  |
| active | false | false |  |  |

### Check Equipped

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
| boolName | "equippedCharm_5" | "equippedCharm_5" |  |  |
| isTrue | Event(EQUIPPED) | Event(EQUIPPED) |  |  |
| isFalse | Event(UNEQUIPPED) | Event(UNEQUIPPED) |  |  |

### Equipped

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

_None_

### Focusing

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

_None_

### Focus End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shell Anim | OwnerDefault Shell Anim |  |  |
| clipName | "Disappear" | "Disappear" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [blocker_open (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [blocker_open (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.15f | 1.15f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Shell Off

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shell Anim | OwnerDefault Shell Anim |  |  |
| active | false | false |  |  |

### Blocker Hit

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 4

#### Actions

##### 1. PlayerDataIntAdd

Full Name: HutongGames.PlayMaker.Actions.PlayerDataIntAdd
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "blockerHits" | "blockerHits" |  |  |
| amount | int Decrement | int Decrement | Variable |  |

##### 2. GetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.GetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| intName | "blockerHits" | "blockerHits" |  |  |
| storeValue | int Blocks | int Blocks | Variable |  |

##### 3. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Blocks | int Blocks |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(BREAK) | Event(BREAK) |  |  |
| lessThan | Event(BREAK) | Event(BREAK) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

##### 4. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shell Anim | OwnerDefault Shell Anim |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Impact" | "Impact" |  |  |

##### 5. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pusher | OwnerDefault Pusher |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 7. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Blocks | int Blocks | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Shell Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shell Anim | OwnerDefault Shell Anim |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Appear" | "Appear" |  |  |

##### 2. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shell Anim | OwnerDefault Shell Anim |  |  |
| active | true | true |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [blocker_close (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [blocker_close (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1.15f | 1.15f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Hits Left?

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
| intName | "blockerHits" | "blockerHits" |  |  |
| storeValue | int Blocks | int Blocks | Variable |  |

##### 2. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Blocks | int Blocks |  |  |
| integer2 | 0 | 0 |  |  |
| equal | Event(CANCEL) | Event(CANCEL) |  |  |
| lessThan | Event(CANCEL) | Event(CANCEL) |  |  |
| greaterThan | Event() | Event() |  |  |
| everyFrame | false | false |  |  |

### Break

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shell Anim | OwnerDefault Shell Anim |  |  |
| clipName | "Break" | "Break" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event() | Event() |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):CameraParent | EventTarget(GameObject):CameraParent |  |  |
| sendEvent | "AverageShake" | "AverageShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Pusher | OwnerDefault Pusher |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Crack | OwnerDefault Crack |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.83f | 0.83f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 6. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blocker HUD | OwnerDefault Blocker HUD |  |  |
| animLibName | "" | "" |  |  |
| clipName | "UI Break 4" | "UI Break 4" |  |  |

### Bits

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shell Anim | OwnerDefault Shell Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Blocker Bit 1 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Blocker Bit 1 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 2 | 2 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 22f | 22f |  |  |
| angleMin | 40f | 40f |  |  |
| angleMax | 140f | 140f |  |  |
| originVariationX | 1f | 1f |  |  |
| originVariationY | 1f | 1f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 3. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Blocker Bit 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Blocker Bit 2 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 2 | 2 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 22f | 22f |  |  |
| angleMin | 40f | 40f |  |  |
| angleMax | 140f | 140f |  |  |
| originVariationX | 1f | 1f |  |  |
| originVariationY | 1f | 1f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 4. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Blocker Bit 3 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Blocker Bit 3 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 2 | 2 |  |  |
| speedMin | 20f | 20f |  |  |
| speedMax | 25f | 25f |  |  |
| angleMin | 40f | 40f |  |  |
| angleMax | 140f | 140f |  |  |
| originVariationX | 1f | 1f |  |  |
| originVariationY | 1f | 1f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 5. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Blocker Bit 4 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Blocker Bit 4 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 2 | 2 |  |  |
| speedMin | 15f | 15f |  |  |
| speedMax | 22f | 22f |  |  |
| angleMin | 40f | 40f |  |  |
| angleMax | 140f | 140f |  |  |
| originVariationX | 1f | 1f |  |  |
| originVariationY | 1f | 1f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

##### 6. FlingObjectsFromGlobalPool

Full Name: HutongGames.PlayMaker.Actions.FlingObjectsFromGlobalPool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | [Global] [Blocker Bit 5 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Blocker Bit 5 (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| position | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| spawnMin | 2 | 2 |  |  |
| spawnMax | 2 | 2 |  |  |
| speedMin | 20f | 20f |  |  |
| speedMax | 25f | 25f |  |  |
| angleMin | 40f | 40f |  |  |
| angleMax | 140f | 140f |  |  |
| originVariationX | 1f | 1f |  |  |
| originVariationY | 1f | 1f |  |  |
| FSM | "" | "" |  |  |
| FSMEvent | "" | "" |  |  |

### HUD Icon Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blocker HUD | OwnerDefault Blocker HUD |  |  |
| active | true | true |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blocker HUD | OwnerDefault Blocker HUD |  |  |
| animLibName | "" | "" |  |  |
| clipName | "UI Appear" | "UI Appear" |  |  |

### HUD 1

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blocker HUD | OwnerDefault Blocker HUD |  |  |
| animLibName | "" | "" |  |  |
| clipName | "UI Break 3" | "UI Break 3" |  |  |

### HUD 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blocker HUD | OwnerDefault Blocker HUD |  |  |
| animLibName | "" | "" |  |  |
| clipName | "UI Break 2" | "UI Break 2" |  |  |

### HUD 3

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blocker HUD | OwnerDefault Blocker HUD |  |  |
| animLibName | "" | "" |  |  |
| clipName | "UI Break 1" | "UI Break 1" |  |  |

### Pause

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

### Unequip Pause

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

### Impact End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 2. Tk2dWatchAnimationEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dWatchAnimationEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Shell Anim | OwnerDefault Shell Anim |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Crack | OwnerDefault Crack |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### Icon Pause

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
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Check Equipped | 0 | 0 | 0 |
| Unequipped | CHARM EQUIP CHECK | Check Equipped | 0 | 0 | 0 |
| Check Equipped | EQUIPPED | Icon Pause | 0 | 0 | 0 |
| Check Equipped | UNEQUIPPED | Unequip Pause | 0 | 0 | 0 |
| Equipped | FOCUS START | Hits Left? | 0 | 0 | 0 |
| Focusing | FOCUS END | Focus End | 0 | 0 | 0 |
| Focusing | BLOCKER HIT | Blocker Hit | 0 | 0 | 0 |
| Focus End | FINISHED | Shell Off | 0 | 0 | 0 |
| Shell Off | FINISHED | Equipped | 0 | 0 | 0 |
| Blocker Hit | 1 | HUD 1 | 0 | 0 | 0 |
| Blocker Hit | 2 | HUD 2 | 0 | 0 | 0 |
| Blocker Hit | 3 | HUD 3 | 0 | 0 | 0 |
| Blocker Hit | BREAK | Break | 0 | 0 | 0 |
| Shell Up | FINISHED | Focusing | 0 | 0 | 0 |
| Hits Left? | CANCEL | Equipped | 0 | 0 | 0 |
| Hits Left? | FINISHED | Shell Up | 0 | 0 | 0 |
| Break | FINISHED | Bits | 0 | 0 | 0 |
| Bits | FINISHED | Shell Off | 0 | 0 | 0 |
| HUD Icon Up | FINISHED | Equipped | 0 | 0 | 0 |
| HUD 1 | FINISHED | Impact End | 0 | 0 | 0 |
| HUD 2 | FINISHED | Impact End | 0 | 0 | 0 |
| HUD 3 | FINISHED | Impact End | 0 | 0 | 0 |
| Pause | FINISHED | Init | 0 | 0 | 0 |
| Unequip Pause | FINISHED | Unequipped | 0 | 0 | 0 |
| Impact End | FINISHED | Shell Off | 0 | 0 | 0 |
| Icon Pause | FINISHED | HUD Icon Up | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| CHARM EQUIP CHECK | Init | 0 | 0 | 0 |
| HERO REVIVED | Init | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| 1 | false |
| 2 | false |
| 3 | false |
| BLOCKER HIT | false |
| BREAK | false |
| CANCEL | false |
| CHARM EQUIP CHECK | false |
| EQUIPPED | false |
| FOCUS END | false |
| FOCUS START | false |
| HERO REVIVED | false |
| UNEQUIPPED | false |

