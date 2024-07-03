using UnityEngine;

public class MoveState : ActorState {
    public MoveState(ActorSM sm, BaseActor actor) : 
        base(ActorAnimName.Move, ActorAnimName.Move_PlaySpeed, sm, actor) { }

    public override void Enter() {
        base.Enter(); 
        actor.moveController.Enter();
    }
    public override BaseState GetTransition(out BaseState newState) {
        //to idle because done
        if (actor.Is_Have_Control_Request == false &&
            actor.Is_Ready_To_Auto_Attack == false &&
            actor.Is_Ready_To_Auto_Follow == false) {
            return newState = ((ActorSM)sm).Idle;
        }

        // to attack because finish and can attack
        if (actor.Is_Ready_To_Auto_Attack == true &&
            actor.Is_Have_Control_Request == false) { 
            return newState = ((ActorSM)sm).Attack;
        }
        
        // to follow because done
        if (actor.Is_Have_Control_Request == false &&
            actor.Is_Ready_To_Auto_Attack == false &&
            actor.Is_Ready_To_Auto_Follow == true) {
            return newState = ((ActorSM)sm).Follow;
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
        actor.moveController.Exit();
    }
}