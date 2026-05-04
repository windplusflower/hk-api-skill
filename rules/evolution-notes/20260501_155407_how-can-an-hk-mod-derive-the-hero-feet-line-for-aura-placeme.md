# Evolution Note - 2026-05-01 15:54:07

- Question: How can an HK mod derive the hero feet line for aura placement?
- Target: `rules/core/core-classes.md`
- Risk: `low`
- Status: `applied to target rule`
- Marker: `<!-- evolution:4e5af439e9d5 -->`

## Learned Facts

- HeroController caches Rigidbody2D, Collider2D, Transform, and MeshRenderer directly from the hero GameObject during setup.
- Mods can read HeroController.instance.gameObject collider and renderer bounds directly to derive hero feet and visible height without searching child objects.

## Sources

- `hkapi/HeroController.cs:4504`
- `hkapi/HeroController.cs:4508`
