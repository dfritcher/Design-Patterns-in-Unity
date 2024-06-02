using System;
using UnityEngine;

public class StateMachine 
{
    public IState CurrentState { get; private set; }

    public HappyState HappyState;
    public AngryState AngryState;
    public ScaredState ScaredState;
    public NormalState NormalState;
    public RelaxedState RelaxedState;
    public VictoryIdleState VictoryIdleState;
    public FistPumpState FistPumpState;

    public event Action<IState> StateChanged;

    public StateMachine(CharacterController characterController)
    {
        HappyState = new HappyState(characterController);
        AngryState = new AngryState(characterController);
        ScaredState = new ScaredState(characterController);
        NormalState = new NormalState(characterController);
        RelaxedState = new RelaxedState(characterController);
        VictoryIdleState = new VictoryIdleState(characterController);
        FistPumpState = new FistPumpState(characterController);
    }

    public void Initialize()
    {
        CurrentState = NormalState;
        CurrentState.Enter();

        StateChanged?.Invoke(CurrentState);
    }

    public void Initialize(IState state)
    {
        CurrentState = state;
        CurrentState.Enter();

        StateChanged?.Invoke(CurrentState);
    }

    public void TransitionTo(IState nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;
        CurrentState.Enter();
        StateChanged?.Invoke(CurrentState);
    }

    public void Update()
    {
        CurrentState?.Update();
    }
}