using System.Collections.Generic;
using UnityEngine;

public abstract class ProacitveSkill : MonoBehaviour {
    protected float cooldown;
    protected float curCD;
    protected List<float> param = new();
    protected BaseActor actor;
    public bool IsReady => curCD == 0;
    public virtual void Init(int level, ActorSkillInfo info, BaseActor actor) {
        cooldown = info.CDTime.x * level + info.CDTime.y;
        foreach (var item in info.SkillParams) {
            param.Add(item.x * level + item.y);
        }
        this.actor = actor;
    }
    protected virtual void Update() {
        curCD = Mathf.Max(0, curCD - Time.deltaTime);
    }
}