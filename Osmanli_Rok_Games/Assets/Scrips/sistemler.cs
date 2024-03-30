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
        // Baþlangýçta tüm nesneleri listeye ekle
        GameObject[] tempObjeler = GameObject.FindGameObjectsWithTag("Talep");
        objeler.AddRange(tempObjeler);

        rastgele();
    }

    public void rastgele()
    {
        if (objeler.Count == 0)
        {
            Debug.Log("Tüm sayýlar seçildi!");
            return;
        }

        int rastgeleIndex = Random.Range(0, objeler.Count);
        GameObject rastgeleObjem = objeler[rastgeleIndex];

        // Daha önce seçilmiþ bir sayý mý kontrol et
        int hash = rastgeleObjem.GetHashCode();
        if (secilenSayilar.Contains(hash))
        {
            // Eðer daha önce seçilmiþse, tekrar seç
            objeler.RemoveAt(rastgeleIndex);
            rastgele();
            return;
        }

        // Nesneye baðlý scripti etkinleþtir veya devre dýþý býrak
        MonoBehaviour script = (MonoBehaviour)rastgeleObjem.GetComponent(scriptAdi);
        script.enabled = !script.enabled;

        // Seçilen sayýyý listeye ekle
        secilenSayilar.Add(hash);
    }
}
