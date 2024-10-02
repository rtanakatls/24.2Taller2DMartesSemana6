using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDeveloperButton : MonoBehaviour
{
    private Button button;
    [SerializeField] private PlayerDeveloperController playerController;
    [SerializeField] private GameObject buttonContainer;
    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        buttonContainer.SetActive(false);
        playerController.gameObject.SetActive(true);
        playerController.Init();
    }
}
