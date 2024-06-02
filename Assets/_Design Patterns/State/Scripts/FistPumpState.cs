using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistPumpState : IState
{
    public FistPumpState(CharacterController controller)
    {
        _controller = controller;
    }

    private CharacterController _controller;

    public void Enter()
    {
        var animator = _controller.GetComponent<Animator>();
        animator.SetTrigger("fist_pump");
    }

    public void Exit()
    {
        
    }

    void IState.Update()
    {
        
    }
}
