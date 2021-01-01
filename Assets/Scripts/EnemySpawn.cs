using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public int instanceCount;
    public Transform spawnPoint;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemyInstances", 3, 10);
    }

    public void SpawnEnemyInstances()
    {
        for (int i = 0; i < instanceCount; i++)
        {
            Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
        }

    }
}
