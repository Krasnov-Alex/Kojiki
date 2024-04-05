using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodSatisfaction : MonoBehaviour
{
    [SerializeField] public Text godName; 
    [SerializeField] public float satisfaction = 0f;
    [SerializeField] private GameObject godDescription;
    [SerializeField] private Text godDescriptionText;
    [SerializeField] private Sprite[] iconEx;
    [SerializeField] private string[] godNameEx;
    private string[] godDescriptionEx = new string[5];
    [SerializeField]private GodControl godControl;
    [SerializeField] private Gamover gamover;
    [SerializeField] private string atribut;
    [SerializeField] private Slider goodLine;
    [SerializeField] private Slider badLine;
    private int minSatis = -30;
    private int maxSatis = 30;
    public Text satis;
    

    private void Start()
    {
        AddDescription();
        GetDescription();
        goodLine.value = 0;
        badLine.value = 0;
    }

    private void Update()
    {
        satis.text = satisfaction.ToString();

        if (satisfaction < 0)
        {
            badLine.value = -(float)satisfaction / 30f;
            goodLine.value = 0;
        }
        else if (satisfaction > 0)
        {
            goodLine.value = (float)satisfaction / 30f;
            badLine.value = 0;
        }
        else
        {
            goodLine.value = 0;
            badLine.value = 0;
        }
        
        

        if (satisfaction <= minSatis)
        {
            gamover.GameOver(false);
        }
        if (satisfaction >= maxSatis)
        {
            satisfaction = maxSatis;
        }
    }

    public void SetSatisfaction(int satis)
    {
        satisfaction += satis;
    }

    public void GodDescription()
    {
        if (godDescription.activeSelf)
        {
            godDescription.SetActive(false);
        }
        else
        {
            godDescription.SetActive(true);
        }
    }

    private void GetDescription()
    {
        switch (atribut)
        {
            case "Ig":
                godDescriptionText.text = godDescriptionEx[0];
                break;
            case "Im":
                godDescriptionText.text = godDescriptionEx[1];
                break;
            case "Am":
                godDescriptionText.text = godDescriptionEx[2];
                break;
            case "Ts":
                godDescriptionText.text = godDescriptionEx[3];
                break;
            case "Su":
                godDescriptionText.text = godDescriptionEx[4];
                break;
        }
    }

    private void AddDescription()
    {
        godDescriptionEx[0] = "Идзанаги.\r\nИзначальный Бог. Брат и муж Идзанами. Волевой и импульсивный. Радуется, когда деревня процветает, и огорчается, когда кто-то погибает.\r\n";
        godDescriptionEx[1] = "Идзанами.\r\nИзначальная Богиня. Жена и сестра Идзанаги. Мягкая, но при этом мстительная. Радуется, когда население растет, и огорчается, когда население снижается.\r\n";
        godDescriptionEx[2] = "Аматерасу.\r\nИзначальный Бог. Брат и муж Идзанами. Волевой и импульсивный. Радуется, когда деревня процветает, и огорчается, когда кто-то погибает.\r\n";
        godDescriptionEx[3] = "Цукуёми.\r\nБог ночи. Сын Идзанаги и Идзанами. Нелюдим. Замкнут. И поэтому даже родственники не знают, что его радует, а что огорчает.\r\n";
        godDescriptionEx[4] = "Сусаноо.\r\nБог стихийных бедствий. Сын Идзанаги и Идзанами. Сам лентяй, но радуется, когда что-то достается с большим трудом, и огорчается, если все дается легко.\r\n";
    }
}
