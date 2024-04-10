using UnityEngine;
using System.Collections.Generic;
/// <summary>
/// The read-only infomation of charactor
/// </summary>
public class CharactorInfo {
    /// <summary>
    /// Identification of charactor
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Name of charactor
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Description about charactor (biography,...)
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Cost of charactor
    /// </summary>
    public int Cost { get; set; }
    /// <summary>
    /// Stats translation of charactor
    /// </summary>
    public CharactorStats<Vector2> StatsTrans { get; set; }
    /// <summary>
    /// List skill of charactor
    /// </summary>
    public List<CharactorSkill> Skill { get; set; }
}