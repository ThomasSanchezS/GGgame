using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 10; 
        maxHealth = 25;
        healthBar.setMaxHealth(maxHealth);
        healthBar.setHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
    }

    public void TakeHealth(int moreHealth)
    {
        if(currentHealth + moreHealth <= maxHealth){
          currentHealth += moreHealth;
        }else if(currentHealth + moreHealth > maxHealth ){
            currentHealth = maxHealth;
        }
        healthBar.setHealth(currentHealth);
    }
}
