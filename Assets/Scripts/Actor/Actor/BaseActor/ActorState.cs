public class ActorState : BaseState {
    protected BaseActor actor;

    public ActorState(string name, string playSpeedParam, StateMachine sm, BaseActor actor) :
        base(name, playSpeedParam, sm) {
        this.actor = actor;
    }
}