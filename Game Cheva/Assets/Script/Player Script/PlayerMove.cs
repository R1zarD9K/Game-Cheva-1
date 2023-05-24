using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 kiri = new Vector3(0, 180, 0);
    float horizontal;
    bool ayam = false;
    
    Rigidbody2D rb;

    public float playerSpeed = 0;
    public float jumpForce = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (transform.rotation.y == 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Rotate(kiri);
            }
        }

        if (transform.rotation.y != 0)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Rotate(-kiri);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        //Jalan menggunakan axis
        //transform.Translate(Vector3.right * horizontal * playerSpeed * Time.deltaTime);


        

        if(ayam == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpForce);
                
                ayam = false;

                //rb.velocity = new Vector2(0, jumpForce);
            }
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            ayam = true;
        }
    }


}
