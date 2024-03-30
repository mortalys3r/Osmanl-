using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistemler : MonoBehaviour
{
    public List<GameObject> objeler; // Oyun nesnelerinin listesi
    public string scriptAdi = "CubeMovement";
    private HashSet<int> secilenSayilar = new HashSet<int>();

    public void Start()
    {
        // Ba�lang��ta t�m nesneleri listeye ekle
        GameObject[] tempObjeler = GameObject.FindGameObjectsWithTag("Talep");
        objeler.AddRange(tempObjeler);

        rastgele();
    }

    public void rastgele()
    {
        if (objeler.Count == 0)
        {
            Debug.Log("T�m say�lar se�ildi!");
            return;
        }

        int rastgeleIndex = Random.Range(0, objeler.Count);
        GameObject rastgeleObjem = objeler[rastgeleIndex];

        // Daha �nce se�ilmi� bir say� m� kontrol et
        int hash = rastgeleObjem.GetHashCode();
        if (secilenSayilar.Contains(hash))
        {
            // E�er daha �nce se�ilmi�se, tekrar se�
            objeler.RemoveAt(rastgeleIndex);
            rastgele();
            return;
        }

        // Nesneye ba�l� scripti etkinle�tir veya devre d��� b�rak
        MonoBehaviour script = (MonoBehaviour)rastgeleObjem.GetComponent(scriptAdi);
        script.enabled = !script.enabled;

        // Se�ilen say�y� listeye ekle
        secilenSayilar.Add(hash);
    }
}
