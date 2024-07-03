using UnityEngine;

public class Navigator : CoreComponent, INavigateable {
    #region STUFF
    private bool isFacingRight;

    private Transform target;

    protected virtual void Awake() {
        isFacingRight = GetComponentInParent<BaseActor>().initDirectionIsRight;
    }

    protected virtual void Update() {
        if (target != null) TurnTo(target.position);
    }
    #endregion

    #region MAIN METHOD
    public virtual void Follow(Transform target) {
        this.target = target;
    }
    public virtual void TurnTo(Vector3 pos) {
        if (transform.position.x != pos.x &&
            isFacingRight != transform.position.x < pos.x) {
            transform.Rotate(0, 180, 0);
            isFacingRight = !isFacingRight;
        }
    }
    public virtual void Stop() {
        target = null;
    }
    #endregion
}
