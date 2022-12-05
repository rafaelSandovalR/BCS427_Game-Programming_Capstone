using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState gameState;
    public static event Action<GameState> OnGameStateChanged;

    public GameObject player;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateGameObjects();
        UpdateGameState(GameState.Idle);
    }

    void UpdateGameObjects()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
    }

    public void UpdateGameState(GameState newState)
    {
        UpdateGameObjects();
        OnGameStateChanged?.Invoke(newState);
        gameState = newState;
        switch (newState)
        {
            case GameState.Idle:
                gameState = GameState.Idle;
                break;
            case GameState.NextLevelPlay:
                //startBtn.SetActive(false);
                HandlePlayingGame();
                break;
            case GameState.Playing:
                //startBtn.SetActive(false);
                //if (mainUI != null)
                   // mainUI.SetActive(false);
                HandlePlayingGame();
                break;
            case GameState.WinLevel:
                HandleWinLevel();
                break;
            case GameState.LoseLevel:

                //continueBtn.SetActive(false);
                //lostGameText.SetActive(true);
                //mainUI.SetActive(true);
                break;
            case GameState.WinGame:
                break;
            case GameState.GameOver:
                break;
        }
    }

    public void HandlePlayingGame()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }


        player.SetActive(true);

        //when the player wins a level

        //when the player loses a level
    }

    public void HandleWinLevel()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");

        if (!WinAudio.WAInstance.Audio.isPlaying)
        {
            WinAudio.WAInstance.Audio.Play();
        }

        //handle ui

        //switch to next level
    }

    private void FixedUpdate()
    {
        //update ui

        //handle timer
    }
}


public enum GameState
{
    Idle,
    Playing,
    WinLevel,
    LoseLevel,
    NextLevelPlay,
    WinGame,
    GameOver
}