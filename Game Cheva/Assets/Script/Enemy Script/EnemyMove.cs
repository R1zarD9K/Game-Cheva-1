using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject ground;
    public float speed = 0;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Batas Kiri"))
        {
            rb.velocity = Vector2.right * speed;
        }

        else if (collision.gameObject.tag.Equals("Batas Kanan"))
        {
            
            rb.velocity = Vector2.right * -speed;
        }
    }
}
