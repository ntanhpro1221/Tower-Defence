public interface IAttackAutomateable {
    bool IsReady { get; }
    void Enter();
    void Exit();
}
