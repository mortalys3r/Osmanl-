using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistemler : MonoBehaviour
{
    public GameObject[] objeler; // Oyun nesnelerinin dizisi
    public string scriptAdi = "CubeMovement";
    public bool hak=false;

    public void Start()
    {
        rastgele();
    }

    public void rastgele()
    {

            objeler = GameObject.FindGameObjectsWithTag("Talep");
            int rastgeleIndex = Random.Range(0, objeler.Length);
            GameObject rastgeleObjem = objeler[rastgeleIndex];
            MonoBehaviour script = (MonoBehaviour)rastgeleObjem.GetComponent(scriptAdi);
            script.enabled = !script.enabled;


    }



}
