using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class InventorySlot : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private Text countText;
    [SerializeField] private Image spriteBox;

    private Item slotItem;

    public void SetItem(Item item)
    {
        slotItem = item;
        countText.text = item.getCount().ToString();
        spriteBox.sprite = item.GetSprite();
    }

    public Item getItem()
    {
        return slotItem;
    }

    public void SelectSlot()
    {
        Inventory inv = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        inv.SelectSlot(this);
        GetComponent<Image>().color += Color.yellow;
    }

    public void DeselectSlot()
    {
        GetComponent<Image>().color -= Color.yellow;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SelectSlot();
    }

}