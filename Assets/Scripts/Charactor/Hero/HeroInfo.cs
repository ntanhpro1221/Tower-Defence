using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroInfo : CharactorInfo {
    [field: SerializeField]
    public List<HeroSkin> Skin { get; set; }
}