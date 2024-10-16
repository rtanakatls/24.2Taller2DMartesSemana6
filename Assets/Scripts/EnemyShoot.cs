using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    private Transform player;
    private float timer;
    [SerializeField] private float shootTime;
    [SerializeField] private float range;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (player != null)
        {
            timer += Time.deltaTime;
            if (Vector2.Distance(player.position, transform.position) <= range)
            {
                if (timer >= shootTime)
                {
                    Vector2 direction = player.transform.position - transform.position;
                    direction = direction.normalized;

                    GameObject obj = Instantiate(bulletPrefab);
                    obj.transform.position = transform.position;
                    obj.GetComponent<BulletMovement>().SetDirection(direction);
                    timer = 0;
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
