public class BaseMonster : BaseActor {
    protected override void Reset() {
        base.Reset();
        canBeControlled = false;
        canAutoMove = true;
        canDie = true;

        listTargetTag = new() { "Hero", "Soldier_Dynamic", "Soldier_Kinematic" };
    }
}
