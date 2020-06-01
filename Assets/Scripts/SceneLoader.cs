using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 1f;
    int currentSceneIndex;
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadTheStartScene()
    {
        StartCoroutine(WaitAndLoad());
    }
    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(1);
    }
}
