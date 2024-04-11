using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Read-only infomation of rune
/// </summary>
[Serializable]
public class RuneInfo {
    /// <summary>
    /// Name of rune
    /// </summary>
    [field: SerializeField]
    public string Name { get; set; }
    /// <summary>
    /// Identification of rune
    /// </summary>
    [field: SerializeField]
    public string Id { get; set; }
    /// <summary>
    /// Description of rune
    /// </summary>
    [field: SerializeField]
    [field: TextArea(1, 4)]
    public string Description { get; set; }
    /// <summary>
    /// Stats translation of rune
    /// </summary>
    [field: SerializeField]
    public List<Vector3> StatsTrans { get; set; }
}


