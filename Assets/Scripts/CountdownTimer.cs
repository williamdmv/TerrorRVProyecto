using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText;
    public GameObject enemyObject;
    private float totalTime = 30f;
    private float currentTime;
    private bool enemyActive = false;

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

            if (currentTime <= 0f && !enemyActive)
            {
                ActivateEnemy();
            }
        }
    }

    void UpdateTimerText()
    {
        string seconds = ((int)currentTime % 60).ToString("00");
        string timerString = string.Format("{0}", seconds);
        timerText.text = timerString;
    }

    void ActivateEnemy()
    {
        enemyObject.SetActive(true);
        enemyActive = true;
        // Realizar acciones adicionales cuando el temporizador llega a cero y el enemigo se activa

        // Aquí puedes hacer referencia al enemigo por su tag
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemigo");
        foreach (GameObject enemy in enemies)
        {
            // Realizar acciones específicas para cada enemigo
        }
    }
}
