using UnityEngine.Events;
/// <summary>
/// Invoke your action when its value is changed
/// </summary>
public class Observable<T> where T : struct {
    private T m_value = default;
    public UnityEvent<T> OnChanged { get; } = new();
    public T Value {
        get => m_value;
        set => OnChanged.Invoke(m_value = value);
    }
}
