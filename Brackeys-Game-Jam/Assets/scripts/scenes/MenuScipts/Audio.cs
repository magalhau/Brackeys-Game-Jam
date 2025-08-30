using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Audio : MonoBehaviour
{
    [SerializeField] Slider Slidervolume;
    void Start()
    {
        if (!PlayerPrefs.HasKey("volumemusica"))
        {
            PlayerPrefs.SetFloat("volumemusica" , 1);
            Load();
        }

        else
        {
            Load();
        }


    }

    public void MudarVolume()
    {
        AudioListener.volume = Slidervolume.value;
        Save();
    }

    private void Load()
    {
        Slidervolume.value = PlayerPrefs.GetFloat("volumemusica");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("volumemusica", Slidervolume.value);
    }
}
