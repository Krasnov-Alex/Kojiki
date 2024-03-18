using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class BuildCard : MonoBehaviour
{
    public int repositoryPosition;
    public string[] names;
    public string[] cartText;
    public GameObject[] houses;
    public string[] typeHouse;
    public int[] gods = new int[8];
    public string[] cardAtr;
    public int buildCost = -300;
    public string houseMat = "Mat";
    private int random;
    public Card card;
    private GodSatisfaction godSatisfaction;
    private GodControl godControl;

    public ResManager resManager;
    public GameObject ground;
    public int count = 6;

    

    private void Start()
    {
        gods[0] = 0;
        gods[1] = 1;
        ChangeCard();
        resManager = FindAnyObjectByType<ResManager>();
        godControl = FindAnyObjectByType<GodControl>();
        SetText();
    }

    private void Update()
    {
        //SetText();
    }
    private void SetText()
    {
        GameObject TextCart;

        TextCart = this.gameObject.transform.GetChild(3).gameObject;
        TextCart.GetComponent<Text>().text = names[repositoryPosition];

        TextCart = this.gameObject.transform.GetChild(1).gameObject;
        TextCart.GetComponent<Text>().text = cartText[repositoryPosition];

        TextCart = this.gameObject.transform.GetChild(2).gameObject;
        TextCart.GetComponent<Text>().text = buildCost.ToString();

        //switch (resTypes[repositoryPosition])
        //{
        //    case "Mat":
        //        resSprite.sprite = material;
        //        break;
        //    case "Hap":
        //        resSprite.sprite = happy;
        //        break;
        //    case "Man":
        //        resSprite.sprite = people;
        //        break;
        //    case "Eat":
        //        resSprite.sprite = eat;
        //        break;
        //}
    }

    public void NewAdd()
    {
        GameObject target = ground.gameObject.transform.GetChild(count).gameObject;
        GameObject newHouse = Instantiate(houses[repositoryPosition], target.transform.position, Quaternion.identity);
        count++;
        TakeGods(cardAtr[repositoryPosition]);
        resManager.SetRes(houseMat, buildCost);
        resManager.AddBuild(typeHouse[repositoryPosition]);
        card.UpdAnyCard();
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
                repositoryPosition = 8;
                break;
            case 2:
                repositoryPosition = 9;
                break;
            case 3:
                repositoryPosition = 10;
                break;
            case 4:
                repositoryPosition = 11;
                break;
            case 5:
                repositoryPosition = 12;
                break;
            case 6:
                repositoryPosition = 13;
                break;
            case 7:
                repositoryPosition = 14;
                break;
            case 8:
                repositoryPosition = 15;
                break;
            case 9:
                random = Random.Range(0, (gods.Length + 1));
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
                break;
            case "God2":
                CheckAndSetSatisfaction(atr, 10);
                break;
            case "God3":
                CheckAndSetSatisfaction(atr, 10);
                break;
            case "God4":
                CheckAndSetSatisfaction(atr, 10);
                break;
            case "God5":
                CheckAndSetSatisfaction(atr, 10);
                break;
            case "God6":
                CheckAndSetSatisfaction(atr, 10);
                break;
            case "God7":
                CheckAndSetSatisfaction(atr, 10);
                break;
            case "God8":
                CheckAndSetSatisfaction(atr, 10);
                break;
            case "God11":
                CheckAndSetSatisfaction("God1", 5);
                break;
            case "God21":
                CheckAndSetSatisfaction("God2", 5);
                break;
            case "God31":
                CheckAndSetSatisfaction("God3", 5);
                break;
            case "God41":
                CheckAndSetSatisfaction("God4", 5);
                break;
            case "God51":
                CheckAndSetSatisfaction("God5", 5);
                break;
            case "God61":
                CheckAndSetSatisfaction("God6", 5);
                break;
            case "God71":
                CheckAndSetSatisfaction("God7", 5);
                break;
            case "God81":
                CheckAndSetSatisfaction("God8", 5);
                break;
        }
    }

    private void CheckAndSetSatisfaction(string atr, int satis)
    {
        
        if (godControl.FindGods(atr) != null)
        {
            godSatisfaction = godControl.FindGods(atr);
            godSatisfaction.SetSatisfaction(satis);
        }
        godSatisfaction = null;
    }
}
