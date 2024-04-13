using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioInGame : MonoBehaviour
{
    [SerializeField] private AudioSource backGameSound;
    [SerializeField] private AudioSource backMenuSound;
    [SerializeField] private AudioSource buttonClick;
    [SerializeField] private AudioSource godBuff;
    [SerializeField] private AudioSource godDebuff;
    [SerializeField] private AudioSource paperButtonClick;
    [SerializeField] private AudioSource screamer;
    [SerializeField] private AudioSource cardDeal;
    [SerializeField] private AudioSource cardShuffle;
    [SerializeField] private AudioSource nightSound;
    [SerializeField] private AudioSource winAudio;
    [SerializeField] private Setting settingGame;

    [SerializeField] private Text musicText;
    [SerializeField] private Text soundText;

    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider soundSlider;

    private void Start()
    {
        settingGame.LoadAudioSetting();
        SetAudioVolume();
        PlayBackSound(false);
    }

    private void Update()
    {
        musicText.text = ((int)(musicSlider.value * 100)).ToString();
        soundText.text = ((int)(soundSlider.value * 100)).ToString();
        settingGame.SettingVolume(soundSlider.value, musicSlider.value);
    }


    public void AudioWinPlay()
    {
        winAudio.Play();
    }


    public void ScreamerPlay()
    {
        screamer.Play();
    }

    public void NightSoundPlay(bool playing)
    {
        if (playing)
        {
            nightSound.Play();
        }
        else
        {
            nightSound.Stop();
        }
    }

    public void DebuffGod()
    {
        godDebuff.Play();
    }

    public void BuffGod()
    {
        godBuff.Play();
    }

    public void ClickPaperButton()
    {
        paperButtonClick.Play();
    }

    public void ClickButton()
    {
        buttonClick.Play();
    }

    public void SetAudioVolume()
    {
        backGameSound.volume = settingGame.musicVolume / 2;
        backMenuSound.volume = settingGame.musicVolume / 2;
        buttonClick.volume = settingGame.soundVolume;
        godBuff.volume = settingGame.soundVolume;
        godDebuff.volume = settingGame.soundVolume * 1.5f;
        paperButtonClick.volume = settingGame.soundVolume;
        screamer.volume = settingGame.musicVolume;
        cardDeal.volume = settingGame.soundVolume;
        cardShuffle.volume = settingGame.soundVolume;
        nightSound.volume = settingGame.musicVolume;
    }

    public void PlayBackSound(bool win)
    {
        if (!win)
        {

            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                backMenuSound.Play();
            }
            else
            {
                backGameSound.Play();
            }
        }
        else
        {
            backGameSound.Stop();
            backMenuSound.Stop();
        }
    }

    
}
