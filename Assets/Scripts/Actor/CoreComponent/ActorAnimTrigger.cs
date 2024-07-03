using System.Collections.Generic;
using UnityEngine.Events;

public class ActorAnimTrigger : CoreComponent {
    private Dictionary<ActorAnimTriggerType, UnityEvent> trigger = new();
    private UnityEvent GetTrigger(ActorAnimTriggerType type) {
        if (!trigger.ContainsKey(type)) {
            trigger.Add(type, new());
        }
        return trigger[type];
    }
    public void RegisterTrigger(ActorAnimTriggerType type, UnityAction callback) {
        GetTrigger(type).AddListener(callback);
    }
    public void RemoveTrigger(ActorAnimTriggerType type, UnityAction callback) {
        GetTrigger(type).RemoveListener(callback);
    }
    public void InvokeTrigger(ActorAnimTriggerType type) {
        GetTrigger(type).Invoke();
    }
}
