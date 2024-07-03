using UnityEngine;

[RequireComponent(typeof(Mover))]
public class MoveController : CoreComponent, IMoveControlable {
    #region STUFF
    private bool isActive = true;
    private Mover mover;
    [SerializeField] private bool isWorking = false;
    private bool IsHaveRequest =>
        isActive &&
        Input.GetMouseButtonDown(0);

    protected virtual void Awake() {
        mover = GetComponent<Mover>();

        //mover.Init();
    }
    
    protected virtual void Update() {
        if (isWorking) {
            if (IsHaveRequest) {
                mover.Move(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            }
        }
    }
    #endregion

    #region MAIN METHOD
    public bool IsReady =>
        IsHaveRequest ||
        mover.IsFinish == false;
    public virtual void Enter() {
        isWorking = true;
        mover.Move(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
    public virtual void Exit() {
        isWorking = false;
        mover.Stop();
    }
    public virtual void ToggleControl() {
        isActive = !isActive;
    }
    public virtual void ActiveControl() {
        isActive = true;
    }
    public virtual void DisableControl() {
        isActive = false;
    }
    #endregion
}
