using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodsDebuff : MonoBehaviour
{
    private bool isMirrorCard = false;
    private bool isUIReverse = false;
    private bool isNight = false;
    private bool isScreamer = false;
    private int stepCount = 1;
    private int stepNow;

    [SerializeField] private GameObject uiRev;
    [SerializeField] private GameObject buildCardRev;
    [SerializeField] private GameObject exchCardRev;
    [SerializeField] private GameObject extCardRev;
    [SerializeField] private GameObject nightPanel;
    [SerializeField] private Image screamer;
    private float colorAlpha = 1.0f;
    private int screamerStep;

    [SerializeField] private AudioInGame audioInGame;

    private void Update()
    {
        if (isMirrorCard && stepCount >= stepNow)
        {
            buildCardRev.transform.rotation = Quaternion.Euler(buildCardRev.transform.rotation.x, 0, buildCardRev.transform.rotation.z);
            exchCardRev.transform.rotation = Quaternion.Euler(buildCardRev.transform.rotation.x, 0, buildCardRev.transform.rotation.z);
            extCardRev.transform.rotation = Quaternion.Euler(buildCardRev.transform.rotation.x, 0, buildCardRev.transform.rotation.z);
            isMirrorCard = false;
        }
        if (isUIReverse && stepCount >= stepNow)
        {
            uiRev.transform.rotation = Quaternion.Euler(uiRev.transform.rotation.x, uiRev.transform.rotation.y, 0);
            isUIReverse = false;
        }
        if (isNight && stepCount >= stepNow)
        {
            nightPanel.SetActive(false);
            isNight = false;
        }
        
        if (isScreamer)
        {
            if (screamerStep != stepCount)
            {
                colorAlpha = 1f;
                screamerStep = stepCount;
                audioInGame.ScreamerPlay();
            }
            if (stepCount >= stepNow && colorAlpha <= 0f)
            {
                screamer.gameObject.SetActive(false);
                isScreamer = false;
            }
            screamer.color = new Color(1f, 1f, 1f, colorAlpha);
            colorAlpha -= Time.deltaTime;
        }
        AllDebuffOff();
    }

    private void AllDebuffOff()
    {

        if (!isUIReverse)
        {
            uiRev.transform.rotation = Quaternion.Euler(uiRev.transform.rotation.x, uiRev.transform.rotation.y, 0);
        }
        if (!isMirrorCard)
        {
            buildCardRev.transform.rotation = Quaternion.Euler(buildCardRev.transform.rotation.x, 0, buildCardRev.transform.rotation.z);
            exchCardRev.transform.rotation = Quaternion.Euler(buildCardRev.transform.rotation.x, 0, buildCardRev.transform.rotation.z);
            extCardRev.transform.rotation = Quaternion.Euler(buildCardRev.transform.rotation.x, 0, buildCardRev.transform.rotation.z);
        }
        if (!isScreamer)
        {
            screamer.gameObject.SetActive(false);
        }
        if (!isNight)
        {
            nightPanel.SetActive(false);
            audioInGame.NightSoundPlay(false);
        }        
    }

    public void StartDebuff()
    {
        stepNow = stepCount + 3;
        int rand = Random.Range(0, 4);
        switch (rand)
        {
            case 0:
                MirrorCard();
                break;
            case 1:
                ScreamerIsComing();
                break;
            case 2:
                NightIsComing();
                break;
            case 3:
                UIReverse();
                break;
        }
    }

    public void CreateStep()
    {
        stepCount++;
    }


    public void MirrorCard()
    {
        isMirrorCard = true;
        buildCardRev.transform.rotation = Quaternion.Euler(buildCardRev.transform.rotation.x, 180, buildCardRev.transform.rotation.z);
        exchCardRev.transform.rotation = Quaternion.Euler(buildCardRev.transform.rotation.x, 180, buildCardRev.transform.rotation.z);
        extCardRev.transform.rotation = Quaternion.Euler(buildCardRev.transform.rotation.x, 180, buildCardRev.transform.rotation.z);
    }

    public void UIReverse()
    {
        isUIReverse = true;
        uiRev.transform.rotation = Quaternion.Euler(uiRev.transform.rotation.x, uiRev.transform.rotation.y, 180);
    }

    public void NightIsComing()
    {
        isNight = true;
        nightPanel.SetActive(true);
        audioInGame.NightSoundPlay(true);
    }

    public void ScreamerIsComing()
    {
        isScreamer = true;
        screamer.gameObject.SetActive(true);
        screamerStep = stepCount;
        colorAlpha = 1f;
        audioInGame.ScreamerPlay();
    }
}
