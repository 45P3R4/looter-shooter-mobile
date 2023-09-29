using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] public List<Item> items;
    [SerializeField] private InventorySlot slot;
    [SerializeField] private Transform gridParent;

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void ShowInventory()
    {
        foreach(Transform child in gridParent)
        {
            Destroy(child.gameObject);
        }

        foreach(Item item in items)
        {
            InventorySlot newSlot = Instantiate(slot, gridParent);
            newSlot.SetItem(item, 1);
        }
    }
}
