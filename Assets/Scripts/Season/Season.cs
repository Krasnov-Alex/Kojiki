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
    public int seasonNow = 1;

    public Text yearTXT;
    

    public int debuffSeason = 100;
    public float winterDebuffCoef = 1.5f;
    public float springDebuffCoef = 1f;
    public float summerDebuffCoef = 0.5f;
    public float autumnDebuffCoef = 1f;


    public float springCoef = 1f;
    public float winterCoef = 0.75f;
    public float autumnCoef = 1f;
    public float summerCoef = 1.25f;

    [SerializeField] private Gamover gamover;
    [SerializeField] private GodControl godControl;
    [SerializeField] private BuildCard buildCard;
    [SerializeField] private ResManager resManager;

    private void Start()
    {
        SetSeason();
        yearTXT.text = year.ToString();
    }

    public void CreateStep()
    {
        month++;
        if (((float)month -1) % 24 == 0)
        {
            year++;
            month = 1;
            yearTXT.text = year.ToString();
        }
        CheckAndDebuffSeason();
        SetSeason();
        if (year == 10)
        {
            gamover.GameOver(true);
        }
    }

    public void CheckAndDebuffSeason()
    {
        if (seasonNow != GetSeason())
        {
            resManager.SeasonSetRes(SeasonDebuff(seasonNow));
            seasonNow = GetSeason();
        }
    }

    public int SeasonDebuff(int atr)
    {
        switch (atr)
        {
            case 1:
                return (int)((float)debuffSeason * resManager.PeopleCoef() * winterDebuffCoef);
            case 2:
                return (int)((float)debuffSeason * resManager.PeopleCoef() * springDebuffCoef);
            case 3:
                return (int)((float)debuffSeason * resManager.PeopleCoef() * summerDebuffCoef);
            case 4:
                return (int)((float)debuffSeason * resManager.PeopleCoef() * autumnDebuffCoef);
        }
        return 1;
        
    }

    private void SetSeason()
    {
        switch (GetSeason())
        {
            case 1:
                seasonImg.sprite = winter;
                break;
            case 2:
                seasonImg.sprite = spring;
                break;
            case 3:
                seasonImg.sprite = summer;
                break;
            case 4:
                seasonImg.sprite = autumn;
                break;
        }
    }

    private int GetSeason()
    {
        if (month == 23 || month == 24 || month <= 4)
        {
            return 1;
        }
        else if (month >= 5 && month <= 10)
        {
            return 2;
        }
        else if (month >= 11 && month <= 16)
        {
            return 3;
        }
        else if (month >= 17 && month <= 22)
        {
            return 4;
        }
        return 1;
    }

    // (1) зимой коеф 0,75
    // (2) весной коеф 1
    // (3) летом коеф 1,25
    // (4) осень коеф 1


    public float SeasonCoef()
    {
        switch (GetSeason())
        {
            case 1:
                return winterCoef;
            case 2:
                return springCoef;
            case 3:
                return summerCoef;
            case 4:
                return autumnCoef;
            default:
                return 1;
        }
    }
}
