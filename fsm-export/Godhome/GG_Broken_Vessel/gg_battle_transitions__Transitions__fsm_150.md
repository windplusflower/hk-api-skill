# Transitions

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Transitions |
| GameObject Name | gg_battle_transitions |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets |
| Start State | Disable |
| FSM PathId | 150 |
| GameObject PathId | 42 |

## Variables

### Floats

| Name | Value | Raw/Type |
| --- | --- | --- |
| Transition In Time | 1 | Single: 1 |
| Transition Out Time | 1.5 | Single: 1.5 |
| TransitionEndTime | 3.2 | Single: 3.2 |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| TransitionEnd | gg_battle_transitions/battle_final (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets) | NamedAssetPPtr: gg_battle_transitions/battle_final (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets) |
| TransitionIn | gg_battle_transitions/battle_enter (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets) | NamedAssetPPtr: gg_battle_transitions/battle_enter (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets) |
| TransitionOut | gg_battle_transitions/battle_end (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets) | NamedAssetPPtr: gg_battle_transitions/battle_end (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets) |

## States

### Disable

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionIn | OwnerDefault TransitionIn |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionOut | OwnerDefault TransitionOut |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionEnd | OwnerDefault TransitionEnd |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

### In

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

##### 2. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "INVENTORY CANCEL" | "INVENTORY CANCEL" |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionIn | OwnerDefault TransitionIn |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionOut | OwnerDefault TransitionOut |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Blanker White | OwnerDefault HUD Blanker White |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker White | EventTarget(GameObject):HUD Blanker White |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 7. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Nail" | "Dream Nail" | FsmName |  |
| variableName | "Dream Warp Allowed" | "Dream Warp Allowed" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Transition In Time | float Transition In Time |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Out

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

##### 2. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "INVENTORY CANCEL" | "INVENTORY CANCEL" |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionOut | OwnerDefault TransitionOut |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. PlayAudioEvent

Full Name: PlayAudioEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioClip | [gg_room_transition (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] | [gg_room_transition (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| audioPlayerPrefab | [Audio Player Actor 2D (AudioSource) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Audio Player Actor 2D (AudioSource) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spawnPosition | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Nail" | "Dream Nail" | FsmName |  |
| variableName | "Dream Warp Allowed" | "Dream Warp Allowed" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "LOOK UP" | "LOOK UP" |  |  |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Transition Out Time | float Transition Out Time |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Send Event

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | false | false |  |  |

##### 2. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Nail" | "Dream Nail" | FsmName |  |
| variableName | "Dream Warp Allowed" | "Dream Warp Allowed" | FsmBool |  |
| setValue | true | true |  |  |
| everyFrame | false | false |  |  |

##### 3. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "GG TRANSITION END" | "GG TRANSITION END" |  |  |

### Final

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

##### 2. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "INVENTORY CANCEL" | "INVENTORY CANCEL" |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionEnd | OwnerDefault TransitionEnd |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. PlayAudioEvent

Full Name: PlayAudioEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioClip | [gg_room_transition_2_bit_shorter (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] | [gg_room_transition_2_bit_shorter (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| audioPlayerPrefab | [Audio Player Actor 2D (AudioSource) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Audio Player Actor 2D (AudioSource) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spawnPosition | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Nail" | "Dream Nail" | FsmName |  |
| variableName | "Dream Warp Allowed" | "Dream Warp Allowed" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "LOOK UP" | "LOOK UP" |  |  |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float TransitionEndTime | float TransitionEndTime |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Out Instant

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

##### 2. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "INVENTORY CANCEL" | "INVENTORY CANCEL" |  |  |

##### 3. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Nail" | "Dream Nail" | FsmName |  |
| variableName | "Dream Warp Allowed" | "Dream Warp Allowed" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionOut | OwnerDefault TransitionOut |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 5. AnimatorPlay

Full Name: HutongGames.PlayMaker.Actions.AnimatorPlay
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionOut | OwnerDefault TransitionOut |  |  |
| stateName | "GG_battle_transition_out" | "GG_battle_transition_out" |  |  |
| layer | 0 | 0 |  |  |
| normalizedTime | 1f | 1f |  |  |
| everyFrame | false | false |  |  |

### Set Blanker

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Blanker White | OwnerDefault HUD Blanker White |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker White | EventTarget(GameObject):HUD Blanker White |  |  |
| sendEvent | "FADE IN" | "FADE IN" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

### Out Statue

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | true | true |  |  |

##### 2. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "INVENTORY CANCEL" | "INVENTORY CANCEL" |  |  |

##### 3. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionOut | OwnerDefault TransitionOut |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 4. PlayAudioEvent

Full Name: PlayAudioEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioClip | [gg_room_transition (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] | [gg_room_transition (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets425.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| audioPlayerPrefab | [Audio Player Actor 2D (AudioSource) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Audio Player Actor 2D (AudioSource) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| spawnPosition | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |

##### 5. SetFsmBool

Full Name: HutongGames.PlayMaker.Actions.SetFsmBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| fsmName | "Dream Nail" | "Dream Nail" | FsmName |  |
| variableName | "Dream Warp Allowed" | "Dream Warp Allowed" | FsmBool |  |
| setValue | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "LOOK UP" | "LOOK UP" |  |  |

##### 7. TransitionToAudioSnapshot

Full Name: HutongGames.PlayMaker.Actions.TransitionToAudioSnapshot
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| snapshot | [Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Silent (AudioMixerSnapshotController) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| transitionTime | float Transition Out Time | float Transition Out Time |  |  |

##### 8. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Transition Out Time | float Transition Out Time |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### In Workshop

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionIn | OwnerDefault TransitionIn |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault TransitionOut | OwnerDefault TransitionOut |  |  |
| activate | false | false |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 3. SetFsmFloat

Full Name: HutongGames.PlayMaker.Actions.SetFsmFloat
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault HUD Blanker White | OwnerDefault HUD Blanker White |  |  |
| fsmName | "Blanker Control" | "Blanker Control" | FsmName |  |
| variableName | "Fade Time" | "Fade Time" | FsmFloat |  |
| setValue | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObject):HUD Blanker White | EventTarget(GameObject):HUD Blanker White |  |  |
| sendEvent | "FADE OUT" | "FADE OUT" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | float Transition In Time | float Transition In Time |  |  |
| finishEvent | FINISHED | FINISHED |  |  |
| realTime | false | false |  |  |

### Send Event Basic

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SendEventToRegister

Full Name: SendEventToRegister
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventName | "GG TRANSITION END" | "GG TRANSITION END" |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| In | FINISHED | Send Event | 0 | 0 | 0 |
| Out | FINISHED | Set Blanker | 0 | 0 | 0 |
| Final | FINISHED | Set Blanker | 0 | 0 | 0 |
| Set Blanker | FINISHED | Send Event | 0 | 0 | 0 |
| Out Statue | FINISHED | Set Blanker | 0 | 0 | 0 |
| In Workshop | FINISHED | Send Event Basic | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| GG TRANSITION IN | In | 0 | 0 | 0 |
| GG TRANSITION OUT | Out | 0 | 0 | 0 |
| GG TRANSITION FINAL | Final | 0 | 0 | 0 |
| GG TRANSITION OUT INSTANT | Out Instant | 0 | 0 | 0 |
| GG TRANSITION OUT STATUE | Out Statue | 0 | 0 | 0 |
| GG TRANSITION IN STATUE | In Workshop | 0 | 0 | 0 |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| GG TRANSITION FINAL | false |
| GG TRANSITION IN | false |
| GG TRANSITION IN STATUE | false |
| GG TRANSITION OUT | false |
| GG TRANSITION OUT INSTANT | false |
| GG TRANSITION OUT STATUE | false |

