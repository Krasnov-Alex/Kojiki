using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public BuildCard buildCard;
    public ExchangeCard exchangeCard;
    public ExtractionCard extractionCard;

    public Season season;

    [SerializeField] private GodsDebuff godsDebuff;
    [SerializeField] private GodControl godControl;

    public GameObject cardBuild;
    public GameObject cardExchange;
    public GameObject cardExtraction;


    public Text buttonVisibleText;
    public bool buttonVisible = true;

    private void Start()
    {
    }

    public void UpdateCardText()
    {
        buildCard.SetText();
        exchangeCard.SetText();
        extractionCard.SetText();
    }

    public void UpdAnyCard()
    {
        buildCard.UpdateCard();
        exchangeCard.UpdateCard();
        extractionCard.UpdateCard();
        season.CreateStep();
        godsDebuff.CreateStep();
        godControl.BuffNoSatisfactionMinus(false);
        godControl.CheckForBuffInGods();
    }

    public void SecretPower()
    {
        buildCard.UpdateCard();
        exchangeCard.UpdateCard();
        extractionCard.UpdateCard();
    }

    public void CardVisible()
    {
        if (buildCard.gameObject.activeSelf)
        {
            cardBuild.SetActive(false);
            cardExchange.SetActive(false);
            cardExtraction.SetActive(false);
        }
        else
        {
            cardBuild.SetActive(true);
            cardExchange.SetActive(true);
            cardExtraction.SetActive(true);
        }
    }

    public void CardVisibleButton()
    {
        if (buttonVisible)
        {
            buttonVisibleText.text = "Показать карты";
            buttonVisible = false;
        }
        else
        {
            buttonVisibleText.text = "Скрыть карты";
            buttonVisible = true;
        }
    }
}
