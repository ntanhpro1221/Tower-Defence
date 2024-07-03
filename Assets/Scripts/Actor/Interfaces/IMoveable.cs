using UnityEngine;

public interface IMoveable {
    bool IsFinish { get; }
    void Move(Vector3 target);
    void Stop();
}
