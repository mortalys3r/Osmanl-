using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playscene : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject credits_menu;
    public GameObject set_menu;



    public void Start()
    {

        credits_menu.SetActive(false);
        main_menu.SetActive(true);
        set_menu.SetActive(false);
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



}
