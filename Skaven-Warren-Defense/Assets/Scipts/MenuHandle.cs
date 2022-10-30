using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandle : MonoBehaviour
{
    public GameObject primaryMenu;
    public GameObject nextMenu;
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
    }

    public void MainGameSetting()
    {
        print("settings");
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
    }
    void Start()
    {

    }

    void Update()
    {

    }
}
