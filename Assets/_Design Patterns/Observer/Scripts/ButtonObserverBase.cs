using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ButtonObserverBase : MonoBehaviour
{
    [SerializeField] protected ButtonSubject _buttonSubject;
    protected string _logTitle;

    protected virtual void Awake()
    {
        if(_buttonSubject != null)
        {
            _buttonSubject.OnClick += OnClickEvent;
            Debug.Log(_logTitle + gameObject.name + "OnClickEvent assigned");
        }
        else
        {
            Debug.LogWarning(_logTitle + gameObject.name + "has no _buttonSubject assigned");
        }
    }

    protected virtual void OnDestroy()
    {
        if (_buttonSubject != null)
        {
            _buttonSubject.OnClick -= OnClickEvent;
        }
    }

    protected abstract void OnClickEvent();
}
