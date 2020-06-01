using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int StarCost = 100;

    public void AddStars(int amount)
    {
        FindObjectOfType<StarsText>().AddStars(amount);
    }    

    public int GetStarCost()
    {
        return StarCost;
    }    
}
