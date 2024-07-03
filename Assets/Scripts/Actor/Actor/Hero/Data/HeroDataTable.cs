using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Hero Data", fileName = "Hero Data Table")]
public class HeroDataTable : ScriptableObject {
    [field: SerializeField]
    public List<HeroData> Table { get; set; }
}