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
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameIsOver)
        {
            if (currentTime < 0)
            { // check to see if timer has run out
              // EndGame();
                print("endgame");
            }
            else
            { // game playing state, so update the timer
                currentTime -= Time.deltaTime;
                if (mainTimerDisplay)
                    mainTimerDisplay.text = currentTime.ToString("0.00");
            }
        }
     }
}
