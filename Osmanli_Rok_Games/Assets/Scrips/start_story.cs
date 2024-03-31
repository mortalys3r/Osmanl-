using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_story : MonoBehaviour
{
    public GameObject story;
    public GameObject cross;
    public FirstPersonLook look;
    public float sens;
    // Start is called before the first frame update
    void Start()
    {
        sens=look.sensitivity;
        look.sensitivity = 0;
        cross.SetActive(false);
        story.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            if(story.activeSelf==true)
            {

                look.sensitivity = sens;
                cross.SetActive(true);
                Time.timeScale = 1f;
                story.SetActive(false);
                

            }
        }
        
    }
}
