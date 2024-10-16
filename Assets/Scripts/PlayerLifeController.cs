using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeController : MonoBehaviour
{
    [SerializeField] private int life;
    [SerializeField] private int maxLife;

    public float Life { get { return life; } }

    private void Start()
    {
        LifeUIController.Instance.UpdateText(life);
        LifeBarUIController.Instance.UpdateLifeBar(life, maxLife);
    }

    public void Config(int life)
    {
        this.life = life;
    }

    public void ChangeLife(int value)
    {
        life += value;
        LifeUIController.Instance.UpdateText(life);
        LifeBarUIController.Instance.UpdateLifeBar(life, maxLife);
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
