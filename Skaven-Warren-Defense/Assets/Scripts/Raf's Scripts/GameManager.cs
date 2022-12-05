using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Skaven Warren Defense

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState gameState;
    public static event Action<GameState> OnGameStateChanged;

    public GameObject player;       //Main Character
    public GameObject enemyWave;    // EnemySpawner object?

    public int waveCount = 1;            // Keeps track of wave

    public int enemyCount;          // Keeps track of enemies left in wave
    public Text enemyCounterDisplay;

    public float startingTime;      // Time to begin with
    private float currentTime;       // Time to countdown
    public Text timerDisplay;

    public AudioSource gameMusic;   // Music during gameplay





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

    void Start()
    {
        currentTime = startingTime;
        
        UpdateGameObjects();
        UpdateGameState(GameState.Idle);
        
        //handle spawning allies ?
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
 // THE COMMENTS IN THIS SECTION ARE FOR REFERENCE FROM OTHER GAME
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
        if(waveCount < 3  && enemyCount == 0)
        {
            UpdateGameState(GameState.WinLevel);
        }

        //when the player loses a level
        if (player == null)
        {
            UpdateGameState(GameState.LoseLevel);
        }


        //when the player wins the game
        if (waveCount == 3 && enemyCount == 0)
        {
            UpdateGameState(GameState.WinGame);
        }

    }

    public void HandleWinLevel()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");

        //handle ui

        //switch to next level
    }

    private void Update()
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