# Evolution Note - 2026-05-05 12:33:27

- Question: Why can a full-source RingLib state machine component mount successfully but never enter its first state?
- Target: `rules/development/code-patterns.md`
- Risk: `low`
- Status: `applied to target rule`
- Marker: `<!-- evolution:8dc181cb2914 -->`

## Learned Facts

- RingLib.StateMachine.StateCollector only collects instance methods marked with the [State] attribute; a method with IEnumerator<Transition> signature alone is not enough.
- If the component is added and initialization logs appear but no state-entry logs appear, first verify that every intended state method has the [State] attribute.
- In full source integration, a missing [State] attribute can make runtime behavior look like the mod did nothing even though the component was mounted successfully.

## Sources

- `RingLib/StateMachine/StateCollector.cs:31`
- `RingLib/StateMachine/StateCollector.cs:33`
- `RingLib/StateMachine/StateCollector.cs:54`
