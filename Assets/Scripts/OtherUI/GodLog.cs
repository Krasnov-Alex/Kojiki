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
        moveSeasonLog = $"\nХод: {moveCount}\nСезон: {season.GetSeasonName()}";
    }

    public void BuildCard(string name, int num)
    {
        MoveAndSeason();
        buildLog = $"\nРазыграна карта постройки: {name}.\nПотрачено: {num} материалов.";
        moveCount++;
        godControl.CheckGodSatisfaction();
    }

    public void ExtractionCard(string name, int num, string resName)
    {
        MoveAndSeason();
        extractionLog = $"\nРазыграна карта: {name}.\nПолучено: {num} {resName}.";
        moveCount++;
        godControl.CheckGodSatisfaction();
    }

    public void ExchangeCard(string name, string resName1, string resName2)
    {
        MoveAndSeason();
        exchangeLog = $"\nРазыграна карта: {name}.\nПолучено: {resName1}.\nПотрачено: {resName2}.";
        moveCount++;
        godControl.CheckGodSatisfaction();
    }

    public void SatisfactionGodsLog(string smileName, string angerName, int atr)
    {
        switch (atr)
        {
            case 1:
                satisfactionLog = $"\nБог {smileName} <color=green>радуется</color>\nБог {angerName} <color=red>гневается</color>";
                break;
            case 2:
                satisfactionLog = $"\nБог {angerName} <color=red>гневается</color>";
                break;
            case 3:
                satisfactionLog = $"\nБог {smileName} <color=green>радуется</color>";
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
            seasonLog = $"\n\nНаселение использовало {atr} материалов.\nПотребило {atr} пищи.\nИ стало несчастно на {atr}.\n\nКонец хода.\n";
        }
        else
        {
            seasonLog = "\n\nКонец хода.\n";
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
