using UnityEngine;
/// <summary>
/// Base of rune
/// </summary>
public abstract class RuneBase : MonoBehaviour {
    /// <summary>
    /// Mutable data of this rune
    /// </summary>
    [field: SerializeField]
    public RuneData Data { get; set; }
    /// <summary>
    /// Equip this rune for hero
    /// </summary>
    public abstract void Equip();
    /// <summary>
    /// Unequip this rune from hero
    /// </summary>
    public abstract void Unequip();
}
