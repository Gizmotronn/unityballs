using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame ()
    {
        SceneManager.LoadScene("LevelSelect1"); // Transitions the scene to the scene called "LevelSelect1" which is the level selector
    }
   

 public void QuitGame () // This creates a public variable called "quitgame" which can be seen in the inspector
 {
  Debug.Log ("QUIT!"); // This prints "QUIT!" to the console to show that the function has proceeded correctly, as when testing the game out in the editor the game will not quit
  Application.Quit(); // This closes the application 
 }   

 public void HowToPlay () // This creates a public variable called "HowToPlay". It is public so that it can be seen in the inspector
 {
     SceneManager.LoadScene("GameOptions"); // Transitions the scene to the scene called "GameOptions" which is how to play the game
 }

 public void HowToPlayToMenu () // This creates a public variable called "HowToPlayToMenu"
 {
     SceneManager.LoadScene("MainMenu"); // Transitions the scene to the scene called "MainMenu" from the "HowToPlay" Scene
 }
}
