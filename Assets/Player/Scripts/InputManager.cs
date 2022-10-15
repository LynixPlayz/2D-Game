using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerActions pa;
    private Vector2 movementInput;

    void HandleAllInput()
    {
        HandleMovementInput();
        //...
    }

    void Awake(){
        pa = new PlayerActions();
    }

    void OnEnable() {
        if (pa == null){
            pa = new PlayerActions();
            pa.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        pa.PlayerMovement.Enable();
    }

    void OnDisable() {
        pa.PlayerMovement.Disable();
    }

    void HandleMovementInput()
    {
        
    }
}
