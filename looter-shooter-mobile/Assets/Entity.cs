using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private HealthBar hpbar;
    private int health;

    private void Start()
    {
        health = maxHealth;
    }

    public virtual void death()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        hpbar.UpdateBar(maxHealth, health);

        if(health <= 0)
        {
            death();
        }
    }
}
