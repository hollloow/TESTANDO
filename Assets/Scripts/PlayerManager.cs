using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private Rigidbody2D rb;

    private InputControl inputControls;
    private Vector2 inputDirector => inputControls.Player.Move.ReadValue<Vector2>();
    Vector2 move;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        inputControls = new InputControl();
        inputControls.Enable();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveSpeed * Time.deltaTime * move.x, rb.linearVelocity.y);
    }

    private void Update()
    { 
        move = new(inputDirector.x,0);
        
    }

    private void OnDestroy()
    {
        inputControls.Disable();
    }

    private void OnDisable()
    {
        inputControls.Disable();
    }
}
