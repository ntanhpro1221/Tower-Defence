using UnityEngine;

public class DeadState : ActorState {
    public float respawnCD;
    public DeadState(StateMachine sm, BaseActor actor) : 
        base(ActorAnimName.Dead, ActorAnimName.Dead_PlaySpeed, sm, actor) { }

    public override void Enter() { 
        base.Enter();
        respawnCD = actor.statsHandler.Stats.RespawnTime.Value;
        actor.coll.enabled = false;
        ((ActorSM)sm).animator.Play(name);
    }
    public override BaseState GetTransition(out BaseState newState) {
        // to Idle because enough time to respawn
        if (respawnCD <= 0) { // enough time
            return newState = ((ActorSM)sm).Idle;
        }

        // to Idle because not die anymore
        if (actor.Is_Dead == false) { // not die
            return newState = ((ActorSM)sm).Idle;
        }

        return base.GetTransition(out newState);
    }
    public override void UpdatePhysics() {
        base.UpdatePhysics();
        respawnCD -= Time.deltaTime;
    }
    public override void Exit() {
        base.Exit(); 
        if (actor.Is_Dead == true) {
            actor.healthHandler.FillHealth();
        }
        actor.coll.enabled = true;
    }
}