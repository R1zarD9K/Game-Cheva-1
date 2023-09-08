using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    [SerializeField] private AudioSource winSoundEffect;
    
    public GameObject BGM;

    // Start is called before the first frame update
    void Start()
    {
        winSoundEffect.Play();
        BGM.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
