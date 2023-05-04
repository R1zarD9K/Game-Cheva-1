using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float horizontal;
    float jump;
    Rigidbody2D rb;
    public int checker = 0;

    public float playerSpeed = 0;
    public float jumpForce = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        jump = Input.GetAxis("Jump");
        horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontal * playerSpeed * Time.deltaTime);
        //transform.Translate(Vector3.up * jump * jumpForce * Time.deltaTime);

        if(checker == 1)
        {
            if (Input.GetButtonDown("Jump"))
            {
                
                rb.velocity = new Vector2(0, jumpForce);
                checker = checker-1;
            }
        }
        

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            checker = 1;
        }
    }


}
