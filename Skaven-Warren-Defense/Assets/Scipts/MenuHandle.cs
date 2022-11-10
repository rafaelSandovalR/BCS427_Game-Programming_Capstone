using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandle : MonoBehaviour
{
    public GameObject primaryMenu;
    public GameObject nextMenu;

    void start()
    {
        Application.targetFrameRate = 60;
    }
    public void TrigerGameQuit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    private void Awake()
    {
        
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
        print("windows");
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
