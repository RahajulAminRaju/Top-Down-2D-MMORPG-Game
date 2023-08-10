using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public int playerDamage = 10;
    public int enemyDamage = 5;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AttackPlayer();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            AttackEnemy();
        }
    }

    private void AttackPlayer()
    {
        PlayerStats playerStats = FindObjectOfType<PlayerStats>();
        if (playerStats != null)
        {
            playerStats.TakeDamage(enemyDamage);
            Debug.Log("Player HP: " + playerStats.currentHP);
        }
    }

    private void AttackEnemy()
    {
        Enemy enemy = FindObjectOfType<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(playerDamage);
            Debug.Log("Enemy HP: " + enemy.currentHP);

            // Check if the enemy can perform the special ability
            if (Random.value < 0.2f) // 20% chance for the special ability (adjust as needed)
            {
                enemy.PerformSpecialAbility(FindObjectOfType<PlayerStats>());
                Debug.Log("Enemy used special ability!");
            }
        }
    }
}
