using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

    public void Level1 ()
    {
        SceneManager.LoadScene("Scene1Artifacts");
    }

    public void MainMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
