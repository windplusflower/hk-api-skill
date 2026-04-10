# Vessel Fragment UI

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Vessel Fragment UI |
| GameObject Name | Vessel Fragment UI |
| GameObject Path |  |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets10.assets |
| Start State | Init |
| FSM PathId | 531 |
| GameObject PathId | 220 |

## Variables

### Ints

| Name | Value | Raw/Type |
| --- | --- | --- |
| HP | 0 | Int32: 0 |
| Max HP | 0 | Int32: 0 |
| Pieces | 1 | Int32: 1 |

### Strings

| Name | Value | Raw/Type |
| --- | --- | --- |
| Get Anim |  | String:  |
| Piece Land Particles |  | String:  |

### Colors

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blanker Colour | Color(1, 1, 1, 0) | UnityColor: Color(1, 1, 1, 0) |
| Mover Colour | Color(1, 1, 1, 0) | UnityColor: Color(1, 1, 1, 0) |
| Piece Colour | Color(1, 1, 1, 0) | UnityColor: Color(1, 1, 1, 0) |

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Blanker | [null] | NamedAssetPPtr:  |
| Camera | [null] | NamedAssetPPtr:  |
| Fleur | [null] | NamedAssetPPtr:  |
| Get Effect | [null] | NamedAssetPPtr:  |
| Get Glow | [null] | NamedAssetPPtr:  |
| Hero | [null] | NamedAssetPPtr:  |
| Mover | [null] | NamedAssetPPtr:  |
| Mover Trail | [null] | NamedAssetPPtr:  |
| Piece | [null] | NamedAssetPPtr:  |
| Piece Get Object | [null] | NamedAssetPPtr:  |
| Self | [null] | NamedAssetPPtr:  |

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

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [heartpiece_decorative_ui (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets10.assets)] | [heartpiece_decorative_ui (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets10.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "Player" | "Player" | Tag |  |
| store | GameObject Hero | GameObject Hero | Variable |  |

##### 4. FindGameObject

Full Name: HutongGames.PlayMaker.Actions.FindGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| objectName | "" | "" |  |  |
| withTag | "CameraParent" | "CameraParent" | Tag |  |
| store | GameObject Camera | GameObject Camera | Variable |  |

##### 5. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Blanker" | "Blanker" |  |  |
| storeResult | GameObject Blanker | GameObject Blanker | Variable |  |

##### 6. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Fleur" | "Fleur" |  |  |
| storeResult | GameObject Fleur | GameObject Fleur | Variable |  |

##### 7. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Piece" | "Piece" |  |  |
| storeResult | GameObject Piece | GameObject Piece | Variable |  |

##### 8. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Mover" | "Mover" |  |  |
| storeResult | GameObject Mover | GameObject Mover | Variable |  |

##### 9. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Mover Trail" | "Mover Trail" |  |  |
| storeResult | GameObject Mover Trail | GameObject Mover Trail | Variable |  |

##### 10. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Get Effect" | "Get Effect" |  |  |
| storeResult | GameObject Get Effect | GameObject Get Effect | Variable |  |

##### 11. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Get Glow" | "Get Glow" |  |  |
| storeResult | GameObject Get Glow | GameObject Get Glow | Variable |  |

### Darken

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| toValue | Color(1, 1, 1, 0.5176471) | Color(1, 1, 1, 0.5176471) |  |  |
| colorVariable | Color Blanker Colour | Color Blanker Colour | Variable |  |
| time | 0.5f | 0.5f |  |  |
| speed | 0f | 0f |  |  |
| delay | 0f | 0f |  |  |
| easeType | 21 | 21 |  |  |
| reverse | false | false |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 2. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| color | Color Blanker Colour | Color Blanker Colour | FsmColor |  |
| everyframe | true | true |  |  |

### Fleur

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 3

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fleur | OwnerDefault Fleur |  |  |
| active | true | true |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fleur | OwnerDefault Fleur |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Fleur Appear" | "Fleur Appear" |  |  |

##### 3. IntSwitch

Full Name: HutongGames.PlayMaker.Actions.IntSwitch
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intVariable | int Pieces | int Pieces | Variable |  |
| compareTo | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| sendEvent | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| everyFrame | false | false |  |  |

### Get One

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Get Anim | string Get Anim | Variable |  |
| stringValue | "Get 1" | "Get 1" | TextArea |  |
| everyFrame | false | false |  |  |

##### 2. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Piece Land Particles | string Piece Land Particles | Variable |  |
| stringValue | "Piece Land 1" | "Piece Land 1" | TextArea |  |
| everyFrame | false | false |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Get 0" | "Get 0" |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | 0.36f | 0.36f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Get Anim

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Get Anim | string Get Anim |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| clipName | string Get Anim | string Get Anim |  |  |
| animationTriggerEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| animationCompleteEvent | Event() | Event() |  |  |

### Fade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetColorValue

Full Name: HutongGames.PlayMaker.Actions.SetColorValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| colorVariable | Color Piece Colour | Color Piece Colour | Variable |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| everyFrame | false | false |  |  |

##### 2. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| toValue | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| colorVariable | Color Piece Colour | Color Piece Colour | Variable |  |
| time | 0.5f | 0.5f |  |  |
| speed | 0f | 0f |  |  |
| delay | 0.5f | 0.5f |  |  |
| easeType | 21 | 21 |  |  |
| reverse | false | false |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |

##### 3. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| color | Color Piece Colour | Color Piece Colour | FsmColor |  |
| everyframe | true | true |  |  |

##### 4. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fleur | OwnerDefault Fleur |  |  |
| color | Color Piece Colour | Color Piece Colour | FsmColor |  |
| everyframe | true | true |  |  |

##### 5. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue | Color(1, 1, 1, 0.5176471) | Color(1, 1, 1, 0.5176471) |  |  |
| toValue | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| colorVariable | Color Blanker Colour | Color Blanker Colour | Variable |  |
| time | 0.5f | 0.5f |  |  |
| speed | 0f | 0f |  |  |
| delay | 0.5f | 0.5f |  |  |
| easeType | 21 | 21 |  |  |
| reverse | false | false |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |

##### 6. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Blanker | OwnerDefault Blanker |  |  |
| color | Color Blanker Colour | Color Blanker Colour | FsmColor |  |
| everyframe | true | true |  |  |

##### 7. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### Destroy Self

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 0

#### Actions

##### 1. SetGravity2dScale

Full Name: HutongGames.PlayMaker.Actions.SetGravity2dScale
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| gravityScale | 0.79f | 0.79f |  |  |

##### 2. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "isInvincible" | "isInvincible" |  |  |
| value | false | false |  |  |

##### 3. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "RegainControl" | "RegainControl" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 4. CallMethodProper

Full Name: HutongGames.PlayMaker.Actions.CallMethodProper
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| behaviour | "HeroController" | "HeroController" | Behaviour |  |
| methodName | "StartAnimationControl" | "StartAnimationControl" | Method |  |
| parameters | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| storeResult | Var unnamed = 0 | Var unnamed = 0 | Variable | Store Result |

##### 5. SetPlayerDataBool

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataBool
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| boolName | "disablePause" | "disablePause" |  |  |
| value | false | false |  |  |

##### 6. DestroySelf

Full Name: HutongGames.PlayMaker.Actions.DestroySelf
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| detachChildren | false | false |  |  |

### Piece Fade

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| active | true | true |  |  |

##### 2. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| toValue | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| colorVariable | Color Piece Colour | Color Piece Colour | Variable |  |
| time | 1f | 1f |  |  |
| speed | 0f | 0f |  |  |
| delay | 0f | 0f |  |  |
| easeType | 21 | 21 |  |  |
| reverse | false | false |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |

##### 3. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| color | Color Piece Colour | Color Piece Colour | FsmColor |  |
| everyframe | true | true |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.8f | 1.8f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### Get Two

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Get Anim | string Get Anim | Variable |  |
| stringValue | "Get 2" | "Get 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Got 1" | "Got 1" |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Piece Land Particles | string Piece Land Particles | Variable |  |
| stringValue | "Piece Land 2" | "Piece Land 2" | TextArea |  |
| everyFrame | false | false |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -0.2f | -0.2f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Check Max

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 2

#### Actions

##### 1. IntCompare

Full Name: HutongGames.PlayMaker.Actions.IntCompare
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| integer1 | int Pieces | int Pieces |  |  |
| integer2 | 3 | 3 |  |  |
| equal | Event(MAX UP) | Event(MAX UP) |  |  |
| lessThan | Event(FINISHED) | Event(FINISHED) |  |  |
| greaterThan | Event(MAX UP) | Event(MAX UP) |  |  |
| everyFrame | false | false |  |  |

### Fuse

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetPlayerDataInt

Full Name: HutongGames.PlayMaker.Actions.SetPlayerDataInt
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| intName | "vesselFragments" | "vesselFragments" |  |  |
| value | 0 | 0 |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [final_heart_piece (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets10.assets)] | [final_heart_piece (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets10.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fleur | OwnerDefault Fleur |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Fleur Disappear" | "Fleur Disappear" |  |  |

##### 4. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| toValue | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| colorVariable | Color Piece Colour | Color Piece Colour | Variable |  |
| time | 0.5f | 0.5f |  |  |
| speed | 0f | 0f |  |  |
| delay | 0f | 0f |  |  |
| easeType | 21 | 21 |  |  |
| reverse | false | false |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |

##### 5. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| color | Color Piece Colour | Color Piece Colour | FsmColor |  |
| everyframe | true | true |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1f | 1f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

##### 7. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Mover Trail | OwnerDefault Mover Trail |  |  |
| emit | 0 | 0 |  |  |

### Piece Get Particles

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Glow | OwnerDefault Get Glow |  |  |
| activate | true | true |  |  |
| recursive | false | false |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 2. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [new_heartpiece_puzzle_bit (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets10.assets)] | [new_heartpiece_puzzle_bit (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets10.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

##### 3. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |  |  |
| sendEvent | "EnemyKillShake" | "EnemyKillShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 4. FindChild

Full Name: HutongGames.PlayMaker.Actions.FindChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | string Piece Land Particles | string Piece Land Particles |  |  |
| storeResult | GameObject Piece Get Object | GameObject Piece Get Object | Variable |  |

##### 5. ActivateGameObject

Full Name: HutongGames.PlayMaker.Actions.ActivateGameObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece Get Object | OwnerDefault Piece Get Object |  |  |
| activate | true | true |  |  |
| recursive | true | true |  |  |
| resetOnExit | false | false |  |  |
| everyFrame | false | false |  |  |

##### 6. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.5f | 1.5f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### Tween Mover

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. iTweenMoveTo

Full Name: HutongGames.PlayMaker.Actions.iTweenMoveTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Mover Trail | OwnerDefault Mover Trail |  |  |
| id | "" | "" |  |  |
| transformPosition |  |  |  |  |
| vectorPosition | Vector3(-13.76, 6.1, 0) | Vector3(-13.76, 6.1, 0) |  |  |
| time | 0.75f | 0.75f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| easeType | iTween/EaseType::easeInBack | 26 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| orientToPath | false | false |  | LookAt |
| lookAtObject |  |  |  |  |
| lookAtVector | Vector3(0, 0, 0) | Vector3(0, 0, 0) |  |  |
| lookTime | 0f | 0f |  |  |
| axis | HutongGames.PlayMaker.Actions.iTweenFsmAction/AxisRestriction::none | 0 |  |  |
| moveToPath | true | true |  | Path |
| lookAhead | 0f | 0f |  |  |
| transforms | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| vectors | FSMViewAvalonia2.FsmArray2 | FSMViewAvalonia2.FsmArray2 |  |  |
| reverse | false | false |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 2. iTweenScaleTo

Full Name: HutongGames.PlayMaker.Actions.iTweenScaleTo
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Mover Trail | OwnerDefault Mover Trail |  |  |
| id | "" | "" |  |  |
| transformScale |  |  |  |  |
| vectorScale | Vector3(0.2, 0.2, 0.2) | Vector3(0.2, 0.2, 0.2) |  |  |
| time | 0.75f | 0.75f |  |  |
| delay | 0f | 0f |  |  |
| speed | 0f | 0f |  |  |
| easeType | iTween/EaseType::easeInBack | 26 |  |  |
| loopType | iTween/LoopType::none | 0 |  |  |
| startEvent | Event() | Event() |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |
| stopOnExit | true | true |  |  |
| loopDontFinish | true | true |  |  |

##### 3. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [dream_ghost_appear (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [dream_ghost_appear (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| pitchMin | 1f | 1f |  |  |
| pitchMax | 1f | 1f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Get

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera | EventTarget(GameObjectFSM)[SendToFSM: CameraShake]:Camera |  |  |
| sendEvent | "EnemyKillShake" | "EnemyKillShake" |  |  |
| delay | 0f | 0f |  |  |
| everyFrame | false | false |  |  |

##### 2. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Mover Trail | OwnerDefault Mover Trail |  |  |

##### 3. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Get Effect | OwnerDefault Get Effect |  |  |
| emit | 0 | 0 |  |  |

##### 4. DestroyObject

Full Name: HutongGames.PlayMaker.Actions.DestroyObject
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | GameObject Piece | GameObject Piece |  |  |
| delay | 0f | 0f |  |  |
| detachChildren | false | false |  |  |

##### 5. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.25f | 0.25f |  |  |
| finishEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| realTime | false | false |  |  |

##### 6. AudioPlayerOneShotSingle

Full Name: HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| audioPlayer | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] | [Global] [Audio Player Actor (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets)] |  |  |
| spawnPoint | GameObject Self | GameObject Self |  |  |
| audioClip | [spell_pickup_final_boom (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets10.assets)] | [spell_pickup_final_boom (AudioClip) (/home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/sharedassets10.assets)] |  |  |
| pitchMin | 1.25f | 1.25f |  |  |
| pitchMax | 1.25f | 1.25f |  |  |
| volume | 1f | 1f |  |  |
| delay | 0f | 0f |  |  |
| storePlayer |  |  |  |  |

### Max Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendEventByName

Full Name: HutongGames.PlayMaker.Actions.SendEventByName
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| eventTarget | EventTarget(BroadcastAll):FSM Owner | EventTarget(BroadcastAll):FSM Owner |  |  |
| sendEvent | "NEW SOUL ORB" | "NEW SOUL ORB" |  |  |
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

##### 3. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault GameManager | OwnerDefault GameManager |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | StoryRecord_maxSoulUp(???) | StoryRecord_maxSoulUp(???) |  |  |

### Hero Anim End

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| clipName | "Collect Heart Piece End" | "Collect Heart Piece End" |  |  |
| animationTriggerEvent | Event() | Event() |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Piece Ready

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| active | true | true |  |  |

##### 2. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| color | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) | FsmColor |  |
| everyframe | true | true |  |  |

##### 3. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 0.8f | 0.8f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### Get Anim 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| animLibName | "" | "" |  |  |
| clipName | string Get Anim | string Get Anim |  |  |

##### 2. Tk2dPlayAnimationWithEvents

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| clipName | string Get Anim | string Get Anim |  |  |
| animationTriggerEvent | Event(FINISHED) | Event(FINISHED) |  |  |
| animationCompleteEvent | Event(FINISHED) | Event(FINISHED) |  |  |

### Get Three

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Get Anim | string Get Anim | Variable |  |
| stringValue | "Get 3" | "Get 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 2. Tk2dPlayAnimation

Full Name: HutongGames.PlayMaker.Actions.Tk2dPlayAnimation
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| animLibName | "" | "" |  |  |
| clipName | "Got 2" | "Got 2" |  |  |

##### 3. SetStringValue

Full Name: HutongGames.PlayMaker.Actions.SetStringValue
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| stringVariable | string Piece Land Particles | string Piece Land Particles | Variable |  |
| stringValue | "Piece Land 3" | "Piece Land 3" | TextArea |  |
| everyFrame | false | false |  |  |

##### 4. SetPosition

Full Name: HutongGames.PlayMaker.Actions.SetPosition
Enabled: false

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| vector | Vector3(0, 0, 0) | Vector3(0, 0, 0) | Variable |  |
| x | 0f | 0f |  |  |
| y | -0.2f | -0.2f |  |  |
| z | 0f | 0f |  |  |
| space | UnityEngine.Space::Self | 1 |  |  |
| everyFrame | false | false |  |  |
| lateUpdate | false | false |  |  |

### Piece Fade 2

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SetMeshRenderer

Full Name: HutongGames.PlayMaker.Actions.SetMeshRenderer
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| active | true | true |  |  |

##### 2. EaseColor

Full Name: HutongGames.PlayMaker.Actions.EaseColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| fromValue | Color(1, 1, 1, 0) | Color(1, 1, 1, 0) |  |  |
| toValue | Color(1, 1, 1, 1) | Color(1, 1, 1, 1) |  |  |
| colorVariable | Color Piece Colour | Color Piece Colour | Variable |  |
| time | 1f | 1f |  |  |
| speed | 0f | 0f |  |  |
| delay | 0f | 0f |  |  |
| easeType | 21 | 21 |  |  |
| reverse | false | false |  |  |
| finishEvent | Event() | Event() |  |  |
| realTime | false | false |  |  |

##### 3. Tk2dSpriteSetColor

Full Name: HutongGames.PlayMaker.Actions.Tk2dSpriteSetColor
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Piece | OwnerDefault Piece |  |  |
| color | Color Piece Colour | Color Piece Colour | FsmColor |  |
| everyframe | true | true |  |  |

##### 4. Wait

Full Name: HutongGames.PlayMaker.Actions.Wait
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| time | 1.8f | 1.8f |  |  |
| finishEvent | Event(WAIT) | Event(WAIT) |  |  |
| realTime | false | false |  |  |

### PD Max Up

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Hero | OwnerDefault Hero |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | AddToMaxMPReserve(33) | AddToMaxMPReserve(33) |  |  |

##### 2. NextFrameEvent

Full Name: HutongGames.PlayMaker.Actions.NextFrameEvent
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| sendEvent | Event(FINISHED) | Event(FINISHED) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Darken | 0 | 0 | 0 |
| Darken | FINISHED | Fleur | 0 | 0 | 0 |
| Fleur | ONE | Get One | 0 | 0 | 0 |
| Fleur | TWO | Get Two | 0 | 0 | 0 |
| Fleur | THREE | Get Three | 0 | 0 | 0 |
| Get One | FINISHED | Piece Ready | 0 | 0 | 0 |
| Get Anim | FINISHED | Piece Get Particles | 0 | 0 | 0 |
| Fade | WAIT | Hero Anim End | 0 | 0 | 0 |
| Piece Fade | WAIT | Get Anim 2 | 0 | 0 | 0 |
| Get Two | FINISHED | Piece Fade | 0 | 0 | 0 |
| Check Max | FINISHED | Fade | 0 | 0 | 0 |
| Check Max | MAX UP | Fuse | 0 | 0 | 0 |
| Fuse | WAIT | Tween Mover | 0 | 0 | 0 |
| Piece Get Particles | WAIT | Check Max | 0 | 0 | 0 |
| Tween Mover | WAIT | Get | 0 | 0 | 0 |
| Get | FINISHED | PD Max Up | 0 | 0 | 0 |
| Max Up | FINISHED | Fade | 0 | 0 | 0 |
| Hero Anim End | FINISHED | Destroy Self | 0 | 0 | 0 |
| Piece Ready | WAIT | Get Anim | 0 | 0 | 0 |
| Get Anim 2 | FINISHED | Piece Get Particles | 0 | 0 | 0 |
| Get Three | FINISHED | Piece Fade 2 | 0 | 0 | 0 |
| Piece Fade 2 | WAIT | Get Anim 2 | 0 | 0 | 0 |
| PD Max Up | FINISHED | Max Up | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| FOUR | false |
| HEAL | false |
| MAX UP | false |
| ONE | false |
| THREE | false |
| TWO | false |
| WAIT | true |

