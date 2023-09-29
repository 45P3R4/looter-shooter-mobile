using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Item : MonoBehaviour
{
    [SerializeField] private Sprite itemSprite;
    [SerializeField] private String itemName = "nameless";

    private SpriteRenderer srender;
    private int count = 1;

    private void Start()
    {
        srender = GetComponent<SpriteRenderer>();
        srender.sprite = itemSprite;
        srender.sortingOrder = 1;
    }

    public Sprite GetSprite()
    {
        return itemSprite;
    }

    public String GetName()
    {
        return itemName;
    }

    public int getCount()
    {
        return count;
    }

    public void AddCount(int newCount)
    {
        count += newCount;
    }
}
