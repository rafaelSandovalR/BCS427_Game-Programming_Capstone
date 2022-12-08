using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float startTime = 5.0f;
    private float currentTime;
    public bool gameIsOver = false;
    public Text mainTimerDisplay;
    
    void Start()
    {
        currentTime = startTime;
    }

    void Update()
    {
        if (!gameIsOver)
        {
            if (currentTime < 0)
            { 
                print("endgame");
            }
            else
            {
                currentTime -= Time.deltaTime;
                if (mainTimerDisplay)
                    mainTimerDisplay.text = currentTime.ToString("0.00");
            }
        }
     }
}
