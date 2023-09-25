using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private Vector2 velocity = Vector2.right;

    void FixedUpdate()
    {
        transform.Translate(velocity * speed * Time.deltaTime);
    }

    public void SetVelocity(Vector2 newVelocity)
    {
        velocity = newVelocity.normalized;
    }
}
