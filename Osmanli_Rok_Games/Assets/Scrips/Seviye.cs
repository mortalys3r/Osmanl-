using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Seviye : MonoBehaviour
{

    public int number;
    public void Start()
    {
        Veri data = new Veri();
        data.bolum_num = number;


        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/data.json", jsonData);

    }


    public void veritabani()
    {
        Veri data = new Veri();
        data.bolum_num = number;

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/data.json", jsonData);
    }

    public void kolay()
    {
        number = 1;
        veritabani();
    }
    public void orta()
    {
        number = 2;
        veritabani();
    }
    public void zor()
    {
        number = 3;
        veritabani();
    }

    [System.Serializable]
    public class Veri
    {
        public int bolum_num;

    }
}
