using System.Linq;
using UnityEngine;

public class Attacker : CoreComponent, IAttackable {
    #region STUFF
    private string animName;
    private string animPlaySpeed;
    private Animator animator;
    private ActorStats<Observable<float>> stats;
    private INavigateable navigator;

    private AnimationClip clip;
    private IHealthHandleable target;

    protected virtual void Awake() {
        animName = ActorAnimName.Attack;
        animPlaySpeed = ActorAnimName.Attack_PlaySpeed;
        animator = GetCoreComponent<BodyHandler>().GetComponent<Animator>();
        stats = GetCoreComponent<StatsHandler>().Stats;
        navigator = GetCoreComponent<Navigator>();

        clip = animator.runtimeAnimatorController.animationClips.
            First(clip => clip.name == animName);
        GetCoreComponent<StatsHandler>().Stats.
            AtkSpeed.OnChanged.AddListener(OnChangeAtkSpeed);

        GetCoreComponent<ActorAnimTrigger>().RegisterTrigger(
            ActorAnimTriggerType.ON_DEAL_DAMAGE_MOMENT,
            _TriggerDealDamageMoment);
        GetCoreComponent<ActorAnimTrigger>().RegisterTrigger(
            ActorAnimTriggerType.ON_FINISH_HIT,
            _TriggerEndAttack);
    }
    
    private void OnChangeAtkSpeed(float newAtkSpeed) {
        MatchWithAtkSpeed(newAtkSpeed);
    }
    private void MatchWithAtkSpeed(float atkSpeed) {
        animator.SetFloat(animPlaySpeed, clip.length * atkSpeed);
    }
    public virtual void _TriggerDealDamageMoment() {
        target?.Damage(stats.Atk.Value);
    }
    public virtual void _TriggerEndAttack() {
        Stop();
    }
    #endregion

    #region MAIN METHOD
    public virtual bool IsFinish { get; private set; } = true;
    public virtual void Attack(IHealthHandleable target, Vector3 targetPos) {
        IsFinish = false;
        this.target = target;
        MatchWithAtkSpeed(stats.AtkSpeed.Value);
        animator.Play(animName, -1, 0);
        navigator.TurnTo(targetPos);
    }
    public virtual void Stop() {
        IsFinish = true;
        target = null;
        navigator.Stop();
    }
    #endregion
}
