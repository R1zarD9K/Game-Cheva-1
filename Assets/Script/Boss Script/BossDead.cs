using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDead : MonoBehaviour
{
    [SerializeField] private AudioSource enemyDeathSoundEffect;

    public GameObject winPanel;
    // Start is called before the first frame update

    int nyawa = 100;

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
            nyawa = nyawa - 1;

            if(nyawa <= 0)
            {
                StartCoroutine(EnemyDeath());
                animator.SetFloat("Dead", 1);
                
            }
            
        }
    }

    IEnumerator EnemyDeath()
    {
        enemyDeathSoundEffect.Play();
        yield return new WaitForSeconds(0.6f);
        winPanel.SetActive(true);
        Destroy(gameObject);
    }
}
