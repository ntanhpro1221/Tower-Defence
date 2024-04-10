/// <summary>
/// The mutable data of charactor
/// </summary>
public class CharactorData {
    /// <summary>
    /// Current level of charactor
    /// </summary>
    public int Level { get; set; }
    /// <summary>
    /// Current experience of charactor
    /// </summary>
    public int Xp { get; set; }
    /// <summary>
    /// Whether the user already owns this charactor
    /// </summary>
    public int IsUnlocked { get; set; }
    /// <summary>
    /// Skill point
    /// </summary>
    public int SkillPoint { get; set; }
}