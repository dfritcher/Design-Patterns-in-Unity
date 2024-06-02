using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    private StateMachine _stateMachine;
    private void Awake()
    {
        _stateMachine = new StateMachine(_characterController);
        _stateMachine.Initialize(_stateMachine.NormalState);
    }

    public void TransitionToHappyState()
    {
        _stateMachine.TransitionTo(_stateMachine.HappyState);
    }

    public void TransitionToScaredState()
    {
        _stateMachine.TransitionTo(_stateMachine.ScaredState);
    }

    public void TransitionToAngryState()
    {
        _stateMachine.TransitionTo(_stateMachine.AngryState);
    }

    public void TransitionToNormalState()
    {
        _stateMachine.TransitionTo(_stateMachine.NormalState);
    }

    public void TransitionToRelaxedState()
    {
        _stateMachine.TransitionTo(_stateMachine.RelaxedState);
    }

    public void TransitionToVictoryIdleState()
    {
        _stateMachine.TransitionTo(_stateMachine.VictoryIdleState);
    }

    public void TransitionToFistPumpState()
    {
        _stateMachine.TransitionTo(_stateMachine.FistPumpState);
    }
}
