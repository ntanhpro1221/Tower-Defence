using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Charactor Info", fileName = "Charactor Info Table")]
public class CharactorInfoTable : ScriptableObject {
    [field: SerializeField]
    public List<CharactorInfo> Table { get; set; }
}