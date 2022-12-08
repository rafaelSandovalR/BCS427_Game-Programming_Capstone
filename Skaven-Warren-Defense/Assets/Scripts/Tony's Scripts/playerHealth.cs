using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    public float currerntHealth;

    public healthSlider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currerntHealth = maxHealth;
        healthBar.setMax(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }


    }

    public void TakeDamage(float damage)
    {
        if (currerntHealth != 0)
        {
        currerntHealth -= damage;
        }
        healthBar.CurrentHealth(currerntHealth);
    }
}
