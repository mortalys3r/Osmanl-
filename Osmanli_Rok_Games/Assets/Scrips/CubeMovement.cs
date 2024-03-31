using Unity.VisualScripting;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Transform targetTransform, targetTransform1, targetTransform2, targetTransform3, targetTransform4; // Hedef konumu temsil eden boþ nesne (empty game object)
    public float moveSpeed = 5.0f;
    public float rotasyon_sp = 5.0f;
    public int sayi = 1, oldu = 0, deneme = 0; // Küpün hýzýný ayarlayýn
    public Person pers;
    public GameObject kagit;

    private void Update()
    {


        if (sayi == 1)
        {
            kagit.SetActive(false);
            pers.enabled = false;

            // Hedef konumun pozisyonunu al
            Vector3 targetPosition = targetTransform.position;

            // Küpün þu anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma doðru yönelim vektörü
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // Küpü hedefe doðru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Eðer küp hedefe çok yaklaþtýysa, hareketi durdur
            if (Vector3.Distance(currentPosition, targetPosition) < 0.1f)
            {
                // Opsiyonel: Hareket tamamlandýðýnda yapýlacak iþlemler
                Debug.Log("1");
                if (oldu == 0)
                {
                    sayi = 2;
                }


                //enabled = false; // Bu script'i devre dýþý býrakarak hareketi durdurabilirsiniz.
            }
        }
        else if (sayi == 2)
        {
            kagit.SetActive(false);
            // Hedef konumun pozisyonunu al
            Vector3 targetPosition = targetTransform1.position;

            // Küpün þu anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma doðru yönelim vektörü
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // Küpü hedefe doðru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Eðer küp hedefe çok yaklaþtýysa, hareketi durdur
            if (Vector3.Distance(currentPosition, targetPosition) < 0.1f)
            {
                Debug.Log("2");

                sayi = 3;
            }
        }
        else if (sayi == 3)
        {

            // Hedef konumun pozisyonunu al
            Vector3 targetPosition = targetTransform2.position;

            // Küpün þu anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma doðru yönelim vektörü
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // Küpü hedefe doðru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Eðer küp hedefe çok yaklaþtýysa, hareketi durdur
            if (Vector3.Distance(currentPosition, targetPosition) < 0.1f)
            {
                pers.enabled = true;

                Debug.Log("3");
                kagit.SetActive(true);
                oldu = 1;
                sayi = 99;


            }
        }
        else if (sayi == 4)
        {
            pers.yazi_kont();
            kagit.SetActive(false);
            // Y ekseninde yavaþ yavaþ 180 derece rotasyon yap
            rotasyon_sp = 50f; // Dönme hýzý
            float step = rotasyon_sp * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 90f, 0f), step);
            if (transform.rotation == Quaternion.Euler(0f, 90f, 0f)) // Eðer dönme tamamlandýysa
            {
                Debug.Log("4");
                sayi = 5; // sayýyý sýfýrla veya baþka bir deðerle güncelle, kodunuzun mantýðýna baðlý olarak
            }
        }
        else if (sayi == 5)
        {
            kagit.SetActive(false);
            // Hedef konumun pozisyonunu al
            Vector3 targetPosition = targetTransform3.position;

            // Küpün þu anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma doðru yönelim vektörü
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // Küpü hedefe doðru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Eðer küp hedefe çok yaklaþtýysa, hareketi durdur
            if (Vector3.Distance(currentPosition, targetPosition) < 0.1f)
            {
                Debug.Log("5");
                sayi = 6;
            }
        }
        else if (sayi == 6)
        {
            kagit.SetActive(false);
            // Y ekseninde yavaþ yavaþ 180 derece rotasyon yap
            rotasyon_sp = 50f; // Dönme hýzý
            float step = rotasyon_sp * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, 0f), step);
            if (transform.rotation == Quaternion.Euler(0f, 0f, 0f)) // Eðer dönme tamamlandýysa
            {
                Debug.Log("6");
                sayi = 7; // sayýyý sýfýrla veya baþka bir deðerle güncelle, kodunuzun mantýðýna baðlý olarak
            }
        }

        else if (sayi == 7)
        {
            kagit.SetActive(false);
            // Hedef konumun pozisyonunu al
            Vector3 targetPosition = targetTransform4.position;

            // Küpün þu anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma doðru yönelim vektörü
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // Küpü hedefe doðru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Eðer küp hedefe çok yaklaþtýysa, hareketi durdur
            if (Vector3.Distance(currentPosition, targetPosition) < 0.1f)
            {
                Debug.Log("7");
                sayi = 8;
                oldu = 1;
            }
        }
        else if (sayi == 8)
        {
            kagit.SetActive(false);
            pers.enabled = false;

            // Hedef konumun pozisyonunu al
            Vector3 targetPosition = targetTransform.position;

            // Küpün þu anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma doðru yönelim vektörü
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // Küpü hedefe doðru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Eðer küp hedefe çok yaklaþtýysa, hareketi durdur
            if (Vector3.Distance(currentPosition, targetPosition) < 0.1f)
            {
                // Opsiyonel: Hareket tamamlandýðýnda yapýlacak iþlemler
                Debug.Log("8");

                if (oldu == 1)
                {
                    pers.Seket();
                    Destroy(gameObject);
                }

                //enabled = false; // Bu script'i devre dýþý býrakarak hareketi durdurabilirsiniz.
            }




        }

    }
}
