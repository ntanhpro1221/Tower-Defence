using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using System;
using System.Linq;

public class StatsHandler : CoreComponent {
    private bool isLoadedStats = false;

    private ActorStats<Observable<float>> stats = new();
    public ActorStats<Observable<float>> Stats { 
        get {
            if (!isLoadedStats) LoadAllStats();
            return stats;
        }
    }
    /// <summary>
    /// original stats with 0 buff
    /// </summary>
    private ActorStats<float> pureStats = new();
    /// <summary>
    /// To remove expired buff in O(logn)
    /// </summary>
    private SortedDictionary<float, List<Buff>> listBuff = new();
    /// <summary>
    /// To recalc stats in O(1)
    /// </summary>
    private ActorStats<Dictionary<EBuffType, float>> buffVal = new();

    protected virtual void Awake() {
        if (!isLoadedStats) LoadAllStats();
    }

    private void LoadAllStats() {
        isLoadedStats = true;
        string id = GetComponentInParent<BaseActor>().id;
        HeroData data = DataManager.Instance.HeroData[id];
        HeroInfo info = DataManager.Instance.HeroInfo[id];

        //init stats & pureStats
        foreach (PropertyInfo prop in pureStats.GetAllProp()) {
            Vector2 f = info.StatsTrans.GetProp(prop.Name);
            //fomula val = a * level + b
            float val = f.x * data.Level + f.y;
            prop.SetValue(pureStats, val);
            stats.GetProp(prop.Name).Value = val;
        }

        //init buffval
        foreach (var item in buffVal.GetAllProp()) {
            foreach (EBuffType e in Enum.GetValues(typeof(EBuffType))) {
                ((Dictionary<EBuffType, float>)item.GetValue(buffVal)).Add(e, 0);
            }
        }
    }

    public void AddBuff(Buff buff) {
        //add buff to listBuff
        if (!listBuff.ContainsKey(buff.EndTime)) {
            listBuff.Add(buff.EndTime, new());
        }
        listBuff[buff.EndTime].Add(buff);

        //add buff to buffVal
        var sum = buffVal.GetProp(buff.PropName);
        sum[buff.Type] += buff.Value;

        //recalc stats
        float val = pureStats.GetProp(buff.PropName);
        foreach (EBuffType e in Enum.GetValues(typeof(EBuffType))) {
            Buff.Calc(ref val, e, sum[e]);
        }
        Stats.GetProp(buff.PropName).Value = val;
    }

    private void Update() {
        MaintainBuff();
    }

    /// <summary>
    /// Remove expired buff
    /// </summary>
    private void MaintainBuff() {
        KeyValuePair<float, List<Buff>> pair; //optimize

        //remove all expired item's buff
        while (listBuff.Count != 0 && (pair = listBuff.First()).Key <= Time.time) {
            foreach (Buff buff in pair.Value) {
                //remove buff from buffVal
                var sum = buffVal.GetProp(buff.PropName);
                sum[buff.Type] -= buff.Value;

                //recalc stats
                float val = pureStats.GetProp(buff.PropName);
                foreach (EBuffType e in Enum.GetValues(typeof(EBuffType))) {
                    Buff.Calc(ref val, e, sum[e]);
                }
                Stats.GetProp(buff.PropName).Value = val;
            }
            //remove from listBuff
            listBuff.Remove(pair.Key);
        }

    }
}
