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
    //private int peopleResourcesAdd = 500;
    public int buffConst = 50;


    private int materialBuild = 1;
    private int foodBuild = 1;
    private int happyBuild = 1;
    private int peopleBuild = 1;

    private int templeIg = 1; // ��������� ���������� ������ ��������
    private int templeIm = 1; // ��������� ���������� ������ ��������
    private int templeAm = 0; // ��������� ���������� ������ ���������
    private int templeCu = 0; // ��������� ���������� ������ �������
    private int templeSu = 0; // ��������� ���������� ������ �������
    private int templeTk = 0; // ��������� ���������� ������ �������������
    private int templeOk = 0; // ��������� ���������� ������ ���������
    private int templeEb = 0; // ��������� ���������� ������ �����

    public Text eatTXT;
    public Text hapTXT;
    public Text matTXT;
    public Text manTXT;
    public Text debuffTXT;

    public Season season;

    private void Start()
    {
        //season = FindAnyObjectByType<Season>();
        //gamover = FindAnyObjectByType<Gamover>();
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
    //        materialResourcesNew = materialResources + (((materialBuildNew * cardTakeNum) * peopleCoefNew) * seasonCoef); // ����� ���������� �������� � ����������� �� ���������� ������ ���� ��������, ������ �������� ������, ��������� �� ��������� � ��������� ������


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

    //private void GameOver()
    //{
    //    gamover.SetActive(true);
    //}

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
                SetRes("Man", (int)(500f/Coef("Man")));
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
