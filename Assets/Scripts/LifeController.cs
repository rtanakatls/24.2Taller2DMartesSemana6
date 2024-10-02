using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{

    [SerializeField] private float life;

    public float Life { get { return life; } }

    public void Config(int life)
    {
        this.life = life;
    }

    public void ChangeLife(int value)
    {
        life += value;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
