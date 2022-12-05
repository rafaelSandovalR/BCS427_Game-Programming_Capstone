using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAudio : MonoBehaviour
{
    public static WinAudio WAInstance;
    public AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
}
