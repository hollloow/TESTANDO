using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    [SerializeField] private GameObject atack;
    Vector2 movement;
    Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void SetMovement (InputAction.CallbackContext value)
    {
        movement = value.ReadValue<Vector2>();
        
    }
    public void SetJump (InputAction.CallbackContext value)
    {
        _rb.AddForce(Vector2.up * 100);
    }

    public void SetAtack(InputAction.CallbackContext value)
    {
        if (atack.)
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = new Vector2(moveSpeed * Time.deltaTime * movement.x, _rb.linearVelocity.y);
    }

}

