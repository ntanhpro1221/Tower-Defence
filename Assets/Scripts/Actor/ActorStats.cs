using System;
using System.Reflection;
using UnityEngine;
/// <summary>
/// The list of charactor's stats
/// </summary>
[Serializable]
public class ActorStats<T> where T : new() {
    public ActorStats() {
        if (typeof(T).IsValueType == false) {
            foreach (PropertyInfo prop in typeof(ActorStats<T>).GetProperties()) {
                prop.SetValue(this, new T());
            }
        }
    }
    /// <summary>
    /// health point
    /// </summary>
    [field: SerializeField]
    public T HP { get; set; }
    /// <summary>
    /// Healing point when not in combat
    /// </summary>
    [field: SerializeField]
    public T HpRegen { get; set; }
    /// <summary>
    /// Physical Damage resistance point
    /// </summary>
    [field: SerializeField]
    public T Armor { get; set; }
    /// <summary>
    /// Magical damage resistance point
    /// </summary>
    [field: SerializeField]
    public T MagicRes { get; set; }
    /// <summary>
    /// Attack point
    /// </summary>
    [field: SerializeField]
    public T Atk { get; set; }
    /// <summary>
    /// Attack speed
    /// </summary>
    [field: SerializeField]
    public T AtkSpeed { get; set; }
    /// <summary>
    /// Physical damage resistance penetration point
    /// </summary>
    [field: SerializeField]
    public T ArmorPen { get; set; }
    /// <summary>
    /// Magical damage resistance penetration point
    /// </summary>
    [field: SerializeField]
    public T MagicPen { get; set; }
    /// <summary>
    /// Rate of dealing a critical hit
    /// </summary>
    [field: SerializeField]
    public T CritRate { get; set; }
    /// <summary>
    /// Percentage of bonus damage for critical hits
    /// </summary>
    [field: SerializeField]
    public T CritDamage { get; set; }
    /// <summary>
    /// Percentage of lifesteal when dealing damage
    /// </summary>
    [field: SerializeField]
    public T LifeSteal { get; set; }
    /// <summary>
    /// Attack range
    /// </summary>
    [field: SerializeField]
    public T Range { get; set; }
    /// <summary>
    /// Movement speed
    /// </summary>
    [field: SerializeField]
    public T MoveSpeed { get; set; }
    /// <summary>
    /// Time to respawn after death
    /// </summary>
    [field: SerializeField]
    public T RespawnTime { get; set; }
    /// <summary>
    /// Percentage reduction of skill cooldown time
    /// </summary>
    [field: SerializeField]
    public T SkillCDR { get; set; }
    /// <summary>
    /// Number of xp required for level up
    /// </summary>
    [field: SerializeField]
    public T XpRequired { get; set; }
}

public static class ActorStatsExtensions {
    public static T GetProp<T>(this ActorStats<T> obj, string name) where T : new()
        => (T)typeof(ActorStats<T>).GetProperty(name).GetValue(obj);
    public static PropertyInfo[] GetAllProp<T>(this ActorStats<T> obj) where T : new()
        => typeof(ActorStats<T>).GetProperties();
    public static void SetProp<T>(this ActorStats<T> obj, string name, T val) where T : new()
        => typeof(ActorStats<T>).GetProperty(name).SetValue(obj, val);
}