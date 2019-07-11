using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesFunctions : MonoBehaviour // Unity tutorial link: https://learn.unity.com/tutorial/variables-and-functions?courseId=5c61706dedbc2a324a9b022d&projectId=5c8920b4edbc2a113b6bc26a#5c8927daedbc2a0d28f484ef. This tutorial has now been completed - 11.7.19
{
    int myInt = 5; /* an integer (whole number) variable. The variable is of an int type, the name is myInt, and the value is 5.
    The variable for myInt will remain 5 until we give it a new value */

    private void Start() // This is called when the object the script is attached to enters the scene
    {
        Debug.Log(myInt); /* To get the value of any variable in our GAME, in this case, the variable "myInt"
        We can attach this script (VariablesFunctions.cs) to a game object in Unity
        When we press play, right now the text 
                "5
                UnityEngine.Debug:Log(Object)
                VariablesFunctions:Start() (at Assets/Scripts/VariablesFunctions.cs:11)"        will appear in the console. 

        It first prints the value of the variable "myInt", then it explains that it is printing a debug log via Unity Engine, and then saying that the debug log is from the void start area of this file, on line 11 */

        // This is temporarily a comment [Debug.Log(myInt * 2);] This displays to the console the value for myInt (which is an integer variable) multiplied by 2

        // Let's reassign the value of myInt:

        // This is temporarily a comment [myInt = 55;]  The value has been reassigned to 55
        // This is temporarily a comment [Debug.Log(myInt);]  Debugging & Printing to console - the new value

        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Creating functions
    int MultiplyByTwo(int number)
    { // These brackets open and close around the actions within this function ^^ (multiply by 2)
        int result;
        result = number * 2;
        return result; /* The result of this function is returned here
        We then need to call this function (see line 29) */
    }
}
