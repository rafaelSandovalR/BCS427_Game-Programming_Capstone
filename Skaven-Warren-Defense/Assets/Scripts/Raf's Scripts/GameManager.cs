using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public Camera mainCamera;
    public Camera secondCamera;


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

        secondCamera.enabled = false;
        UpdateGameState(GameState.Idle);
    }

    void UpdateGameObjects()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        if(mainCamera == null)
        {
            mainCamera = (Camera)GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        }
        if(secondCamera == null)
        {
            secondCamera = (Camera)GameObject.FindGameObjectWithTag("SecondCamera").GetComponent<Camera>();
        }
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

        if (Input.GetKey(KeyCode.I))
        {
            mainCamera.enabled = !mainCamera.enabled;
            secondCamera.enabled = !secondCamera.enabled;
        }

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