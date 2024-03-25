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

    
    
    //public void SetGod(string atr)
    //{
    //    switch (atr)
    //    {
    //        case "God1":
    //            GameObject target = this.gameObject.transform.GetChild(locate).gameObject;
    //            GameObject godd = Instantiate(godSatis, target.transform.position, Quaternion.identity, this.gameObject.transform);
    //            god1 = godd.GetComponent<GodSatisfaction>();
    //            god1.SetDisplay(atr);
    //            gods[locate] = god1;
    //            locate++;
    //            break;
    //        case "God2":
    //            GameObject target1 = this.gameObject.transform.GetChild(locate).gameObject;
    //            GameObject godd1 = Instantiate(godSatis, target1.transform.position, Quaternion.identity, this.gameObject.transform);
    //            god2 = godd1.GetComponent<GodSatisfaction>();
    //            god2.SetDisplay(atr);
    //            gods[locate] = god2;
    //            locate++;
    //            break;
    //        case "God3":
    //            GameObject target2 = this.gameObject.transform.GetChild(locate).gameObject;
    //            GameObject godd2 = Instantiate(godSatis, target2.transform.position, Quaternion.identity, this.gameObject.transform);
    //            god3 = godd2.GetComponent<GodSatisfaction>();
    //            god3.SetDisplay(atr);
    //            gods[locate] = god3;
    //            locate++;
    //            break;
    //        case "God4":
    //            GameObject target3 = this.gameObject.transform.GetChild(locate).gameObject;
    //            GameObject godd3 = Instantiate(godSatis, target3.transform.position, Quaternion.identity, this.gameObject.transform);
    //            god4 = godd3.GetComponent<GodSatisfaction>();
    //            god4.SetDisplay(atr);
    //            gods[locate] = god4;
    //            locate++;
    //            break;
    //        case "God5":
    //            GameObject target4 = this.gameObject.transform.GetChild(locate).gameObject;
    //            GameObject godd4 = Instantiate(godSatis, target4.transform.position, Quaternion.identity, this.gameObject.transform);
    //            god5 = godd4.GetComponent<GodSatisfaction>();
    //            god5.SetDisplay(atr);
    //            gods[locate] = god5;
    //            locate++;
    //            break;
    //    }
    //}

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
