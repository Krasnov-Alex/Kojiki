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
    public int resCost = 1;
    public string nameRes = "Mat";
    private int random;
    public Card card;

    public Image resSprite;
    public Sprite material;
    public Sprite eat;
    public Sprite happy;
    public Sprite people;

    public ResManager resManager;
    private GodControl godControl;
    public GameObject ground;
    public GameObject house;
    public int count = 4;

    private void Start()
    {
        UpdateCard();
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
        TextCart.GetComponent<Text>().text = cardText[repositoryPosition];

        TextCart = this.gameObject.transform.GetChild(2).gameObject;
        TextCart.GetComponent<Text>().text = (resCosts[repositoryPosition] * resManager.Coef(resTypes[repositoryPosition])).ToString();

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

    public void Extraction()
    {
        resManager.SetRes(nameRes, resCosts[repositoryPosition]);
        card.UpdAnyCard();
        for (int i = 0; i < godControl.locate;  i++)
        {
            godControl.gods[i].SetSatisfaction(godControl.satisfactionTakeMinus);
        }
    }

    public void UpdateCard()
    {
        random = Random.Range(0, 15);
        repositoryPosition = random;
        nameRes = resTypes[repositoryPosition];
        SetText();
    }
}
