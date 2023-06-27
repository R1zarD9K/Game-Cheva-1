using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRightGround : MonoBehaviour
{
    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Batas"))
        {
            speed = speed * -1;
        }
    }
}
