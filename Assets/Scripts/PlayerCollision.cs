using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private LifeController lifeController;

    private void Awake()
    {
        lifeController = GetComponent<LifeController>();
    }

    private void TakeDamage(int damage)
    {
        lifeController.ChangeLife(-damage);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            TakeDamage(1);
        }
    }
}
