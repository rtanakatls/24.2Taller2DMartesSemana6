using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    private Camera cam;

    private void Awake()
    {
        cam=GameObject.Find("Main Camera").GetComponent<Camera>();
    }


    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 originPosition = transform.position;
            Vector2 direction=(mousePosition - originPosition).normalized;
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = originPosition;
            obj.GetComponent<BulletMovement>().SetDirection(direction);
        }
    }
}
