using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour {
    private static T instance;
    public static T Instance {
        get {
            if (instance == null) {
                instance = FindObjectOfType<T>();
            }
            if (instance == null) {
                instance = new GameObject("(Singleton) " + typeof(T).Name).AddComponent<T>();
            }
            return instance;
        }
    }
    protected virtual void Awake() {
        if (instance != null && instance.GetInstanceID() != GetInstanceID()) {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
