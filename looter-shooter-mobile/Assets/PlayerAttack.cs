using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Bullet bullet;
    private PlayerMovement movement;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }

    public void Fire()
    {
        Debug.Log("Fire");
        Bullet projectile = Instantiate(bullet, transform.position, quaternion.identity);
        projectile.SetVelocity(movement.GetVelocity());
    }
}
