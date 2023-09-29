using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] private Text countText;
    [SerializeField] private Image spriteBox;

    private Item slotItem;

    public void SetItem(Item item)
    {
        countText.text = item.getCount().ToString();
        spriteBox.sprite = item.GetSprite();
    }

    public Item getItem()
    {
        return slotItem;
    }
}
