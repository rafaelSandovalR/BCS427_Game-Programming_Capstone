using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackNoise : MonoBehaviour
{
    public static AttackNoise ANInstance;
    public AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
}
