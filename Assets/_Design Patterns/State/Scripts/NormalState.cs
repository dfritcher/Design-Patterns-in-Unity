using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalState : IState
{
    public NormalState(CharacterController controller)
    {
        _controller = controller;
    }

    private CharacterController _controller;

    public void Enter()
    {
        var animator = _controller.GetComponent<Animator>();
        animator.SetTrigger("normal");
    }

    public void Exit()
    {
        
    }

    void IState.Update()
    {
       
    }
}
