using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    private List<GameObject> enemies = new List<GameObject>();

    private float elapsedTime = 0;

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                SpawnEnemy();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClearEnemies();
        }

        if (elapsedTime > 3)
        {
            int enemyCount = Random.Range(0, 5);
            for (int i = 0; i < enemyCount; i++)
            {
                SpawnEnemy();
            }
            elapsedTime = 0;
        }
    }
    private void SpawnEnemy()
    {
        Vector3 spawnLocation = new Vector3(0, 1, 0);
        GameObject enemy = Instantiate(enemyPrefab, spawnLocation, Quaternion.identity);
        enemies.Add(enemy);
    }

    private void ClearEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();
    }

}

