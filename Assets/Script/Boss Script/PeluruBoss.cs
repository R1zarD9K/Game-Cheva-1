using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruBoss : MonoBehaviour
{
    public float speed = 0;

    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        Destroy(gameObject, 20f);

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject)
        {
            Destroy(gameObject);
        }
    }
}
