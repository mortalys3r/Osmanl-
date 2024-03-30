using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Transform targetTransform, targetTransform2, targetTransform3; // Hedef konumu temsil eden bo� nesne (empty game object)
    public float moveSpeed = 5.0f;
    public int sayi = 0, oldu = 0, deneme = 0; // K�p�n h�z�n� ayarlay�n
    public Person pers;

    private void Update()
    {


        if (sayi == 0)
        {
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
                Debug.Log("K�p hedefe ula�t�!");
                if (oldu == 0)
                {
                    sayi = 1;
                }
                if (oldu == 1)
                {
                    sayi = 2;
                }

                //enabled = false; // Bu script'i devre d��� b�rakarak hareketi durdurabilirsiniz.
            }
        }
        else if (sayi == 1)
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
                // Opsiyonel: Hareket tamamland���nda yap�lacak i�lemler
                Debug.Log("K�p hedefe ula�t�!");
                pers.enabled = true;
                sayi = 4;
                oldu = 1;
                // Bu script'i devre d��� b�rakarak hareketi durdurabilirsiniz.
            }
        }
        else if (sayi == 2)
        {
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
                // Opsiyonel: Hareket tamamland���nda yap�lacak i�lemler
                enabled = false; // Bu script'i devre d��� b�rakarak hareketi durdurabilirsiniz.
            }
        }
        else if (sayi == 3)
        {
            // Y ekseninde yava� yava� 180 derece rotasyon yap
            float rotationSpeed = 60f; // D�nme h�z�
            float step = rotationSpeed * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 180f, 0f), step);
            if (transform.rotation == Quaternion.Euler(0f, 180f, 0f)) // E�er d�nme tamamland�ysa
            {
                sayi = 0; // say�y� s�f�rla veya ba�ka bir de�erle g�ncelle, kodunuzun mant���na ba�l� olarak
            }
        }
    }
}
