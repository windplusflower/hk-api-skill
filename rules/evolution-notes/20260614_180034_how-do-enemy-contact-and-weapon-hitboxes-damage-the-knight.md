# Evolution Note - 2026-06-14 18:00:34

- Question: How do enemy contact and weapon hitboxes damage the Knight?
- Target: `rules/systems/combat-system.md`
- Risk: `low`
- Status: `applied to target rule`
- Marker: `<!-- evolution:dd5ff006ee62 -->`

## Learned Facts

- HeroBox checks the Collider2D GameObject that touched the hero; if that object has a damages_hero FSM, the FSM damageDealt and hazardType variables are used.
- If no damages_hero FSM is present, HeroBox reads DamageHero from the same Collider2D GameObject, so adding DamageHero only to a parent object does not make child weapon colliders hurt the hero.
- DamageHero defaults to damageDealt=1 and hazardType=1, and resetOnEnable can reset damageDealt when the component is enabled.

## Sources

- `hkapi/HeroBox.cs:35`
- `hkapi/HeroBox.cs:37`
- `hkapi/HeroBox.cs:57`
- `hkapi/DamageHero.cs:5`
- `hkapi/DamageHero.cs:22`
