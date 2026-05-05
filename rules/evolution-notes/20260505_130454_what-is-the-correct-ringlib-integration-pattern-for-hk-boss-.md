# Evolution Note - 2026-05-05 13:04:54

- Question: What is the correct RingLib integration pattern for HK boss state machines, and what common misuse should be avoided?
- Target: `rules/libraries/ringlib.md`
- Risk: `low`
- Status: `applied to target rule`
- Marker: `<!-- evolution:cf6f07cb38c1 -->`

## Learned Facts

- For HK boss or enemy main behavior, the preferred RingLib pattern is to add the state machine component from the hook/entry point and let the state machine initialize itself in EntityStateMachineStart().
- In MossBeast, the external entry point mainly does AddComponent<...StateMachine>(); old FSM shutdown and dependency capture happen inside EntityStateMachineStart(), not through a custom external Initialize(...) call.
- When replacing an existing PlayMaker boss FSM, disabling the old FSM inside EntityStateMachineStart() is more robust than splitting initialization between an external controller and the state machine.
- Use plain StateMachine only for simpler non-entity behavior; for boss or enemy hosts that need Rigidbody2D, BoxCollider2D, Position, Velocity, Direction(), or Turn(), prefer EntityStateMachine.

## Sources

- `../MossBeast/MossBeast.cs:210`
- `../MossBeast/MossBeastStateMachine.cs:55`
- `../MossBeast/MossBeastStateMachine.cs:82`
- `../MossBeast/RingLib/StateMachine/EntityStateMachine.cs:62`
