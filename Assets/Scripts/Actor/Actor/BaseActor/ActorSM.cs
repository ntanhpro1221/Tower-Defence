using System.Collections.Generic;
using UnityEngine;

public abstract class ActorSM : StateMachine {
    public override BaseState CurState {
        get => curState ??= Idle;
        set => curState = value;
    }
    public override BaseState AnyState => 
        anyState = new Actor_AnyState(this, GetComponentInParent<BaseActor>());

    [HideInInspector] public Animator animator;
    public ActorState Idle { get; set; }
    public ActorState Move { get; set; }
    public ActorState Follow { get; set; }
    public ActorState Attack { get; set; }
    public ActorState Dead { get; set; }
    public List<ActorState> DoSkill { get; set; } = new();

    protected virtual void Awake() {
        animator = GetCoreComponent<BodyHandler>().GetComponent<Animator>();

        BaseActor actor = GetComponentInParent<BaseActor>();
        Idle = new IdleState(this, actor);
        Move = new MoveState(this, actor);
        Follow = new FollowState(this, actor);
        Attack = new AttackState(this, actor);
        Dead = new DeadState(this, actor);
    }
}