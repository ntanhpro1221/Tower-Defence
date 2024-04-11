using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {
    public static DataManager Instance { get; }

    [field: SerializeField]
    private CharactorInfoTable heroInfoTable { get; set; }
    [field: SerializeField]
    private CharactorDataTable heroDataTable { get; set; }
    public Dictionary<string, CharactorInfo> heroInfo { get; private set; }
    public List<CharactorData> heroData { get; private set; }

    [field: SerializeField]
    private RuneInfoTable runeInfoTable { get; set; }
    [field: SerializeField]
    private RuneDataTable runeDataTable { get; set; }
    public Dictionary<string, RuneInfo> runeInfo { get; private set; }
    public List<RuneData> runeData { get; private set; }
    private void LoadAllData() {
        heroData = heroDataTable.Table;
        foreach (CharactorInfo info in heroInfoTable.Table)
            heroInfo[info.Id] = info;
        runeData = runeDataTable.Table;
        foreach (RuneInfo info in runeInfoTable.Table)
            runeInfo[info.Id] = info;
    }
}