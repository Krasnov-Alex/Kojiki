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

    private void Start()
    {
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

    //private void GameOver()
    //{
    //    gamover.SetActive(true);
    //}

    public void SetRes(string material, int cost)
    {
        if (material == "Eat")
        {
            eat += cost;
        }
        else if (material == "Mat")
        {
            mat += cost;
        }
        else if (material == "Hap")
        {
            hap += cost;
        }
        else if(material == "Man")
        {
            man += cost;
        }
    }

    private void TextUpdate()
    {
        eatTXT.text = eat.ToString();
        hapTXT.text = hap.ToString();
        matTXT.text = mat.ToString();
        manTXT.text = man.ToString();
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
