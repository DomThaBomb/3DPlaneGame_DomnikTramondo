using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float currentHealth;
    public float maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amountItTook)
    {
        currentHealth -= amountItTook;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void Heal(float amountItTook)
    {
        currentHealth += amountItTook;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (currentHealth == 0) 
        {
            Dead();
        }
    }

    public void Dead()
    {
        Destroy(gameObject);
    }
}
