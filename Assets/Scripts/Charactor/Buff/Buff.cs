using System;
using UnityEngine;

[Serializable]
public class Buff {
    [field: SerializeField]
    public EBuffType Type { get; set; }
    [field: SerializeField]
    public float Value { get; set; }
}
