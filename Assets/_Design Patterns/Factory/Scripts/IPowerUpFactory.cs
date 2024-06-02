using System;
using UnityEngine;

public interface IPowerUpFactory
{
    public PowerUpType PowerUpType { get; }
    public IPowerUp GetPowerUp(Vector3 spawnPosition);
}