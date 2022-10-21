using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private InputManager im;
    private PlayerMovement pm;
    void Awake()
    {
        im = GetComponent<InputManager>();
        pm = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        im.HandleAllInput();
        Debug.Log("Test 1");
    }

    void FixedUpdate() {
        pm.HandleAllMovement();
    }

}
