using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Transform fill;

    public void UpdateBar(float max_value, float value)
    {
        fill.transform.localScale = new Vector2(Mathf.Clamp(max_value * (value / 100)/100, 0, 1), transform.localScale.y);
    }
}
