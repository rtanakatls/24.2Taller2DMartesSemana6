using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    [SerializeField] private float followRange;
    [SerializeField] private float stopFollowRange;
    private Transform target;
    private void Awake()
    {
        target = GameObject.Find("Player").transform;
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (target != null)
        {
            if(Vector2.Distance(target.position,transform.position)<=followRange && Vector2.Distance(target.position, transform.position)>=stopFollowRange)
            {
                Vector2 direction = target.position - transform.position;
                direction=direction.normalized;
                rb2d.velocity = direction.normalized * speed;
            }
            else 
            {

                rb2d.velocity = Vector2.zero;
            }
        }
        else
        {
            rb2d.velocity = Vector2.zero;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, followRange);
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, stopFollowRange);
    }
}
