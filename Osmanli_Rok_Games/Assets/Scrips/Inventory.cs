using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int güvenlik=3, para=3, din = 3, halk=3;
    public GameObject yazi;
    //public int sempati;

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

        }
        if (halk <= 0)
        {

        }
        if (güvenlik <= 0)
        {

        }
        if (din <= 0)
        {

        }

    }


    public void olcak()
    {
        yazi.SetActive(false);
    }

}
