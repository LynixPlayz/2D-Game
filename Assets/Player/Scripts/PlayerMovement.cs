using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputManager im;
    private Rigidbody2D rb;
    public Vector3 moveDirection;

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
        moveDirection += new Vector3((transform.right * im.HorizontalInput).x, 0f, 0f);
        moveDirection.z = 0;
        moveDirection.Normalize();
        Vector3 moveVelocity = moveDirection;
        rb.velocity = moveVelocity;
        
    }

    void HandleRotation() {

    }
}
