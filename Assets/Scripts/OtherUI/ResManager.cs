using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResManager : MonoBehaviour
{
    [SerializeField] private Gamover gamover;

    public int eat = 1000;
    public int mat = 1000;
    public int hap = 1000;
    public int man = 1000;

    private int peopleCoefConst = 1000;
    public int buffConst = 50;


    private int materialBuild = 1;
    private int foodBuild = 1;
    private int happyBuild = 1;
    private int peopleBuild = 1;

    private int templeIg = 0; // начальное количество храмов Идзанаги
    private int templeIm = 0; // начальное количество храмов Идзанами
    private int templeAm = 0; // начальное количество храмов Аматерасу
    private int templeCu = 0; // начальное количество храмов Цукуеми
    private int templeSu = 0; // начальное количество храмов Сусаноо

    public Text eatTXT;
    public Text hapTXT;
    public Text matTXT;
    public Text manTXT;
    public Text debuffTXT;

    public Season season;

    private void Start()
    {
        TextUpdate();
    }

    private void Update()
    {
        

        if (eat < 0 || mat < 0 || hap < 0)
        {
            gamover.GameOver(false);
        }
    }

    public float Coef(string atr)
    {
        
        switch (atr)
        {
            case "Mat":
                //Debug.Log("materialBuild " + materialBuild + " PeopleCoef " + PeopleCoef() + " SeasonCoef " + season.SeasonCoef());
                return ((float)materialBuild * PeopleCoef() * season.SeasonCoef());
            case "Man":
                //Debug.Log("peopleBuild " + peopleBuild + " PeopleCoef " + PeopleCoef() + " SeasonCoef " + season.SeasonCoef());
                return ((float)peopleBuild * PeopleCoef() * season.SeasonCoef());
            case "Eat":
                //Debug.Log("foodBuild " + foodBuild + " PeopleCoef " + PeopleCoef() + " SeasonCoef " + season.SeasonCoef());
                return ((float)foodBuild * PeopleCoef() * season.SeasonCoef());
            case "Hap":
                //Debug.Log("happyBuild " + happyBuild + " PeopleCoef " + PeopleCoef() + " SeasonCoef " + season.SeasonCoef());
                return ((float)happyBuild * PeopleCoef() * season.SeasonCoef());
            default: 
                return 1;
        }

        //return (int)1.5f;
        
    }

    public float PeopleCoef()
    {
        return (float)((float)man / (float)peopleCoefConst);
    }

    public void SetRes(string material, int cost)
    {
        if (material == "Eat")
        {
            eat += (int)((float)cost);
        }
        else if (material == "Mat")
        {
            mat += (int)((float)cost);
        }
        else if (material == "Hap")
        {
            hap += (int)((float)cost);
        }
        else if(material == "Man")
        {
            man += (int)((float)cost);
        }
        TextUpdate();
    }

    public void SeasonSetRes(int atr)
    {
        SetRes("Mat", atr * -1);
        SetRes("Hap", atr * -1);
        SetRes("Eat", atr * -1);
        TextUpdate();
    }

    public void TextUpdate()
    {
        eatTXT.text = eat.ToString();
        hapTXT.text = hap.ToString();
        matTXT.text = mat.ToString();
        manTXT.text = man.ToString();
        debuffTXT.text = season.SeasonDebuff(season.seasonNow).ToString();
    }

    public int ReturnCountBuilds(string atr)
    {
        switch (atr)
        {
            case "Mat":
                return materialBuild;
            case "Man":
                return peopleBuild;
            case "Eat":
                return foodBuild;
            case "Hap":
                return happyBuild;
            default:
                return 1;
        }
    }

    public void AddBuild(string atr)
    {
        switch (atr)
        {
            case "God1":
                templeIg++;
                break;
            case "God2":
                templeIm++;
                break;
            case "God3":
                templeAm++;
                break;
            case "God4":
                templeCu++;
                break;
            case "God5":
                templeSu++;
                break;
            case "Mat":
                materialBuild++;
                break;
            case "Eat":
                foodBuild++;
                break;
            case "Hap":
                happyBuild++;
                break;
            case "Man":
                peopleBuild++;
                SetRes("Man", 500);
                break;

        }
    }

    public int ExtractionCoef(string atr)
    {
        switch (atr)
        {
            case "Mat":
                return materialBuild;
            case "Hap":
                return happyBuild;
            case "Eat":
                return foodBuild;
        }
        return 1;
    }
}
