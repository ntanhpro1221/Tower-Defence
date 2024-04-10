/// <summary>
/// The list of charactor's stats
/// </summary>
public class CharactorStats<T> {
    /// <summary>
    /// health point
    /// </summary>
    public T Hp { get; set; }
    /// <summary>
    /// Healing point when not in combat
    /// </summary>
    public T HpRegen { get; set; }
    /// <summary>
    /// Physical Damage resistance point
    /// </summary>
    public T Armor { get; set; }
    /// <summary>
    /// Magical damage resistance point
    /// </summary>
    public T MagicRes { get; set; }
    /// <summary>
    /// Attack point
    /// </summary>
    public T Atk { get; set; }
    /// <summary>
    /// Attack speed
    /// </summary>
    public T AtkSpeed { get; set; }
    /// <summary>
    /// Physical damage resistance penetration point
    /// </summary>
    public T ArmorPen { get; set; }
    /// <summary>
    /// Magical damage resistance penetration point
    /// </summary>
    public T MagicPen { get; set; }
    /// <summary>
    /// Rate of dealing a critical hit
    /// </summary>
    public T CritRate { get; set; }
    /// <summary>
    /// Percentage of bonus damage for critical hits
    /// </summary>
    public T CritDamage { get; set; }
    /// <summary>
    /// Percentage of lifesteal when dealing damage
    /// </summary>
    public T LifeSteal { get; set; }
    /// <summary>
    /// Attack range
    /// </summary>
    public T Range { get; set; }
    /// <summary>
    /// Movement speed
    /// </summary>
    public T MoveSpeed { get; set; }
    /// <summary>
    /// Time to respawn after death
    /// </summary>
    public T RespawnTime { get; set; }
    /// <summary>
    /// Percentage reduction of skill cooldown time
    /// </summary>
    public T SkillCDR { get; set; }
    /// <summary>
    /// Number of xp required for level up
    /// </summary>
    public T XpRequired { get; set; }
}