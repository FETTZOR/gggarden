using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseColliderrr : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        FindObjectOfType<TextHealth>().TakeHealth();
        Destroy(otherCollider.gameObject);
    }
}
