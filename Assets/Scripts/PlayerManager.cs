using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    Vector2 movement;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetMovement (InputAction.CallbackContext value)
    {
        movement = value.ReadValue<Vector2>();
    }
    public void SetJump (InputAction.CallbackContext value)
    {
        rb.AddForce(Vector2.up * 100);
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveSpeed * Time.deltaTime * movement.x, rb.linearVelocity.y);
    }

}

