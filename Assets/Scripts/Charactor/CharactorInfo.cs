﻿using UnityEngine;
using System.Collections.Generic;
using System;
/// <summary>
/// The read-only infomation of charactor
/// </summary>
[Serializable]
public class CharactorInfo {
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
    public List<Cost> Cost { get; set; }
    /// <summary>
    /// Stats translation of charactor
    /// </summary>
    [field: SerializeField]
    public CharactorStats<Vector2> StatsTrans { get; set; }
    /// <summary>
    /// List skill of charactor
    /// </summary>
    [field: SerializeField]
    public List<CharactorSkill> Skill { get; set; }
}