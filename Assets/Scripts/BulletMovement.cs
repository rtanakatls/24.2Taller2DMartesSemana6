using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    private Vector2 direction;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }


    void Update()
    {
        Move();
    }

    void Move()
    {
        rb2d.velocity= direction.normalized * speed;
    }
}
