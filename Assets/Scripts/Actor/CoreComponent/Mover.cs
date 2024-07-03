using UnityEngine;

public class Mover : CoreComponent, IMoveable {
    #region STUFF
    private string animName;
    private string animPlaySpeed;
    private float strideLength;
    private Animator animator;
    private ActorStats<Observable<float>> stats;
    private INavigateable navigator;
    private Transform root;

    private Vector3? target;

    protected virtual void Awake() {
        animName = ActorAnimName.Move;
        animPlaySpeed = ActorAnimName.Move_PlaySpeed;
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
        animator.SetFloat(animPlaySpeed, moveSpeed / (2 * strideLength));
    }
    protected virtual void FixedUpdate() {
        if (target != null) {
            if (Vector2.Distance(root.position, (Vector2)target) <= stats.MoveSpeed.Value * Time.fixedDeltaTime) {
                root.position.Set(target.Value.x, target.Value.y, root.position.z);
                Stop();
            } else {
                root.Translate(stats.MoveSpeed.Value * Time.fixedDeltaTime *
                    ((Vector2)(target - root.position)).normalized,
                    Space.World);
            }
        }
    }
    #endregion

    #region MAIN METHOD
    public bool IsFinish => target == null;
    public virtual void Move(Vector3 target) {
        this.target = target;
        MatchWithMoveSpeed(stats.MoveSpeed.Value);
        animator.Play(animName);
        navigator.TurnTo(target);
    }
    public virtual void Stop() {
        target = null;
        navigator.Stop();
    }
    #endregion
}
