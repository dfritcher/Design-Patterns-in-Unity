using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelaxedState : IState
{
    public RelaxedState(CharacterController controller)
    {
        _controller = controller;
    }

    private CharacterController _controller;

    public void Enter()
    {
        var animator = _controller.GetComponent<Animator>();
        animator.SetTrigger("battle");
    }

    public void Exit()
    {
        
    }

    void IState.Update()
    {
        
    }
}
