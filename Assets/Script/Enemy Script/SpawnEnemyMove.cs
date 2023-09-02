using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyMove : MonoBehaviour
{
    public float speed = 0;
    public float rotate = 180;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Batas"))
        {

            rotate = rotate * -1;
            transform.Rotate(Vector3.up * rotate);

            //speed = speed * -1;


        }
    }
}
