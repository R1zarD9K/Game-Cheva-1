using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningFollow : MonoBehaviour
{
    public GameObject player;
    //koordinat di posisi yang diinginkan
    public Vector3 posisi = new Vector3(0f, 0.5f, 0f);

    void Start()
    {
        
    }

    //Late update adalah method yang dipanggil setelah update,
    //jadi late update dipakai supaya pergerakan kamera tidak patah2
    void LateUpdate()
    {
        //mengubah posisi kamera mengikuti player, tapi dengan tambahan koordinat supaya posisinya sesuai dengan koordinat yang diinginkan
        transform.position = posisi + new Vector3(player.transform.position.x,0,player.transform.position.z);
    }
}
