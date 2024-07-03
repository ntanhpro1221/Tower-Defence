using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Infomation about skill of charactor
/// </summary>
[Serializable]
public class ActorSkillInfo {
    /// <summary>
    /// Name of skill
    /// </summary>
    [field: SerializeField]
    public string Name { get; set; }
    /// <summary>
    /// Cooldown time after use
    /// </summary>
    [field: SerializeField]
    public Vector2 CDTime { get; set; }
    /// <summary>
    /// Parameters of skill
    /// </summary>
    [field: SerializeField]
    public List<Vector2> SkillParams { get; set; }
    /// <summary>
    /// Description of skill
    /// </summary>
    [field: SerializeField]
    [field: TextArea(1, 4)]
    public string Description { get; set; }
}