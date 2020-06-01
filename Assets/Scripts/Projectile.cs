using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 5f)]
    [SerializeField] float attackSpeed = 1f;
    [SerializeField] float damage = 50;

    void Update()
    {
        transform.Translate(Vector2.right * attackSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Healthah>();
        var attacker = otherCollider.GetComponent<Attacker>();

        if(attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
