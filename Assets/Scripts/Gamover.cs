using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamover : MonoBehaviour
{
    [SerializeField] private GameObject winWindow;
    [SerializeField] private GameObject overWindow;
    private bool isEndGame = false;
    public void GameOver(bool win)
    {
        if (win & !isEndGame)
        {
            winWindow.SetActive(true);
            isEndGame = true;
        }
        else if (!isEndGame)
        {
            overWindow.SetActive(true);
            isEndGame = true;
        }
    }
}
