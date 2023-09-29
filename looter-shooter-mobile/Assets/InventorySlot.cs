using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] private Text countText;
    [SerializeField] private Image spriteBox;

    private Item slotItem;
    private int itemCount;

    public void SetItem(Item item, int count)
    {
        countText.text = count.ToString();
        spriteBox.sprite = item.GetSprite();
        itemCount = count;
    }

    public int GetCount()
    {
        return itemCount;
    }

    public void SetCount(int newCount)
    {
        countText.text = newCount.ToString();
        itemCount = newCount;
    }

    public Item getItem()
    {
        return slotItem;
    }

    public void SetItem(Item item)
    {
        slotItem = item;
    }
}
