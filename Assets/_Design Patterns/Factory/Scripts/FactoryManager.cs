using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FactoryManager : MonoBehaviour
{
    public List<IPowerUpFactory> PowerUpFactories { get; private set; }
    
    void Awake()
    {
        PowerUpFactories = GetComponents<IPowerUpFactory>().ToList();
    }
}
