using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
   public void LoadNextScene()
    {
        // Get the current active scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        // Load the next scene (incrementing current scene index by 1)
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
