using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowerUp
{
    public string Name { get; set; }
    public void Initialize();

    public void Destroy();

    public void Pickup();
}
