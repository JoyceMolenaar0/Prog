using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    private float OffSetEnemy = 1f;
    private float ElapsedTime = 0f;
    private int EnemyCount = 0;
    private GameObject EnemyClone;
    private List<GameObject> Enemies = new List<GameObject>();
    [SerializeField] GameObject Enemy;


    void Start()
    {

    }


    void Update()
    {
        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > 3)
        {
            EnemySpawn(3);
            EnemyCount = 0;

        }


        if (Input.GetKey(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                EnemySpawn(1);
            }
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Destroy(EnemyClone);
        }

    }

    void EnemySpawn(int EnemyCounts)
    {
        for (int i = 0; i < EnemyCounts; i++)
        {
            float x = Random.Range(-4, 4) + (i * OffSetEnemy);

            Vector3 RandomPos = new Vector3(x, 0.5f, 0);
            EnemyClone = Instantiate(Enemy, RandomPos, Quaternion.identity);

            ElapsedTime = 0f;
            EnemyCount++;
        }
    }
}

