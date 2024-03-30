using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class kazan_kaybet : MonoBehaviour
{
    public string okunanMetin;
    public TMP_Text talep;

    void Start()
    {
        // JSON dosyasýndan veriyi oku
        string jsonData = File.ReadAllText(Application.dataPath + "/data.json");

        // JSON verisini Veri sýnýfýna dönüþtür
        Veri data = JsonUtility.FromJson<Veri>(jsonData);

        // String deðeri al ve atama yap
        if (data != null)
        {
            okunanMetin = data.myString;
            talep.text = data.myString;
            Debug.Log("JSON dosyasýndan okunan metin: " + okunanMetin);
        }
        else
        {
            Debug.LogWarning("JSON dosyasýnda veri bulunamadý veya dosya yok.");
        }
    }

    // Veri sýnýfý tanýmý
    [System.Serializable]
    public class Veri
    {
        public string myString;
    }
}
