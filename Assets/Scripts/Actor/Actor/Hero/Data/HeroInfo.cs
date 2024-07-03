using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroInfo {
    /// <summary>
    /// Name of charactor
    /// </summary>
    [field: SerializeField]
    public string Name { get; set; }
    /// <summary>
    /// Identification of charactor
    /// </summary>
    [field: SerializeField]
    public string Id { get; set; }
    /// <summary>
    /// Description about charactor (biography,...)
    /// </summary>
    [field: SerializeField]
    [field: TextArea(1, 4)]
    public string Description { get; set; }
    /// <summary>
    /// Cost of charactor
    /// </summary>
    [field: SerializeField]
    public List<Cost> ListCost { get; set; }
    /// <summary>
    /// Stats translation of charactor when char level up
    /// </summary>
    [field: SerializeField]
    public ActorStats<Vector2> StatsTrans { get; set; }
    /// <summary>
    /// List skill of charactor
    /// </summary>
    [field: SerializeField]
    public List<ActorSkillInfo> ListSkill { get; set; }
    /// <summary>
    /// List skin of charactor
    /// </summary>
    [field: SerializeField]
    public List<HeroSkin> Skin { get; set; }
}