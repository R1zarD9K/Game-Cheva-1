using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPanel : MonoBehaviour
{
    [SerializeField] private AudioSource deathSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        deathSoundEffect.Play(); 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
