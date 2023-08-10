using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;

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
        // Handle player death logic here (e.g., game over, respawn, etc.)
        // For now, let's just deactivate the player GameObject.
        gameObject.SetActive(false);
    }
}
