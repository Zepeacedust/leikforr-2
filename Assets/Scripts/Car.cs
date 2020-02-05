using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Car : MonoBehaviour
{
    public int gear = 0;
    public float forwardSpeed = 2000f;
    public float torque = 100f;
    public float jumpForce = 100f;
    public Rigidbody rb;
    private float trueSpeed = 0;
    private float trueTorque = 0;
    private bool grounded = true;

    void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            if (gear != 10) {

            ++gear;
            trueSpeed = forwardSpeed * gear;

            trueTorque = torque / (float)Math.Log(gear+1);
            Debug.Log(trueTorque);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
        {
            if (gear != 1)
            {
                --gear;
            trueSpeed = forwardSpeed * gear;

            trueTorque = torque / (float)Math.Log(gear+1);
            Debug.Log(trueTorque);
            }
        }
        //fara áfram 
        rb.AddRelativeForce(0, 0, trueSpeed * Time.deltaTime);
        //beygja
        if (Input.GetKey("d"))
        {
            rb.AddRelativeTorque(0f,trueTorque,0f);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddRelativeTorque(0f,-trueTorque, 0f);
        }
        if (Input.GetKey("q"))
        {
            rb.AddRelativeTorque(0f, 0f, trueTorque);
        }
        else if (Input.GetKey("e"))
        {
            rb.AddRelativeTorque(0f,0f, -trueTorque);
        }
        if (Input.GetKey("w"))
        {
            rb.AddRelativeTorque(trueTorque, 0f, 0f);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddRelativeTorque(-trueTorque, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (grounded)
            {
                grounded = false;
                rb.AddForce(0f, jumpForce, 0f);
                Debug.Log("jumpe");
            }
        }
    }
}

