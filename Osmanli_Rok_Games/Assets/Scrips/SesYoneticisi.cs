using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SesYoneticisi : MonoBehaviour
{
    public AudioMixer audioMixer; // Unity Editörü'nde atanacak
    public string grupParameterName = "music"; // Unity Editörü'nde atanacak
    public Slider slider; // Unity Editörü'nde atanacak

    private float minSliderValue = 0f;
    private float maxSliderValue = 100f;

    private void Start()
    {
        if (slider != null)
        {
            // Slider'ýn deðer deðiþikliði dinleyicisini ekleyin
            slider.onValueChanged.AddListener(SesDuzeyiniAyarla);
        }
        else
        {
            Debug.LogError("Slider atanmamýþ!");
        }
    }

    public void SesDuzeyiniAyarla(float sesDuzeyi)
    {
        if (audioMixer != null && slider != null)
        {
            // Slider deðerini -80 ile 0 dB arasýna dönüþtür ve audio mixer'a uygula
            float dbSesDuzeyi = Mathf.Lerp(-80f, 0f, (slider.value - minSliderValue) / (maxSliderValue - minSliderValue));
            audioMixer.SetFloat(grupParameterName, dbSesDuzeyi);
        }
        else
        {
            Debug.LogError("Audio Mixer veya Slider atanmamýþ!");
        }
    }
}
