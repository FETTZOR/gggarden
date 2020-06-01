using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHealth : MonoBehaviour
{
    [SerializeField] int health = 5;
    [SerializeField] int damage = 1;
    Text healthText;
    void Start()
    {
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        healthText.text = health.ToString(); //GetScore.ToString(); >>> bil moi metod
    }
    //public int GetScore()
    //{
    //    return stars; 
    //}
    public void TakeHealth()
    {      
            health -= 1;
            UpdateDisplay();
        if (health <= 0)
        {
            FindObjectOfType<LevelControllah>().HandleLoseCondition();
        }    
    }
    public bool HaveEnoughStars(int amount)
    {
        return health >= amount;
    }
}

