using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusDefend : MonoBehaviour
{

    [Range(0f, 5f)]
    float attackDelay = 1f;

    void Update()
    {
        transform.Translate(Vector2.left * attackDelay * Time.deltaTime);
    }
    public void SetAttackBeforeDelay(float attack)
    {
        attackDelay = attack;
    }
}