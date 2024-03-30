using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Person : MonoBehaviour
{
    public int sayi,kontrol=0;

    public sistemler systems;
    public TMP_Text talep;
    public GameObject yazi;


    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))//karaktere bak�yorsa
        {
            Stek tree = hit.collider.GetComponent<Stek>();
            CubeMovement cube_character = hit.collider.GetComponent<CubeMovement>();

            if (hit.collider.CompareTag("Talep"))
            {
                yazi.SetActive(true); // Karaktere bak�ld���nda yaz�y� aktifle�tir


                if (Input.GetKeyDown(KeyCode.Space))
                {

                    talep.text = tree.istek;
                    kontrol = 1;
                }

                if (Input.GetKeyDown(KeyCode.E)) // karaktere e t�klan�rsa
                {
                    if (tree != null&& kontrol==1)
                    {
                        cube_character.sayi = 4;

                        tree.evet();
                        kontrol = 0;
                        talep.text = "�ste�ini dinlemek i�in Bo�luk tu�una t�kla.";

                    }
                }

                if (Input.GetKeyDown(KeyCode.Q)) // karaktere e t�klan�rsa
                {
                    if (tree != null && kontrol==1)
                    {
                        cube_character.sayi = 4;


                        tree.hay�r();
                        kontrol = 0;
                        talep.text = "�ste�ini dinlemek i�in Bo�luk tu�una t�kla.";

                    }
                }
            }
            else
            {
                yazi.SetActive(false);

            }
        }
        else
        {
            yazi.SetActive(false);

        }
    }

    public void yazi_kont()
    {
        yazi.SetActive(false);
    }

    public void Seket()
    {
        systems.rastgele();
    }
}
