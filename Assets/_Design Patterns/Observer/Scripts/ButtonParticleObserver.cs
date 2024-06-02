using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonParticleObserver : ButtonObserverBase
{
    [SerializeField] private ParticleSystem _particleSystem;
    protected override void OnClickEvent()
    {
        if( _particleSystem != null)
        {
            _particleSystem.Stop();
            _particleSystem.Play();
        }
    }
}
