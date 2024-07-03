public class BaseSoldier_Dynamic : BaseActor {
    protected override void Reset() {
        base.Reset();
        canBeControlled = true;
        canAutoMove = true;
        canDie = true;

        listTargetTag = new() { "Monster" };
    }
}

