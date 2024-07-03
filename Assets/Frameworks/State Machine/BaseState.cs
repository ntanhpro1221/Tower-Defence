using UnityEngine;

public class BaseState {
    public string name;
    public string playSpeedParam;
    protected StateMachine sm;

    public BaseState(string name, string playSpeedParam, StateMachine sm) {
        this.name = name;
        this.playSpeedParam = playSpeedParam;
        this.sm = sm;
    }

    public virtual void Enter() { }
    public virtual BaseState GetTransition(out BaseState newState) {
        return newState = null;
    }
    public virtual void UpdateLogic() { }
    public virtual void UpdatePhysics() { }
    public virtual void Exit() { }
}
