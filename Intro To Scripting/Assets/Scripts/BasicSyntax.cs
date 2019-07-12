using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x); // Find the x transform position of the game object this script is attached to and display it to the console

        if (transform.position.y <= 5) // If the y transform position is less than or equal to 5, do the following:
        {
            Debug.Log("I'm about to hit the ground!"); // Print "I'm about to hit the ground!" to the console if the requirements in the if statement on line 12 are fulfilled
        }
    }

}

    /*
     * Log is within debug - the parent is DEBUG and the child is LOG. DOT OPERATOR - separate/access elements of a compound item
     * The semicolon (;) is used to terminate statements, always seen at the end of the line */
