using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    [SerializeField] private List<Item> loot;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.GetComponent<Bullet>())
        {
            TakeDamage(10);
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
