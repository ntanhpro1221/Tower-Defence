using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Observer : CoreComponent, IObserveable<BaseActor> {
    #region STUFF
    [SerializeField] private List<string> listTargetTag;
    private CircleCollider2D col;
    private List<BaseActor> listTarget = new();
    private BaseActor _curTarget;

    public virtual void Init(
        float range, 
        List<string> listTargetTag) {
        col = GetComponent<CircleCollider2D>();
        col.radius = range;
        this.listTargetTag = listTargetTag;
    }
    
    protected virtual void UpdateTarget() {
        listTarget.RemoveAll(target => target.Is_Dead == true);
        _curTarget = listTarget.FirstOrDefault();
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision) {
        if (listTargetTag.Contains(collision.tag)) {
            var target = collision.GetComponent<BaseActor>();
            if (target.Is_Dead == false) {
                listTarget.Add(target);
            }
        }
    }
    protected virtual void OnTriggerExit2D(Collider2D collision) {
        if (listTargetTag.Contains(collision.tag)) {
            var target = collision.GetComponent<BaseActor>();
            listTarget.Remove(target);
            if (target == _curTarget) {
                UpdateTarget();
            }
        }
    }
    #endregion

    #region MAIN METHOD
    public virtual BaseActor CurTarget {
        get {
            if ((_curTarget == null && listTarget.Count != 0) ||
                (_curTarget != null && _curTarget.Is_Dead == true)) {
                UpdateTarget();
            }

            return _curTarget;
        }
    }
    public void ChangeRange(float newRange) {
        col.radius = newRange;
    }
    #endregion
}
