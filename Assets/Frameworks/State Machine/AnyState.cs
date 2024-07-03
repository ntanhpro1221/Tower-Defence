using System;

[Obsolete("This class is only meant as a guide. If you have your own BaseState class, " +
    "your AnyState class must inherit from it, not this class")]
public abstract class AnyState : BaseState {
    public AnyState(StateMachine sm) : base(string.Empty, string.Empty, sm) { }
}