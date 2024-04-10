using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Info Table/Charactor Info Table", fileName = "Charactor Info Table")]
public class CharactorInfoTable : ScriptableObject {
    [field: SerializeField]
    public List<CharactorInfo> Table { get; set; }
}