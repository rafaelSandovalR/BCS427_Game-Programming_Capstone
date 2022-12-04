using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageValue : MonoBehaviour
{

    private GameState state;
    public CharacterHealth characterHealth;
    public int damageValue = 5;

    public GameObject target;

    public int attackDistance = 1;
    public int rateOfAttack = 1;
    public int count;

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
        if (detectEnemy())
        {
            count++;

            if (count % (1000 / rateOfAttack) == 0)
            {
                attack();

            }
            
        }
        else
        {
            count = 0;
        }
    }

    private bool detectEnemy()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;
        Ray ray = new Ray(origin, direction);
        Debug.DrawRay(origin, direction * attackDistance, Color.red);

        if (Physics.Raycast(ray, out RaycastHit h, attackDistance))
        {
            target = h.collider.gameObject;
            if (target.CompareTag("Ally"))
            {
                return true;
            }
        }

        target = null;
        return false;
    }

    private void attack()
    {
        
        target.GetComponent<CharacterHealth>().TakeDamage(damageValue);
        
    }   

    public int getAttackDistance()
    {
        return attackDistance;
    }
}
