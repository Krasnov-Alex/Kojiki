using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EducationController : MonoBehaviour
{
    [SerializeField] private GodSatisfaction amaSatis;
    [SerializeField] private BuildCard buildCard;
    [SerializeField] private ExtractionCard extractionCard;
    [SerializeField] private ExchangeCard exchangeCard;
    [SerializeField] private ResManager resManager;
    [SerializeField] private Card card;

    [SerializeField] private GameObject stepOneFrame;
    [SerializeField] private GameObject stepOneOneFrame;
    [SerializeField] private GameObject stepTwoFrame;
    [SerializeField] private GameObject stepTwoTwoFrame;
    [SerializeField] private GameObject stepThreeFrame;
    [SerializeField] private GameObject stepThreeThreeFrame;
    [SerializeField] private GameObject finalFrame;
    [SerializeField] private Text educText;

    private void Start()
    {
        StartStats();
    }


    private void StartStats()
    {
        resManager.mat = 0;
        resManager.eat = 520;
        resManager.hap = 9999;
        resManager.man = 500;
        resManager.TextUpdate();
        extractionCard.repositoryPosition = 7;
        card.UpdateCardText();
        stepOneOneFrame.SetActive(true);
    }

    public void StepOneOne()
    {
        StartStats();
        stepOneOneFrame.SetActive(false);
        stepOneFrame.SetActive(true);
        educText.text = "Ты Старейшина, тебе предстоит решать несколько задач, поддерживать баланс и не гневить богов. Население нуждается в еде, давай разыграем карту “Собрать фрукты”";
    }

    public void StepOne()
    {
        stepOneFrame.SetActive(false);
        stepTwoTwoFrame.SetActive(true);
        educText.text = "Видишь, Аматерасу разгневалась. Когда ее состояние достигнет отметки в “-30”, тебя постигнет кара и ты проиграешь. Нам нужно построить храм Аматерасу.\r\nНажмите ЛКМ.\r\n";
        exchangeCard.repositoryPosition = 3;
        card.UpdateCardText();
    }

    public void StepTwoTwo()
    {
        stepTwoTwoFrame.SetActive(false);
        stepTwoFrame.SetActive(true);
        educText.text = "Тебе пока не хватает материалов для строительства, но зато теперь достаточно еды. Давай разыграем карту  “Отправиться в экспедицию за материалами”.";
    }

    public void StepTwo()
    {
        stepTwoFrame.SetActive(false);
        stepThreeThreeFrame.SetActive(true);
        educText.text = "Видишь, настроение Аматерасу немного улучшилось когда ты отправился в экспедицию. Внимательно изучай карты, каждая карта так или иначе влияет на состояние богов.\r\nНажмите ЛКМ.\r\n";
        buildCard.repositoryPosition = 2;
        card.UpdateCardText();
    }
    public void StepThreeThree()
    {
        stepThreeThreeFrame.SetActive(false);
        stepThreeFrame.SetActive(true);
        educText.text = "Да, в основной игре пять богов. И тебе придется следить за их состоянием. Ну а сейчас давай наконец-то построим храм Аматерасу, разыграв соответствующую карту.";
    }

    public void StepThree()
    {
        stepThreeFrame.SetActive(false);
        finalFrame.SetActive(true);
        educText.text = "Поздравляем. Ты прошел обучение. Теперь тебе предстоит самостоятельно вести деревню к процветанию. Нажмите ЛКМ для выхода.";
    }

    public void FinalEduc()
    {
        SceneManager.LoadScene(0);
    }
}
