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
                }

                if (Input.GetKeyDown(KeyCode.E)) // karaktere e týklanýrsa
                {
                    if (tree != null)
                    {
                        cube_character.sayi = 3;
                        cube_character.deneme = 1;
                        Seket();
                        tree.evet();
                        yazi.SetActive(false); // E tuþuna basýldýktan sonra yazýyý kapat
                    }
                }

                if (Input.GetKeyDown(KeyCode.Q)) // karaktere e týklanýrsa
                {
                    if (tree != null)
                    {
                        cube_character.sayi = 3;
                        cube_character.deneme = 1;
                        Seket();
                        tree.hayýr();
                    }
                }
            }
            else
            {
                yazi.SetActive(false); // Karaktere bakýlmadýðýnda yazýyý devre dýþý býrak
            }
        }
        else
        {
            yazi.SetActive(false); // Eðer bir þeye bakýlmýyorsa da yazýyý devre dýþý býrak
        }
    }

    public void Seket()
    {
        systems.rastgele();
    }
}
