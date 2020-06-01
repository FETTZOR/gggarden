using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.8f;
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
    }

    // Update is called once per frame
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayerScr>();
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }    
        else
        {
            Debug.Log("OptionsControllerVolumeSetElse");
        }    
    }
    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<LevelLoader>().MainMenu();
    }
    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
    }    
}
