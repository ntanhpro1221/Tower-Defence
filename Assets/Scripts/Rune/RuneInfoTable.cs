using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Rune Info", fileName = "Rune Info Table")]
public class RuneInfoTable : ScriptableObject {
    [field: SerializeField]
    public List<RuneInfo> Table { get; set; }
}
