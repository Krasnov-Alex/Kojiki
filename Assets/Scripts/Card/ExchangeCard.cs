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
        godControl = FindAnyObjectByType<GodControl>();
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
        TextCart.GetComponent<Text>().text = (resCost1[repositoryPosition] * -1).ToString();

        TextCart = this.gameObject.transform.GetChild(4).gameObject;
        TextCart.GetComponent<Text>().text = resCost2[repositoryPosition].ToString();

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
        TakeGods(cardAtr[repositoryPosition]);
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
            case "Atr1":
                CheckAndSetSatisfaction("God1", 2);
                break;
            case "Atr2":
                break;
            case "Atr3":
                CheckAndSetSatisfaction("God4", 2);
                break;
            case "Atr4":
                CheckAndSetSatisfaction("God7", -2);
                break;
            case "Atr5":
                CheckAndSetSatisfaction("God2", 2);
                break;
            case "Atr6":
                CheckAndSetSatisfaction("God6", -2);
                break;
            case "Atr7":
                break;
            case "Atr8":
                CheckAndSetSatisfaction("God7", 2);
                break;
            case "Atr9":
                CheckAndSetSatisfaction("God5", -2);
                break;
            case "Atr10":
                CheckAndSetSatisfaction("God2", -2);
                break;
            case "Atr11":
                break;
            case "Atr12":
                CheckAndSetSatisfaction("God1", -2);
                break;
            case "Atr13":
                CheckAndSetSatisfaction("God8", 2);
                break;
            case "Atr14":
                CheckAndSetSatisfaction("God3", -2);
                break;
            case "Atr15":
                break;
            case "Atr16":
                CheckAndSetSatisfaction("God4", -2);
                break;
            case "Atr17":
                CheckAndSetSatisfaction("God3", 2);
                break;
            case "Atr18":
                CheckAndSetSatisfaction("God5", 2);
                break;
            case "Atr19":
                CheckAndSetSatisfaction("God8", -2);
                break;
            case "Atr20":
                CheckAndSetSatisfaction("God6", 2);
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
