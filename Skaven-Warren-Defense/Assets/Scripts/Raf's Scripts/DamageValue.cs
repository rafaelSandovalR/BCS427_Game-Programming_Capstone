using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageValue : MonoBehaviour
{

    private GameState state;
    public CharacterHealth characterHealth;
    public int damageValue = 5;

    public bool checkCollision = false;


    void Start()
    {
        GameManager.OnGameStateChanged += GMOnGameStateChanged;
    }

    private void GMOnGameStateChanged(GameState newState)
    {
        state = newState;
    }

    // Update is called once per frame
    void Update()
    {
        attack();
    }

    private void attack()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;
        Ray ray = new Ray(origin, direction);
        Debug.DrawRay(origin, direction * 2, Color.red);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("o");
        if(collision.gameObject.tag == "Ally")
        {
            print("ok");
            characterHealth = collision.gameObject.GetComponent<CharacterHealth>();
            characterHealth.TakeDamage(damageValue);
        }
    }
}
