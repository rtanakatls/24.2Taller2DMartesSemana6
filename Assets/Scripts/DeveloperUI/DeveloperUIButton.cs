using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeveloperUIButton : MonoBehaviour
{
    private Button button;
    [SerializeField] private GameObject panel;
    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Clicked);
    }

    private void Clicked()
    {
        panel.SetActive(!panel.activeSelf);
    }
}
