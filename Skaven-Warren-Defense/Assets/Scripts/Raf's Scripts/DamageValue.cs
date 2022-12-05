using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageValue : MonoBehaviour
{

    private GameState state;
    public CharacterHealth characterHealth;
    public int damageValue = 5;

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
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ally")
        {
            characterHealth.TakeDamage(damageValue);
        }
    }
}
