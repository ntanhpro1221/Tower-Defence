﻿using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Base of charactor
/// </summary>
public class CharactorBase {
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
    /// <summary>
    /// Skill action list of charactor
    /// </summary>
    public List<Action<List<float>>> Skill { get; set; }
}