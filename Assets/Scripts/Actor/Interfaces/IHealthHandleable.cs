public interface IHealthHandleable {
    float CurHP { get; }
    bool IsDead { get; }
    void Damage(float amount);
    void Health(float amount);
    void FillHealth();
}
