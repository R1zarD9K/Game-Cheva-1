using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    [SerializeField] private AudioSource enemyDeathSoundEffect;
    // Start is called before the first frame update

    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Peluru"))
        {
            StartCoroutine(EnemyDeath());
            animator.SetFloat("Dead", 1);
        }
    }

    IEnumerator EnemyDeath()
    {
        enemyDeathSoundEffect.Play();
        yield return new WaitForSeconds(0.6f);
        Destroy(gameObject);
    }
}
