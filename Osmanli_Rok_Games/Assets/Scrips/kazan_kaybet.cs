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
        // JSON dosyas�ndan veriyi oku
        string jsonData = File.ReadAllText(Application.dataPath + "/data.json");

        // JSON verisini Veri s�n�f�na d�n��t�r
        Veri data = JsonUtility.FromJson<Veri>(jsonData);

        // String de�eri al ve atama yap
        if (data != null)
        {
            okunanMetin = data.myString;
            talep.text = data.myString;
            Debug.Log("JSON dosyas�ndan okunan metin: " + okunanMetin);
        }
        else
        {
            Debug.LogWarning("JSON dosyas�nda veri bulunamad� veya dosya yok.");
        }
    }

    // Veri s�n�f� tan�m�
    [System.Serializable]
    public class Veri
    {
        public string myString;
    }
}
