using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtractionCard : MonoBehaviour
{
    public int repositoryPosition;
    public string[] names;
    public string[] cardText;
    public string[] resTypes;
    public int[] resCosts;
    public string[] cardAtr;
    public int resCost = 1;
    private int random;
    public Card card;
    [SerializeField] private Season season;

    public Image resSprite;
    public Sprite material;
    public Sprite eat;
    public Sprite happy;
    public Sprite people;

    public ResManager resManager;
    [SerializeField] private GodControl godControl;
    public GameObject ground;
    public GameObject house;
    public int count = 4;

    [SerializeField] private Text cardName;
    [SerializeField] private Text cardDescription;
    [SerializeField] private Text cardPoint1;
    [SerializeField] private GodLog godLog;
    [SerializeField] private CardDesription description;

    private void Start()
    {
        UpdateCard();
    }

    public void SetText()
    {
        cardName.text = names[repositoryPosition];
        cardDescription.text = cardText[repositoryPosition];
        cardPoint1.text = ("+" + ExtractionCoeff().ToString());
        SetSprite();
    }

    private void SetSprite()
    {
        switch (resTypes[repositoryPosition])
        {
            case "Mat":
                resSprite.sprite = material;
                break;
            case "Hap":
                resSprite.sprite = happy;
                break;
            case "Man":
                resSprite.sprite = people;
                break;
            case "Eat":
                resSprite.sprite = eat;
                break;
        }
    }

    private int ExtractionCoeff()
    {
        return (int)((float)resCosts[repositoryPosition] + ((float)resManager.buffConst * ((float)resManager.ReturnCountBuilds(resTypes[repositoryPosition]) - 1) * season.SeasonCoef() * resManager.PeopleCoef()));
    }

    public void Extraction()
    {
        resManager.SetRes(resTypes[repositoryPosition], ExtractionCoeff());
        godLog.ExtractionCard(names[repositoryPosition], ExtractionCoeff(), ReturnRes());
        SetSatisfactionEx();
        card.UpdAnyCard();
        description.ReExtraction();
    }

    private string ReturnRes()
    {
        switch (resTypes[repositoryPosition])
        {
            case "Mat":
                return "материалов";
            case "Eat":
                return "пищи";
            case "Hap":
                return "счастья";
            case "Man":
                return "людей";
            default:
                return $"какой-то баг{resTypes[repositoryPosition]}";

        }
    }

    private void SetSatisfactionEx()
    {
        for (int i = 0; i < 5; i++)
        {
            godControl.gods[i].SetSatisfaction(godControl.satisfactionTakeMinus);
        }
    }

    public void UpdateCard()
    {
        int[] values = { 0, 1, 2, 2, 3, 3, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 13, 13, 14, 14 };
        random = values[Random.Range(0, values.Length)];
        repositoryPosition = random;
        SetText();
    }

    public string ReturnResName()
    {
        return resTypes[repositoryPosition];
    }

    public int ReturnResCost()
    {
        return ExtractionCoeff();
    }

    public int ReturnResMean()
    {
        switch (resTypes[repositoryPosition])
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
