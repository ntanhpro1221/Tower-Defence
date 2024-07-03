using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {
    #region SINGLETON
    private static DataManager instance;
    public static DataManager Instance {
        get {
            if (instance == null) {
                instance = FindObjectOfType<DataManager>();
            }
            if (instance == null) {
                instance = new GameObject("(Singleton) " + typeof(DataManager).Name).AddComponent<DataManager>();
            }
            if (instance.isInitializedData == false) instance.InitializeData();
            return instance;
        }
    }
    protected virtual void Awake() {
        if (instance != null && instance.GetInstanceID() != GetInstanceID()) {
            Destroy(gameObject);
        }
        if (isInitializedData ==  false) InitializeData();
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    private bool isInitializedData = false;
    [SerializeField] private HeroInfoTable heroInfoTable;
    public Dictionary<string, HeroInfo> HeroInfo { get; } = new();
    [SerializeField] private HeroDataTable heroDataTable;
    public Dictionary<string, HeroData> HeroData { get; } = new();

    //[field: SerializeField]
    //private RuneInfoTable runeInfoTable { get; set; }
    //[field: SerializeField]
    //private RuneDataTable runeDataTable { get; set; }
    //public Dictionary<string, RuneInfo> runeInfo { get; private set; }
    //public List<RuneData> runeData { get; private set; }

    protected virtual void InitializeData() {
        isInitializedData = true;
        foreach (HeroInfo info in heroInfoTable.Table) {
            HeroInfo.Add(info.Id, info);
        }
        foreach (HeroData data in heroDataTable.Table) {
            HeroData.Add(data.Id, data);
        }
        //runeData = runeDataTable.Table;
        //foreach (RuneInfo info in runeInfoTable.Table)
        //    runeInfo[info.Id] = info;
    }
}