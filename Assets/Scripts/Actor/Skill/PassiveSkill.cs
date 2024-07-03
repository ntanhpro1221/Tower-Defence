using System.Collections.Generic;
using UnityEngine;

public abstract class PassiveSkill : MonoBehaviour {
    protected List<float> param = new();
    protected BaseActor actor;
    public virtual void Init(int level, ActorSkillInfo info, BaseActor actor) {
        foreach (var item in info.SkillParams) {
            param.Add(item.x * level + item.y);
        }
        this.actor = actor;
    }
    protected virtual void Update() { }
    public virtual void Active() { }
}
