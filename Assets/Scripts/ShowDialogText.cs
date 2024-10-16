using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowDialogText : MonoBehaviour
{
    [SerializeField] private List<string> dialogs;
    private TextMeshProUGUI dialogText;

    private void Awake()
    {
        dialogText = GetComponent<TextMeshProUGUI>();
        StartCoroutine(ShowText());
    }

    private IEnumerator ShowText()
    {
        int i = 0;
        while (i < dialogs.Count)
        {
            dialogText.text= dialogs[i];
            i++;
            yield return new WaitForSeconds(3);
        }
    }
}
