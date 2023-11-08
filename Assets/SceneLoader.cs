using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("Loading scene: " + sceneName);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void LoadScene(int sceneIndex)
    {
        Debug.Log("Loading scene index: " + sceneIndex);
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }

    public void LoadIntroScene()
    {
        SceneManager.LoadScene("Intro_CutScenes");
    }


}
