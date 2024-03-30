using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using SimpleJSON;


public class Inventory : MonoBehaviour
{
    public int güvenlik=3, para=3, din = 3, halk=3;
    public GameObject yazi;
    public string kaybetme_sebebi;
    //public int sempati;


    public void Start()
    {
        Veri data = new Veri();
        data.myString = kaybetme_sebebi;

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/data.json", jsonData);
    }


    public void veritabani()
    {
        Veri data = new Veri();
        data.myString = kaybetme_sebebi;

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/data.json", jsonData);
    }

    public void para_olay(int durum)
    {
        if (durum == -1 && para > 0)
        {
            para=para-1;
        }
        else if (durum == 1 && para < 10)
        {
            para = para + 1;
        }
    }
    public void güvenlik_olay(int durum)
    {
        if (durum == -1 && güvenlik > 0)
        {
            güvenlik = güvenlik - 1;
        }
        else if (durum == 1 && güvenlik < 10)
        {
            güvenlik = güvenlik + 1;
        }
    }
    public void halk_olay(int durum)
    {
        if (durum == -1 && halk > 0)
        {
            halk = halk - 1;
        }
        else if (durum == 1 && halk < 10)
        {
            halk= halk + 1;
        }
    }
    public void din_olay(int durum)
    {
        if (durum == -1 && din >0)
        {
            din= din - 1;
        }
        else if (durum == 1 && din < 10)
        {
            din = din + 1;
        }
    }


    public void Update()
    {
        if(para<=0)
        {
            kaybetme_sebebi = "para bitti";
            veritabani();
            SceneManager.LoadSceneAsync(3);

            
        }
        if (halk <= 0)
        {
            kaybetme_sebebi = "halkın sana düşmman oldu";
            veritabani();
            SceneManager.LoadSceneAsync(3);

        }
        if (güvenlik <= 0)
        {
            kaybetme_sebebi = "askerlerinin hepsi öldü";
            veritabani();
            SceneManager.LoadSceneAsync(3);

        }
        if (din <= 0)
        {
            kaybetme_sebebi = "inançlılar kafir olduğun için seni astı";
            veritabani();
            SceneManager.LoadSceneAsync(3);
        }

    }


    public void olcak()
    {
        yazi.SetActive(false);
    }

    [System.Serializable]
    public class Veri
    {
        public string myString;
    }

}
