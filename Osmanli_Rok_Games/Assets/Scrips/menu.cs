using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    
    public void Quit()
    {
        Application.Quit();
    }



    public void main_menu()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
