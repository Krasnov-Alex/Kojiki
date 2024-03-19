using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExchangeCard : MonoBehaviour
{
    public int repositoryPosition;
    public string[] names;
    public string[] cardText;
    public string[] resTypes1;
    public string[] resTypes2;
    public int[] resCost1;
    public int[] resCost2;
    public string[] cardAtr;
    private int random;
    public Card card;
    private GodSatisfaction godSatisfaction;
    private GodControl godControl;

    public Image resSprite1;
    public Image resSprite2;
    public Sprite material;
    public Sprite eat;
    public Sprite happy;
    public Sprite people;

    public ResManager resManager;
    public int count = 4;

    private void Start()
    {
        resManager = FindAnyObjectByType<ResManager>();
        UpdateCard();
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
        TextCart.GetComponent<Text>().text = cardText[repositoryPosition];

        TextCart = this.gameObject.transform.GetChild(2).gameObject;
        TextCart.GetComponent<Text>().text = ((resCost1[repositoryPosition] * (resManager.Coef(resTypes1[repositoryPosition]))) * -1).ToString();

        TextCart = this.gameObject.transform.GetChild(4).gameObject;
        TextCart.GetComponent<Text>().text = (resCost2[repositoryPosition] * (resManager.Coef(resTypes2[repositoryPosition]))).ToString();

        switch (resTypes1[repositoryPosition])
        {
            case "Mat":
                resSprite1.sprite = material;
                break;
            case "Hap":
                resSprite1.sprite = happy;
                break;
            case "Man":
                resSprite1.sprite = people;
                break;
            case "Eat":
                resSprite1.sprite = eat;
                break;
        }
        switch (resTypes2[repositoryPosition])
        {
            case "Mat":
                resSprite2.sprite = material;
                break;
            case "Hap":
                resSprite2.sprite = happy;
                break;
            case "Man":
                resSprite2.sprite = people;
                break;
            case "Eat":
                resSprite2.sprite = eat;
                break;
        }
    }

    public void Exchange()
    {
        //TakeGods(cardAtr[repositoryPosition]);
        resManager.SetRes(resTypes2[repositoryPosition], resCost1[repositoryPosition] * -1);
        resManager.SetRes(resTypes1[repositoryPosition], resCost2[repositoryPosition]);
        card.UpdAnyCard();
    }

    public void UpdateCard()
    {
        random = Random.Range(0, 18);
        repositoryPosition = random;
        SetText();
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
        godSatisfaction = godControl.FindGods(atr);
        if (godSatisfaction != null)
        {
            godSatisfaction.SetSatisfaction(satis);
        }
        godSatisfaction = null;
    }
}
