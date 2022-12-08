using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public GameObject closestTarget;
    public float maxDistance = 20f;
    public float minDistance = .5f;
    public float speed = 10.0f;
    public List <GameObject> targets;

    // Start is called before the first frame update
    void Start()
    {
        if (closestTarget == null)
        {
            findClosestTarget();
        }
    }

    void findClosestTarget()
    {
        // makes a list of potential allies
        if (gameObject.tag == "Ally")
        {
            targets = new List<GameObject> (GameObject.FindGameObjectsWithTag("Enemy"));

        }
        else
        {
            targets = new List<GameObject>(GameObject.FindGameObjectsWithTag("Ally"));
            targets.Add(GameObject.FindWithTag("Player"));
        }

        // determines the closest enemy to lock on
        float smallestDistance = maxDistance;
        float distance = 0;
        targets.ForEach(delegate (GameObject go)
        {
            distance = Vector3.Distance(transform.position, go.transform.position);
            if (distance < smallestDistance)
            {
                closestTarget = go;
            }
        });
    }


    void Update()
    {
        
        if(closestTarget == null)
        {
            
            findClosestTarget();
        }

        transform.LookAt(closestTarget.transform);
        // calculates distance between targets position and objects position.
        float dist = Vector3.Distance(transform.position, closestTarget.transform.position); ;

        // if object is close enough, move towards target
                
        if(dist <= minDistance)
        {
            if (WalkingNoise.WNInstance.Audio.isPlaying)
            {
                WalkingNoise.WNInstance.Audio.Stop();
            }

            return;
        }   
        else if(dist < maxDistance)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            if (!WalkingNoise.WNInstance.Audio.isPlaying)
            {
                WalkingNoise.WNInstance.Audio.Play();
            }
        }
    }
}
