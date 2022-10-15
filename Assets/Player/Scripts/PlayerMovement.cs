using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputManager im;
    private Rigidbody2D rb;
    private Vector2 moveDirection;

    void Awake()
    {
        im = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    public void HandleAllMovement() {
        HandleTranslation();
        HandleRotation();
    }

    void HandleTranslation() {
        moveDirection = transform.up * im.VerticalInput;
        moveDirection += new Vector2((transform.right * im.HorizontalInput).x, (transform.right * im.HorizontalInput).y);
        moveDirection.y = 0;
        moveDirection.Normalize();
    }

    void HandleRotation() {

    }
}
