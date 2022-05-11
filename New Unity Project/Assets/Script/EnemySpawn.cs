using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public Transform[] spawnPoints;
    public bool _isSpawnable = false;
    private int randNum;
    private int CurEnemy = 0;
    private int MaxEnemy = 1;

    void Start()
    {

    
    }

    void Update()
    {

        if (CurEnemy <= 20 && MaxEnemy >= 0)
        {
            _isSpawnable = true;
            if (_isSpawnable)
            {
                Spawn();

            }
        }
        else
        {
            _isSpawnable = false;
        }


    }

    void Spawn()
    {
        randNum = Random.Range(0, spawnPoints.Length);

        Instantiate(Enemy, spawnPoints[randNum].position, Quaternion.identity);
        CurEnemy++;
        MaxEnemy--;
        _isSpawnable = false;
    }
}
