using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    //rigidbody reference=rb
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float slidewayForce = 50f;

    //fixed is added cause we are messing with physics
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);//add a forwardForce

        if (Input.GetKey("d"))//d for right movement
        {
            rb.AddForce(slidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);//ForceMode.VelocityChange is used for more responsive action in sideways
        }

        if (Input.GetKey("a"))// a for left movement
        {
            rb.AddForce(-slidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}