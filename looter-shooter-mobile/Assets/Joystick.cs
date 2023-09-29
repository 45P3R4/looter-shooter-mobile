using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Joystick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private float radius = 100f;
    private Vector2 direction;
    private Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        direction = ((Vector2)transform.position - startPosition).normalized;

        float distance = Vector2.Distance(eventData.position, startPosition);

        if(distance < 100)
        {
            transform.position = eventData.position;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.position = startPosition;
        direction = Vector2.zero;
    }

    public Vector2 GetDirection()
    {
        return direction;
    }
}
