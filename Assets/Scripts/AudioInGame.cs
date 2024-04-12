using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    [SerializeField] private Setting settingGame;

    private void Start()
    {
        SetAudioVolume();
        PlayBackSound();
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
        backGameSound.volume = settingGame.musicVolume;
        backMenuSound.volume = settingGame.musicVolume;
        buttonClick.volume = settingGame.soundVolume;
        godBuff.volume = settingGame.soundVolume;
        godDebuff.volume = settingGame.soundVolume;
        paperButtonClick.volume = settingGame.soundVolume;
        screamer.volume = settingGame.musicVolume;
        cardDeal.volume = settingGame.soundVolume;
        cardShuffle.volume = settingGame.soundVolume;
        nightSound.volume = settingGame.musicVolume;
    }

    public void PlayBackSound()
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
}
