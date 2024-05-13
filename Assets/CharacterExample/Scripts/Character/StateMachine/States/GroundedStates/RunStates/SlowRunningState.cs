
public class SlowRunningState : RunState
{
    public SlowRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = Config.SlowRunSpeed;
    }
}
