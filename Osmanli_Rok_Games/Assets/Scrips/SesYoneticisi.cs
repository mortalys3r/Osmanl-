using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SesYoneticisi : MonoBehaviour
{
    public AudioMixer audioMixer; // Unity Edit�r�'nde atanacak
    public string grupParameterName = "music"; // Unity Edit�r�'nde atanacak
    public Slider slider; // Unity Edit�r�'nde atanacak

    private float minSliderValue = 0f;
    private float maxSliderValue = 100f;

    private void Start()
    {
        if (slider != null)
        {
            // Slider'�n de�er de�i�ikli�i dinleyicisini ekleyin
            slider.onValueChanged.AddListener(SesDuzeyiniAyarla);
        }
        else
        {
            Debug.LogError("Slider atanmam��!");
        }
    }

    public void SesDuzeyiniAyarla(float sesDuzeyi)
    {
        if (audioMixer != null && slider != null)
        {
            // Slider de�erini -80 ile 0 dB aras�na d�n��t�r ve audio mixer'a uygula
            float dbSesDuzeyi = Mathf.Lerp(-80f, 0f, (slider.value - minSliderValue) / (maxSliderValue - minSliderValue));
            audioMixer.SetFloat(grupParameterName, dbSesDuzeyi);
        }
        else
        {
            Debug.LogError("Audio Mixer veya Slider atanmam��!");
        }
    }
}
