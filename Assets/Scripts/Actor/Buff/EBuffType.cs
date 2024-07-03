/// <summary>
/// Write each type by its priority
/// </summary>
public enum EBuffType {
    /// <summary>
    /// ax + b += Add
    /// </summary>
    Add,
    /// <summary>
    /// ax + b + Add *= Mul
    /// </summary>
    Mul,
    /// <summary>
    /// (ax + b + Add) * Mul *= GlobalMul
    /// </summary>
    GlobalMul,
}