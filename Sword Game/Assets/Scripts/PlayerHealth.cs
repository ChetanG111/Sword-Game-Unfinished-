using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;
    [SerializeField]private Slider healthBar;
    public int resistance;

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

  public  void TakeDamge(int amount)
    {
        Mathf.Clamp(amount, 0, int.MaxValue);
        amount -= resistance;
        Debug.Log(amount);
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
