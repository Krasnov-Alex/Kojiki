using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildCount : MonoBehaviour
{
    public int sawBuild = 1;
    public int quarriesBuild = 0;
    public int riceFieldBuild = 1;
    public int wellBuild = 0;
    public int baniBuild = 1;
    public int theaterBuild = 0;
    public int lifeDomBuild = 1;
    public int kazarmaBuild = 0;

    public int templeIg = 0;
    public int templeIm = 0;
    public int templeAm = 0;
    public int templeCu = 0;
    public int templeSu = 0;

    [SerializeField] private Text text1;
    [SerializeField] private Text text2;
    [SerializeField] private Text text3;
    [SerializeField] private Text text4;
    [SerializeField] private Text text5;
    [SerializeField] private Text text6;
    [SerializeField] private Text text7;
    [SerializeField] private Text text8;
    [SerializeField] private Text text9;
    [SerializeField] private Text text10;
    [SerializeField] private Text text11;
    [SerializeField] private Text text12;
    [SerializeField] private Text text13;

    private void Start()
    {
        AddBuild();
    }

    public void AddBuild()
    {
        text1.text = sawBuild.ToString();
        text2.text = quarriesBuild.ToString();
        text3.text = riceFieldBuild.ToString();
        text4.text = wellBuild.ToString();
        text5.text = baniBuild.ToString();
        text6.text = theaterBuild.ToString();
        text7.text = lifeDomBuild.ToString();
        text8.text = kazarmaBuild.ToString();
        text9.text = templeIg.ToString();
        text10.text = templeIm.ToString();
        text11.text = templeAm.ToString();
        text12.text = templeCu.ToString();
        text13.text = templeSu.ToString();
    }
}
