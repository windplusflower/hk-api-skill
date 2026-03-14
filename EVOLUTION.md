# Skill Evolution Workflow

## Goal

Keep `rules/**` up to date when answers require fallback research from `hkapi/**`.

## Trigger

Evolution is required when both are true:

1. `rules/**` does not contain enough information to answer correctly.
2. The answer depends on source-level findings from `hkapi/**`.

## Two-Stage Update Strategy

1. Create a pending evolution note in `rules/_pending/`.
2. Apply directly to the target rule file only when risk is `low`.
3. Keep pending-only for `high` risk until user confirms.

## Record Command

```bash
python scripts/evolution_record.py \
  --question "How does HealthManager apply damage?" \
  --target rules/core/core-classes.md \
  --fact "ApplyExtraDamage updates hp after damage adjustments." \
  --source hkapi/HealthManager.cs:212 \
  --risk low
```
