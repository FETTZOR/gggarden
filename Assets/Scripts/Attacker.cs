using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    //[SerializeField] GameObject deathVFX;
    [SerializeField] float durationOfExplosion = 1f;
    [Range (0f, 5f)]
    float currentSpeed = 1f;
    GameObject currentTarget;

    private void Awake()
    {
        FindObjectOfType<LevelControllah>().AttackerSpawned();
    }
    private void OnDestroy()
    {
        FindObjectOfType<LevelControllah>().AttackerKilled();
    }
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }


    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }    
    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget) { return; }
        Healthah health = currentTarget.GetComponent<Healthah>();
        if (health)
        {
            health.DealDamage(damage);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("no hit");
        GetComponent<Attacker>().NotAttacking();
    }
    public void NotAttacking()
    {
        GetComponent<Animator>().SetBool("isAttacking", false);
    }
}

    //    public void Die()
    //    { 
    //     GameObject explosion = Instantiate(deathVFX, transform.position, transform.rotation);
    //    Destroy(explosion, 1f);
    //}
