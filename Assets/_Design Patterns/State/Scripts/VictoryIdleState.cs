using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryIdleState : IState
{
    public VictoryIdleState(CharacterController controller)
    {
        _controller = controller;
    }

    private CharacterController _controller;

    public void Enter()
    {
        var animator = _controller.GetComponent<Animator>();
        animator.SetTrigger("victory");
    }

    public void Exit()
    {
        
    }

    void IState.Update()
    {
        
    }
}
