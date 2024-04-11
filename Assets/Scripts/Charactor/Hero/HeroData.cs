using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Mutable data of hero
/// </summary>
[Serializable]
public class HeroData : CharactorData {
    /// <summary>
    /// List of runes owned by this hero
    /// </summary>
    [field: SerializeField]
    public List<RuneData> Rune { get; set; }
}
