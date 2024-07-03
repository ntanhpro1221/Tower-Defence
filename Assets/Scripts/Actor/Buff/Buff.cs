using System;
using UnityEngine;

[Serializable]
public class Buff {
    /// <summary>
    /// How it's value effect to stats
    /// </summary>
    [field: SerializeField]
    public EBuffType Type { get; set; }
    /// <summary>
    /// Value of buff
    /// </summary>
    [field: SerializeField]
    public float Value { get; set; }
    /// <summary>
    /// This effect disappear when Time.time == endTime
    /// </summary>
    [field: SerializeField]
    public float EndTime { get; set; }
    /// <summary>
    /// stat that this buff affect
    /// </summary>
    [field: SerializeField]
    public string PropName { get; set; }

    /// <summary>
    /// how each type of Buff affect ans
    /// </summary>
    public static void Calc(ref float ans, EBuffType type, float val) {
        switch (type) {
            case EBuffType.Add: ans += val; break;
            case EBuffType.Mul: ans *= val; break;
            case EBuffType.GlobalMul: ans *= val; break;
            default: throw new NotImplementedException();
        }
    }
}
