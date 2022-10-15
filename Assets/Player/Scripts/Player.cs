using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private InputManager im;
    void Awake()
    {
        im = GetComponent<InputManager>();
    }

    void Update()
    {
        im.HandleAllInput()
    }

}
