using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerRigidbody : MonoBehaviour {

    private string MoveInputAxis = "Vertical";

    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360;

    public float movespeed = 10;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
        float moveAxis = Input.GetAxis(MoveInputAxis);
        float trunAxis = Input.GetAxis(MoveInputAxis);

        ApplyInput(moveAxis, trunAxis);
    }

    private void ApplyInput(float moveInput,
                            float turnInput)
    {
        Move(moveInput);
        Turn(moveInput); 
    }
        
        


private void Move(float input)
    {
        //transform.Translate(Vector3.forward * input * movespeed);
        rb.AddForce(transform.forward * input * movespeed, ForceMode.Force);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
}
