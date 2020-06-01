using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in SECONDS")]
    [SerializeField] float levelTime = 10;
    bool triggeredLevelfinished = false;
    void Update()
    {
        if (triggeredLevelfinished)
        {
            return;
        }    
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            FindObjectOfType<LevelControllah>().LevelTimeFinished();
            triggeredLevelfinished = true;
        }
    }
}
