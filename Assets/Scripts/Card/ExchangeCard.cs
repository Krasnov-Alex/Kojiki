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
    [SerializeField] private GodControl godControl;

    [SerializeField] private Text pointRes1TXT;
    [SerializeField] private Text pointRes2TXT;
    [SerializeField] private Season season;

    public Image resSprite1;
    public Image resSprite2;
    public Sprite material;
    public Sprite eat;
    public Sprite happy;
    public Sprite people;
    public Sprite emptySpr;

    [SerializeField] private Text cardName;
    [SerializeField] private Text cardDescription;
    [SerializeField] private GodLog godLog;
    [SerializeField] private CardDesription description;

    public ResManager resManager;
    public int count = 4;

    private void Start()
    {
        //resManager = FindAnyObjectByType<ResManager>();
        UpdateCard();
    }

    private void Update()
    {
        //SetText();
    }
    public void SetText()
    {
        cardName.text = names[repositoryPosition];
        cardDescription.text = cardText[repositoryPosition];
        pointRes1TXT.text = AddRes().ToString();
        pointRes2TXT.text = ("+" + OutRes().ToString());
        SetSprite();
        
    }

    private void SetSprite()
    {
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

        switch (cardAtr[repositoryPosition])
        {
            case "Atr17":
                resSprite2.sprite = emptySpr;
                pointRes2TXT.text = "";
                break;
            case "Atr18":
                resSprite2.sprite = emptySpr;
                pointRes2TXT.text = "";
                break;
            case "Atr19":
                resSprite2.sprite = emptySpr;
                pointRes2TXT.text = "";
                break;
            case "Atr20":
                resSprite2.sprite = emptySpr;
                pointRes2TXT.text = "";
                break;
            case "Atr21":
                resSprite2.sprite = emptySpr;
                pointRes2TXT.text = "";
                break;
            default:
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
                break;
        }
        
    }

    private int AddRes()
    {
        return (int)((float)resCost1[repositoryPosition] - ((float)resManager.buffConst * season.SeasonCoef() * resManager.PeopleCoef()));
    }

    private int OutRes()
    {
        return (int)((float)resCost2[repositoryPosition] + ((float)resManager.buffConst * season.SeasonCoef() * resManager.PeopleCoef()));
    }

    

    public void Exchange()
    {
        TakeGods(cardAtr[repositoryPosition]);
        godLog.ExchangeCard(names[repositoryPosition], ReturnRes(OutRes(), resTypes2[repositoryPosition]),  ReturnRes(AddRes(), resTypes1[repositoryPosition]));
        resManager.SetRes(resTypes1[repositoryPosition], AddRes());
        resManager.SetRes(resTypes2[repositoryPosition], OutRes());
        card.UpdAnyCard();
        description.ReExchange();
    }

    private string ReturnRes(int num, string atr)
    {
        switch (atr)
        {
            case "Mat":
                return $"{num} материалов";
            case "Eat":
                return $"{num} пищи";
            case "Hap":
                return $"{num} счастья";
            case "Man":
                return $"{num} людей";
            default:
                return "удовлетворенность для богов";

        }
    }

    public void UpdateCard()
    {
        random = Random.Range(0, 21);
        repositoryPosition = random;
        SetText();
    }

    private void TakeGods(string atr)
    {
        switch (atr)
        {
            case "Atr1":
                CheckAndSetSatisfactionEx("God1", 2);
                CheckAndSetSatisfactionEx("God5", -2);
                break;
            case "Atr2":
                CheckAndSetSatisfactionEx("God1", 2);
                CheckAndSetSatisfactionEx("God5", -2);
                break;
            case "Atr3":
                CheckAndSetSatisfactionEx("God2", -2);
                CheckAndSetSatisfactionEx("God5", 2);
                break;
            case "Atr4":
                CheckAndSetSatisfactionEx("God2", -2);
                CheckAndSetSatisfactionEx("God3", 2);
                break;
            case "Atr5":
                CheckAndSetSatisfactionEx("God2", 2);
                CheckAndSetSatisfactionEx("God4", -2);
                break;
            case "Atr6":
                CheckAndSetSatisfactionEx("God2", 2);
                CheckAndSetSatisfactionEx("God3", -2);
                break;
            case "Atr7":
                CheckAndSetSatisfactionEx("God4", -2);
                CheckAndSetSatisfactionEx("God5", 2);
                break;
            case "Atr8":
                CheckAndSetSatisfactionEx("God1", 2);
                CheckAndSetSatisfactionEx("God4", -2);
                break;
            case "Atr9":
                CheckAndSetSatisfactionEx("God3", -2);
                CheckAndSetSatisfactionEx("God4", 2);
                break;
            case "Atr10":
                CheckAndSetSatisfactionEx("God1", -2);
                CheckAndSetSatisfactionEx("God5", 2);
                break;
            case "Atr11":
                CheckAndSetSatisfactionEx("God2", -2);
                CheckAndSetSatisfactionEx("God3", 2);
                break;
            case "Atr12":
                CheckAndSetSatisfactionEx("God1", -2);
                CheckAndSetSatisfactionEx("God4", 2);
                break;
            case "Atr13":
                CheckAndSetSatisfactionEx("God1", -2);
                CheckAndSetSatisfactionEx("God4", 2);
                break;
            case "Atr14":
                CheckAndSetSatisfactionEx("God2", 2);
                CheckAndSetSatisfactionEx("God3", -2);
                break;
            case "Atr15":
                CheckAndSetSatisfactionEx("God2", 2);
                CheckAndSetSatisfactionEx("God5", -2);
                break;
            case "Atr16":
                CheckAndSetSatisfactionEx("God2", -2);
                CheckAndSetSatisfactionEx("God3", 2);
                break;
            case "Atr17":
                CheckAndSetSatisfactionEx("God1", 3);
                CheckAndSetSatisfactionEx("God5", -3);
                break;
            case "Atr18":
                CheckAndSetSatisfactionEx("God2", 3);
                CheckAndSetSatisfactionEx("God3", -3);
                break;
            case "Atr19":
                CheckAndSetSatisfactionEx("God3", 3);
                CheckAndSetSatisfactionEx("God4", -3);
                break;
            case "Atr20":
                CheckAndSetSatisfactionEx("God2", -3);
                CheckAndSetSatisfactionEx("God4", 3);
                break;
            case "Atr21":
                CheckAndSetSatisfactionEx("God1", -3);
                CheckAndSetSatisfactionEx("God5", 3);
                break;

        }
    }

    private void CheckAndSetSatisfactionEx(string atr, int satis)
    {
        godSatisfaction = godControl.FindGods(atr);
        if (godSatisfaction != null)
        {
            godSatisfaction.SetSatisfaction(satis);
        }
        godSatisfaction = null;
    }

    public string ReturnOutResName()
    {
        return resTypes1[repositoryPosition];
    }

    public string ReturnAddResName()
    {
        return resTypes2[repositoryPosition];
    }

    public int ReturnOutResCost()
    {
        return AddRes();
    }

    public int ReturnAddResCost()
    {
        return OutRes();
    }

    public int ReturnOutResMean()
    {
        switch (resTypes1[repositoryPosition])
        {
            case "Mat":
                return resManager.mat;
            case "Eat":
                return resManager.eat;
            case "Hap":
                return resManager.hap;
            case "Man":
                return resManager.man;
            default:
                return -1;
        }
    }

    public int ReturnAddResMean()
    {
        switch (resTypes2[repositoryPosition])
        {
            case "Mat":
                return resManager.mat;
            case "Eat":
                return resManager.eat;
            case "Hap":
                return resManager.hap;
            case "Man":
                return resManager.man;
            default:
                return -1;
        }
    }
}
