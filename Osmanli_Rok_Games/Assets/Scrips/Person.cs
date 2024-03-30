using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Person : MonoBehaviour
{
    public int sayi;
    public GameObject kagit;
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
                }

                if (Input.GetKeyDown(KeyCode.E)) // karaktere e t�klan�rsa
                {
                    if (tree != null)
                    {
                        cube_character.sayi = 3;
                        cube_character.deneme = 1;
                        Seket();
                        tree.evet();
                        yazi.SetActive(false); // E tu�una bas�ld�ktan sonra yaz�y� kapat
                    }
                }

                if (Input.GetKeyDown(KeyCode.Q)) // karaktere e t�klan�rsa
                {
                    if (tree != null)
                    {
                        cube_character.sayi = 3;
                        cube_character.deneme = 1;
                        Seket();
                        tree.hay�r();
                    }
                }
            }
            else
            {
                yazi.SetActive(false); // Karaktere bak�lmad���nda yaz�y� devre d��� b�rak
            }
        }
        else
        {
            yazi.SetActive(false); // E�er bir �eye bak�lm�yorsa da yaz�y� devre d��� b�rak
        }
    }

    public void Seket()
    {
        systems.rastgele();
    }
}
