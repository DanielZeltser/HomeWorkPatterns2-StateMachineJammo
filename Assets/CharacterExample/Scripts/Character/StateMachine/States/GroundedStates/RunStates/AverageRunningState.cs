
public class AverageRunningState : RunState
{
    public AverageRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = Config.AverageRunSpeed;
    }
}
