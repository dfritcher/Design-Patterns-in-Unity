using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaredState : IState
{
    public ScaredState(CharacterController controller)
    {
        _controller = controller;
    }

    private CharacterController _controller;

    public void Enter()
    {
        var animator = _controller.GetComponent<Animator>();
        animator.SetTrigger("scared");
    }

    public void Exit()
    {
        
    }

    void IState.Update()
    {
        
    }
}
