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

    private void Start()
    {
        UpdateCard();
        //resManager = FindAnyObjectByType<ResManager>();
        //godControl = FindAnyObjectByType<GodControl>();
        SetText();
    }

    private void Update()
    {
        //SetText();
    }
    private void SetText()
    {
        cardName.text = names[repositoryPosition];
        cardDescription.text = cardText[repositoryPosition];
        cardPoint1.text = ExtractionCoeff().ToString();


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
        SetSatisfactionEx();
        card.UpdAnyCard();
    }

    private void SetSatisfactionEx()
    {
        switch (cardAtr[repositoryPosition])
        {
            case "Card0":
                for (int i = 0; i < 5; i++)
                {
                    godControl.gods[i].SetSatisfaction(godControl.satisfactionTakeMinus);
                }
                break;
            case "Card1":
                for (int i = 0; i < 5; i++)
                {
                    godControl.gods[i].SetSatisfaction(godControl.satisfactionTakeMinus + 1);
                }
                break;
        }
    }

    public void UpdateCard()
    {
        random = Random.Range(0, 15);
        repositoryPosition = random;
        SetText();
    }
}
