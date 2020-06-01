using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControllah : MonoBehaviour
{
    [SerializeField] float waitToLoad = 4f;
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject losLabel;
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    private void Start()
    {
        losLabel.SetActive(false);
        winLabel.SetActive(false);
        //Debug.Log("WinLabel");
    }
    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }
    public void AttackerKilled()
    {
        numberOfAttackers--;
        if (numberOfAttackers <= 0 && levelTimerFinished)
        {
            Debug.Log("attackersandtimeiszero");
            StartCoroutine(HandleWinningCondition());
        }    
    }
    IEnumerator HandleWinningCondition()
    {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }    
    public void HandleLoseCondition()
    {
        losLabel.SetActive(true);
        Time.timeScale = 0;
    }    
    public void LevelTimeFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
        Debug.Log("LevelTimeFinished");
    }    
    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
            foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
            //Debug.Log("Stop Spawn");
        }
    }    
}
