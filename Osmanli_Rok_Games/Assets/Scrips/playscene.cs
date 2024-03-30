using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class playscene : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject credits_menu;
    public GameObject set_menu;
    public GameObject game_seviye_menu;
    public int seviye;

    public void Start()
    {
        Veri data = new Veri();
        data.sevi = seviye;

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/data.json", jsonData);





        credits_menu.SetActive(false);
        main_menu.SetActive(true);
        set_menu.SetActive(false);
    }





    public void veritabani()
    {
        Veri data = new Veri();
        data.sevi = seviye;

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/data.json", jsonData);
    }

    public void credits()
    {
        credits_menu.SetActive(true);
        main_menu.SetActive(false);
        set_menu.SetActive(false);
    }

    public void setting_menu()
    {
        credits_menu.SetActive(false);
        main_menu.SetActive(false);
        set_menu.SetActive(true);
    }

    public void Main_Menu()
    {
        credits_menu.SetActive(false);
        main_menu.SetActive(true);
        set_menu.SetActive(false);
    }

    public void playseviye()
    {
        main_menu.SetActive(false);
        set_menu.SetActive(false);
        credits_menu.SetActive(false);
        game_seviye_menu.SetActive(true);
    }


    public void seviyelisecim(int sayi)
    {
        seviye = sayi;
    }



    [System.Serializable]
    public class Veri
    {
        public int sevi; // veya baþka bir veri türü
    }
}
