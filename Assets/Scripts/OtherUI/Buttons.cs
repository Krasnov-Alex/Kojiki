using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private GameObject allUI;
    [SerializeField] private GameObject history;
    [SerializeField] private GameObject buildings;
    [SerializeField] private GameObject pauseFrame;
    [SerializeField] private Text unvisUIText;

    [SerializeField] private Card card;
    private int secretPower = 5;


    public void ReverseCard(GameObject reverseButton)
    {
        card.SecretPower();
        reverseButton.SetActive(false);
    }

    public void PauseGame()
    {
        if (pauseFrame.activeSelf)
        {
            pauseFrame.SetActive(false);
        }
        else
        {
            pauseFrame.SetActive(true);
        }
    }

    public void HistoryBuildings()
    {
        if (history.activeSelf) 
        {
            history.SetActive(false);
            buildings.SetActive(true);
        }
        else
        {
            history.SetActive(true);
            buildings.SetActive(false);
        }
    }

    public void UnvisUI()
    {
        if (allUI.activeSelf)
        {
            allUI.SetActive(false);
            unvisUIText.text = "Показать UI";
        }
        else
        {
            allUI.SetActive(true);
            unvisUIText.text = "Скрыть UI";
        }
        
    }

    public void Education()
    {
        SceneManager.LoadScene(2);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void BackButton(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenButton(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }
}