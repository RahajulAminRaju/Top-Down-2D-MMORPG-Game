using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHP = 50;
    public int currentHP;
    public int attackDamage = 5;
    public int specialAbilityDamage = 20; // New property for special ability damage

    private void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Handle enemy death logic here (e.g., play death animation, drop loot, etc.)
        Destroy(gameObject);
    }

    public void PerformSpecialAbility(PlayerStats playerStats)
    {
        // Implement the special ability logic here
        playerStats.TakeDamage(specialAbilityDamage);
    }
}
