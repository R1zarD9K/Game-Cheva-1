using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    Vector3 ayam = new Vector3(5,-0.5f,0);
    
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
        Instantiate(enemy, transform.position - ayam, transform.rotation);
    }
}
