using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int amount)
    {
        Debug.Log(amount);
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        
        Destroy(gameObject);
    }

}
