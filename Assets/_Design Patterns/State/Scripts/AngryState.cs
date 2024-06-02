using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryState : IState
{
    public AngryState(CharacterController controller)
    {
        _controller = controller;
    }

    private CharacterController _controller;

    public void Enter()
    {
        var animator = _controller.GetComponent<Animator>();
        animator.SetTrigger("angry");
    }

    public void Exit()
    {
        
    }

    void IState.Update()
    {
        
    }
}
