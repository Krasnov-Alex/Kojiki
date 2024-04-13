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
        educText.text = "�� ����������, ���� ��������� ������ ��������� �����, ������������ ������ � �� ������� �����. ��������� ��������� � ���, ����� ��������� ����� �������� �������";
    }

    public void StepOne()
    {
        stepOneFrame.SetActive(false);
        stepTwoTwoFrame.SetActive(true);
        educText.text = "������, ��������� ������������. ����� �� ��������� ��������� ������� � �-30�, ���� ��������� ���� � �� ����������. ��� ����� ��������� ���� ���������.\r\n������� ���.\r\n";
        exchangeCard.repositoryPosition = 3;
        card.UpdateCardText();
    }

    public void StepTwoTwo()
    {
        stepTwoTwoFrame.SetActive(false);
        stepTwoFrame.SetActive(true);
        educText.text = "���� ���� �� ������� ���������� ��� �������������, �� ���� ������ ���������� ���. ����� ��������� �����  ������������ � ���������� �� �����������.";
    }

    public void StepTwo()
    {
        stepTwoFrame.SetActive(false);
        stepThreeThreeFrame.SetActive(true);
        educText.text = "������, ���������� ��������� ������� ���������� ����� �� ���������� � ����������. ����������� ������ �����, ������ ����� ��� ��� ����� ������ �� ��������� �����.\r\n������� ���.\r\n";
        buildCard.repositoryPosition = 2;
        card.UpdateCardText();
    }
    public void StepThreeThree()
    {
        stepThreeThreeFrame.SetActive(false);
        stepThreeFrame.SetActive(true);
        educText.text = "��, � �������� ���� ���� �����. � ���� �������� ������� �� �� ����������. �� � ������ ����� �������-�� �������� ���� ���������, �������� ��������������� �����.";
    }

    public void StepThree()
    {
        stepThreeFrame.SetActive(false);
        finalFrame.SetActive(true);
        educText.text = "�����������. �� ������ ��������. ������ ���� ��������� �������������� ����� ������� � �����������. ������� ��� ��� ������.";
    }

    public void FinalEduc()
    {
        SceneManager.LoadScene(0);
    }
}
