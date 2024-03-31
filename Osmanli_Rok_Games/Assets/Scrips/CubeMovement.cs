using Unity.VisualScripting;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Transform targetTransform, targetTransform1, targetTransform2, targetTransform3, targetTransform4; // Hedef konumu temsil eden bo� nesne (empty game object)
    public float moveSpeed = 5.0f;
    public float rotasyon_sp = 5.0f;
    public int sayi = 1, oldu = 0, deneme = 0; // K�p�n h�z�n� ayarlay�n
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

            // K�p�n �u anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma do�ru y�nelim vekt�r�
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // K�p� hedefe do�ru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // E�er k�p hedefe �ok yakla�t�ysa, hareketi durdur
            if (Vector3.Distance(currentPosition, targetPosition) < 0.1f)
            {
                // Opsiyonel: Hareket tamamland���nda yap�lacak i�lemler
                Debug.Log("1");
                if (oldu == 0)
                {
                    sayi = 2;
                }


                //enabled = false; // Bu script'i devre d��� b�rakarak hareketi durdurabilirsiniz.
            }
        }
        else if (sayi == 2)
        {
            kagit.SetActive(false);
            // Hedef konumun pozisyonunu al
            Vector3 targetPosition = targetTransform1.position;

            // K�p�n �u anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma do�ru y�nelim vekt�r�
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // K�p� hedefe do�ru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // E�er k�p hedefe �ok yakla�t�ysa, hareketi durdur
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

            // K�p�n �u anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma do�ru y�nelim vekt�r�
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // K�p� hedefe do�ru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // E�er k�p hedefe �ok yakla�t�ysa, hareketi durdur
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
            // Y ekseninde yava� yava� 180 derece rotasyon yap
            rotasyon_sp = 50f; // D�nme h�z�
            float step = rotasyon_sp * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 90f, 0f), step);
            if (transform.rotation == Quaternion.Euler(0f, 90f, 0f)) // E�er d�nme tamamland�ysa
            {
                Debug.Log("4");
                sayi = 5; // say�y� s�f�rla veya ba�ka bir de�erle g�ncelle, kodunuzun mant���na ba�l� olarak
            }
        }
        else if (sayi == 5)
        {
            kagit.SetActive(false);
            // Hedef konumun pozisyonunu al
            Vector3 targetPosition = targetTransform3.position;

            // K�p�n �u anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma do�ru y�nelim vekt�r�
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // K�p� hedefe do�ru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // E�er k�p hedefe �ok yakla�t�ysa, hareketi durdur
            if (Vector3.Distance(currentPosition, targetPosition) < 0.1f)
            {
                Debug.Log("5");
                sayi = 6;
            }
        }
        else if (sayi == 6)
        {
            kagit.SetActive(false);
            // Y ekseninde yava� yava� 180 derece rotasyon yap
            rotasyon_sp = 50f; // D�nme h�z�
            float step = rotasyon_sp * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, 0f), step);
            if (transform.rotation == Quaternion.Euler(0f, 0f, 0f)) // E�er d�nme tamamland�ysa
            {
                Debug.Log("6");
                sayi = 7; // say�y� s�f�rla veya ba�ka bir de�erle g�ncelle, kodunuzun mant���na ba�l� olarak
            }
        }

        else if (sayi == 7)
        {
            kagit.SetActive(false);
            // Hedef konumun pozisyonunu al
            Vector3 targetPosition = targetTransform4.position;

            // K�p�n �u anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma do�ru y�nelim vekt�r�
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // K�p� hedefe do�ru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // E�er k�p hedefe �ok yakla�t�ysa, hareketi durdur
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

            // K�p�n �u anki konumu
            Vector3 currentPosition = transform.position;

            // Hedef konuma do�ru y�nelim vekt�r�
            Vector3 direction = (targetPosition - currentPosition).normalized;

            // K�p� hedefe do�ru hareket ettirme
            transform.position += direction * moveSpeed * Time.deltaTime;

            // E�er k�p hedefe �ok yakla�t�ysa, hareketi durdur
            if (Vector3.Distance(currentPosition, targetPosition) < 0.1f)
            {
                // Opsiyonel: Hareket tamamland���nda yap�lacak i�lemler
                Debug.Log("8");

                if (oldu == 1)
                {
                    pers.Seket();
                    Destroy(gameObject);
                }

                //enabled = false; // Bu script'i devre d��� b�rakarak hareketi durdurabilirsiniz.
            }




        }

    }
}
