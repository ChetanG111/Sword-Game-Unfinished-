using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;
    [SerializeField]private Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHealth;
    }

    void TakeDamge(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("You Died");
    }
}
