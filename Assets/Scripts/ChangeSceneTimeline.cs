using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class ChangeSceneTimeline : MonoBehaviour
{
    private static ChangeSceneTimeline instance;

    public static ChangeSceneTimeline Instance {  get { return instance; } }

    private PlayableDirector playableDirector;

    private void Awake()
    {
        instance = this;
        playableDirector = GetComponent<PlayableDirector>();
    }


    public void ExecuteTimeline(string sceneName)
    {
        playableDirector.Play();
        StartCoroutine(ChangeScene(sceneName));

    }


    IEnumerator ChangeScene(string sceneName)
    {
        while (playableDirector.state == PlayState.Playing)
        {
            yield return null;
        }
        SceneManager.LoadScene(sceneName);
    }
}
