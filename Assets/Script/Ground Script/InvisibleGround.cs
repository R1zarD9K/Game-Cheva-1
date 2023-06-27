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
        if(collision.gameObject.CompareTag("Player"))
        {
            this.gameObject.AddComponent<SpriteRenderer>().sprite = tanah;
            this.gameObject.AddComponent<BoxCollider2D>();
        }
    }
}
