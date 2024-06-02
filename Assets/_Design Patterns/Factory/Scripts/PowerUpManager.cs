using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    #region Fields
    [SerializeField] private List<Transform> _spawnLocations;
    [SerializeField] private FactoryManager _factoryManager;
    private PowerUpType _powerUpType;
    #endregion Fields (end)


    #region Methods
    private void Start()
    {
        _powerUpType = PowerUpType.Grow;
    }

    /// <summary>
    /// Method called by Unity Button in scene.
    /// </summary>
    public void SpawnGrowPowerUp()
    {
        SpawnPowerUp(PowerUpType.Grow, GetSpawnLocation().position);
    }

    /// <summary>
    /// Method called by Unity Button in scene.
    /// </summary>
    public void SpawnShrinkPowerUp()
    {
        SpawnPowerUp(PowerUpType.Shrink, GetSpawnLocation().position);
    }

    /// <summary>
    /// Method to create a shrink power up using the factory.
    /// </summary>
    /// <param name="powerUpType">The type of power up to spawn</param>
    /// <param name="spawnPosition">The world space the object should be spawned at.</param>
    private void SpawnPowerUp(PowerUpType powerUpType, Vector3 spawnPosition)
    {
        _factoryManager.PowerUpFactories.Find(p => p.PowerUpType == powerUpType).GetPowerUp(spawnPosition);
    }

    /// <summary>
    /// Method to retrieve a random spawn location from the list. 
    /// </summary>
    /// <returns>Transform object to get the world space position.</returns>
    private Transform GetSpawnLocation()
    {
       return _spawnLocations[Random.Range(0, _spawnLocations.Count - 1)];
    }
    #endregion Methods (end)
}
