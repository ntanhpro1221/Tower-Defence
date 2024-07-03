using UnityEngine;

public interface INavigateable {
    void Follow(Transform target);
    void TurnTo(Vector3 pos);
    void Stop();
}
