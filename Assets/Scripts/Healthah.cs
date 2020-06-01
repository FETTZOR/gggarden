using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthah : MonoBehaviour
{
    [SerializeField] GameObject deathVFX;
    [SerializeField] float health = 100f;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
            Destroy(gameObject);
        }
    }
    public void Die()
    {
        if(!deathVFX) { return; }
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1f);
    }

}
