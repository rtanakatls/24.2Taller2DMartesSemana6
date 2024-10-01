using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;
    private float timer;
    [SerializeField] private float changeTime;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ChangeDirection();
        Move();
    }

    void ChangeDirection()
    {
        timer += Time.deltaTime;
        if(timer>=changeTime)
        {
            timer = 0;
            direction *= -1;
        }
    }

    void Move()
    {
        rb2d.velocity = direction.normalized * speed;
    }
}
