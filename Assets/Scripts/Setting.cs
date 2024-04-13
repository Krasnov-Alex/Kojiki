using System;
using Unity.VisualScripting;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public float musicVolume = 0.5f;
    public float soundVolume = 0.5f;
    [SerializeField] private AudioInGame audioInGame;

    private void Start()
    {
        if (PlayerPrefs.HasKey("music"))
        {
            LoadAudioSetting();
        }
    }

    public void LoadAudioSetting()
    {
        musicVolume = PlayerPrefs.GetFloat("music");
        soundVolume = PlayerPrefs.GetFloat("sound");
    }


    public void SaveAudioSetting()
    {
        PlayerPrefs.SetFloat("music", musicVolume);
        PlayerPrefs.SetFloat("sound", soundVolume);
    }

    private void OnApplicationQuit()
    {
        SaveAudioSetting();
    }

    public void SettingVolume(float volumeSound, float volumeAudio)
    {
        soundVolume = volumeSound;
        musicVolume = volumeAudio;
        SaveAudioSetting();
        audioInGame.SetAudioVolume();
    }
}

//public class Saver
//{
//    public static float musicVolume = 0.5f;
//    public static float soundVolume = 0.5f;

//    public static float SaverMusicVolume
//    {
//        get { return musicVolume; }
//        set { musicVolume = value; }
//    }

//    public static float SaverSoundVolume
//    {
//        get { return soundVolume; }
//        set { soundVolume = value; }
//    }
//}
