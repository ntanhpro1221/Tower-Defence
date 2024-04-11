using System;
using UnityEngine;
/// <summary>
/// The mutable data of rune
/// </summary>
[Serializable]
public class RuneData {
    /// <summary>
    /// Not nessesary but make easier to create data table
    /// </summary>
    [field: SerializeField]
    public string Name { get; set; }
    /// <summary>
    /// Identification of rune
    /// </summary>
    [field: SerializeField]
    public string Id {  get; set; }
    /// <summary>
    /// Current level of rune
    /// </summary>
    [field: SerializeField]
    public int Level { get; set; }
    /// <summary>
    /// Current rank of rune
    /// </summary>
    [field: SerializeField]
    public int Rank { get; set; }
    /// <summary>
    /// The identity of the hero who owns this rune
    /// </summary>
    [field: SerializeField]
    public string OwnerId { get; set; }
}