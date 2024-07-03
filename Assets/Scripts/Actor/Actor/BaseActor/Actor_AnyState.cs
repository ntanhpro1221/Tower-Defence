public class Actor_AnyState : ActorState {
    public Actor_AnyState(StateMachine sm, BaseActor actor) : 
        base(string.Empty, string.Empty, sm, actor) { }
    public override BaseState GetTransition(out BaseState newState) {
        if (((ActorSM)sm).CurState == ((ActorSM)sm).Dead)
            return newState = null;
        else if (actor.Is_Dead) return newState = ((ActorSM)sm).Dead;

        if (((ActorSM)sm).CurState == ((ActorSM)sm).Move)
            return newState = null;
        else if (actor.Is_Have_Control_Request) return newState = ((ActorSM)sm).Move;

        return base.GetTransition(out newState);
    }
}
