using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardDesription : MonoBehaviour
{
    [SerializeField] private Text matRes;
    [SerializeField] private Text eatRes;
    [SerializeField] private Text hapRes;
    [SerializeField] private Text manRes;
    [SerializeField] private ResManager resManager;
    [SerializeField] private BuildCard buildCard;
    [SerializeField] private ExtractionCard extractionCard;
    [SerializeField] private ExchangeCard exchangeCard;
    private bool isInCardBuild = false;
    [SerializeField] private Text exActiveRes;
    private int exActiveCost;

    [SerializeField] private Text excActiveAddRes;
    [SerializeField] private Text excActiveOutRes;
    private int excActiveAddCost;
    private int excActiveOutCost;

    private void Update()
    {
        if (isInCardBuild)
        {
            matRes.text = (resManager.mat - buildCard.BuildCoeff()).ToString();
            matRes.color = Color.red;
        }
    }

    public void BuildCardInfoOn()
    {
        isInCardBuild = true;
        resManager.TextUpdate();
    }
    
    public void BuildCardInfoOff()
    {
        isInCardBuild = false;
        matRes.color = Color.black;
        resManager.TextUpdate();
    }

    public void ReExtraction()
    {
        exActiveCost = extractionCard.ReturnResCost();
        TxTUpd();
        ExtractionCardInfoOn();
    }

    public void ExtractionCardInfoOn()
    {
        exActiveCost = extractionCard.ReturnResCost();
        switch (extractionCard.ReturnResName())
        {
            case "Mat":
                matRes.color = Color.green;
                exActiveRes = matRes.GetComponent<Text>();
                break;
            case "Eat":
                eatRes.color = Color.green;
                exActiveRes = eatRes.GetComponent<Text>();
                break;
            case "Hap":
                hapRes.color = Color.green;
                exActiveRes = hapRes.GetComponent<Text>();
                break;
            case "Man":
                manRes.color = Color.green;
                exActiveRes = manRes.GetComponent<Text>();
                break;
            default:

                break;
        }
        exActiveRes.text = (extractionCard.ReturnResMean() + exActiveCost).ToString();
    }

    public void ReExchange()
    {
        excActiveAddCost = exchangeCard.ReturnAddResCost();
        excActiveOutCost = exchangeCard.ReturnOutResCost();
        TxTUpd();
        ExchangeCardInfoOn();
    }

    public void ExchangeCardInfoOn()
    {
        excActiveAddCost = exchangeCard.ReturnAddResCost();
        excActiveOutCost = exchangeCard.ReturnOutResCost();
        switch (exchangeCard.ReturnAddResName())
        {
            case "Mat":
                matRes.color = Color.green;
                excActiveAddRes = matRes.GetComponent<Text>();
                break;
            case "Eat":
                eatRes.color = Color.green;
                excActiveAddRes = eatRes.GetComponent<Text>();
                break;
            case "Hap":
                hapRes.color = Color.green;
                excActiveAddRes = hapRes.GetComponent<Text>();
                break;
            case "Man":
                manRes.color = Color.green;
                excActiveAddRes = manRes.GetComponent<Text>();
                break;
            default:

                break;
        }

        if (exchangeCard.ReturnAddResName() != "Sat")
        {
            excActiveAddRes.text = (exchangeCard.ReturnAddResMean() + excActiveAddCost).ToString();
        }
        
        switch (exchangeCard.ReturnOutResName())
        {
            case "Mat":
                matRes.color = Color.red;
                excActiveOutRes = matRes.GetComponent<Text>();
                break;
            case "Eat":
                eatRes.color = Color.red;
                excActiveOutRes = eatRes.GetComponent<Text>();
                break;
            case "Hap":
                hapRes.color = Color.red;
                excActiveOutRes = hapRes.GetComponent<Text>();
                break;
            case "Man":
                manRes.color = Color.red;
                excActiveOutRes = manRes.GetComponent<Text>();
                break;
            default:

                break;
        }
        excActiveOutRes.text = (exchangeCard.ReturnOutResMean() + excActiveOutCost).ToString();
    }

    public void TxTUpd()
    {
        resManager.TextUpdate();
        matRes.color = Color.black;
        eatRes.color = Color.black;
        hapRes.color = Color.black;
        manRes.color = Color.black;
    }
}
