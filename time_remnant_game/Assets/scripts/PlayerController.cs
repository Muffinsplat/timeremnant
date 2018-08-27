using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360;

    public float movespeed = 2;
	
	// Update is called once per frame
	void Update ()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float trunAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(moveAxis, trunAxis);
    }

    private void ApplyInput(float moveInput,
                            float turnInput)
    {
        Move(moveInput);
        Turn(turnInput); 
    }
        
        

private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * movespeed);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
}
