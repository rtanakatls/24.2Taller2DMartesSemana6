using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeSceneButton : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public string SceneName { get { return sceneName; } }

    public void SetSceneName(string value)
    {
        sceneName = value;
    }

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(ChangeScene);
    }

    private void ChangeScene()
    {
        ChangeSceneTimeline.Instance.ExecuteTimeline(sceneName);
    }
}
