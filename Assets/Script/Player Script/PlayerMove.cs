using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 20f; // Increased move speed
    float horizontal;

    //vector 3 belok
    Vector3 kiri = new Vector3(0, 180, 0);

    public int checker = 0;
    [SerializeField] float jumpHeight = 5;
    [SerializeField] float gravityScale = 5;
    [SerializeField] float fallGravityScale = 15;
    public float playerSpeed = 0;
    float jumpForce = 15;
    Rigidbody2D rb;

    bool hasJumped = false;
    float buttonPressedTime;
    bool jumping;
    float buttonPressWindow = 0.2f;

    bool jumpCancelled;
    float cancelRate = 50;

    [SerializeField] private AudioSource jumpSoundEffect;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        //Belok Kiri
        if (transform.rotation.y == 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Rotate(kiri);
            }
        }

        //Belok Kanan
        if (transform.rotation.y != 0)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Rotate(-kiri);
            }
        }

        if (!hasJumped && Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = gravityScale;
            jumping = true;
            hasJumped = true;
            buttonPressedTime = 0;
            jumpSoundEffect.Play();
        }

        if (jumping)
        {
            buttonPressedTime += Time.deltaTime;
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

            if (buttonPressedTime > buttonPressWindow || Input.GetKeyUp(KeyCode.Space))
            {
                jumping = false;
            }

            if (rb.velocity.y < 0)
            {
                rb.gravityScale = fallGravityScale;
                jumping = false;
            }
        }
    }

    private void FixedUpdate()
    {
        
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);

        if (jumpCancelled && jumping && rb.velocity.y > 0)
        {
            rb.AddForce(Vector2.down * cancelRate);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            checker = 1;
            hasJumped = false;
        }
    }
}
