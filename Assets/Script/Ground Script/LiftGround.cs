using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftGround : MonoBehaviour
{
    public float speed = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Batas"))
        {

            speed = speed * -1;
        }
    }
}
