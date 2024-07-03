using UnityEngine;

public class FollowState : ActorState {
    public FollowState(ActorSM sm, BaseActor actor) : 
        base(ActorAnimName.Follow, ActorAnimName.Follow_PlaySpeed, sm, actor) {}

    public override void Enter() {
        base.Enter();
        actor.moveAutomator.Enter();
    }
    public override BaseState GetTransition(out BaseState newState) {
        // to idle because lost target
        if (actor.Is_Ready_To_Auto_Follow == false &&
            actor.Is_Ready_To_Auto_Attack == false) {
            return newState = ((ActorSM)sm).Idle;
        }
        
        // to attack because can attack :v
        if (actor.Is_Ready_To_Auto_Attack == true) { 
            return newState = ((ActorSM)sm).Attack;
        }
        return base.GetTransition(out newState);
    }
    public override void UpdateLogic() {
        base.UpdateLogic();
    }
    public override void UpdatePhysics() { 
        base.UpdatePhysics();
    }
    public override void Exit() { 
        base.Exit();
        actor.moveAutomator.Exit();
    }
}