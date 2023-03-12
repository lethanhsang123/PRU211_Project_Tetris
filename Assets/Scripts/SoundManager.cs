using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else 
        { 
            Load(); 
        }
        AmThanh = GetComponent<AudioSource>();
    }

    public void ChangeVolum()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

    private AudioClip DiChuyen;
    private AudioClip RoiXuong;
    private AudioClip Xoay;

    private AudioSource AmThanh;

    private void AmThanhDiChuyen()
    {
        AmThanh.PlayOneShot(DiChuyen);
    }
}
