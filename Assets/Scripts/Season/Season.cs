using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Season : MonoBehaviour
{
    [SerializeField] private Image seasonImg;
    [SerializeField] private Sprite summer;
    [SerializeField] private Sprite autumn;
    [SerializeField] private Sprite spring;
    [SerializeField] private Sprite winter;
    public int year = 1; 
    public int month = 1;
    public Text yearTXT;


    private Gamover gamover;

    private void Start()
    {
        SetSeason();
        gamover = FindAnyObjectByType<Gamover>();
        yearTXT.text = year.ToString();
    }

    public void CreateStep()
    {
        month++;
        if (((float)month -1) % 12 == 0)
        {
            year++;
            month = 1;
            yearTXT.text = year.ToString();
        }
        SetSeason();
        if (year == 10)
        {
            gamover.GameOver(true);
        }
    }

    private void SetSeason()
    {
        if (month == 12 || month <= 2)
        {
            seasonImg.sprite = winter;
        }
        else if (month >= 3 && month <= 5)
        {
            seasonImg.sprite = spring;
        }
        else if (month >= 6 && month <= 8)
        {
            seasonImg.sprite = summer;
        }
        else if (month >= 9 && month <= 11)
        {
            seasonImg.sprite = autumn;
        }
    }
}
