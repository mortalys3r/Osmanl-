using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Transform targetTransform, targetTransform2, targetTransform3; // Hedef konumu temsil eden boþ nesne (empty game object)
    public float moveSpeed = 5.0f;
    public int sayi = 0, oldu = 0, deneme = 0; // Küpün hýzýný ayarlayýn
    public Person pers;

    private void Update()
    {


        if (sayi == 0)
        {
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
                Debug.Log("Küp hedefe ulaþtý!");
                if (oldu == 0)
                {
                    sayi = 1;
                }
                if (oldu == 1)
                {
                    sayi = 2;
                }

                //enabled = false; // Bu script'i devre dýþý býrakarak hareketi durdurabilirsiniz.
            }
        }
        else if (sayi == 1)
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
                // Opsiyonel: Hareket tamamlandýðýnda yapýlacak iþlemler
                Debug.Log("Küp hedefe ulaþtý!");
                pers.enabled = true;
                sayi = 4;
                oldu = 1;
                // Bu script'i devre dýþý býrakarak hareketi durdurabilirsiniz.
            }
        }
        else if (sayi == 2)
        {
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
                // Opsiyonel: Hareket tamamlandýðýnda yapýlacak iþlemler
                enabled = false; // Bu script'i devre dýþý býrakarak hareketi durdurabilirsiniz.
            }
        }
        else if (sayi == 3)
        {
            // Y ekseninde yavaþ yavaþ 180 derece rotasyon yap
            float rotationSpeed = 60f; // Dönme hýzý
            float step = rotationSpeed * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 180f, 0f), step);
            if (transform.rotation == Quaternion.Euler(0f, 180f, 0f)) // Eðer dönme tamamlandýysa
            {
                sayi = 0; // sayýyý sýfýrla veya baþka bir deðerle güncelle, kodunuzun mantýðýna baðlý olarak
            }
        }
    }
}
