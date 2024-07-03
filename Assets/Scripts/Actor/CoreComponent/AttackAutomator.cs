using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Observer))]
[RequireComponent(typeof(Attacker))]
public class AttackAutomator : CoreComponent, IAttackAutomateable {
    #region STUFF
    private Observer observer;
    private Attacker attacker;
    private bool isWorking = false;

    protected virtual void Awake() {
        observer = GetComponent<Observer>();
        attacker = GetComponent<Attacker>();

        observer.Init(
            GetCoreComponent<StatsHandler>().Stats.Range.Value, 
            GetComponentInParent<BaseActor>().listTargetTag);
        //attacker.Init();

        GetCoreComponent<StatsHandler>().Stats.
            Range.OnChanged.AddListener(OnRangeChange);
    }

    private void OnRangeChange(float newRange) {
        observer.ChangeRange(newRange);
    }
    protected virtual void FixedUpdate() {
        if (isWorking) {
            if (attacker.IsFinish == true && observer.CurTarget != null) {
                attacker.Attack(observer.CurTarget.healthHandler, observer.CurTarget.transform.position);
            }
        }
    }
    #endregion

    #region MAIN METHOD
    public bool IsReady => observer.CurTarget != null;
    public virtual void Enter() {
        isWorking = true;
        attacker.Attack(observer.CurTarget.healthHandler, observer.CurTarget.transform.position);
    }
    public virtual void Exit() {
        isWorking = false;
        attacker.Stop();
    }
    #endregion
}
