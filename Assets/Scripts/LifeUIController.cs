using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeUIController : MonoBehaviour
{
    private static LifeUIController instance;

    public static LifeUIController Instance { get { return instance; } }

    private TextMeshProUGUI lifeText;



    private void Awake()
    {
        lifeText = GetComponent<TextMeshProUGUI>();
        instance = this; 
    }

    public void UpdateText(int value)
    {
        lifeText.text = $"Life: {value}";
    }
}
