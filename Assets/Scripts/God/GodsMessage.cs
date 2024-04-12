using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GodsMessage : MonoBehaviour
{
    [SerializeField] private float timer = 5;
    private float realTimer;
    private Image messege;
    private Text messegeText;
    private float colorAlpha = 1f;
    private bool isStart = false;
    private void Start()
    {
        realTimer = timer;
    }

    private void Update()
    {
        if (colorAlpha <= 0f)
        {
            messege = null;
            colorAlpha = 1f;
        }
        if (messege != null && !isStart)
        {
            messege.color = new Color(1f, 1f, 1f, colorAlpha);
            messegeText.color = new Color(0f, 0f, 0f, colorAlpha);
            colorAlpha-= Time.deltaTime;
        }
        if (isStart)
        {
            realTimer -= Time.deltaTime;
            if (realTimer <= 0)
            {
                isStart = false;
                realTimer = timer;
            }
        }

    }

    public void ActiveMessege(GameObject godMessege)
    {
        isStart = true;
        messege = godMessege.GetComponent<Image>();
        messegeText = messege.gameObject.transform.GetChild(0).GetComponent<Text>();
        messege.color = new Color(1f, 1f, 1f, colorAlpha);
        messegeText.color = new Color(0f, 0f, 0f, colorAlpha);
    }
}
