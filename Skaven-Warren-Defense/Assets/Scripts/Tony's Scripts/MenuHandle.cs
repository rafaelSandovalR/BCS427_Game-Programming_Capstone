using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandle : MonoBehaviour
{
    public GameObject primaryMenu;
    public GameObject nextMenu;
    private int playerChoice;
    public int playerNum;
    private bool windowScre = true;

    void start()
    {
        Application.targetFrameRate = 60;
    }
    public void TrigerGameQuit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void PlayerChoice()
    {
        playerChoice = playerNum;
    }

    private void Awake()
    {
        
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(3);
     }

    public void MainStartMenu()
    {
        print("start");
        nextMenu.SetActive(true);
        primaryMenu.SetActive(false);
    }

    public void MainGameSetting()
    {
        print("settings");
        nextMenu.SetActive(true);
        primaryMenu.SetActive(false);
    }

    public void MouseSens()
    {
        print("mouseS");
    }

    public void Windowmode()
    {
        if (windowScre == true)
        {
            Screen.fullScreenMode= FullScreenMode.MaximizedWindow;
            windowScre = false;
        }

        if (windowScre == true)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
            windowScre = true;
        }

    }

    public void backButtion()
    {
        print("back");
        nextMenu.SetActive(false);
        primaryMenu.SetActive(true);
    }
    void Start()
    {

    }

    void Update()
    {

    }
}
