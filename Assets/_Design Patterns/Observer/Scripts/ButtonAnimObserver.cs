using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class ButtonAnimObserver : ButtonObserverBase
{
    [SerializeField] Animator _anim;

    protected override void Awake()
    {
        _logTitle = "<color=green>Animation</color>";
        base.Awake();
    }

    protected override void OnClickEvent()
    {
        Debug.Log(_logTitle + gameObject.name + "OnClickEvent()");
        if (_anim != null)
        {
            _anim.SetTrigger("Clicked");
            Debug.Log(_logTitle + gameObject.name + "Played Animation.");
        }
        else
        {
            Debug.LogError(_logTitle + gameObject.name + " _animClip is null!");
        }
    }
}
