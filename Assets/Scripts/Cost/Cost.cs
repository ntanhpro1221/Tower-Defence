using System;
using UnityEngine;

[Serializable]
public class Cost {
    [field: SerializeField]
    public float Value { get; set; }
    [field: SerializeField]
    public ECostType Type { get; set; }
}