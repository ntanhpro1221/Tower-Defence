using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Base of hero
/// </summary>
public abstract class HeroBase : CharactorBase {
    /// <summary>
    /// Multable data of this hero
    /// </summary>
    [field: SerializeField]
    public HeroData Data { get; set; }
}