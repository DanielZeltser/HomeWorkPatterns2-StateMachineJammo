using UnityEngine.InputSystem;

public class RunState : GroundedState
{
    public readonly RunningStateConfig Config;

    public RunState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => Config = character.Config.RunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartRunning();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }

    protected override void AddInputActionsCallbacks()
    {
        base.AddInputActionsCallbacks();

        Input.Movement.SlowRun.started += OnSlowRunKeyPressed;
        Input.Movement.AverageRun.started += OnAverageRunKeyPressed;
        Input.Movement.FastRun.started += OnFastRunKeyPressed;
    }

    protected override void RemoveInputActionsCallbacks()
    {
        base.RemoveInputActionsCallbacks();

        Input.Movement.SlowRun.started -= OnSlowRunKeyPressed;
        Input.Movement.AverageRun.started -= OnAverageRunKeyPressed;
        Input.Movement.FastRun.started -= OnFastRunKeyPressed;
    }

    private void OnSlowRunKeyPressed(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<SlowRunningState>();
    private void OnAverageRunKeyPressed(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<AverageRunningState>();
    private void OnFastRunKeyPressed(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<FastRunningState>();
}
