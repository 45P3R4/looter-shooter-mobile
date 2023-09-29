using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerBattle : MonoBehaviour
{
    [SerializeField] private Bullet bullet;
    private PlayerMovement movement;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }

    public void Fire()
    {
        Bullet projectile = Instantiate(bullet, transform.position, quaternion.identity);
        projectile.gameObject.layer = 7; //PlayerBullet
        projectile.SetVelocity(movement.GetVelocity() != Vector2.zero ? movement.GetVelocity() : Vector2.right);
    }
}
