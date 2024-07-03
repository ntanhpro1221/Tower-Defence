using UnityEngine;

public class AttackState : ActorState {
    public AttackState(StateMachine sm, BaseActor actor) :
        base(ActorAnimName.Attack, ActorAnimName.Attack_PlaySpeed, sm, actor) { }

    public override void Enter() {
        base.Enter();
        actor.attackAutomator.Enter();
    }
    public override BaseState GetTransition(out BaseState newState) {
        // to Follow because target too far
        if (actor.Is_Ready_To_Auto_Attack == false &&
            actor.Is_Ready_To_Auto_Follow == true) {
            return newState = ((ActorSM)sm).Follow;
        }

        // to Idle because not have any target
        if (actor.Is_Ready_To_Auto_Attack == false &&
            actor.Is_Ready_To_Auto_Follow == false) {
            return newState = ((ActorSM)sm).Idle;
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
        actor.attackAutomator.Exit();
    }
}