using UnityEngine;

public interface IFollowable {
    Transform Target { get; }
    void Follow(Transform target);
    void Stop();
}
