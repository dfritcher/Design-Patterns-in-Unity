using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class GrowPowerUpFactory : MonoBehaviour, IPowerUpFactory
{
    [SerializeField] private List<GrowPowerUp> _growPowerUps;

    public PowerUpType PowerUpType { get => PowerUpType.Grow; }

    public IPowerUp GetPowerUp(Vector3 spawnPosition)
    {
        // Create a Prefab Instance and get the product component
        var instance = Instantiate(_growPowerUps[UnityEngine.Random.Range(0, _growPowerUps.Count -1)], spawnPosition, Quaternion.identity);
        var powerUp = instance.GetComponent<GrowPowerUp>();
        StartCoroutine(InitializePowerUp(powerUp));

        return powerUp;
    }

    private IEnumerator InitializePowerUp(GrowPowerUp powerUp)
    {
        yield return new WaitForSeconds(1);
        powerUp.Initialize();
    }
}