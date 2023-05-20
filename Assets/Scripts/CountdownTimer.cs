using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    public Text timerText;
    private float totalTime = 30f;
    private float currentTime;
    public GameObject EnemigoAparecer;
    

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
            EnemigoAparecer.SetActive(false);
        }
        else
        {
            currentTime = 0f;
            EnemigoAparecer.SetActive(true);
            // Realizar acciones cuando el temporizador llega a cero
        }
    }

    void UpdateTimerText()
    {
        string seconds = ((int)currentTime % 60).ToString("00");

        string timerString = string.Format("{0}", seconds);
        timerText.text = timerString;
    }

}

