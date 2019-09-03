using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float InstantionTimer = 5f;
    public Transform spawn;
    public GameObject Enemy;

    private void Update()
    {
        CreatePrefab();
    }

    void CreatePrefab()
    {
        InstantionTimer -= Time.deltaTime;
        if (InstantionTimer <= 0)
        {
            Instantiate(Enemy, spawn.position, Quaternion.identity);
            InstantionTimer = 2.5f;
        }
    }
}
