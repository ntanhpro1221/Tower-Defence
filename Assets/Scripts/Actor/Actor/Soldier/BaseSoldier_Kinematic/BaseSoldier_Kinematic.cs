public class BaseSoldier_Kinematic : BaseActor {
    protected override void Reset() {
        base.Reset();
        canBeControlled = true;
        canAutoMove = false;
        canDie = true;

        listTargetTag = new() { "Monster" };
    }
}

