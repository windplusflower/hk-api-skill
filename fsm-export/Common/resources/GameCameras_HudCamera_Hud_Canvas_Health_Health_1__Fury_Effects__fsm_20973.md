# Fury Effects

## Summary

| Field | Value |
| --- | --- |
| FSM Name | Fury Effects |
| GameObject Name | Health 1 |
| GameObject Path | _GameCameras/HudCamera/Hud Canvas/Health |
| Source Asset | /home/windflower/snap/steam/common/.local/share/Steam/steamapps/common/Hollow Knight/hollow_knight_Data/resources.assets |
| Start State | Init |
| FSM PathId | 20973 |
| GameObject PathId | 4008 |

## Variables

### GameObjects

| Name | Value | Raw/Type |
| --- | --- | --- |
| Fury Particle | [null] | NamedAssetPPtr:  |
| Idle | [null] | NamedAssetPPtr:  |

## States

### Init

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. GetChild

Full Name: HutongGames.PlayMaker.Actions.GetChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Fury Particle" | "Fury Particle" |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| storeResult | GameObject Fury Particle | GameObject Fury Particle | Variable |  |

##### 2. GetChild

Full Name: HutongGames.PlayMaker.Actions.GetChild
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault FSM Owner | OwnerDefault FSM Owner |  |  |
| childName | "Idle" | "Idle" |  |  |
| withTag | "Untagged" | "Untagged" | Tag |  |
| storeResult | GameObject Idle | GameObject Idle | Variable |  |

### Idle

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. StopParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.StopParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fury Particle | OwnerDefault Fury Particle |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle | OwnerDefault Idle |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | CancelFlash(???) | CancelFlash(???) |  |  |

### Fury

Description: (none)
Flags: breakpoint=false, sequence=false, hideUnused=false
Local Transitions: 1

#### Actions

##### 1. PlayParticleEmitter

Full Name: HutongGames.PlayMaker.Actions.PlayParticleEmitter
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Fury Particle | OwnerDefault Fury Particle |  |  |
| emit | 0 | 0 |  |  |

##### 2. SendMessage

Full Name: HutongGames.PlayMaker.Actions.SendMessage
Enabled: true

| Name | Value | RawValue | UIHint | Group |
| --- | --- | --- | --- | --- |
| gameObject | OwnerDefault Idle | OwnerDefault Idle |  |  |
| delivery | HutongGames.PlayMaker.Actions.SendMessage/MessageType::SendMessage | 0 |  |  |
| options | UnityEngine.SendMessageOptions::DontRequireReceiver | 1 |  |  |
| functionCall | FlashingFury(???) | FlashingFury(???) |  |  |

## Transitions

| From | Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- | --- |
| Init | FINISHED | Idle | 0 | 0 | 0 |
| Idle | FURY START | Fury | 0 | 0 | 0 |
| Fury | FURY END | Idle | 0 | 0 | 0 |

## Global Transitions

| Event | To | ColorIndex | LinkStyle | LinkConstraint |
| --- | --- | --- | --- | --- |
| _(none)_ |  |  |  |  |

## Events

| Name | Global |
| --- | --- |
| FINISHED | false |
| FURY END | false |
| FURY START | false |

