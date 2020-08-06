using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //Loads the next scene in comparison to the current one
    //Important Attach to the game object + attach the gameobject to the button On Click() and add function LoadNextScene() 
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Load1lvl()
    {
        SceneManager.LoadScene(1);
    }
    public void Load2lvl()
    {
        SceneManager.LoadScene(2);
    }
    public void Load3lvl()
    {
        SceneManager.LoadScene(3);
    }
}
