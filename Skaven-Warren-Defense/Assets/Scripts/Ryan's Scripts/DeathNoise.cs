using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathNoise : MonoBehaviour
{
    public static DeathNoise DNInstance;
    public AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
}
