public interface IMoveControlable {
    bool IsReady { get; }
    void Enter();
    void Exit();
    void ToggleControl();
    void ActiveControl();
    void DisableControl();
}
