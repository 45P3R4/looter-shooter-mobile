using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    [SerializeField] private float speed = 5;
    private Vector2 velocity;

    void FixedUpdate()
    {
        velocity.x = Input.GetAxis("Horizontal");
        velocity.y = Input.GetAxis("Vertical");

        //For testing from PC
        if(velocity == Vector2.zero)
        {
            velocity = joystick.GetDirection();
        }

        transform.Translate(velocity * speed * Time.deltaTime);
    }

    public Vector2 GetVelocity()
    {
        return velocity;
    }
}
