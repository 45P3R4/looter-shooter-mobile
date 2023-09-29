using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Inventory))]
public class Player : Entity
{
    private Inventory inventory;

    private void Start()
    {
        inventory = GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.GetComponent<Item>() != null)
        {
            inventory.AddItem(other.GetComponent<Item>());
            Destroy(other.gameObject);
        }
    }
}
