using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodLog : MonoBehaviour
{
    [SerializeField] private string description = ""; 
    [SerializeField] private string descriptionSeason = "";
    [SerializeField] private Season season;
    [SerializeField] private Text[] godLogs = new Text[24];
    [SerializeField] private GodControl godControl;
    private int moveCount = 1;

    private string buildLog;
    private string extractionLog;
    private string exchangeLog;
    private string seasonLog;
    private string satisfactionLog;
    private string moveSeasonLog;


    private void MoveAndSeason()
    {
        moveSeasonLog = $"\n���: {moveCount}\n�����: {season.GetSeasonName()}";
    }

    public void BuildCard(string name, int num)
    {
        MoveAndSeason();
        buildLog = $"\n��������� ����� ���������: {name}.\n���������: {num} ����������.";
        moveCount++;
        godControl.CheckGodSatisfaction();
    }

    public void ExtractionCard(string name, int num, string resName)
    {
        MoveAndSeason();
        extractionLog = $"\n��������� �����: {name}.\n��������: {num} {resName}.";
        moveCount++;
        godControl.CheckGodSatisfaction();
    }

    public void ExchangeCard(string name, string resName1, string resName2)
    {
        MoveAndSeason();
        exchangeLog = $"\n��������� �����: {name}.\n��������: {resName1}.\n���������: {resName2}.";
        moveCount++;
        godControl.CheckGodSatisfaction();
    }

    public void SatisfactionGodsLog(string smileName, string angerName, int atr)
    {
        switch (atr)
        {
            case 1:
                satisfactionLog = $"\n��� {smileName} <color=green>��������</color>\n��� {angerName} <color=red>���������</color>";
                break;
            case 2:
                satisfactionLog = $"\n��� {angerName} <color=red>���������</color>";
                break;
            case 3:
                satisfactionLog = $"\n��� {smileName} <color=green>��������</color>";
                break;
            case 4:
                satisfactionLog = "";
                break;
        }
    }

    public void SeasonWriteOff(int atr)
    {
        if (atr != 0)
        {
            seasonLog = $"\n\n��������� ������������ {atr} ����������.\n��������� {atr} ����.\n� ����� ��������� �� {atr}.\n\n����� ����.\n";
        }
        else
        {
            seasonLog = "\n\n����� ����.\n";
        }
        CreateLog();
    }

    private void CreateLog()
    {
        description = moveSeasonLog + buildLog + extractionLog + exchangeLog + seasonLog;
        for (int i = 0; i <= 23; i++)
        {
            if (i < 23)
            {
                godLogs[i].text = godLogs[i +1].text;
            }
            else
            {
                godLogs[i].text = description;
                description = "";
            }
        }
        ClearLog();
    }

    private void ClearLog()
    {
        buildLog = "";
        extractionLog = "";
        exchangeLog = "";
        seasonLog = "";
        satisfactionLog = "";
        moveSeasonLog = "";
    }
}
