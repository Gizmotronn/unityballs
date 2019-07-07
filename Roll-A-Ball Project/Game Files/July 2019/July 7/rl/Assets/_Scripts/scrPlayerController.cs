using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPlayerController : MonoBehaviour {

    public float speed; // Public floats will show up in the INSPECTOR as an editable property. Changes can be made to this variable in the Unity editor. We now have control over this variable inside the Unity editor, without having to recompile.

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>(); // The rigidbody is a tool to make objects move in a realistic way using physics
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed); // part of the rigidbody, to make the object (in this case the ball) move faster or slower. To solve the issue of compiling over and over again whenever I change the speed, I'll create a new public variable on line 7
    }
}