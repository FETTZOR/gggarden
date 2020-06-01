using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    [SerializeField] int delayInSeconds = 3;
    int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }    
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(delayInSeconds);
        LoadNextScene();
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadYouLose()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
