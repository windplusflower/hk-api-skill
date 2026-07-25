# Evolution Note - 2026-06-27 10:56:19

- Question: Why can an enemy take damage but miss directional hit recoil events?
- Target: `rules/systems/combat-system.md`
- Risk: `low`
- Status: `applied to target rule`
- Marker: `<!-- evolution:fbce4bf1c09d -->`

## Learned Facts

- HealthManager.Hit returns while evasionByHitRemaining is positive; NonFatalHit sets that timer to 0.2 seconds for normal non-fatal hits.
- HealthManager.TakeDamage sends HIT and TOOK DAMAGE, then calls Recoil.RecoilByDirection when a Recoil component is present.
- Recoil.Reset gives the component a default recoilDuration of 0.5 seconds, and RecoilByDirection returns immediately unless the Recoil state is Ready.
- When RecoilByDirection runs while Ready, it emits directional FSM events HIT RIGHT, HIT UP, HIT LEFT, or HIT DOWN to the owner GameObject.

## Sources

- `hkapi/HealthManager.cs:126`
- `hkapi/HealthManager.cs:130`
- `hkapi/HealthManager.cs:136`
- `hkapi/HealthManager.cs:249`
- `hkapi/HealthManager.cs:251`
- `hkapi/HealthManager.cs:258`
- `hkapi/HealthManager.cs:343`
- `hkapi/Recoil.cs:47`
- `hkapi/Recoil.cs:85`
- `hkapi/Recoil.cs:111`
- `hkapi/Recoil.cs:114`
- `hkapi/Recoil.cs:118`
- `hkapi/Recoil.cs:121`
