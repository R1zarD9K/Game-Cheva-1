using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Shoot : MonoBehaviour
{
    int jump = 0;
    Rigidbody2D rb;

    public GameObject senjata;
    public GameObject peluru;
    public AudioClip impact;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            jump = 1;
        }

        if(jump == 1 && Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * 1000);
            jump = 0;
        }

        if (Input.GetMouseButtonDown(0))
        {
            

        Instantiate(peluru, senjata.transform.position, senjata.transform.rotation); 

        audioSource.PlayOneShot(impact, 0.7F);

            
        }

    }

    
}
