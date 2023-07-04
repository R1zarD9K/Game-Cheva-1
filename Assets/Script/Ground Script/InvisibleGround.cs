using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class InvisibleGround : MonoBehaviour
{
    public Sprite tanah;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get the collision point in world space
            Vector2 collisionPoint = collision.ClosestPoint(transform.position);

            // Check if the player collided from below
            if (collisionPoint.y < transform.position.y)
            {
                // Add the required components
                SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
                spriteRenderer.sprite = tanah;

                BoxCollider2D boxCollider = gameObject.AddComponent<BoxCollider2D>();
                boxCollider.usedByComposite = true;

            }
        }
    }
}

