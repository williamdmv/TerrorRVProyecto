using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText;
    private float totalTime = 30f;
    private float currentTime;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        if (currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            currentTime = 0f;
            // Realizar acciones cuando el temporizador llega a cero
        }
    }

    void UpdateTimerText()
    {
        string seconds = ((int)currentTime % 60).ToString("00");
        string milliseconds = ((currentTime * 1000) % 1000).ToString("000");

        string timerString = string.Format("{0}:{1}", seconds, milliseconds);
        timerText.text = timerString;
    }

}
