using UnityEngine;

public class HealthHandler : CoreComponent, IHealthHandleable {
    #region STUFF
    private ActorStats<Observable<float>> stats;

    [SerializeField] private Transform healthTrf;
    private float maxWidth;
    private float _curHP;

    protected virtual void Awake() {
        stats = GetCoreComponent<StatsHandler>().Stats;

        maxWidth = healthTrf.localScale.x;
        CurHP = stats.HP.Value;
    }
    #endregion

    #region MAIN METHOD
    public float CurHP {
        get => _curHP;
        private set {
            _curHP = Mathf.Min(stats.HP.Value, Mathf.Max(0, value));
            healthTrf.localScale = new Vector3(
                _curHP / stats.HP.Value * maxWidth,
                healthTrf.localScale.y,
                healthTrf.localScale.z);
        }
    }
    public bool IsDead => CurHP == 0;

    public virtual void Damage(float amount) {
        CurHP -= amount;
    }
    public virtual void Health(float amount) {
        CurHP += amount;
    }
    public virtual void FillHealth() {
        CurHP = stats.HP.Value;
    }
    #endregion
}
