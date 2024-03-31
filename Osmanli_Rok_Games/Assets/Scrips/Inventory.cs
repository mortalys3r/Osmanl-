using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    public int güvenlik=5, para=5, din = 5, halk=5;
    public GameObject yazi;
    public string kaybetme_sebebi;

    public Image paraIcon;
    public Image dinIcon;
    public Image halkIcon;
    public Image askerIcon;
    public int amount = 10;
    //public int sempati;


    public void Start()
    {
        Veri data = new Veri();
        data.myString = kaybetme_sebebi;

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/data.json", jsonData);


        paraIcon.fillAmount = 0.5f;
        askerIcon.fillAmount = 0.5f;
        dinIcon.fillAmount = 0.5f;
        halkIcon.fillAmount = 0.5f;



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
            paraIcon.fillAmount = paraIcon.fillAmount - 0.1f;

        }
        else if (durum == 1 && para < 10)
        {
            para = para + 1;
            paraIcon.fillAmount = paraIcon.fillAmount + 0.1f;
        }
    }
    public void güvenlik_olay(int durum)
    {
        if (durum == -1 && güvenlik > 0)
        {
            güvenlik = güvenlik - 1;
            askerIcon.fillAmount = askerIcon.fillAmount - 0.1f;
        }
        else if (durum == 1 && güvenlik < 10)
        {
            güvenlik = güvenlik + 1;
            askerIcon.fillAmount = askerIcon.fillAmount + 0.1f;
        }
    }
    public void halk_olay(int durum)
    {
        if (durum == -1 && halk > 0)
        {
            halkIcon.fillAmount = halkIcon.fillAmount - 0.1f;
            halk = halk - 1;
        }
        else if (durum == 1 && halk < 10)
        {
            halkIcon.fillAmount = halkIcon.fillAmount + 0.1f;
            halk = halk + 1;
        }
    }
    public void din_olay(int durum)
    {
        if (durum == -1 && din >0)
        {
            dinIcon.fillAmount = dinIcon.fillAmount - 0.1f;
            din = din - 1;
        }
        else if (durum == 1 && din < 10)
        {
            dinIcon.fillAmount = dinIcon.fillAmount + 0.1f;
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
