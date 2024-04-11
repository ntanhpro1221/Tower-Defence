using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Base of charactor
/// </summary>
public abstract class CharactorBase : MonoBehaviour {
    /// <summary>
    /// Stats bonus of charactor (from rune, upgrade, effect...)
    /// </summary>
    public CharactorStats<Vector2> StatsBonus { get; set; }
    /// <summary>
    /// Final stats of this charactor.
    /// It is calculated from Info and StatsBonus
    /// </summary>
    public CharactorStats<float> Stats { get; set; }
    /// <summary>
    /// Current health point of charactor
    /// </summary>
    public float CurHp { get; set; }

    public abstract void DoSkill_0(List<float> param);
    public abstract void DoSkill_1(List<float> param);
    public abstract void DoSkill_2(List<float> param);
    public abstract void DoSkill_3(List<float> param);
}