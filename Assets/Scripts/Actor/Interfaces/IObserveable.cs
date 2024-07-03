public interface IObserveable<T> {
    T CurTarget { get; }
    void ChangeRange(float newRange);
}
