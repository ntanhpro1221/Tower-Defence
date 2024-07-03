public interface IMoveAutomateable {
    bool IsReady { get; }
    void Enter();
    void Exit();
}
