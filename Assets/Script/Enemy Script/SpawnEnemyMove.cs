using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyMove : MonoBehaviour
{
    public float speed = 0;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if(transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Batas"))
        {
            speed = speed * -1;
        }
    }
}
