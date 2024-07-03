using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Hero Info", fileName = "Hero Info Table")]
public class HeroInfoTable : ScriptableObject {
    [field: SerializeField]
    public List<HeroInfo> Table {  get; set; }
} 