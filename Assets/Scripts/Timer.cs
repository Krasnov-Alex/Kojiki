using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float time;
    private float stopTime = 0f;
    public Text timerText;

    private void Start()
    {
        stopTime = Time.time;
    }
    void Update()
    {
        time = Mathf.Round((Time.time - stopTime));
        timerText.text = time.ToString();
    }
}


