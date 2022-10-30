using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandle : MonoBehaviour
{
    // Start is called before the first frame update
    public void TrigerGameQuit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
