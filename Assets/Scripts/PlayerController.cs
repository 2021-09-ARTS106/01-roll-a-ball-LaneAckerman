using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void onMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.get<Vector2>();
    }
}