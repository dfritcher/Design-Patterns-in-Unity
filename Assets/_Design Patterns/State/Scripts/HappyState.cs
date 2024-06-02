using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyState : IState
{
    public HappyState(CharacterController controller)
    {
        _controller = controller;
    }

    private CharacterController _controller;

    public void Enter()
    {
        var animator = _controller.GetComponent<Animator>();
        animator.SetTrigger("happy");
    }

    public void Exit()
    {
        
    }

    void IState.Update()
    {
        
    }
}
