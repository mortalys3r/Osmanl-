using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class main_scene_uı_manager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject settings_menu;
    public GameObject main_menu;
    public GameObject crosshair;
    public float sens;
    public FirstPersonLook look;
    public bool Cursor_mode=false;
    public TMP_InputField hassasiyet;




    private void Start()
    {
        canvas.SetActive(false);
        main_menu.SetActive(true);
        settings_menu.SetActive(false);

    }
    public void change()
    {
        sens = float.Parse(hassasiyet.text);
    }




    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if(canvas.activeSelf==false)
            {
                canvas.SetActive(true);
                main_menu.SetActive(true);
                settings_menu.SetActive(false);
                cursor();
            }
            else if(canvas.activeSelf==true) 
            {
                canvas.SetActive(false);
                main_menu.SetActive(true);
                settings_menu.SetActive(false);
                cursor();
            }

        }

    }

    public void resume()
    {
        canvas.SetActive(false);
        cursor();
    }
    public void settings()
    {
        main_menu.SetActive(false);
        settings_menu.SetActive(true);
    }
    public void ex_settings()
    {
        settings_menu.SetActive(false);
        main_menu.SetActive(true);
    }




    public void cursor()
    {
        if (Cursor_mode==false)
        {
            crosshair.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            sens = look.sensitivity;
            look.sensitivity = 0;
            Cursor_mode = true;
        }
        else if (Cursor_mode==true) 
        {
            crosshair.SetActive(true);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            look.sensitivity = sens;
            Cursor_mode = false;
        }
    }
}
