using UnityEngine;

public abstract class StateMachine : CoreComponent {
    protected BaseState curState;
    public abstract BaseState CurState { get; set; }
    protected BaseState anyState;
    public abstract BaseState AnyState { get; }

    protected virtual void Update() {
        if (AnyState?.GetTransition(out var newState) != null) {
            ChangeState(newState);
        } else if (CurState?.GetTransition(out newState) != null) {
            ChangeState(newState);
        }

        CurState?.UpdateLogic();
    }
    protected virtual void FixedUpdate() {
        CurState?.UpdatePhysics();
    }
    protected virtual void ChangeState(BaseState newState) {
        if (CurState == newState) return;
        CurState?.Exit();
        CurState = newState;
        CurState?.Enter();
    }
}