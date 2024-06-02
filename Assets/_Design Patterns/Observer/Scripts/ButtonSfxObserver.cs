using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ButtonSfxObserver : ButtonObserverBase
{
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private AudioSource _audioSource;

    protected override void Awake()
    {
        _logTitle = "<color=blue>SFX</color>";
        _audioSource = GetComponent<AudioSource>();       
        base.Awake();
    }

    protected override void OnClickEvent()
    {
        _audioSource.PlayOneShot(_audioClip);
        Debug.Log(_logTitle + gameObject.name + "OnClickEvent()");
    }
}
