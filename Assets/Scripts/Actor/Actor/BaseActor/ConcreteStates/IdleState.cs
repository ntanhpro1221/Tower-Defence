using System.Net;
using UnityEngine;

public class IdleState : ActorState {
    public IdleState(StateMachine sm, BaseActor actor) :
        base(ActorAnimName.Idle, ActorAnimName.Idle_PlaySpeed, sm, actor) { }

    public override void Enter() { 
        base.Enter();
        ((ActorSM)sm).animator.Play(name);
    }
    public override BaseState GetTransition(out BaseState newState) {
        // auto attack
        if (actor.Is_Ready_To_Auto_Attack == true) {
            return newState = ((ActorSM)sm).Attack;
        }

        // to auto follow
        if (actor.Is_Ready_To_Auto_Attack == false &&
            actor.Is_Ready_To_Auto_Follow == true) {
            return newState = ((ActorSM)sm).Follow;
        }

        return base.GetTransition(out newState);
    }
    public override void UpdatePhysics() { 
        base.UpdatePhysics();
    }
    public override void Exit() { 
        base.Exit();
    }
}