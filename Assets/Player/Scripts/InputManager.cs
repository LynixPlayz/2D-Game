using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerActions pa;
    private Vector2 movementInput;
    public float HorizontalInput;
    public float VerticalInput;
    private float movementFloat;

    public void HandleAllInput()
    {
        HandleMovementInput();
        //...
        Debug.Log("Test 2");
    }

    //void Awake(){
        
    //}

    void OnEnable() {
        if (pa == null){
            pa = new PlayerActions();
            pa.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            //Debug.Log(i.ReadValue<Vector2>().x.ToString() + " " + i.ReadValue<Vector2>().y.ToString());
        }
        pa.Enable();
    }

    void OnDisable() {
        pa.Disable();
    }

    void HandleMovementInput()
    {
        VerticalInput = movementInput.y;
        HorizontalInput = movementInput.x;

        movementFloat = Mathf.Clamp01(Mathf.Abs(HorizontalInput) + Mathf.Abs(VerticalInput));
        Debug.Log("Test 3 " + movementInput);
    }
}
