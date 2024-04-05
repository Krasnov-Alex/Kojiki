using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class BuildCard : MonoBehaviour
{
    public int repositoryPosition;
    public string[] names;
    public string[] cartText;
    public GameObject[] houses;
    public string[] typeHouse;
    public int[] gods = new int[5];
    public string[] cardAtr;
    public int buildCost = -300;
    public string houseMat = "Mat";
    private int random;
    public Card card;
    private GodSatisfaction godSatisfaction;
    [SerializeField] private GodControl godControl;
    [SerializeField] private Season season;

    public ResManager resManager;
    public GameObject ground;
    public int count = 4;

    [SerializeField] private Text cardName;
    [SerializeField] private Text cardDescription;
    [SerializeField] private Text cardPoint;
    [SerializeField] private GodLog godLog;
    [SerializeField] private BuildCount buildCount;

    private void Start()
    {
        gods[0] = 0;
        gods[1] = 1;
        ChangeCard();
        //resManager = FindAnyObjectByType<ResManager>();
        //godControl = FindAnyObjectByType<GodControl>();
        SetText();
    }



    public void SetText()
    {
        cardName.text = names[repositoryPosition];
        cardDescription.text = cartText[repositoryPosition];
        cardPoint.text = (-BuildCoeff()).ToString();
    }

    public int BuildCoeff()
    {
        return -(int)((float)buildCost - ((float)resManager.buffConst * resManager.PeopleCoef()));
    }

    public void Build()
    {
        TakeGods(cardAtr[repositoryPosition]);
        NewBuildAdd();
        godLog.BuildCard(names[repositoryPosition], -BuildCoeff());
        resManager.SetRes(houseMat, -BuildCoeff());
        resManager.AddBuild(typeHouse[repositoryPosition]);
        card.UpdAnyCard();
    }

    public void NewBuildAdd()
    {
        GameObject target = ground.gameObject.transform.GetChild(count).gameObject;
        GameObject newHouse = Instantiate(houses[repositoryPosition], target.transform.position, Quaternion.identity);
        count++;
    }

    public void UpdateCard()
    {
        ChangeCard();
        SetText();
    }

    private void ChangeCard()
    {
        random = Random.Range(0, 10);
        switch (random)
        {
            case 1:
                repositoryPosition = 5;
                break;
            case 2:
                repositoryPosition = 6;
                break;
            case 3:
                repositoryPosition = 7;
                break;
            case 4:
                repositoryPosition = 8;
                break;
            case 5:
                repositoryPosition = 9;
                break;
            case 6:
                repositoryPosition = 10;
                break;
            case 7:
                repositoryPosition = 11;
                break;
            case 8:
                repositoryPosition = 12;
                break;
            case 9:
                random = Random.Range(0, 5);
                repositoryPosition = random;
                break;
        }
    }

    private void TakeGods(string atr)
    {
        switch (atr)
        {
            case "God1":
                CheckAndSetSatisfaction(atr, 10);
                CheckAndSetSatisfaction("God5", -5);
                buildCount.templeIg++;
                buildCount.AddBuild();
                break;
            case "God2":
                CheckAndSetSatisfaction(atr, 10);
                CheckAndSetSatisfaction("God3", -5);
                buildCount.templeIm++;
                buildCount.AddBuild();
                break;
            case "God3":
                CheckAndSetSatisfaction(atr, 10);
                CheckAndSetSatisfaction("God4", -5);
                buildCount.templeAm++;
                buildCount.AddBuild();
                break;
            case "God4":
                CheckAndSetSatisfaction(atr, 10);
                CheckAndSetSatisfaction("God2", -5);
                buildCount.templeCu++;
                buildCount.AddBuild();
                break;
            case "God5":
                CheckAndSetSatisfaction(atr, 10);
                CheckAndSetSatisfaction("God1", -5);
                buildCount.templeSu++;
                buildCount.AddBuild();
                break;
            case "God11":
                CheckAndSetSatisfaction("God3", 5);
                buildCount.kazarmaBuild++;
                buildCount.AddBuild();
                break;
            case "God21":
                CheckAndSetSatisfaction("God2", 5);
                buildCount.lifeDomBuild++;
                buildCount.AddBuild();
                break;
            case "God31":
                CheckAndSetSatisfaction("God1", 5);
                buildCount.baniBuild++;
                buildCount.AddBuild();
                break;
            case "God41":
                CheckAndSetSatisfaction("God1", 1);
                CheckAndSetSatisfaction("God2", 1);
                CheckAndSetSatisfaction("God5", 1);
                CheckAndSetSatisfaction("God4", 2);
                buildCount.theaterBuild++;
                buildCount.AddBuild();
                break;
            case "God51":
                CheckAndSetSatisfaction("God3", 1);
                CheckAndSetSatisfaction("God1", 2);
                CheckAndSetSatisfaction("God2", 2);
                buildCount.riceFieldBuild++;
                buildCount.AddBuild();
                break;
            case "God61":
                CheckAndSetSatisfaction("God5", 5);
                buildCount.wellBuild++;
                buildCount.AddBuild();
                break;
            case "God71":
                CheckAndSetSatisfaction("God4", 5);
                buildCount.quarriesBuild++;
                buildCount.AddBuild();
                break;
            case "God81":
                CheckAndSetSatisfaction("God5", 2);
                CheckAndSetSatisfaction("God4", 1);
                CheckAndSetSatisfaction("God3", 2);
                buildCount.sawBuild++;
                buildCount.AddBuild();
                break;
        }
    }

    private void CheckAndSetSatisfaction(string atr, int satis)
    {
        godSatisfaction = godControl.FindGods(atr);
        godSatisfaction.SetSatisfaction(satis);
        godSatisfaction = null;
    }
}
