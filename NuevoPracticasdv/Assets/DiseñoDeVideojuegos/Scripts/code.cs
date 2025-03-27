using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    public float relativeHeight, amplitude, waveSpeed;
    public Rigidbody ballRB;

    private void FixedUpdate()
    {
        transform.position = ballRB.position + Vector3.up * relativeHeight;
        if(ballRB.velocity.magnitude > 0)
        {
            transform.forward = ballRB.velocity;
        }
    }
}
