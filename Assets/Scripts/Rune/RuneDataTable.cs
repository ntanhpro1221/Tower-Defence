using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Rune Data", fileName = "Rune Data Table")]
public class RuneDataTable : ScriptableObject {
    [field: SerializeField]
    public List<RuneData> Table { get; set; }
}