using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class ShrinkPowerUpFactory : MonoBehaviour, IPowerUpFactory
{
    [SerializeField] private List<ShrinkPowerUp> _growPowerUps;

    public PowerUpType PowerUpType { get => PowerUpType.Shrink; }

    public IPowerUp GetPowerUp(Vector3 spawnPosition)
    {
        // Create a Prefab Instance and get the product component
        var instance = Instantiate(_growPowerUps[UnityEngine.Random.Range(0, _growPowerUps.Count -1)], spawnPosition, Quaternion.identity);
        var powerUp = instance.GetComponent<ShrinkPowerUp>();
        StartCoroutine(InitializePowerUp(powerUp));

        return powerUp;
    }

    private IEnumerator InitializePowerUp(ShrinkPowerUp powerUp)
    {
        yield return new WaitForSeconds(1);
        powerUp.Initialize();
    }
}