using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroSkin {
    [field: SerializeField]
    public string Name { get; set; }
    [field: SerializeField]
    public string Id {  get; set; }
    [field: SerializeField]
    public List<Cost> Cost { get; set; }
    [field: SerializeField]
    public CharactorStats<List<Buff>> Buff { get; set; }
}