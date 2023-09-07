using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigShoot : MonoBehaviour
{
    public GameObject enemy;
    public float fireRate = 0f;

    Vector3 ayam = new Vector3(6,-0.5f,0);
    
    void Start()
    {
        
        InvokeRepeating("spawnEnemy", 20f, fireRate);
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
