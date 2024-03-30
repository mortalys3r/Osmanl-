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
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))//karaktere bakýyorsa
        {
            Stek tree = hit.collider.GetComponent<Stek>();
            CubeMovement cube_character = hit.collider.GetComponent<CubeMovement>();

            if (hit.collider.CompareTag("Talep"))
            {
                yazi.SetActive(true); // Karaktere bakýldýðýnda yazýyý aktifleþtir


                if (Input.GetKeyDown(KeyCode.Space))
                {

                    talep.text = tree.istek;
                    kontrol = 1;
                }

                if (Input.GetKeyDown(KeyCode.E)) // karaktere e týklanýrsa
                {
                    if (tree != null&& kontrol==1)
                    {
                        cube_character.sayi = 4;

                        tree.evet();
                        kontrol = 0;
                        talep.text = "Ýsteðini dinlemek için Boþluk tuþuna týkla.";

                    }
                }

                if (Input.GetKeyDown(KeyCode.Q)) // karaktere e týklanýrsa
                {
                    if (tree != null && kontrol==1)
                    {
                        cube_character.sayi = 4;


                        tree.hayýr();
                        kontrol = 0;
                        talep.text = "Ýsteðini dinlemek için Boþluk tuþuna týkla.";

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
