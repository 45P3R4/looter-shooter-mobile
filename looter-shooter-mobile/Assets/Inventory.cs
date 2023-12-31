using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] public List<Item> items;
    [SerializeField] private InventorySlot slot;
    [SerializeField] private Transform gridParent;

    private InventorySlot selectedSlot;

    public void SelectSlot(InventorySlot selectableSlot)
    {
        if(selectedSlot != null)
        {
            selectedSlot.DeselectSlot();
        }
        selectedSlot = selectableSlot;
    }

    public void AddItem(Item item)
    {
        bool has_equal = false;
        foreach(Item i in items)
        {
            if(i.GetName() == item.GetName())
            {
                has_equal = true;
                i.AddCount(item.getCount());
            }
        }
        if(!has_equal)
        {
            items.Add(item);
        }
    }

    public void DeleteSelectedSlot()
    {
        if(selectedSlot != null)
        {
            foreach(Item i in items)
            {
                if(i.GetName() == selectedSlot.getItem().GetName())
                {
                    items.Remove(i);
                    break;
                }
            }
            ShowInventory();
        }
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
            newSlot.SetItem(item);
            if(item.getCount() == 1)
            {
                Destroy(newSlot.countText.gameObject);
            }
        }
    }
}
