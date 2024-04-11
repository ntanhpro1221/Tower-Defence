using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Charactor Data", fileName = "Charactor Data Table")]
public class CharactorDataTable : ScriptableObject {
    [field: SerializeField]
    public List<CharactorData> Table { get; set; }
}