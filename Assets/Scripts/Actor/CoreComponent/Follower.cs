using System.Linq;
using UnityEngine;

public class Follower : CoreComponent, IFollowable {
    #region STUFF
    private string animName;
    private string animPlaySpeed;
    private float strideLength;
    private Animator animator;
    private ActorStats<Observable<float>> stats;
    private INavigateable navigator;
    private Transform root;

    protected virtual void Awake() {
        animName = ActorAnimName.Follow;
        animPlaySpeed = ActorAnimName.Follow_PlaySpeed;
        strideLength = GetComponentInParent<BaseActor>().strideLength;
        animator = GetCoreComponent<BodyHandler>().GetComponent<Animator>();
        stats = GetCoreComponent<StatsHandler>().Stats;
        navigator = GetCoreComponent<Navigator>();
        root = GetComponentInParent<BaseActor>().transform;

        GetCoreComponent<StatsHandler>().Stats.
            MoveSpeed.OnChanged.AddListener(OnChangeMoveSpeed);
    }
    
    private void OnChangeMoveSpeed(float newMoveSpeed) {
        MatchWithMoveSpeed(newMoveSpeed);
    }
    private void MatchWithMoveSpeed(float moveSpeed) {
        animator.SetFloat(animPlaySpeed, moveSpeed / (2f * strideLength));
    }
    protected virtual void FixedUpdate() {
        if (Target != null) {
            if (Vector2.Distance(root.position, Target.position) <= stats.MoveSpeed.Value * Time.fixedDeltaTime) {
                root.position = Target.position;
            } else {
                root.Translate(stats.MoveSpeed.Value * Time.fixedDeltaTime *
                    ((Vector2)(Target.position - root.position)).normalized,
                    Space.World);
            }
        }
    }
    #endregion

    #region MAIN METHOD
    public Transform Target { get; private set; }
    public virtual void Follow(Transform target) {
        Target = target;
        MatchWithMoveSpeed(stats.MoveSpeed.Value);
        animator.Play(animName);
        navigator.Follow(target);
    }
    public virtual void Stop() {
        Target = null;
        navigator.Stop();
    }
    #endregion
}
