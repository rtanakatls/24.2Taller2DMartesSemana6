using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InputGroupController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI keyText;
    [SerializeField] private TMP_InputField inputField;
    private Action<string> OnCallback;

    private void Awake()
    {
        inputField.onValueChanged.AddListener(Change);
    }

    public void RegisterCallback(string key, Action<string> callback, string defaultValue)
    {
        keyText.text = key;
        inputField.text = defaultValue;
        OnCallback = callback;
    }

    private void Change(string value)
    {
        OnCallback?.Invoke(value);
    }

}
