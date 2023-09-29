using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private int liveTime = 2;
    private Vector2 velocity = Vector2.right;

    private void Start() {
        StartCoroutine(DestroyTimer(liveTime));
    }

    void FixedUpdate()
    {
        transform.Translate(velocity * speed * Time.deltaTime);
    }

    public void SetVelocity(Vector2 newVelocity)
    {
        velocity = newVelocity.normalized;
    }

    IEnumerator DestroyTimer (int seconds) {
        yield return new WaitForSeconds (seconds);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(gameObject);
    }
}
