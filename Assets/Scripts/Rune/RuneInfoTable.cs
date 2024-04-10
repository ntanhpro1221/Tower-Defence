using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Info Table/Rune Info Table", fileName = "Rune Info Table")]
public class RuneInfoTable : ScriptableObject {
    [field: SerializeField]
    public List<RuneInfo> Table { get; set; }
}
