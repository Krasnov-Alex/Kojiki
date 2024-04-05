using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GodControl : MonoBehaviour
{
    [SerializeField] public int locate = 0;
    [SerializeField] private GameObject godSatis;
    public int satisfactionTakeMinus = -1;
    public GodSatisfaction god1;
    public GodSatisfaction god2;
    public GodSatisfaction god3;
    public GodSatisfaction god4;
    public GodSatisfaction god5;
    public GodSatisfaction[] gods = new GodSatisfaction[5];
    public GodLog godLog;
    private int findGod;

    void Start()
    {
        
    }

    public GodSatisfaction FindGods(string atr)
    {
        switch (atr)
        {
            case "God1":
                if (god1 != null)
                {
                    return god1;
                }
                else
                {
                    return null;
                }
            case "God2":
                if (god2 != null)
                {
                    return god2;
                }
                else
                {
                    return null;
                }
            case "God3":
                if (god3 != null)
                {
                    return god3;
                }
                else
                {
                    return null;
                }
            case "God4":
                if (god4 != null)
                {
                    return god4;
                }
                else
                {
                    return null;
                }
            case "God5":
                if (god5 != null)
                {
                    return god5 ;
                }
                else
                {
                    return null;
                }
            default: 
                return null;
        }
    }

    public void CheckGodSatisfaction()
    {
        int satisMin = 0;
        int satisMax = 0;
        string smileGod = "";
        string angerGod = "";
        for (int i = 0; i < gods.Length; i++)
        {
            if ((int)gods[i].satisfaction <= satisMin)
            {
                satisMin = (int)gods[i].satisfaction;
                angerGod = gods[i].godName.text;
            }
            if ((int)gods[i].satisfaction >= satisMax)
            {
                satisMax = (int)gods[i].satisfaction;
                smileGod = gods[i].godName.text;
            }
        }
        if (satisMin != 0 && satisMax != 0)
        {
            godLog.SatisfactionGodsLog(smileGod, angerGod, 1);
        }
        else if (satisMin != 0 && satisMax == 0)
        {
            godLog.SatisfactionGodsLog(smileGod, angerGod, 2);
        }
        else if (satisMin == 0 && satisMax != 0)
        {
            godLog.SatisfactionGodsLog(smileGod, angerGod, 3);
        }
        else
        {
            godLog.SatisfactionGodsLog(smileGod, angerGod, 4);
        }
    }

    public void BuffDebuffCheck(string atr) 
    {
        switch (atr)
        {
            case "God1":

                break;
            case "God2":

                break;
            case "God3":

                break;
            case "God4":

                break;
            case "God5":

                break;
            case "God6":

                break;
            case "God7":

                break;
            case "God8":

                break;
        }
    }
}
