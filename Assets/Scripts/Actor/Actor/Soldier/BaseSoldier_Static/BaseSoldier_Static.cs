public class BaseSoldier_Static : BaseActor {
    protected override void Reset() {
        base.Reset();
        canBeControlled = false;
        canAutoMove = false;
        canDie = false;

        listTargetTag = new() { "Monster" };
    }
}

