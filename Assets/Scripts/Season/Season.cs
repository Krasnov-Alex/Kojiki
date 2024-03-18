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
    private bool isGodSeason = false;
    public int year = 1; 
    public int month = 1;
    public Text yearTXT;


    private Gamover gamover;
    private GodControl godControl;
    private BuildCard buildCard;

    private void Start()
    {
        SetSeason();
        gamover = FindAnyObjectByType<Gamover>();
        godControl = FindAnyObjectByType<GodControl>();
        buildCard = FindAnyObjectByType<BuildCard>();
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

        if (month == 6 && !isGodSeason)
        {
            godControl.SetGod("God3");
            godControl.SetGod("God4");
            buildCard.AddGod(3);
            buildCard.AddGod(4);
            isGodSeason = true;
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
