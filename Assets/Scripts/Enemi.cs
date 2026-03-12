using System;
using UnityEngine;

public class Enemi : MonoBehaviour
{
    [SerializeField] private int speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left* speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            speed *= -1;
        }
    }
}
