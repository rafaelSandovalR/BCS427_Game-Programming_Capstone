using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && Input.GetKeyDown("q"))
        {
            CharacterHealth enemyHealth = other.GetComponent<CharacterHealth>();
            enemyHealth.TakeDamage(15);
        }
    }
}
