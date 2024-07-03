using UnityEngine;

public interface IAttackable {
    bool IsFinish { get; }
    void Attack(IHealthHandleable target, Vector3 targetPos);
    void Stop();
}
