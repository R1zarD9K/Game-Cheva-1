using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGround : MonoBehaviour
{
    float ukuran;
    bool getaran = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        ukuran = Random.Range(0.1f, 0.15f);

        if(getaran == true)
        {
            //untuk membuat tanahnya getar2, angka sebelum var ukuran adalah ukuran asli dari game objek
            transform.localScale = new Vector3(4.472525f + ukuran, 1 + ukuran, 1 + ukuran);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Player"))
        {
            
            getaran = true;
            Destroy(gameObject,3f);
        }
    }
}
