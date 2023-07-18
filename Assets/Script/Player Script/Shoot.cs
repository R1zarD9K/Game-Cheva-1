using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Shoot : MonoBehaviour
{
    public GameObject senjata;
    public GameObject peluru;
    public AudioClip impact;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { Instantiate(peluru, senjata.transform.position, transform.rotation); 
        audioSource.PlayOneShot(impact, 0.7F);
        }
        
    }
}
