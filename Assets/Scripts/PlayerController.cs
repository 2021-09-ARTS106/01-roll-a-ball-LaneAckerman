using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //declares Rigidbody variable
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //provides movement data
    void onMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.Y;
    }


    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement);
    }
}