using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodSatisfaction : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Text godName; 
    [SerializeField] public float satisfaction = 0f;
    [SerializeField] private Text godDescription;
    [SerializeField] private Sprite[] iconEx;
    [SerializeField] private string[] godNameEx;
    [SerializeField] private string[] godDescriptionEx;
    private GodControl godControl;
    private int minSatis = -30;
    private int maxSatis = 30;
    public string atribut;
    public Slider badLine;
    public Slider goodLine;
    public Text satis;
    private Gamover gamover;

    private void Start()
    {
        gamover = FindAnyObjectByType<Gamover>();
        godControl = FindAnyObjectByType<GodControl>();
        goodLine.normalizedValue = satisfaction;
        badLine.value = satisfaction;
    }

    private void Update()
    {
        satis.text = satisfaction.ToString();
        if (satisfaction <= minSatis)
        {
            gamover.GameOver(false);
        }
        if (satisfaction >= maxSatis)
        {
            satisfaction = maxSatis;
        }
        //if (satisfaction > 0f)
        //{
        //    goodLine.value = (float)satisfaction / (float)maxSatis;
        //    badLine.value = 0f;
        //}
        //else if (satisfaction < 0f)
        //{
        //    badLine.value = (float)satisfaction / (float)minSatis * (-1);
        //    goodLine.value = 0f;
        //}
        //else
        //{
        //    goodLine.value = 0f;
        //    badLine.value = 0f;
        //}

    }

    public void SetSatisfaction(int satis)
    {
        satisfaction += satis;
    }

    public void SetDisplay(string atr)
    {
        switch (atr)
        {
            case "God1":
                icon.sprite = iconEx[0];
                godName.text = godNameEx[0];
                godDescription.text = godDescriptionEx[0];
                atribut = "God1"; 
                break;
            case "God2":
                icon.sprite = iconEx[1];
                godName.text = godNameEx[1];
                godDescription.text = godDescriptionEx[1];
                atribut = "God2";
                break;
            case "God3":
                icon.sprite = iconEx[2];
                godName.text = godNameEx[2];
                godDescription.text = godDescriptionEx[2];
                atribut = "God3";
                break;
            case "God4":
                icon.sprite = iconEx[3];
                godName.text = godNameEx[3];
                godDescription.text = godDescriptionEx[3];
                atribut = "God4";
                break;
            case "God5":
                icon.sprite = iconEx[4];
                godName.text = godNameEx[4];
                godDescription.text = godDescriptionEx[4];
                atribut = "God5";
                break;
            case "God6":
                icon.sprite = iconEx[5];
                godName.text = godNameEx[5];
                godDescription.text = godDescriptionEx[5];
                atribut = "God6";
                break;
            case "God7":
                icon.sprite = iconEx[6];
                godName.text = godNameEx[6];
                godDescription.text = godDescriptionEx[6];
                atribut = "God7";
                break;
            case "God8":
                icon.sprite = iconEx[7];
                godName.text = godNameEx[7];
                godDescription.text = godDescriptionEx[7];
                atribut = "God8";
                break;

        }
    }


}
