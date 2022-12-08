using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 100;
    public Healthbar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float amount)
    {

        health -= amount;
        healthbar.updateHealthBar(maxHealth, health);

        if (health <= 0)
        {
            Destroy(gameObject);
            DeathNoise.DNInstance.Audio.Play();
            
        }
    }
}
