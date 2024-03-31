using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playscene : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject credits_menu;
    public GameObject set_menu;
    public GameObject game_seviye_menu;


    public void Start()
    {
        game_seviye_menu.SetActive(false);
        credits_menu.SetActive(false);
        main_menu.SetActive(true);
        set_menu.SetActive(false);
    }




    public void credits()
    {
        game_seviye_menu.SetActive(false);
        credits_menu.SetActive(true);
        main_menu.SetActive(false);
        set_menu.SetActive(false);
    }

    public void setting_menu()
    {
        game_seviye_menu.SetActive(false);
        credits_menu.SetActive(false);
        main_menu.SetActive(false);
        set_menu.SetActive(true);
    }

    public void Main_Menu()
    {
        game_seviye_menu.SetActive(false);
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

}
