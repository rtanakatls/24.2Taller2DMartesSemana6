using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarUIController : MonoBehaviour
{
    private static LifeBarUIController instance;

    public static LifeBarUIController Instance {  get { return instance; } }

    private Image lifeBar;

    private void Awake()
    {
        instance = this;
        lifeBar = GetComponent<Image>();
    }


    public void UpdateLifeBar(float value, float maxValue)
    {
        lifeBar.fillAmount = value / maxValue;
    }
}
