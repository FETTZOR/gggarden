﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsText : MonoBehaviour
{
    [SerializeField] int stars = 1000;
    Text starText;
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        starText.text = stars.ToString(); //GetScore.ToString(); >>> bil moi metod
    }
    //public int GetScore()
    //{
    //    return stars; 
    //}
    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }
}
