using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRunning : MonoBehaviour
{
    public float speed = 10.0f;
    public float minDist = 1f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = GameObject.FindWithTag("enemy").transform;
        }
    }       
    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        transform.LookAt(target);

        float dist = Vector3.Distance(transform.position, target.position);

        if (dist > minDist)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            if (!WalkingNoise.WNInstance.Audio.isPlaying)
            {
                WalkingNoise.WNInstance.Audio.Play();
            }
        }
    }
}
