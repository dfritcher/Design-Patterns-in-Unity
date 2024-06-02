using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Button script to implement the Observer pattern
/// This script acts as the subject, declaring, and invoking some event.
/// </summary>
public class ButtonSubject : MonoBehaviour
{
    public event Action OnClick;

    public void DoClick()
    {
        OnClick?.Invoke();
        Debug.Log(gameObject.name + "DoClick()");
    }
}
