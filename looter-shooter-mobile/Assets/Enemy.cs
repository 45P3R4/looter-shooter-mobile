using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : Entity
{
    [SerializeField] private float speed = 2;
    [SerializeField] private List<Item> loot;
    [SerializeField] private NavMeshAgent nav;

    private Transform followTarget;

    private void FixedUpdate()
    {
        if(followTarget != null)
        {
            transform.Translate((followTarget.position - transform.position).normalized * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.GetComponent<Bullet>())
        {
            TakeDamage(10);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.GetComponent<Player>())
        {
            followTarget = other.transform;
        }
    }

    private void dropLoot(List<Item> item)
    {
        Instantiate(loot[Random.Range(0,item.Count)], transform.position, Quaternion.identity);
    }

    public override void death()
    {
        base.death();
        dropLoot(loot);
    }
}
