using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Transform target;
    public float sightDistance = 2f;
    public float speed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            // sets target at the start of the game.
            // can be used for enemies or allies
            if (gameObject.tag == "Ally")
            {
                target = GameObject.FindWithTag("Enemy").transform;
            }
            else
            {
                target = GameObject.FindWithTag("Ally").transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(target == null)
        {
            return;
        }

        transform.LookAt(target);
        // calculates distance between targets position and objects position.
        float dist = Vector3.Distance(transform.position, target.position);

        // if object is close enough, move towards target
        
        
        if(dist <= this.GetComponent<DamageValue>().getAttackDistance())
        {
            return;
        }
        
        
        else if(dist < sightDistance)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
