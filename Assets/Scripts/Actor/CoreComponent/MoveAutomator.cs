using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Observer))]
[RequireComponent(typeof(Follower))]
public class MoveAutomator : CoreComponent, IMoveAutomateable {
    #region STUFF
    private Observer observer;
    private Follower follower;
    private bool isWorking = false;

    protected virtual void Awake() {
        observer = GetComponent<Observer>();
        follower = GetComponent<Follower>();

        observer.Init(
            GetComponentInParent<BaseActor>().followRange,
            GetComponentInParent<BaseActor>().listTargetTag);
        //follower.Init();
    }

    protected virtual void FixedUpdate() {
        if (isWorking) {
            if (observer.CurTarget.transform != null &&
                observer.CurTarget.transform != follower.Target) {
                follower.Follow(observer.CurTarget.transform);
            }
        }
    }
    #endregion

    #region MAIN METHOD
    public bool IsReady =>
        observer.CurTarget != null &&
        (Vector2)observer.CurTarget.transform.position != (Vector2)transform.position;
    public virtual void ChangeRange(float newRange) {
        observer.ChangeRange(newRange);
    }
    public virtual void Enter() {
        isWorking = true;
        follower.Follow(observer.CurTarget.transform);
    }
    public virtual void Exit() {
        isWorking = false;
        follower.Stop();
    }
    #endregion

}
