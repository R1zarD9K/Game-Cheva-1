using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        InvokeRepeating("spawnEnemy", 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
