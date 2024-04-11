using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// The mutable data of charactor
/// </summary>
[Serializable]
public class CharactorData {
    /// <summary>
    /// Not nessesary but make easier to create data table
    /// </summary>
    [field: SerializeField]
    public string Name { get; set; }
    /// <summary>
    /// Identification of charactor
    /// </summary>
    [field: SerializeField]
    public string Id { get; set; }
    /// <summary>
    /// Current level of charactor
    /// </summary>
    [field: SerializeField]
    public int Level { get; set; }
    /// <summary>
    /// Current experience of charactor
    /// </summary>
    [field: SerializeField]
    public int Xp { get; set; }
    /// <summary>
    /// Whether the user already owns this charactor
    /// </summary>
    [field: SerializeField]
    public int IsUnlocked { get; set; }
    /// <summary>
    /// Skill point
    /// </summary>
    [field: SerializeField]
    public int SkillPoint { get; set; }
    /// <summary>
    /// Level of skill
    /// </summary>
    [field: SerializeField]
    public List<int> SkillLevel { get; set; }
}