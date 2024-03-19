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


    //private int materialResourcesNew;
    //private int foodResourcesNew;
    //private int happyResourcesNew;
    //private int peopleResoursesLast = 1000;
    //private int peopleCoef; // = peopleResoursesLast / 1000;
    //private int peopleResourcesAdd = 500;

    private int peopleCoefConst = 1000;
    // private int peopleCoef; // = peopleResoursesLast / 1000;
    private int peopleResourcesAdd = 500;


    private int materialBuild = 1;
    private int foodBuild = 1;
    private int happyBuild = 1;
    private int peopleBuild = 1;

    private int templeIg = 1; // начальное количество храмов Идзанаги
    private int templeIm = 1; // начальное количество храмов Идзанами
    private int templeAm = 0; // начальное количество храмов Аматерасу
    private int templeCu = 0; // начальное количество храмов Цукуеми
    private int templeSu = 0; // начальное количество храмов Сусаноо
    private int templeTk = 0; // начальное количество храмов Такэмикадзуси
    private int templeOk = 0; // начальное количество храмов Окунинуси
    private int templeEb = 0; // начальное количество храмов Эбису

    public Text eatTXT;
    public Text hapTXT;
    public Text matTXT;
    public Text manTXT;
    public Text debuffTXT;

    private Season season;

    private void Start()
    {
        season = FindAnyObjectByType<Season>();
        gamover = FindAnyObjectByType<Gamover>();
        TextUpdate();
    }

    private void Update()
    {
        TextUpdate();

        if (eat < 0 || mat < 0 || hap < 0)
        {
            gamover.GameOver(false);
        }
    }
    //      if cardTake = 1
    //        materialResourcesNew = materialResources + (((materialBuildNew * cardTakeNum) * peopleCoefNew) * seasonCoef); // новое количество ресурсов в зависимости от количества зданий этих ресурсов, выбора карточки добычи, множителя от населения и множителя сезона

    public int Coef(string atr)
    {
        //return (int)1.5f;
        return atr switch
        {
            "Mat" => (int)((float)materialBuild * PeopleCoef()),
            "Man" => (int)((float)peopleBuild * PeopleCoef()),
            "Eat" => (int)((float)foodBuild * PeopleCoef()),
            "Hap" => (int)((float)happyBuild * PeopleCoef()),
            _ => 1,
        };
    }

    public float PeopleCoef()
    {
        return (float)((float)man / (float)peopleCoefConst);
    }

    //private void GameOver()
    //{
    //    gamover.SetActive(true);
    //}

    public void SetRes(string material, int cost)
    {
        if (material == "Eat")
        {
            eat += (int)((float)cost * Coef(material));
        }
        else if (material == "Mat")
        {
            mat += (int)((float)cost * Coef(material));
        }
        else if (material == "Hap")
        {
            hap += (int)((float)cost * Coef(material));
        }
        else if(material == "Man")
        {
            man += (int)((float)cost * Coef(material));
        }
    }

    

    public void SeasonSetRes(int atr)
    {
        SetRes("Mat", atr * -1);
        SetRes("Hap", atr * -1);
        SetRes("Eat", atr * -1);
    }

    private void TextUpdate()
    {
        eatTXT.text = eat.ToString();
        hapTXT.text = hap.ToString();
        matTXT.text = mat.ToString();
        manTXT.text = man.ToString();
        debuffTXT.text = season.SeasonDebuff(season.seasonNow).ToString();
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
            case "God6":
                templeTk++;
                break;
            case "God7":
                templeOk++;
                break;
            case "God8":
                templeEb++;
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
