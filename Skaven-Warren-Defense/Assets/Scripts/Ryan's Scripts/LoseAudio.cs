using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseAudio : MonoBehaviour
{
    public static LoseAudio LAInstance;
    public AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
}
