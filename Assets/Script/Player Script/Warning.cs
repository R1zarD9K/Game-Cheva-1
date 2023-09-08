using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    public GameObject warningSign;
    [SerializeField] private AudioSource warningSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("warning", 15f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void warning()
    {
        Instantiate(warningSign, transform.position, transform.rotation);
        warningSoundEffect.Play();
    }
}
