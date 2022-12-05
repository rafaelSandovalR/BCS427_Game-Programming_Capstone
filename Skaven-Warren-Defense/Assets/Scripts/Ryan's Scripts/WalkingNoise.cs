using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingNoise : MonoBehaviour
{
    public static WalkingNoise WNInstance;
    public AudioSource Audio;


    private void Awake()
    {
        if (WNInstance != null&&WNInstance!=this)
        {
            Destroy(this.gameObject);
            return;
        }
        WNInstance = this;
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
}
