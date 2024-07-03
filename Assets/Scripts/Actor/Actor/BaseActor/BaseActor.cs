using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;
/// <summary>
/// Base of actor
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public abstract class BaseActor : MonoBehaviour {
    #region CONFIG VARIABLE
    [Header("-----CONFIG-------")]
    public string id = "000";
    public bool canBeControlled = true;
    public bool canAutoMove = true;
    public bool canDie = true;
    public List<string> listTargetTag = new() { 
        "Hero", };
    public float followRange = 3;
    public bool initDirectionIsRight = true;
    public float strideLength = 2.5f;
    #endregion

    #region STATUS VARIABLE
    public virtual bool Is_Dead =>
        canDie &&
        healthHandler.IsDead; 
    public virtual bool Is_Have_Control_Request =>
        canBeControlled &&
        moveController.IsReady;
    public virtual bool Is_Ready_To_Auto_Follow =>
        canAutoMove &&
        moveAutomator.IsReady;
    public virtual bool Is_Ready_To_Auto_Attack =>
        attackAutomator.IsReady;
    #endregion

    #region ACTOR COMPONENT
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public CapsuleCollider2D coll;
    [HideInInspector] public Core core;
    #endregion

    #region CORE COMPONENT
    [HideInInspector] public StatsHandler statsHandler;
    [HideInInspector] public MoveController moveController;
    [HideInInspector] public AttackAutomator attackAutomator;
    [HideInInspector] public MoveAutomator moveAutomator;
    [HideInInspector] public HealthHandler healthHandler;
    [HideInInspector] public Navigator navigator;
    [HideInInspector] public BodyHandler bodyHandler;
    [HideInInspector] public ActorSM sm;

    [HideInInspector] public List<ProacitveSkill> listProactiveSkill = new();
    [HideInInspector] public List<PassiveSkill> listPassiveSkill = new();
    #endregion

    protected virtual void Awake() {
        //Get actor component
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<CapsuleCollider2D>();
        core = GetComponentInChildren<Core>();

        //Get core component
        statsHandler = core.GetCoreComponent<StatsHandler>();
        moveController = core.GetCoreComponent<MoveController>();
        attackAutomator = core.GetCoreComponent<AttackAutomator>();
        moveAutomator = core.GetCoreComponent<MoveAutomator>();
        healthHandler = core.GetCoreComponent<HealthHandler>();
        navigator = core.GetCoreComponent<Navigator>();
        bodyHandler = core.GetCoreComponent<BodyHandler>();
        sm = GetComponentInChildren<ActorSM>();
    }

    protected virtual void Reset() { }
}