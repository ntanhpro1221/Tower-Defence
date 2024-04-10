using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Infomation about skill of charactor
/// </summary>
public class CharactorSkill {
    /// <summary>
    /// Cooldown time after use
    /// </summary>
    public Vector2 CDTime { get; set; }
    /// <summary>
    /// Parameters of skill
    /// </summary>
    public List<Vector2> SkillParams { get; set; }
    /// <summary>
    /// Description of skill
    /// </summary>
    public string Description { get; set; }
}