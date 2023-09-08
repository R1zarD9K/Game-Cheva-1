using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPanel : MonoBehaviour
{
    [SerializeField] private AudioSource deathSoundEffect;

    public GameObject BGM;

    // Start is called before the first frame update
    void Start()
    {
        deathSoundEffect.Play(); 
        BGM.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
