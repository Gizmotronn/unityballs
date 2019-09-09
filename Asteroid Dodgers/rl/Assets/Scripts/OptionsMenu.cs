using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
     public void MainMenu ()
    {
        SceneManager.LoadScene("MainMenu"); // Transitions the scene to the scene called "MainMenu" (from the options scene) which is the main menu
    }
   
}
